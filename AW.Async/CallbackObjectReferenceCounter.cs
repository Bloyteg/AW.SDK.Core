using System.Collections.Generic;
using System.Threading.Tasks;

namespace AW.Async
{
    class CallbackObjectReferenceCounter
    {
        public CallbackObjectReferenceCounter()
        {
            Counter = 0;
            TaskCompletionSources = new Dictionary<int, TaskCompletionSource<Result>>();
        }

        public int Counter { get; set; }

        public Dictionary<int, TaskCompletionSource<Result>> TaskCompletionSources { get; private set; }
    }
}