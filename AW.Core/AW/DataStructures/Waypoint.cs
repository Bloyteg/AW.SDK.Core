using System;
using System.Runtime.InteropServices;

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
            get { return speed; }
            set { speed = value; }
        }

        public byte Pause
        {
            get { return pause; }
            set { pause = value; }
        }

        //private byte flag;
    }
}