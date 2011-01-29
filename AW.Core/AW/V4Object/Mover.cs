// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Utilities.Serialization;

namespace AW
{
    [Serializable]
    public sealed class Mover : IV4Object
    {
        #region data
#pragma warning disable 169
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private class MoverData
        {
            public byte version = 1;
            public byte type;
            public MoverFlags flags = new MoverFlags();
            public short locked_pos_x;
            public short locked_pos_y;
            public short locked_pos_z;
            public short locked_yaw;
            public short locked_pitch;
            public byte glide_factor;     // -100 to +100
            public byte speed_factor = 1;      // 0.0 to 25.5 max (* 10)
            public byte friction_factor = 1;   // 0.0 to 25.5 max (* 10)
            public byte accel_tilt_x;     // -127 to +127
            public byte accel_tilt_z;     // -127 to +127
            public byte turn_factor = 1;       // 0.0 to 25.5 max (* 10)
            public byte avatar_tag;        // 0 to 255
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public sbyte[] reserved1;      // Bytes reserverd for future use /9 bytes
            [FieldSizeOrdinal(1)]
            public byte name_len;          // length of 1st string in str_data
            [FieldSizeOrdinal(2)]
            public byte seq_len;           // length of 2nd string in str_data
            [FieldSizeOrdinal(3)]
            public byte script_len;        // length of 3rd string in str_data
            [FieldSizeOrdinal(4)]
            public byte sound_len;         // length of 4rd string in str_data
            [FieldSizeOrdinal(5)]
            public short waypoints_len;   // length of 5th string in str_data
            [FieldSizeOrdinal(6)]
            public byte bump_name_len;     // length of 6th string in str_data
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public sbyte[] reserved2;      // Bytes reserverd for future use /2 bytes
        }
#pragma warning restore 169
        #endregion

        [FieldSizeProvider]
        private readonly MoverData _moverData = new MoverData();

        [FieldValueOrdinal(5)]
        private readonly List<Waypoint> _waypoints = new List<Waypoint>();
        [FieldValueOrdinal(1)]
        private string _name = string.Empty;
        [FieldValueOrdinal(2)]
        private string _sequence = string.Empty;
        [FieldValueOrdinal(3)]
        private string _script = string.Empty;
        [FieldValueOrdinal(4)]
        private string _sound = string.Empty;
        [FieldValueOrdinal(6)]
        private string _bumpName = string.Empty;

        public MoverFlags Flags
        {
            get { return _moverData.flags; }
            set { _moverData.flags = value; }
        }

        public MoverType Type
        {
            get { return (MoverType)_moverData.type; }
            set { _moverData.type = (byte)value; }
        }

        public short LockedPositionX
        {
            get { return _moverData.locked_pos_x; }
            set { _moverData.locked_pos_x = value; }
        }

        public short LockedPositionY
        {
            get { return _moverData.locked_pos_y; }
            set { _moverData.locked_pos_y = value; }
        }

        public short LockedPositionZ
        {
            get { return _moverData.locked_pos_z; }
            set { _moverData.locked_pos_z = value; }
        }

        public short LockedYaw
        {
            get { return _moverData.locked_yaw; }
            set { _moverData.locked_yaw = value; }
        }

        public short LockedPitch
        {
            get { return _moverData.locked_pitch; }
            set { _moverData.locked_pitch = value; }
        }

        public byte GlideFactor
        {
            get { return _moverData.glide_factor; }
            set { _moverData.glide_factor = value; }
        }

        public byte SpeedFactor
        {
            get { return _moverData.speed_factor; }
            set { _moverData.speed_factor = value; }
        }

        public byte FrictionFactor
        {
            get { return _moverData.friction_factor; }
            set { _moverData.friction_factor = value; }
        }

        public byte AccelerationTiltX
        {
            get { return _moverData.accel_tilt_x; }
            set { _moverData.accel_tilt_x = value; }
        }

        public byte AccelerationTiltZ
        {
            get { return _moverData.accel_tilt_z; }
            set { _moverData.accel_tilt_z = value; }
        }

        public byte TurnFactor
        {
            get { return _moverData.turn_factor; }
            set { _moverData.turn_factor = value; }
        }

        public byte AvatarTag
        {
            get { return _moverData.avatar_tag; }
            set { _moverData.avatar_tag = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Sequence
        {
            get { return _sequence; }
            set { _sequence = value; }
        }

        public string Script
        {
            get { return _script; }
            set { _script = value; }
        }

        public string Sound
        {
            get { return _sound; }
            set { _sound = value; }
        }

        public IList<Waypoint> Waypoints
        {
            get { return _waypoints; }
        }

        public string BumpName
        {
            get { return _bumpName; }
            set { _bumpName = value; }
        }
    }
}