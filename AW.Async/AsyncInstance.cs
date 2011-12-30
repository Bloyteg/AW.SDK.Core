using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AW.Async
{
    public static class AsyncInstance
    {
        private static readonly Dictionary<IInstance, Dictionary<Callbacks, Queue<CallbackWorkItem>>> CallbackWorkItemQueue = new Dictionary<IInstance, Dictionary<Callbacks, Queue<CallbackWorkItem>>>();

        public static Task<Result> AddressAsync(this IInstance instance, int session)
        {
            return instance.CreateCallbackTask(Callbacks.Address,
                                               () => instance.Address(session),
                                               handler => instance.CallbackAddress += handler);
        }

        public static Task<Result> AvatarLocationAsync(this IInstance instance, int citizenNumber = 0, int session = 0, string name = "")
        {
            return instance.CreateCallbackTask(Callbacks.AvatarLocation,
                                               () => instance.AvatarLocation(citizenNumber, session, name),
                                               handler => instance.CallbackAvatarLocation += handler);
        }

        public static Task<Result> EnterAsync(this IInstance instance, string worldName)
        {
            return instance.CreateCallbackTask(Callbacks.Enter,
                                               () => instance.Enter(worldName),
                                               handler => instance.CallbackEnter += handler);
        }

        public static Task<Result> LoginAsync(this IInstance instance)
        {
            return instance.CreateCallbackTask(Callbacks.Login,
                                               instance.Login,
                                               handler => instance.CallbackLogin += handler);
        }

        #region Helper methods

        private static Task<Result> CreateCallbackTask(this IInstance instance, Callbacks callback, Func<Result> workUnit, Action<InstanceCallbackHandler> handler)
        {
            instance.AddCallbackHandlerIfNeeded(callback, handler);

            var callbackWorkItemQueue = CallbackWorkItemQueue[instance][callback];
            var taskCompletionSource = new TaskCompletionSource<Result>();

            var callbackWorkItem = new CallbackWorkItem
                                       {
                                           TaskCompletionSource = taskCompletionSource,
                                           WorkUnit = workUnit
                                       };

            callbackWorkItemQueue.Enqueue(callbackWorkItem);

            if (callbackWorkItemQueue.Count <= 1)
            {
                try
                {
                    var result = callbackWorkItem.WorkUnit();

                    if(result != Result.Success)
                    {
                        taskCompletionSource.SetResult(result);
                    }
                }
                catch(Exception exception)
                {
                    callbackWorkItem.TaskCompletionSource.SetException(exception);
                    return taskCompletionSource.Task;
                }
            }

            return taskCompletionSource.Task;
        }

        private static void AddCallbackHandlerIfNeeded(this IInstance instance, Callbacks callback, Action<InstanceCallbackHandler> addHandlerAction)
        {
            if(!CallbackWorkItemQueue.ContainsKey(instance))
            {
                CallbackWorkItemQueue[instance] = new Dictionary<Callbacks, Queue<CallbackWorkItem>>();
                
                instance.Disposing += HandleInstanceDisposing;
            }

            if (CallbackWorkItemQueue[instance].ContainsKey(callback))
            {
                return;
            }

            CallbackWorkItemQueue[instance].Add(callback, new Queue<CallbackWorkItem>());

            addHandlerAction(InstanceCallbackHandler(callback));
        }

        private static InstanceCallbackHandler InstanceCallbackHandler(Callbacks callback)
        {
            return (sender, result) =>
                       {
                           var callbackWorkItemQueue = CallbackWorkItemQueue[sender][callback];
                           CallbackWorkItem callbackWorkItem = callbackWorkItemQueue.Dequeue();

                           callbackWorkItem.TaskCompletionSource.SetResult(result);

                           if (callbackWorkItemQueue.Count != 0)
                           {
                               var next = callbackWorkItemQueue.Peek();

                               try
                               {
                                   var nextResult = next.WorkUnit();

                                   if (nextResult != Result.Success)
                                   {
                                       next.TaskCompletionSource.SetResult(nextResult);
                                   }
                               }
                               catch (Exception exception)
                               {
                                   callbackWorkItemQueue.Dequeue();
                                   next.TaskCompletionSource.SetException(exception);
                               }
                           }
                       };
        }

        private static void HandleInstanceDisposing(IInstance sender)
        {
            CallbackWorkItemQueue.Remove(sender);
            sender.Disposing -= HandleInstanceDisposing;
        }

        #endregion
    }
}
