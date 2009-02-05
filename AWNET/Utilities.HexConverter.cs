using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Utilities
{
    internal class HexConverter
    {
        private string stringData;
        private byte[] byteData;

        public HexConverter(string hexString)
        {
            stringData = hexString;
        }

        public HexConverter(byte[] bytes)
        {
            byteData = bytes;
        }

        public void ConvertToBytes()
        {
            if (stringData != null)
            {
                if (stringData.Length % 2 != 0)
                    throw new SystemException("Oh shit!"); //Make this throw an actual exception one of these days. :)

                int size = stringData.Length / 2;
                byteData = new byte[size];
                for (int i = 0; i < size; ++i)
                {
                    byteData[i] = byte.Parse(stringData.Substring(i << 1, 2), System.Globalization.NumberStyles.HexNumber);
                }
            }
        }

        public void ConvertToString()
        {
            if (byteData != null)
            {
                StringBuilder outStr = new StringBuilder();
                foreach (byte curByte in byteData)
                {
                    outStr.AppendFormat("{0:X2}", curByte);
                }

                stringData = outStr.ToString();
            }
        }

        public static implicit operator byte[](HexConverter converter)
        {
            converter.ConvertToBytes();
            return converter.byteData;
        }

        public static implicit operator string(HexConverter converter)
        {
            converter.ConvertToString();
            return converter.stringData;
        }

        public string StringData
        {
            get { return stringData; }
        }

        public byte[] ByteData
        {
            get { return byteData; }
        }
    }
}