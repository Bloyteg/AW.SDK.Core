using System;
using System.Collections.Generic;
using System.Reflection;

namespace Utilities.Serialization
{
    static class SerializationHelper
    {
        /// <summary>
        /// Gets the field provider.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static MemberInfo GetFieldSizeProvider<T>()
        {
            var type = typeof (T);
            var members = type.GetMembers(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            return GetFirstMemberWithAttribute<FieldSizeProviderAttribute>(members);
        }

        /// <summary>
        /// Gets the field size ordinals.
        /// </summary>
        /// <param name="fieldSizeProvider">The field size provider.</param>
        /// <returns></returns>
        public static IDictionary<int, MemberInfo> GetFieldSizeOrdinals(MemberInfo fieldSizeProvider)
        {
            return GetOrdinals<FieldSizeOrdinalAttribute>(fieldSizeProvider);
        }

        /// <summary>
        /// Gets the field value ordinals.
        /// </summary>
        /// <param name="fieldValueProvider">The field value provider.</param>
        /// <returns></returns>
        public static IDictionary<int, MemberInfo> GetFieldValueOrdinals(MemberInfo fieldValueProvider)
        {
            return GetOrdinals<FieldValueOrdinalAttribute>(fieldValueProvider);
        }

        /// <summary>
        /// Gets the ordinals.
        /// </summary>
        /// <typeparam name="TAttribute">The type of the attribute.</typeparam>
        /// <param name="member">The member.</param>
        /// <returns></returns>
        private static IDictionary<int, MemberInfo> GetOrdinals<TAttribute>(MemberInfo member)
            where TAttribute : OrdinalAttribute
        {
            var fields = GetFieldsAndProperties(member);
            var fieldOrdinals = new SortedDictionary<int, MemberInfo>();

            foreach (MemberInfo field in fields)
            {
                if (Attribute.IsDefined(field, typeof(TAttribute)))
                {
                    var ordinalAttribute = (TAttribute)Attribute.GetCustomAttribute(field, typeof(TAttribute));
                    fieldOrdinals.Add(ordinalAttribute.GetOrdinal(), field);
                }
            }

            return fieldOrdinals;
        }

        /// <summary>
        /// Gets the first member with attribute.
        /// </summary>
        /// <typeparam name="TAttribute">The type of the attribute.</typeparam>
        /// <param name="candidates">The candidates.</param>
        /// <returns></returns>
        private static MemberInfo GetFirstMemberWithAttribute<TAttribute>(IEnumerable<MemberInfo> candidates)
        {
            foreach (var member in candidates)
            {
                if (member.IsDefined(typeof(TAttribute), false))
                {
                    return member;
                }
            }

            return null;
        }


        /// <summary>
        /// Gets the fields and properties.
        /// </summary>
        /// <param name="memberInfo">The member info.</param>
        /// <returns></returns>
        private static IEnumerable<MemberInfo> GetFieldsAndProperties(MemberInfo memberInfo)
        {
            switch (memberInfo.MemberType)
            {
                case MemberTypes.Field:
                    return ((FieldInfo)memberInfo).FieldType.GetMembers(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                case MemberTypes.Property:
                    return ((PropertyInfo)memberInfo).PropertyType.GetMembers(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                case MemberTypes.TypeInfo:
                    return ((Type)memberInfo).GetMembers(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                default:
                    return null;
            }
        }

        /// <summary>
        /// Gets the type of the field or property.
        /// </summary>
        /// <param name="member">The member.</param>
        /// <returns></returns>
        public static Type GetFieldOrPropertyType(MemberInfo member)
        {
            switch (member.MemberType)
            {
                case MemberTypes.Field:
                    return ((FieldInfo)member).FieldType;
                case MemberTypes.Property:
                    return ((PropertyInfo)member).PropertyType;
                default:
                    return null;
            }    
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <param name="member">The member.</param>
        /// <param name="instance">The instance.</param>
        /// <returns></returns>
        public static object GetValue(MemberInfo member, object instance)
        {
            switch (member.MemberType)
            {
                case MemberTypes.Field:
                    return ((FieldInfo)member).GetValue(instance);
                case MemberTypes.Property:
                    return ((PropertyInfo)member).GetValue(instance, null);
                default:
                    return null;
            }    
        }

        public static void SetValue(MemberInfo member, object instance, object value)
        {
            switch (member.MemberType)
            {
                case MemberTypes.Field:
                    {
                        var field = (FieldInfo) member;
                        field.SetValue(instance, Convert.ChangeType(value, field.FieldType));
                    }
                    break;
                case MemberTypes.Property:
                    {
                        var property = (PropertyInfo) member;
                        property.SetValue(instance, Convert.ChangeType(value, property.PropertyType), null);
                    }
                    break;
            }     
        }
    }
}
