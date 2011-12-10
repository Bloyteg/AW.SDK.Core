// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using Utilities;
using Utilities.Serialization;

namespace AW
{

    public class V4ObjectSerializer<TObject>
        where TObject : IV4Object, new()
    {
        private static readonly MemberInfo FieldSizeProvider = SerializationHelper.GetFieldSizeProvider<TObject>();
        private static readonly IDictionary<int, MemberInfo> FieldSizeOrdinals = SerializationHelper.GetFieldSizeOrdinals(FieldSizeProvider);
        private static readonly IDictionary<int, MemberInfo> FieldValueOrdinals = SerializationHelper.GetFieldValueOrdinals(typeof(TObject));

        //Force the static fields to be initialized.
        static V4ObjectSerializer() { }

        /// <summary>
        /// Deserializes the specified text reader.
        /// </summary>
        /// <param name="textReader">The text reader.</param>
        /// <returns></returns>
        [EnvironmentPermissionAttribute(SecurityAction.LinkDemand, Unrestricted = true)]
        public TObject Deserialize(TextReader textReader)
        {
            var buffer = textReader.ReadToEnd();
            return BytesToObject(new HexConverter(buffer));
        }

        /// <summary>
        /// Deserializes the specified input stream.
        /// </summary>
        /// <param name="inputStream">The input stream.</param>
        /// <returns></returns>
        [EnvironmentPermissionAttribute(SecurityAction.LinkDemand, Unrestricted = true)]
        public TObject Deserialize(Stream inputStream)
        {
            var buffer = new byte[inputStream.Length];
            inputStream.Position = 0;
            inputStream.Read(buffer, 0, buffer.Length);
            return BytesToObject(buffer);
        }

        /// <summary>
        /// Serializes the specified text writer.
        /// </summary>
        /// <param name="textWriter">The text writer.</param>
        /// <param name="v4Object">The v4 object.</param>
        [EnvironmentPermissionAttribute(SecurityAction.LinkDemand, Unrestricted = true)]
        public void Serialize(TextWriter textWriter, TObject v4Object)
        {
            textWriter.Write(new HexConverter(ObjectToBytes(v4Object)));
        }

        /// <summary>
        /// Serializes the specified output stream.
        /// </summary>
        /// <param name="outputStream">The output stream.</param>
        /// <param name="v4Object">The v4 object.</param>
        [EnvironmentPermissionAttribute(SecurityAction.LinkDemand, Unrestricted = true)]
        public void Serialize(Stream outputStream, TObject v4Object)
        {
            var buffer = ObjectToBytes(v4Object);
            outputStream.Write(buffer, 0, buffer.Length);
        }

        [EnvironmentPermissionAttribute(SecurityAction.LinkDemand, Unrestricted = true)]
        private static TObject BytesToObject(byte[] data)
        {
            var inObject = new TObject();

            //Get the header and set its data
            var type = SerializationHelper.GetFieldOrPropertyType(FieldSizeProvider);
            var header = Miscellaneous.BytesToStruct(type, data, 0);
            SerializationHelper.SetValue(FieldSizeProvider, inObject, header);

            //Get the payload
            int size = data.Length - Marshal.SizeOf(type);
            var payload = new byte[size];
            Array.ConstrainedCopy(data, data.Length - size, payload, 0, size);

            int offset = 0;
            foreach (var valueOrdinal in FieldValueOrdinals)
            {
                MemberInfo sizeOrdinal;

                if (!FieldSizeOrdinals.TryGetValue(valueOrdinal.Key, out sizeOrdinal))
                {
                    throw new V4ObjectSerializationException("Failed to deserialize object.");
                }

                var length = Convert.ToInt32(SerializationHelper.GetValue(sizeOrdinal, header));
                var targetType = SerializationHelper.GetFieldOrPropertyType(valueOrdinal.Value);


                if(targetType == null)
                {
                    throw new V4ObjectSerializationException("Failed to deserialize object.");   
                }

                if (targetType == typeof(string))
                {
                    var asString = Encoding.UTF8.GetString(payload, offset, length);
                    SerializationHelper.SetValue(valueOrdinal.Value, inObject, asString);
                }
                else if (targetType.GetInterface("ICollection") != null)
                {
                    var genericArguments = targetType.GetGenericArguments();
                    if(genericArguments.Length != 1)
                    {
                        throw new V4ObjectSerializationException("Failed to deserialize object.");
                    }

                    var structCollection = Activator.CreateInstance(targetType) as IList;
                    if (structCollection == null)
                    {
                        throw new V4ObjectSerializationException("Failed to deserialize object.");
                    }

                    var structType = genericArguments[0];
                    int structSize = Marshal.SizeOf(structType) + 1;
                    int totalStructs = length/structSize;
                    int structPosition = offset;

                    for(int i = 0; i < totalStructs; ++i)
                    {
                        structCollection.Add(Miscellaneous.BytesToStruct(structType, payload, structPosition));
                        structPosition += structSize;
                    }

                    SerializationHelper.SetValue(valueOrdinal.Value, inObject, structCollection);
                }

                offset += length;
            }

            return inObject;
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        [EnvironmentPermission(SecurityAction.LinkDemand, Unrestricted=true)]
        private static byte[] ObjectToBytes(TObject outObject)
        {
            var payload = new List<byte[]>();
            var fieldSizeProvider = SerializationHelper.GetValue(FieldSizeProvider, outObject);

            foreach (var valueOrdinal in FieldValueOrdinals)
            {
                MemberInfo sizeOrdinal;

                if (!FieldSizeOrdinals.TryGetValue(valueOrdinal.Key, out sizeOrdinal))
                {
                    throw new V4ObjectSerializationException("Failed to serialize object.");
                }

                var value = SerializationHelper.GetValue(valueOrdinal.Value, outObject);

                if(value == null)
                {
                    throw new V4ObjectSerializationException("Failed to serialize object.");
                }

                byte[] asBytes = null;

                if(value is string)
                {
                    asBytes = Encoding.UTF8.GetBytes((string) value);
                }
                else if(value is IEnumerable)
                {
                    var asEnumerable = (IEnumerable) value;
                    var byteList = new List<byte>();

                    foreach(var item in asEnumerable)
                    {
                        byteList.AddRange(Miscellaneous.ConcatArrays(Miscellaneous.StructToBytes(item), new byte[] { 0x0 }));
                    }

                    asBytes = byteList.ToArray();
                }

                if(asBytes == null)
                {
                    throw new V4ObjectSerializationException("Failed to serialize object.");
                }

                SerializationHelper.SetValue(sizeOrdinal, fieldSizeProvider, asBytes.Length);
                payload.Add(asBytes);
            }

            payload.Add(new byte[] { 0 });

            var header = Miscellaneous.StructToBytes(fieldSizeProvider);
            var result = Miscellaneous.ConcatArrays(header, payload);

            return result;
        }
    }
}