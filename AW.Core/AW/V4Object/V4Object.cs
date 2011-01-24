using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel;
using Utilities;
using Utilities.Serialization;

namespace AW
{
    /// <summary>
    /// Abstract class containing base members for V4 objects in the wrapper.  This class cannot be constructed directly.  Use one of the derivatives.
    /// </summary>
    [Serializable]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public abstract class V4Object<TObject>
        where TObject : V4Object<TObject>, new()
    {
        private static readonly MemberInfo FieldSizeProvider = SerializationHelper.GetFieldSizeProvider<TObject>();
        private static readonly IDictionary<int, MemberInfo> FieldSizeOrdinals = SerializationHelper.GetFieldSizeOrdinals(FieldSizeProvider);
        private static readonly IDictionary<int, MemberInfo> FieldValueOrdinals = SerializationHelper.GetFieldValueOrdinals(typeof(TObject));

        //Force the static fields to be initialized.
        static V4Object() {}

        internal void SetData(byte[] data)
        {
            //Get the header and set its data
            var type = SerializationHelper.GetFieldOrPropertyType(FieldSizeProvider);
            var header = Miscellaneous.BytesToStruct(type, data, 0);
            SerializationHelper.SetValue(FieldSizeProvider, this, header);

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
                    throw new Exception("BORKA BORKA!");
                }

                var length = Convert.ToInt32(SerializationHelper.GetValue(sizeOrdinal, header));
                var targetType = SerializationHelper.GetFieldOrPropertyType(valueOrdinal.Value);


                if(targetType == null)
                {
                    throw new Exception("Jerpa jerpa!");    
                }

                if (targetType == typeof(string))
                {
                    var asString = Encoding.UTF8.GetString(payload, offset, length);
                    SerializationHelper.SetValue(valueOrdinal.Value, this, asString);
                }
                else if (targetType.GetInterface("ICollection") != null)
                {
                    var genericArguments = targetType.GetGenericArguments();
                    if(genericArguments.Length != 1)
                    {
                        throw new Exception("Belp belp!");
                    }

                    var structCollection = Activator.CreateInstance(targetType) as IList;
                    if (structCollection == null)
                    {
                        throw new Exception("Jerbl jerbl!");
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

                    SerializationHelper.SetValue(valueOrdinal.Value, this, structCollection);
                }

                offset += length;
            }
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        internal byte[] GetData()
        {
            var payload = new List<byte[]>();
            var fieldSizeProvider = SerializationHelper.GetValue(FieldSizeProvider, this);

            foreach (var valueOrdinal in FieldValueOrdinals)
            {
                MemberInfo sizeOrdinal;

                if (!FieldSizeOrdinals.TryGetValue(valueOrdinal.Key, out sizeOrdinal))
                {
                    throw new Exception("BORKA BORKA!");
                }

                var value = SerializationHelper.GetValue(valueOrdinal.Value, this);

                if(value == null)
                {
                    throw new Exception("Jerpa jerpa!");
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
                    throw new Exception("Gargle gargle!");
                }

                SerializationHelper.SetValue(sizeOrdinal, fieldSizeProvider, asBytes.Length);
                payload.Add(asBytes);
            }

            payload.Add(new byte[] { 0 });

            var header = Miscellaneous.StructToBytes(fieldSizeProvider);
            var result = Miscellaneous.ConcatArrays(header, payload);

            return result;
        }

        #region Hex serialization
        /// <summary>
        /// Sets the parameters of the V4 object to those parameters represented by the hex-encoded string.
        /// </summary>
        /// <param name="hexString">The hex-encoded string to decode and convert into a V4 object.</param>
        public void UnserializeFromHex(string hexString)
        {
            SetData(new HexConverter(hexString));
        }

        /// <summary>
        /// Serializes the parameters of the V4 object into a hex-encoded string representation.
        /// </summary>
        /// <returns>The hex-encoded string representation.</returns>
        public string SerializeToHex()
        {
            return new HexConverter(GetData());
        }
        #endregion

        #region XML serialization
        /// <summary>
        /// Sets the parameters of the V4 objects to those parameters represented by the XML file.
        /// </summary>
        /// <param name="xmlFile">The location of the XML file to load.</param>
        public void UnserializeFromXml(string xmlFile)
        {
            using (FileStream fileStream = File.OpenRead(xmlFile))
            {
                var xmlSerializer = new XmlSerializer(GetType());
                SetData(((V4Object<TObject>) xmlSerializer.Deserialize(fileStream)).GetData());
            }
        }

        /// <summary>
        /// Sets the parameters of the V4 objects to those parameters represented by the XML file.
        /// </summary>
        /// <param name="xmlStream">A stream containing an XML file to be loaded.</param>
        public void UnserializeFromXml(Stream xmlStream)
        {
            var xmlSerializer = new XmlSerializer(GetType());
            SetData(((V4Object<TObject>)xmlSerializer.Deserialize(xmlStream)).GetData());
        }

        /// <summary>
        /// Writes the parameters of the V4 object to an XML file on disk.
        /// </summary>
        /// <param name="xmlFile">The location of where to save the XML file to.</param>
        public void SerializeToXml(string xmlFile)
        {
            using(FileStream fileStream = File.OpenWrite(xmlFile))
            {
                var xmlSerializer = new XmlSerializer(GetType());
                xmlSerializer.Serialize(fileStream, this);
            }
        }

        /// <summary>
        /// Writes the parameters of the V4 object to an XML file in the specified stream.
        /// </summary>
        /// <param name="xmlStream">The stream to write the XML file to.</param>
        public void SerializeToXml(Stream xmlStream)
        {
            var xmlSerializer = new XmlSerializer(GetType());
            xmlSerializer.Serialize(xmlStream, this);
        }

        #endregion
    }
}