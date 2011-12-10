// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
using System;
using System.Collections.Generic;
using System.Text;

namespace AW
{
    [Serializable]
    public class V4ObjectSerializationException : Exception
    {
        internal V4ObjectSerializationException(string message) : base(message)
        {}
    }
}
