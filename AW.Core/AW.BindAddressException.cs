using System;

namespace AW
{
    /// <summary>
    /// Represents a failure to bind the given IP address.
    /// </summary>
    public class BindAddressException : Exception
    {
        internal BindAddressException(string message) : base(message)
        {
            
        }
    }
}
