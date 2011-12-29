using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AW.Async
{
    public static class AsyncInstance
    {
        private static readonly Dictionary<IInstance, Queue<CallbackWorkItem>> WorldCallbackWorkItemQueue = new Dictionary<IInstance, Queue<CallbackWorkItem>>();
        private static readonly Dictionary<IInstance, Queue<CallbackWorkItem>> UniverseCallbackWorkItemQueue = new Dictionary<IInstance, Queue<CallbackWorkItem>>();
        private static readonly Dictionary<IInstance, HashSet<Callbacks>> InstanceCallbacks = new Dictionary<IInstance, HashSet<Callbacks>>();

        public static Task<Result> LoginAsync(this IInstance instance)
        {
            AddUniverseCallbackHandlerIfNeeded(instance, handler => instance.CallbackLogin += handler, Callbacks.Login);
            return CreateUniverseCallbackTask(instance, () => instance.Login());
        }

        public static Task<Result> EnterAsync(this IInstance instance, string worldName)
        {
            AddWorldCallbackHandlerIfNeeded(instance, handler => instance.CallbackEnter += handler, Callbacks.Enter);
            return CreateWorldCallbackTask(instance, () => instance.Enter(worldName));
        }

        #region Helper methods

        private static Task<Result> CreateUniverseCallbackTask(IInstance instance, Action workUnit)
        {
            return CreateCallbackTask(workUnit, UniverseCallbackWorkItemQueue[instance]);
        }

        private static Task<Result> CreateWorldCallbackTask(IInstance instance, Action workUnit)
        {
            return CreateCallbackTask(workUnit, WorldCallbackWorkItemQueue[instance]);
        }

        private static Task<Result> CreateCallbackTask(Action workUnit, Queue<CallbackWorkItem> callbackWorkItemQueue)
        {
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
                    callbackWorkItem.WorkUnit();
                }
                catch(Exception exception)
                {
                    callbackWorkItem.TaskCompletionSource.SetException(exception);
                    return taskCompletionSource.Task;
                }
            }

            return taskCompletionSource.Task;
        }

        private static void AddUniverseCallbackHandlerIfNeeded(IInstance instance, Action<InstanceCallbackHandler> addHandlerAction, Callbacks callback)
        {
            if(!UniverseCallbackWorkItemQueue.ContainsKey(instance))
            {
                UniverseCallbackWorkItemQueue[instance] = new Queue<CallbackWorkItem>();
            }

            AddCallbackHandlerIfNeeded(instance, callback, addHandlerAction, HandleUniverseCallback);
        }

        private static void AddWorldCallbackHandlerIfNeeded(IInstance instance, Action<InstanceCallbackHandler> addHandlerAction, Callbacks callback)
        {
            if (!WorldCallbackWorkItemQueue.ContainsKey(instance))
            {
                WorldCallbackWorkItemQueue[instance] = new Queue<CallbackWorkItem>();
            }

            AddCallbackHandlerIfNeeded(instance, callback, addHandlerAction, HandleWorldCallback);
        }

        private static void AddCallbackHandlerIfNeeded(IInstance instance, Callbacks callback, Action<InstanceCallbackHandler> addHandlerAction, InstanceCallbackHandler handler)
        {
            if(!InstanceCallbacks.ContainsKey(instance))
            {
                InstanceCallbacks[instance] = new HashSet<Callbacks>();
                
                instance.Disposing += HandleInstanceDisposing;
            }

            if (InstanceCallbacks[instance].Contains(callback))
            {
                return;
            }

            InstanceCallbacks[instance].Add(callback);
            addHandlerAction(handler);
        }

        private static void HandleInstanceDisposing(IInstance sender)
        {
            UniverseCallbackWorkItemQueue.Remove(sender);
            WorldCallbackWorkItemQueue.Remove(sender);
            InstanceCallbacks.Remove(sender);

            sender.Disposing -= HandleInstanceDisposing;
        }

        #endregion

        #region Callback handlers

        private static void HandleUniverseCallback(IInstance sender, Result result)
        {
            HandleCallbackWorkItem(UniverseCallbackWorkItemQueue[sender], result);
        }

        private static void HandleWorldCallback(IInstance sender, Result result)
        {
            HandleCallbackWorkItem(WorldCallbackWorkItemQueue[sender], result);
        }

        private static void HandleCallbackWorkItem(Queue<CallbackWorkItem> callbackWorkItemQueue, Result result)
        {
            CallbackWorkItem callbackWorkItem = callbackWorkItemQueue.Dequeue();

            callbackWorkItem.TaskCompletionSource.SetResult(result);

            if (callbackWorkItemQueue.Count != 0)
            {
                var next = callbackWorkItemQueue.Peek();

                try
                {
                    next.WorkUnit();
                }
                catch (Exception exception)
                {
                    callbackWorkItemQueue.Dequeue();
                    next.TaskCompletionSource.SetException(exception);
                }
            }
        }

        #endregion
    }
}
