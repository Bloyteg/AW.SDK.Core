using System.Diagnostics;
using System.Reflection;

namespace AW
{
    /// <summary>
    /// Exception thrown when an instance based operation fails.
    /// </summary>
    public sealed class InstanceException : System.Exception
    {

        internal InstanceException(string message)
            : base(message)
        {
            HelpLink = "http://docs.theenginerd.com/awnet/";
        }

        /// <summary>
        /// Numeric representation of the Return Code returned by the instance operation.
        /// </summary>
        /// 
        public int ErrorCode
        {
            get;
            internal set;
        }

        /// <summary>
        /// Indicates the method that threw the exception.
        /// </summary>
        public string CallingMethod
        {
            get;
            internal set;
        }

        internal static void Assert(int error)
        {
            if (error == 0)
            {
                return;
            }

            var stackTrace = new StackTrace();
            StackFrame stackFrame = stackTrace.GetFrame(stackTrace.FrameCount > 0 ? 1 : 0);
            MethodBase methodBase = stackFrame.GetMethod();

            string message = string.Format("Instance call to method {0} failed (Reason {1}).", methodBase.Name,
                                           error);

            throw new InstanceException(message)
                      {
                          ErrorCode = error,
                          HResult = error,
                          CallingMethod = methodBase.Name
                      };
        }
    }
}
