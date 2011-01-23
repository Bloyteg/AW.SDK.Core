using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Serialization
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
    public class FieldSizeProviderAttribute : Attribute
    { }
}
