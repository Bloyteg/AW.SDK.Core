using System;
using System.Runtime.InteropServices;

namespace AW
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [Serializable]
    public sealed class ZoneFlags
    {
        private short flags;
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
                flags = (value == true ? (short)(flags | flagValues[0]) : (short)(flags & ~flagValues[0]));
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
                flags = (value == true ? (short)(flags | flagValues[1]) : (short)(flags & ~flagValues[1]));
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
                flags = (value == true ? (short)(flags | flagValues[2]) : (short)(flags & ~flagValues[2]));
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
                flags = (value == true ? (short)(flags | flagValues[3]) : (short)(flags & ~flagValues[3]));
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
                flags = (value == true ? (short)(flags | flagValues[4]) : (short)(flags & ~flagValues[4]));
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
                flags = (value == true ? (short)(flags | flagValues[5]) : (short)(flags & ~flagValues[5]));
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
                flags = (value == true ? (short)(flags | flagValues[6]) : (short)(flags & ~flagValues[6]));
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
                flags = (value == true ? (short)(flags | flagValues[7]) : (short)(flags & ~flagValues[7]));
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
            public byte shape = 0;
            public byte priority = 0;
            public float gravity = 1.0f;
            public float friction = 1.0f;
            public ZoneFlags flags = new ZoneFlags();
            public uint color = 0xFFFFFFFF;
            public short fog_min = 0;
            public short fog_max = 100;
            public short footstep_len = 0;
            public short ambient_len = 0;
            public byte camera_len = 0;
            public byte target_cur_len = 0;
            public byte voip_rights_len = 0;
            public byte name_len = 0;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public byte[] reserved;
        }

        private ZoneData zoneData = new ZoneData();
        private byte[] remainder;
        private string footstep = string.Empty;
        private string ambient = string.Empty;
        private string camera = string.Empty;
        private string targetCursor = string.Empty;
        private string voipRights = string.Empty;
        private string name = string.Empty;

        public ZoneFlags Flags
        {
            get { return zoneData.flags; }
            set { zoneData.flags = value; }
        }

        public Vector Size
        {
            get { return zoneData.size; }
            set { zoneData.size = value; }
        }

        public ZoneType Shape
        {
            get { return (ZoneType)zoneData.shape; }
            set { zoneData.shape = (byte)value; }
        }

        public byte Priority
        {
            get { return zoneData.priority; }
            set { zoneData.priority = value; }
        }

        public float Gravity
        {
            get { return zoneData.gravity; }
            set { zoneData.gravity = value; }
        }

        public float Friction
        {
            get { return zoneData.friction; }
            set { zoneData.friction = value; }
        }

        public Color Color
        {
            get
            {
                return (int)zoneData.color;
            }

            set
            {
                zoneData.color = (uint)(int)value;
            }
        }

        public short FogMinimum
        {
            get { return zoneData.fog_min; }
            set { zoneData.fog_min = value; }
        }
        public short FogMaximum
        {
            get { return zoneData.fog_max; }
            set { zoneData.fog_max = value; }
        }

        public string Footstep
        {
            get { return footstep; }
            set { footstep = value; }
        }

        public string Ambient
        {
            get { return ambient; }
            set { ambient = value; }
        }

        public string Camera
        {
            get { return camera; }
            set { camera = value; }
        }

        public string TargetCursor
        {
            get { return targetCursor; }
            set { targetCursor = value; }
        }

        public string VoipRights
        {
            get { return voipRights; }
            set { voipRights = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        internal override byte[] GetData()
        {
            zoneData.footstep_len = (short)System.Text.UTF8Encoding.UTF8.GetByteCount(footstep);
            zoneData.ambient_len = (short)System.Text.UTF8Encoding.UTF8.GetByteCount(ambient);
            zoneData.camera_len = (byte)System.Text.UTF8Encoding.UTF8.GetByteCount(camera);
            zoneData.target_cur_len = (byte)System.Text.UTF8Encoding.UTF8.GetByteCount(targetCursor);
            zoneData.voip_rights_len = (byte)System.Text.UTF8Encoding.UTF8.GetByteCount(voipRights);
            zoneData.name_len = (byte)System.Text.UTF8Encoding.UTF8.GetByteCount(name);

            return Utilities.Miscellaneous.ConcatArrays(Utilities.Miscellaneous.StructToBytes(zoneData),
                                             System.Text.UTF8Encoding.UTF8.GetBytes(footstep),
                                             System.Text.UTF8Encoding.UTF8.GetBytes(ambient),
                                             System.Text.UTF8Encoding.UTF8.GetBytes(camera),
                                             System.Text.UTF8Encoding.UTF8.GetBytes(targetCursor),
                                             System.Text.UTF8Encoding.UTF8.GetBytes(voipRights),
                                             System.Text.UTF8Encoding.UTF8.GetBytes(name),
                                             new byte[] { 0 }
                                            );

        }

        internal override void SetData(byte[] data)
        {
            zoneData = Utilities.Miscellaneous.BytesToStruct<ZoneData>(data, 0);
            int size = data.Length - Marshal.SizeOf(typeof(ZoneData));
            remainder = new byte[size];
            Array.ConstrainedCopy(data, data.Length - size, remainder, 0, size);

            footstep = System.Text.UTF8Encoding.UTF8.GetString(remainder, 0, zoneData.footstep_len);
            ambient = System.Text.UTF8Encoding.UTF8.GetString(remainder, zoneData.footstep_len, zoneData.ambient_len);
            camera = System.Text.UTF8Encoding.UTF8.GetString(remainder, zoneData.footstep_len+zoneData.ambient_len, zoneData.camera_len);
            targetCursor = System.Text.UTF8Encoding.UTF8.GetString(remainder, zoneData.footstep_len+zoneData.ambient_len+zoneData.camera_len, zoneData.target_cur_len);
            voipRights = System.Text.UTF8Encoding.UTF8.GetString(remainder, zoneData.voip_rights_len + zoneData.footstep_len + zoneData.ambient_len + zoneData.camera_len, zoneData.voip_rights_len);
            name = System.Text.UTF8Encoding.UTF8.GetString(remainder, zoneData.voip_rights_len + zoneData.footstep_len + zoneData.ambient_len + zoneData.camera_len + zoneData.voip_rights_len, zoneData.name_len);
        }
    }
}