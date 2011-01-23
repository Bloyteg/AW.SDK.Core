using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
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
            //int waypointSize = Marshal.SizeOf(typeof(Waypoint)) + 1;

            //_moverData = Utilities.Miscellaneous.BytesToStruct<MoverData>(data, 0);
            //int size = data.Length - Marshal.SizeOf(typeof(MoverData));
            //_remainder = new byte[size];
            //Array.ConstrainedCopy(data, data.Length - size, _remainder, 0, size);

            //_name = Encoding.UTF8.GetString(_remainder, 0, _moverData.name_len);
            //_sequence = Encoding.UTF8.GetString(_remainder, _moverData.name_len, _moverData.seq_len);
            //_script = Encoding.UTF8.GetString(_remainder, _moverData.name_len + _moverData.seq_len, _moverData.script_len);
            //_sound = Encoding.UTF8.GetString(_remainder, _moverData.name_len + _moverData.seq_len + _moverData.script_len, _moverData.sound_len);
            ////waypoints before bumpName.
            //_bumpName = Encoding.UTF8.GetString(_remainder, _moverData.name_len + _moverData.seq_len + _moverData.script_len + _moverData.sound_len + _moverData.waypoints_len, _moverData.bump_name_len);

            //// waypoints
            //int waypointPosition = _moverData.name_len + _moverData.seq_len + _moverData.script_len + _moverData.sound_len;
            //int totalWaypoints = _moverData.waypoints_len / waypointSize;

            //for (int i = 0; i < totalWaypoints; ++i)
            //{
            //    _waypoints.Add(Utilities.Miscellaneous.BytesToStruct<Waypoint>(_remainder, waypointPosition));
            //    waypointPosition += waypointSize;
            //}
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
                        byteList.AddRange(Miscellaneous.StructToBytes(item));
                    }

                    payload.Add(byteList.ToArray());
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