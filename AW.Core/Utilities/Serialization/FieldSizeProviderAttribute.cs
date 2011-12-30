// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Serialization
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
    class FieldSizeProviderAttribute : Attribute
    { }
}
