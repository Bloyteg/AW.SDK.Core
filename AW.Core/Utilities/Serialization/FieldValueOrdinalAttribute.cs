﻿// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
using System;

namespace Utilities.Serialization
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    class FieldValueOrdinalAttribute : OrdinalAttribute
    {
        public FieldValueOrdinalAttribute(int ordinal) : base(ordinal) { }
    }
}
