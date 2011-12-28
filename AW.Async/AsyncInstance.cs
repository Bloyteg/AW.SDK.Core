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

        private static readonly ConcurrentQueue<CallbackWorkItem> WorldCallbackWorkItemQueue = new ConcurrentQueue<CallbackWorkItem>();
        private static readonly Queue<CallbackWorkItem> UniverseCallbackWorkItemQueue = new Queue<CallbackWorkItem>();
        private static readonly ConcurrentDictionary<IInstance, HashSet<string>> InstanceCallbacks = new ConcurrentDictionary<IInstance, HashSet<string>>();

        public static Task<Result> LoginAsync(this IInstance instance)
        {
            AddCallbackHandlerIfNeeded(instance, "login");
            return HandleUniverseCallbackWorkItem(() => instance.Login());
        }

        private static Task<Result> HandleUniverseCallbackWorkItem(Action workUnit)
        {
            var taskCompletionSource = new TaskCompletionSource<Result>();

            var callbackWorkItem = new CallbackWorkItem
                                       {
                                           TaskCompletionSource = taskCompletionSource,
                                           WorkUnit = workUnit
                                       };

            UniverseCallbackWorkItemQueue.Enqueue(callbackWorkItem);

            if (UniverseCallbackWorkItemQueue.Count <= 1)
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

        private static void AddCallbackHandlerIfNeeded(IInstance instance, string callback)
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
            instance.CallbackLogin += HandleUniverseCallback;
        }

        private static void HandleUniverseCallback(IInstance sender, Result result)
        {
            CallbackWorkItem callbackWorkItem = UniverseCallbackWorkItemQueue.Dequeue();

            callbackWorkItem.TaskCompletionSource.SetResult(result);

            if (UniverseCallbackWorkItemQueue.Count != 0)
            {
                var next = UniverseCallbackWorkItemQueue.Peek();

                try
                {
                    next.WorkUnit();
                }
                catch (Exception exception)
                {
                    UniverseCallbackWorkItemQueue.Dequeue();
                    next.TaskCompletionSource.SetException(exception);
                }
            }
        }

        private static void HandleWorldCallback(IInstance sender, Result result)
        {
            
        }
    }
}
