using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace AW
{
    /// <summary>
    /// A three dimensional vector used by the SDK.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    [Serializable]
    public sealed class Vector
    {
        float xMagnitude;
        float yMagnitude;
        float zMagnitude;

        /// <summary>
        /// Magnitude of the vector along the X axis.
        /// </summary>
        [XmlAttribute("XMagnitude")]
        public float XMagnitude
        {
            get
            {
                return xMagnitude;
            }

            set
            {
                xMagnitude = value;
            }
        }

        /// <summary>
        /// Magnitude of the vector along the Y axis.
        /// </summary>
        [XmlAttribute("YMagnitude")]
        public float YMagnitude
        {
            get
            {
                return yMagnitude;
            }

            set
            {
                yMagnitude = value;
            }
        }

        /// <summary>
        /// Magnitude of the vector along the Z axis.
        /// </summary>
        [XmlAttribute("ZMagnitude")]
        public float ZMagnitude
        {
            get
            {
                return zMagnitude;
            }

            set
            {
                zMagnitude = value;
            }
        }
    }
}