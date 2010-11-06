using System;

namespace AW
{
    /// <summary>
    /// Represents an exception for when the SDK fails to initialize properly.
    /// </summary>
    public class InitializationFailedException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InitializationFailedException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        internal InitializationFailedException(string message) : base(message)
        {
            
        }
    }
}
