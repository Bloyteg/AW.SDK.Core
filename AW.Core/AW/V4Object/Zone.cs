// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
using System;
using System.Runtime.InteropServices;
using Utilities.Serialization;

namespace AW
{
    [Serializable]
    public sealed class Zone : IV4Object
    {
#pragma warning disable 169
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private class ZoneData
        {
            public Vector size = new Vector();
            public byte version = 1;
            public byte shape;
            public byte priority;
            public float gravity = 1.0f;
            public float friction = 1.0f;
            public ZoneFlags flags = new ZoneFlags();
            public uint color = 0xFFFFFFFF;
            public short fog_min;
            public short fog_max = 100;
            [FieldSizeOrdinal(1)]
            public short footstep_len;
            [FieldSizeOrdinal(2)]
            public short ambient_len;
            [FieldSizeOrdinal(3)]
            public byte camera_len;
            [FieldSizeOrdinal(4)]
            public byte target_cur_len;
            [FieldSizeOrdinal(5)]
            public byte voip_rights_len;
            [FieldSizeOrdinal(6)]
            public byte name_len;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public byte[] reserved;
        }
#pragma warning restore 169

        [FieldSizeProvider]
        [NonSerialized]
        private readonly ZoneData _zoneData = new ZoneData();

        [FieldValueOrdinal(1)]
        private string _footstep = string.Empty;
        [FieldValueOrdinal(2)]
        private string _ambient = string.Empty;
        [FieldValueOrdinal(3)]
        private string _camera = string.Empty;
        [FieldValueOrdinal(4)]
        private string _targetCursor = string.Empty;
        [FieldValueOrdinal(5)]
        private string _voipRights = string.Empty;
        [FieldValueOrdinal(6)]
        private string _name = string.Empty;

        public ZoneFlags Flags
        {
            get { return _zoneData.flags; }
            set { _zoneData.flags = value; }
        }

        public Vector Size
        {
            get { return _zoneData.size; }
            set { _zoneData.size = value; }
        }

        public ZoneType Shape
        {
            get { return (ZoneType)_zoneData.shape; }
            set { _zoneData.shape = (byte)value; }
        }

        public byte Priority
        {
            get { return _zoneData.priority; }
            set { _zoneData.priority = value; }
        }

        public float Gravity
        {
            get { return _zoneData.gravity; }
            set { _zoneData.gravity = value; }
        }

        public float Friction
        {
            get { return _zoneData.friction; }
            set { _zoneData.friction = value; }
        }

        public Color Color
        {
            get
            {
                return (int)_zoneData.color;
            }

            set
            {
                _zoneData.color = (uint)(int)value;
            }
        }

        public short FogMinimum
        {
            get { return _zoneData.fog_min; }
            set { _zoneData.fog_min = value; }
        }
        public short FogMaximum
        {
            get { return _zoneData.fog_max; }
            set { _zoneData.fog_max = value; }
        }

        public string Footstep
        {
            get { return _footstep; }
            set { _footstep = value; }
        }

        public string Ambient
        {
            get { return _ambient; }
            set { _ambient = value; }
        }

        public string Camera
        {
            get { return _camera; }
            set { _camera = value; }
        }

        public string TargetCursor
        {
            get { return _targetCursor; }
            set { _targetCursor = value; }
        }

        public string VoipRights
        {
            get { return _voipRights; }
            set { _voipRights = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}