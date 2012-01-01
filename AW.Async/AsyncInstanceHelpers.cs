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
            var objectReferenceCounter = CallbackObjectReferenceCounters[instance];
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
            var callbackWorkItemQueue = CallbackWorkItemQueues[instance][callback];
            var taskCompletionSource = new TaskCompletionSource<Result>();

            var callbackWorkItem = new CallbackWorkItem
                                       {
                                           TaskCompletionSource = taskCompletionSource,
                                           WorkUnit = workUnit
                                       };

            callbackWorkItemQueue.Enqueue(callbackWorkItem);

            if (callbackWorkItemQueue.Count <= 1)
            {
                if(!TryExecuteWorkUnit(taskCompletionSource, workUnit))
                {
                    callbackWorkItemQueue.Dequeue();
                }
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
            if(!CallbackWorkItemQueues.ContainsKey(instance) && !CallbackObjectReferenceCounters.ContainsKey(instance))
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
            if(!CallbackObjectReferenceCounters.ContainsKey(instance))
            {
                CallbackObjectReferenceCounters[instance] = new CallbackObjectReferenceCounter();
                addHandlerAction(CreateObjectReferenceCounterCallbackHandler());
            }
        }

        private static InstanceCallbackHandler CreateObjectReferenceCounterCallbackHandler()
        {
            return (sender, result) =>
                       {
                           var objectReference = sender.Attributes.ObjectCallbackReference;
                           var objectReferenceCounter = CallbackObjectReferenceCounters[sender];
                           var taskCompletionSource = objectReferenceCounter.TaskCompletionSources[objectReference];

                           taskCompletionSource.SetResult(result);
                           objectReferenceCounter.TaskCompletionSources.Remove(objectReference);
                       };
        }

        private static void AddCallbackWorkItemQueueHandler(IInstance instance, Callbacks callback, Action<InstanceCallbackHandler> addHandlerAction)
        {
            if(!CallbackWorkItemQueues.ContainsKey(instance))
            {
                CallbackWorkItemQueues[instance] = new Dictionary<Callbacks, Queue<CallbackWorkItem>>();
            }

            if (CallbackWorkItemQueues[instance].ContainsKey(callback))
            {
                return;
            }

            CallbackWorkItemQueues[instance].Add(callback, new Queue<CallbackWorkItem>());
            addHandlerAction(CreateWorkItemQueueCallbackHandler(callback));
        }

        private static InstanceCallbackHandler CreateWorkItemQueueCallbackHandler(Callbacks callback)
        {
            return (sender, result) =>
                       {
                           var callbackWorkItemQueue = CallbackWorkItemQueues[sender][callback];
                           CallbackWorkItem callbackWorkItem = callbackWorkItemQueue.Dequeue();

                           callbackWorkItem.TaskCompletionSource.SetResult(result);

                           if (callbackWorkItemQueue.Count != 0)
                           {
                               var next = callbackWorkItemQueue.Peek();

                               if (!TryExecuteWorkUnit(next.TaskCompletionSource, next.WorkUnit))
                               {
                                   callbackWorkItemQueue.Dequeue();
                               }
                           }
                       };
        }

        private static void HandleInstanceDisposing(IInstance sender)
        {
            CallbackWorkItemQueues.Remove(sender);
            CallbackObjectReferenceCounters.Remove(sender);
            sender.Disposing -= HandleInstanceDisposing;
        }
    }
}