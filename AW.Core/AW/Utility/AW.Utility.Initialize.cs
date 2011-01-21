using System.Runtime.InteropServices;

namespace AW
{
    /// <summary>
    /// The Utility class contains several functions required to operate the SDK, but are not related to the <see cref="AW.Instance" /> class.
    /// </summary>
    public static partial class Utility
    {
        private static bool _initialized;
        private static string _bindAddress = string.Empty;

        public static string BindAddress
        {
            get { return _bindAddress; }
            set
            {
                if (_initialized)
                    throw new BindAddressException();

                _bindAddress = value;
            }
        }

        internal static bool Initialized
        {
            get { return _initialized; }
        }

        internal static int Initialize()
        {
            Marshal.PrelinkAll(typeof(NativeMethods));

            int rc = _bindAddress.Equals(string.Empty) ? NativeMethods.aw_init(Constants.CurrentBuild) : NativeMethods.aw_init_bind(Constants.CurrentBuild, Utilities.Miscellaneous.IPStringToInt(_bindAddress));

            if (rc == 0)
                _initialized = true;
            return rc;
        }

        internal static void Terminate()
        {
            _initialized = false;
            NativeMethods.aw_term();
        }
    }
}
