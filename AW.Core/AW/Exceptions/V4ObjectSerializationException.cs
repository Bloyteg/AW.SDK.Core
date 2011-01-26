using System;
using System.Collections.Generic;
using System.Text;

namespace AW
{
    public class V4ObjectSerializationException : Exception
    {
        internal V4ObjectSerializationException(string message) : base(message)
        {}
    }
}
