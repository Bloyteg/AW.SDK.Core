using AW;

namespace Utilities
{
    internal class EventDelegates
    {
        public InstanceEventHandler Managed { get; set; }
        public NativeMethods.Event Native { get; set; }
    }

    internal class CallbackDelegates
    {
        public InstanceCallbackHandler Managed { get; set; }
        public NativeMethods.Callback Native { get; set; }
    }
}
