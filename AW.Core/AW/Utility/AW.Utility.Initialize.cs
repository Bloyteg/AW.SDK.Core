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
                if (initialized == true)
                    throw new Exception("Can not set the bind IP address after an instance has been created.");
                else
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

            int rc;

            if (bindAddress.Equals(string.Empty))
            {
                rc = InterOp.aw_init(Utility.Constants.CurrentBuild);
            }
            //Handles the case where a bind IP address has been set before all other instances were created.
            else
            {
                rc = InterOp.aw_init_bind(Utility.Constants.CurrentBuild, Utilities.Miscellaneous.IPStringToInt(bindAddress));
            }

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
