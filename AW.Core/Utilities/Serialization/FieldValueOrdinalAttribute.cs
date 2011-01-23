using System;

namespace Utilities.Serialization
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    class FieldValueOrdinalAttribute : OrdinalAttribute
    {
        public FieldValueOrdinalAttribute(int ordinal) : base(ordinal) { }
    }
}
