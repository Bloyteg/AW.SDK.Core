using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace AW
{
    [Serializable]
    public abstract class V4Object
    {
        abstract protected internal void SetData(byte[] data);
        abstract protected internal byte[] GetData();

        public void UnserializeFromHex(string hexString)
        {
            SetData(new Utilities.HexConverter(hexString));
        }

        public string SerializeToHex()
        {
            return new Utilities.HexConverter(GetData());
        }

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

        public void UnserializeFromXML(Stream xmlStream)
        {
            XmlSerializer xs = new XmlSerializer(this.GetType());
            SetData(((V4Object)xs.Deserialize(xmlStream)).GetData());
        }

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

        public void SerializeToXML(Stream xmlStream)
        {
            XmlSerializer xs = new XmlSerializer(this.GetType());
            xs.Serialize(xmlStream, this);
        }
    }

    public partial class Instance
    {
        public void SetV4Object<TV4Object>(TV4Object v4Object) where TV4Object : V4Object
        {
            SetInstance();
            SetData(Attributes.ObjectData, v4Object.GetData());
        }

        public void GetV4Object<TV4Object>(out TV4Object v4Object) where TV4Object : V4Object, new()
        {
            SetInstance();
            v4Object = new TV4Object();
            v4Object.SetData(this.GetData(Attributes.ObjectData));
        }
    }
}