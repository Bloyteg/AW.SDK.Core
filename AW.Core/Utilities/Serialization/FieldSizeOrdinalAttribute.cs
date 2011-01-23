using System;

namespace Utilities.Serialization
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    class FieldSizeOrdinalAttribute : OrdinalAttribute
    {
        public FieldSizeOrdinalAttribute(int ordinal) : base(ordinal) { }
    }
}
