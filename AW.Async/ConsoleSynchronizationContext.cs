using System;
using System.Collections.Concurrent;
using System.Threading;

namespace AW.Async
{
    sealed class ConsoleSynchronizationContext : SynchronizationContext
    {
        readonly ConcurrentQueue<Action> _messagesToProcess = new ConcurrentQueue<Action>();

        public override void Post(SendOrPostCallback d, object state)
        {
            _messagesToProcess.Enqueue(() => d(state));
        }

        public override void Send(SendOrPostCallback d, object state)
        {
            _messagesToProcess.Enqueue(() => d(state));
        }

        public void Dispatch()
        {
            Action action;
            var result = _messagesToProcess.TryDequeue(out action);

            if (result)
            {
                action();
            }
        }
    }
}
