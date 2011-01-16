using System;

namespace AW
{
    /// <summary>
    /// Represents an exception for poorly formatted hex strings.
    /// </summary>
    public class NotHexStringException : Exception
    {
        internal NotHexStringException() : base("The provided hex string is poorly formatted.")
        {
            
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public string Value { get; internal set; }
    }
}
