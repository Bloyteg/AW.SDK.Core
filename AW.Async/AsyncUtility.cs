using System.Threading;
using System.Threading.Tasks;

namespace AW.Async
{
    /// <summary>
    /// Contains several utility methods used in writing asynchronous SDK applications, mostly pertaining to console applications.
    /// </summary>
    public static class AsyncUtility
    {
        private static readonly ConsoleSynchronizationContext _SynchronizationContext = new ConsoleSynchronizationContext();
        private static readonly ConsoleTaskScheduler _TaskScheduler = new ConsoleTaskScheduler(_SynchronizationContext);

        /// <summary>
        /// Gets a <see cref="System.Threading.SynchronizationContext" /> that is compatible with console SDK applications.
        /// </summary>
        public static SynchronizationContext SynchronizationContext
        {
            get { return _SynchronizationContext; }
        }

        /// <summary>
        /// Gets a <see cref="System.Threading.Tasks.TaskScheduler"/> that is compatible with console SDK applications.
        /// </summary>
        public static TaskScheduler TaskScheduler
        {
            get { return _TaskScheduler; }
        }

        /// <summary>
        /// Waits the specified milliseconds and then dispatches any pending events and callbacks.
        /// </summary>
        /// Only use this for console applications.  This is not compatible with WPF or Windows Forms applciations.
        /// You must use this in conjunction with <see cref="AW.Async.AsyncUtility.SynchronizationContext" />.
        /// <code>
        /// SynchronizationContext.SetSynchronizationContext(AsyncUtility.SynchronizationContext);
        /// </code>
        /// <param name="milliseconds">The milliseconds.</param>
        /// <returns></returns>
        public static Result Wait(int milliseconds)
        {
            var result = Utility.Wait(milliseconds);
            _SynchronizationContext.Dispatch();
            return result;
        }
    }
}
