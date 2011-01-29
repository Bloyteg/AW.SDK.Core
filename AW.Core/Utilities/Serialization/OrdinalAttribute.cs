// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
using System;

namespace Utilities.Serialization
{
    abstract class OrdinalAttribute : Attribute
    {
        private readonly int _ordinal;

        public OrdinalAttribute(int ordinal)
        {
            _ordinal = ordinal;
        }

        internal int GetOrdinal()
        {
            return _ordinal;
        }
    }
}
