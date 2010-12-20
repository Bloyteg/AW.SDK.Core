using System;
using System.Runtime.InteropServices;

namespace AW
{
    /// <summary>
    /// The Utility class contains several functions required to operate the SDK, but are not related to the <see cref="AW.Instance" /> class.
    /// </summary>
    public static partial class Utility
    {
        private static bool initialized = false;
        private static string bindAddress = string.Empty;

        public static string BindAddress
        {
            get { return bindAddress; }
            set
            {
                if (initialized)
                    throw new BindAddressException();

                bindAddress = value;
            }
        }

        internal static bool Initialized
        {
            get { return initialized; }
        }

        internal static int Initialize()
        {
            Marshal.PrelinkAll(typeof(InterOp));

            int rc = bindAddress.Equals(string.Empty) ? InterOp.aw_init(Constants.CurrentBuild) : InterOp.aw_init_bind(Constants.CurrentBuild, Utilities.Miscellaneous.IPStringToInt(bindAddress));

            if (rc == 0)
                initialized = true;
            return rc;
        }

        internal static void Terminate()
        {
            initialized = false;
            InterOp.aw_term();
        }
    }
}
