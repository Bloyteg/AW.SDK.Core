using System;
using System.Runtime.InteropServices;
using System.Text;

namespace AW
{
    public interface IZoneFlags
    {
        bool Water { get; set; }
        bool BlockParticles { get; set; }
        bool BlockLights { get; set; }
        bool BlockWorldLight { get; set; }
        bool BlockChat { get; set; }
        bool Visible { get; set; }
        bool BlockJoin { get; set; }
        bool Voip { get; set; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [Serializable]
    sealed class ZoneFlags : IZoneFlags
    {
        private ushort flags;
        static readonly byte[] flagValues = { 0x01, 0x02, 0x04, 0x08, 0x10, 0x20, 0x40, 0x80 };
        /**
         *  AW_ZONE_FLAG_WATER              = 0x01,
         *  AW_ZONE_FLAG_BLOCK_PARTICLES    = 0x02,
         *  AW_ZONE_FLAG_BLOCK_LIGHTS       = 0x04,
         *  AW_ZONE_FLAG_BLOCK_WORLD_LIGHT  = 0x08,
         *  AW_ZONE_FLAG_BLOCK_CHAT         = 0x10,
         *  AW_ZONE_FLAG_VISIBLE            = 0x20,
         *  AW_ZONE_FLAG_BLOCK_JOIN         = 0x40,
         *  AW_ZONE_FLAG_VOIP               = 0x80
         */

        public bool Water
        {
            get
            {
                return (flags & flagValues[0]) == flagValues[0];
            }

            set
            {
                flags = (ushort)(value ? (flags | flagValues[0]) : (flags & ~flagValues[0]));
            }
        }

        public bool BlockParticles
        {
            get
            {
                return (flags & flagValues[1]) == flagValues[1];
            }

            set
            {
                flags = (ushort)(value ? (flags | flagValues[1]) : (flags & ~flagValues[1]));
            }
        }

        public bool BlockLights
        {
            get
            {
                return (flags & flagValues[2]) == flagValues[2];
            }

            set
            {
                flags = (ushort)(value ? (flags | flagValues[2]) : (flags & ~flagValues[2]));
            }
        }

        public bool BlockWorldLight
        {
            get
            {
                return (flags & flagValues[3]) == flagValues[3];
            }

            set
            {
                flags = (ushort)(value ? (flags | flagValues[3]) : (flags & ~flagValues[3]));
            }
        }

        public bool BlockChat
        {
            get
            {
                return (flags & flagValues[4]) == flagValues[4];
            }

            set
            {
                flags = (ushort)(value ? (flags | flagValues[4]) : (flags & ~flagValues[4]));
            }
        }

        public bool Visible
        {
            get
            {
                return (flags & flagValues[5]) == flagValues[5];
            }

            set
            {
                flags = (ushort)(value ? (flags | flagValues[5]) : (flags & ~flagValues[5]));
            }
        }

        public bool BlockJoin
        {
            get
            {
                return (flags & flagValues[6]) == flagValues[6];
            }

            set
            {
                flags = (ushort)(value ? (flags | flagValues[6]) : (flags & ~flagValues[6]));
            }
        }

        public bool Voip
        {
            get
            {
                return (flags & flagValues[7]) == flagValues[7];
            }

            set
            {
                flags = (ushort)(value ? (flags | flagValues[7]) : (flags & ~flagValues[7]));
            }
        }
    }

    public sealed class Zone : V4Object
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private class ZoneData
        {
            public Vector size = new Vector();
            public byte version = 1;
            public byte shape;
            public byte priority;
            public float gravity = 1.0f;
            public float friction = 1.0f;
            public IZoneFlags flags = new ZoneFlags();
            public uint color = 0xFFFFFFFF;
            public short fog_min;
            public short fog_max = 100;
            public short footstep_len ;
            public short ambient_len;
            public byte camera_len;
            public byte target_cur_len;
            public byte voip_rights_len;
            public byte name_len;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public byte[] reserved;
        }

        private ZoneData _zoneData = new ZoneData();
        private byte[] _remainder;
        private string _footstep = string.Empty;
        private string _ambient = string.Empty;
        private string _camera = string.Empty;
        private string _targetCursor = string.Empty;
        private string _voipRights = string.Empty;
        private string _name = string.Empty;

        public IZoneFlags Flags
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

        internal override byte[] GetData()
        {
            _zoneData.footstep_len = (short)Encoding.UTF8.GetByteCount(_footstep);
            _zoneData.ambient_len = (short)Encoding.UTF8.GetByteCount(_ambient);
            _zoneData.camera_len = (byte)Encoding.UTF8.GetByteCount(_camera);
            _zoneData.target_cur_len = (byte)Encoding.UTF8.GetByteCount(_targetCursor);
            _zoneData.voip_rights_len = (byte)Encoding.UTF8.GetByteCount(_voipRights);
            _zoneData.name_len = (byte)Encoding.UTF8.GetByteCount(_name);

            return Utilities.Miscellaneous.ConcatArrays(Utilities.Miscellaneous.StructToBytes(_zoneData),
                                                        Encoding.UTF8.GetBytes(_footstep),
                                                        Encoding.UTF8.GetBytes(_ambient),
                                                        Encoding.UTF8.GetBytes(_camera),
                                                        Encoding.UTF8.GetBytes(_targetCursor),
                                                        Encoding.UTF8.GetBytes(_voipRights),
                                                        Encoding.UTF8.GetBytes(_name),
                                                        new byte[] {0});

        }

        internal override void SetData(byte[] data)
        {
            _zoneData = Utilities.Miscellaneous.BytesToStruct<ZoneData>(data, 0);
            int size = data.Length - Marshal.SizeOf(typeof(ZoneData));
            _remainder = new byte[size];
            Array.ConstrainedCopy(data, data.Length - size, _remainder, 0, size);

            _footstep = Encoding.UTF8.GetString(_remainder, 0, _zoneData.footstep_len);
            _ambient = Encoding.UTF8.GetString(_remainder, _zoneData.footstep_len, _zoneData.ambient_len);
            _camera = Encoding.UTF8.GetString(_remainder, _zoneData.footstep_len + _zoneData.ambient_len, _zoneData.camera_len);
            _targetCursor = Encoding.UTF8.GetString(_remainder, _zoneData.footstep_len + _zoneData.ambient_len + _zoneData.camera_len, _zoneData.target_cur_len);
            _voipRights = Encoding.UTF8.GetString(_remainder, _zoneData.voip_rights_len + _zoneData.footstep_len + _zoneData.ambient_len + _zoneData.camera_len, _zoneData.voip_rights_len);
            _name = Encoding.UTF8.GetString(_remainder, _zoneData.voip_rights_len + _zoneData.footstep_len + _zoneData.ambient_len + _zoneData.camera_len + _zoneData.voip_rights_len, _zoneData.name_len);
        }
    }
}