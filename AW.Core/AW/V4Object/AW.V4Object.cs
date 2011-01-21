using System;
using System.IO;
using System.Xml.Serialization;
using System.ComponentModel;

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
        abstract internal void SetData(byte[] data);
        abstract internal byte[] GetData();

        #region Hex serialization
        /// <summary>
        /// Sets the parameters of the V4 object to those parameters represented by the hex-encoded string.
        /// </summary>
        /// <param name="hexString">The hex-encoded string to decode and convert into a V4 object.</param>
        public void UnserializeFromHex(string hexString)
        {
            SetData(new Utilities.HexConverter(hexString));
        }

        /// <summary>
        /// Serializes the parameters of the V4 object into a hex-encoded string representation.
        /// </summary>
        /// <returns>The hex-encoded string representation.</returns>
        public string SerializeToHex()
        {
            return new Utilities.HexConverter(GetData());
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