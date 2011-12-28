using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AW.Async
{
    public static class AsyncInstance
    {
        internal class CallbackWorkItem
        {
            public TaskCompletionSource<Result> TaskCompletionSource { get; set; }

            public Action WorkUnit { get; set; }
        }

        private static readonly Queue<CallbackWorkItem> WorldCallbackWorkItemQueue = new Queue<CallbackWorkItem>();
        private static readonly Queue<CallbackWorkItem> UniverseCallbackWorkItemQueue = new Queue<CallbackWorkItem>();
        private static readonly Dictionary<IInstance, HashSet<string>> InstanceCallbacks = new Dictionary<IInstance, HashSet<string>>();

        public static Task<Result> LoginAsync(this IInstance instance)
        {
            AddUniverseCallbackHandlerIfNeeded(instance, handler => instance.CallbackLogin += handler, "login");
            return CreateUniverseCallbackTask(() => instance.Login());
        }

        public static Task<Result> EnterAsync(this IInstance instance, string worldName)
        {
            AddWorldCallbackHandlerIfNeeded(instance, handler => instance.CallbackEnter += handler, "enter");
            return CreateWorldCallbackTask(() => instance.Enter(worldName));
        }

        #region Helper methods
        private static Task<Result> CreateUniverseCallbackTask(Action workUnit)
        {
            return CreateCallbackTask(workUnit, UniverseCallbackWorkItemQueue);
        }

        private static Task<Result> CreateWorldCallbackTask(Action workUnit)
        {
            return CreateCallbackTask(workUnit, WorldCallbackWorkItemQueue);
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

        private static void AddUniverseCallbackHandlerIfNeeded(IInstance instance, Action<InstanceCallbackHandler> addHandlerAction, string callback)
        {
            AddCallbackHandlerIfNeeded(instance, callback, addHandlerAction, HandleUniverseCallback);
        }

        private static void AddWorldCallbackHandlerIfNeeded(IInstance instance, Action<InstanceCallbackHandler> addHandlerAction, string callback)
        {
            AddCallbackHandlerIfNeeded(instance, callback, addHandlerAction, HandleWorldCallback);
        }

        private static void AddCallbackHandlerIfNeeded(IInstance instance, string callback, Action<InstanceCallbackHandler> addHandlerAction, InstanceCallbackHandler handler)
        {
            if(!InstanceCallbacks.ContainsKey(instance))
            {
                InstanceCallbacks[instance] = new HashSet<string>();
            }

            if (InstanceCallbacks[instance].Contains(callback))
            {
                return;
            }

            InstanceCallbacks[instance].Add(callback);
            addHandlerAction(handler);
        }

        #endregion

        #region Callback handlers

        private static void HandleUniverseCallback(IInstance sender, Result result)
        {
            HandleCallbackWorkItem(UniverseCallbackWorkItemQueue, result);
        }

        private static void HandleWorldCallback(IInstance sender, Result result)
        {
            HandleCallbackWorkItem(WorldCallbackWorkItemQueue, result);
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
