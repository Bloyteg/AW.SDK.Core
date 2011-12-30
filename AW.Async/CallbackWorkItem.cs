using System;
using System.Threading.Tasks;

namespace AW.Async
{
    class CallbackWorkItem
    {
        public TaskCompletionSource<Result> TaskCompletionSource { get; set; }

        public Func<Result> WorkUnit { get; set; }
    }
}