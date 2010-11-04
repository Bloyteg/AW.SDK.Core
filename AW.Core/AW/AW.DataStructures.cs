using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace AW
{
    /// <summary>
    /// Represents a mover waypoint.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [Serializable]
    public sealed class Waypoint
    {
        private short x;
        private short y;
        private short z;
        private short yaw;
        private short pitch;
        private short roll;
        private short speed;
        private byte pause;
        private byte flag;

        /// <summary>
        /// The X position of the waypoint.
        /// </summary>
        public short X
        {
            get { return x; }
            set { x = value; }
        }

        /// <summary>
        /// The Y position of the waypoint.
        /// </summary>
        public short Y
        {
            get { return y; }
            set { y = value; }
        }

        /// <summary>
        /// The Z position of the waypoint.
        /// </summary>
        public short Z
        {
            get { return z; }
            set { z = value; }
        }

        /// <summary>
        /// The Yaw of the wapoint.
        /// </summary>
        public short Yaw
        {
            get { return yaw; }
            set { yaw = value; }
        }

        /// <summary>
        /// The Pitch of the waypoint.
        /// </summary>
        public short Pitch
        {
            get { return pitch; }
            set { pitch = value; }
        }

        /// <summary>
        /// The Roll of the waypoint.
        /// </summary>
        public short Roll
        {
            get { return roll; }
            set { roll = value; }
        }

        public short Speed
        {
            get { return (short)speed; }
            set { speed = (short)value; }
        }

        public byte Pause
        {
            get { return pause; }
            set { pause = value; }
        }

        //private byte flag;
    }

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

    /// <summary>
    /// A range of two vectors used by the SDK.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    [Serializable]
    public sealed class VectorRange
    {
        Vector minimum = new Vector();
        Vector maximum = new Vector();

        /// <summary>
        /// The mininal range vector.
        /// </summary>
        public Vector Minimum
        {
            get { return minimum; }
            set { minimum = value; }
        }

        /// <summary>
        /// The maximal range vector.
        /// </summary>
        public Vector Maximum
        {
            get { return maximum; }
            set { maximum = value; }
        }
    }
}