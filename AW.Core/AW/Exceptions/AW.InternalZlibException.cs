using System;

namespace AW
{
    /// <summary>
    /// Represents an internal Zlib error.
    /// </summary>
	public class InternalZlibException : Exception
	{
        internal InternalZlibException(string message) : base(message)
        {
        }
	}
}
