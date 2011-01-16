using System.Text;
using AW;

namespace Utilities
{
    /// <summary>
    /// Class used to convert between byte arrays and hex-encoded strings.
    /// </summary>
    internal class HexConverter
    {
        private string _stringData;
        private byte[] _byteData;

        /// <summary>
        /// Constructs a new HexConverter with the specified hex-encoded string.
        /// </summary>
        /// <param name="hexString">The string to convert.</param>
        public HexConverter(string hexString)
        {
            _stringData = hexString;
        }

        /// <summary>
        /// Constructs a new HexConverter with the specified byte-array.
        /// </summary>
        /// <param name="bytes">The byte array to convert.</param>
        public HexConverter(byte[] bytes)
        {
            _byteData = bytes;
        }

        /// <summary>
        /// Converts the internal data into a byte-array.
        /// </summary>
        public void ConvertToBytes()
        {
            if (_stringData != null)
            {
                if (_stringData.Length % 2 != 0)
                    throw new NotHexStringException
                              {
                                  Value = _stringData
                              };

                int size = _stringData.Length / 2;
                _byteData = new byte[size];
                for (int i = 0; i < size; ++i)
                {
                    _byteData[i] = byte.Parse(_stringData.Substring(i << 1, 2), System.Globalization.NumberStyles.HexNumber);
                }
            }
        }

        /// <summary>
        /// Converts the internal data into a string.
        /// </summary>
        public void ConvertToString()
        {
            if (_byteData != null)
            {
                StringBuilder outStr = new StringBuilder();
                foreach (byte curByte in _byteData)
                {
                    outStr.AppendFormat("{0:X2}", curByte);
                }

                _stringData = outStr.ToString();
            }
        }

        /// <summary>
        /// Implicit operator that converts the internal data into bytes.
        /// </summary>
        /// <param name="converter">The HexConverter the operator is being performed on.</param>
        /// <returns>byte-array representation of the data.</returns>
        public static implicit operator byte[](HexConverter converter)
        {
            converter.ConvertToBytes();
            return converter._byteData;
        }

        /// <summary>
        /// Implicit operator that converts the internal data into a hex-encoded string..
        /// </summary>
        /// <param name="converter">The HexConverter the operator is being performed on.</param>
        /// <returns>Hex-encoded string representation of the data.</returns>
        public static implicit operator string(HexConverter converter)
        {
            converter.ConvertToString();
            return converter._stringData;
        }

        /// <summary>
        /// The hex-encoded string representation of the internal data.
        /// </summary>
        public string StringData
        {
            get
            {
                ConvertToString();
                return _stringData;
            }
        }

        /// <summary>
        /// The byte-array representation of the internal data.
        /// </summary>
        public byte[] ByteData
        {
            get
            {
                ConvertToBytes();
                return _byteData;
            }
        }
    }
}