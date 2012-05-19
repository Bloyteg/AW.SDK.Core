using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AW.Async
{
    public static partial class AsyncInstance
    {
        private static Task<Result> CreateCallbackTask(this IInstance instance, Callbacks callback, Func<Result> workUnit, Action<InstanceCallbackHandler> addHandlerAction)
        {
            instance.AddCallbackHandlerIfNeeded(callback, addHandlerAction);

            switch (callback)
            {
                case Callbacks.ObjectResult:
                    return CreateCallbackObjectReferenceCounterTask(instance, workUnit);
                    
                default:
                    return CreateCallbackWorkItemQueueTask(instance, callback, workUnit);
            }
        }

        private static Task<Result> CreateCallbackObjectReferenceCounterTask(IInstance instance, Func<Result> workUnit)
        {
            var objectReferenceCounter = _CallbackObjectReferenceCounters[instance];
            var taskCompletionSource = new TaskCompletionSource<Result>();
            var counter = unchecked(objectReferenceCounter.Counter++);
            objectReferenceCounter.TaskCompletionSources[counter] = taskCompletionSource;

            instance.Attributes.ObjectCallbackReference = counter;

            if(!TryExecuteWorkUnit(taskCompletionSource, workUnit))
            {
                objectReferenceCounter.TaskCompletionSources.Remove(counter);
            }

            return taskCompletionSource.Task;
        }

        private static Task<Result> CreateCallbackWorkItemQueueTask(IInstance instance, Callbacks callback, Func<Result> workUnit)
        {
            var callbackWorkItemQueue = _CallbackWorkItemQueues[instance][callback];
            var taskCompletionSource = new TaskCompletionSource<Result>();

            var callbackWorkItem = new CallbackWorkItem
                                       {
                                           TaskCompletionSource = taskCompletionSource,
                                           WorkUnit = workUnit
                                       };

            callbackWorkItemQueue.Enqueue(callbackWorkItem);

            if (callbackWorkItemQueue.Count <= 1 && !TryExecuteWorkUnit(taskCompletionSource, workUnit))
            {
                callbackWorkItemQueue.Dequeue();
            }

            return taskCompletionSource.Task;
        }

        private static bool TryExecuteWorkUnit(TaskCompletionSource<Result> taskCompletionSource, Func<Result> workUnit)
        {
            try
            {
                var result = workUnit();

                if(result != Result.Success)
                {
                    taskCompletionSource.SetResult(result);
                    return false;
                }
            }
            catch(Exception exception)
            {
                taskCompletionSource.SetException(exception);
                return false;
            }

            return true;
        }

        private static void AddCallbackHandlerIfNeeded(this IInstance instance, Callbacks callback, Action<InstanceCallbackHandler> addHandlerAction)
        {
            if(!_CallbackWorkItemQueues.ContainsKey(instance) && !_CallbackObjectReferenceCounters.ContainsKey(instance))
            {
                instance.Disposing += HandleInstanceDisposing;
            }

            switch(callback)
            {
                case Callbacks.ObjectResult:
                    AddCallbackObjectReferenceCounterHandler(instance, addHandlerAction);
                    break;
                default:
                    AddCallbackWorkItemQueueHandler(instance, callback, addHandlerAction);
                    break;
            }
        }

        private static void AddCallbackObjectReferenceCounterHandler(IInstance instance, Action<InstanceCallbackHandler> addHandlerAction)
        {
            if(!_CallbackObjectReferenceCounters.ContainsKey(instance))
            {
                _CallbackObjectReferenceCounters[instance] = new CallbackObjectReferenceCounter();
                addHandlerAction(CreateObjectReferenceCounterCallbackHandler());
            }
        }

        private static InstanceCallbackHandler CreateObjectReferenceCounterCallbackHandler()
        {
            return (sender, result) =>
                       {
                           var objectReference = sender.Attributes.ObjectCallbackReference;
                           var objectReferenceCounter = _CallbackObjectReferenceCounters[sender];
                           var taskCompletionSource = objectReferenceCounter.TaskCompletionSources[objectReference];

                           taskCompletionSource.SetResult(result);
                           objectReferenceCounter.TaskCompletionSources.Remove(objectReference);
                       };
        }

        private static void AddCallbackWorkItemQueueHandler(IInstance instance, Callbacks callback, Action<InstanceCallbackHandler> addHandlerAction)
        {
            if(!_CallbackWorkItemQueues.ContainsKey(instance))
            {
                _CallbackWorkItemQueues[instance] = new Dictionary<Callbacks, Queue<CallbackWorkItem>>();
            }

            if (_CallbackWorkItemQueues[instance].ContainsKey(callback))
            {
                return;
            }

            _CallbackWorkItemQueues[instance].Add(callback, new Queue<CallbackWorkItem>());
            addHandlerAction(CreateWorkItemQueueCallbackHandler(callback));
        }

        private static InstanceCallbackHandler CreateWorkItemQueueCallbackHandler(Callbacks callback)
        {
            return (sender, result) =>
                       {
                           var callbackWorkItemQueue = _CallbackWorkItemQueues[sender][callback];
                           CallbackWorkItem callbackWorkItem = callbackWorkItemQueue.Dequeue();

                           if (callbackWorkItemQueue.Count > 0)
                           {
                               var next = callbackWorkItemQueue.Peek();

                               if (!TryExecuteWorkUnit(next.TaskCompletionSource, next.WorkUnit))
                               {
                                   callbackWorkItemQueue.Dequeue();
                               }
                           }

                           callbackWorkItem.TaskCompletionSource.SetResult(result);
                       };
        }

        private static void HandleInstanceDisposing(IInstance sender)
        {
            _CallbackWorkItemQueues.Remove(sender);
            _CallbackObjectReferenceCounters.Remove(sender);
            sender.Disposing -= HandleInstanceDisposing;
        }
    }
}