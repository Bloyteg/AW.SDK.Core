using System;
using System.IO;
using System.Xml.Serialization;

namespace AW
{
    /// <summary>
    /// Abstract class containing base members for V4 objects in the wrapper.  This class cannot be constructed directly.  Use one of the derivatives.
    /// </summary>
    [Serializable]
    public abstract class V4Object
    {
        abstract protected internal void SetData(byte[] data);
        abstract protected internal byte[] GetData();

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

        /// <summary>
        /// Sets the parameters of the V4 objects to those parameters represented by the XML file.
        /// </summary>
        /// <param name="xmlFile">The location of the XML file to load.</param>
        public void UnserializeFromXML(string xmlFile)
        {
            FileStream sr = File.OpenRead(xmlFile);

            try
            {
                XmlSerializer xs = new XmlSerializer(this.GetType());
                SetData(((V4Object)xs.Deserialize(sr)).GetData());
            }
            finally
            {
                sr.Close();
            }
        }

        /// <summary>
        /// Sets the parameters of the V4 objects to those parameters represented by the XML file.
        /// </summary>
        /// <param name="xmlStream">A stream containing an XML file to be loaded.</param>
        public void UnserializeFromXML(Stream xmlStream)
        {
            XmlSerializer xs = new XmlSerializer(this.GetType());
            SetData(((V4Object)xs.Deserialize(xmlStream)).GetData());
        }

        /// <summary>
        /// Writes the parameters of the V4 object to an XML file on disk.
        /// </summary>
        /// <param name="xmlFile">The location of where to save the XML file to.</param>
        public void SerializeToXML(string xmlFile)
        {
            FileStream sw = File.OpenWrite(xmlFile);

            try
            {
                XmlSerializer xs = new XmlSerializer(this.GetType());
                xs.Serialize(sw, this);
            }
            finally
            {
                sw.Close();
            }
        }

        /// <summary>
        /// Writes the parameters of the V4 object to an XML file in the specified stream.
        /// </summary>
        /// <param name="xmlStream">The stream to write the XML file to.</param>
        public void SerializeToXML(Stream xmlStream)
        {
            XmlSerializer xs = new XmlSerializer(this.GetType());
            xs.Serialize(xmlStream, this);
        }
    }

    //Portions of the Instance class related to handling V4 objects.
    public partial class Instance
    {
        /// <summary>
        /// Sets the attribute Attributes.ObjectData of the instance to the data represented by the V4 object.
        /// </summary>
        /// <typeparam name="TV4Object">The type of the V4 object being used.</typeparam>
        /// <param name="v4Object">The V4 object representing the data to be set.</param>
        /// <returns>RC code if Utility.UseReturnCodes is set to true.</returns>
        public int SetV4Object<TV4Object>(TV4Object v4Object) where TV4Object : V4Object
        {
            SetInstance();
            return SetData(Attributes.ObjectData, v4Object.GetData());
        }

        /// <summary>
        /// Retrieves a V4 object from the Attributes.ObjectData attribute of the instance.
        /// </summary>
        /// <typeparam name="TV4Object">the type of V4 object to be returned.</typeparam>
        /// <param name="v4Object">A reference to a V4 object to store the data into (does not have to be constructed).</param>
        public void GetV4Object<TV4Object>(out TV4Object v4Object) where TV4Object : V4Object, new()
        {
            SetInstance();
            v4Object = new TV4Object();
            v4Object.SetData(this.GetData(Attributes.ObjectData));
        }
    }
}