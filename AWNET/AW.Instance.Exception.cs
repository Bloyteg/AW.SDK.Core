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
            this.HelpLink = "http://docs.theenginerd.com/awnet/";
        }

        /// <summary>
        /// Numeric representation of the Return Code returned by the instance operation.
        /// <see cref="AW.Utility.ReturnCodes"/> contains string equivalents of all error codes.
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

        internal static int Assert(int error)
        {
            if (error != 0 && !Utility.UseReturnCodes)
            {
                StackTrace stackTrace = new StackTrace();
                StackFrame stackFrame;

                if (stackTrace.FrameCount > 0)
                    stackFrame = stackTrace.GetFrame(1);
                else
                    stackFrame = stackTrace.GetFrame(0);

                MethodBase methodBase = stackFrame.GetMethod();

                string message = string.Format("Instance call to method {0} failed (Reason {1}).", methodBase.Name, error);

                throw new InstanceException(message)
                {
                    ErrorCode = error,
                    HResult = error,
                };
            }
            else
            {
                return error;
            }
        }
    }
}
