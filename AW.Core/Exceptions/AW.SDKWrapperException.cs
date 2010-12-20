using System;
using System.Diagnostics;
using System.Reflection;

namespace AW
{
    /// <summary>
    /// Exception thrown when an instance based operation fails.
    /// </summary>
    public abstract class SDKWrapperException<T> : System.Exception
        where T : SDKWrapperException<T>, new()
    {
        protected SDKWrapperException()
        {

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

        public override string Message
        {
            get
            {
                return string.Format("SDK call to {0} failed (Reason {1}).", CallingMethod, ErrorCode);
            }
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

            throw new T
                      {
                          HelpLink = "http://docs.theenginerd.com/awnet/",
                          ErrorCode = error,
                          HResult = error,
                          CallingMethod = methodBase.Name
                      };
        }
    }
}
