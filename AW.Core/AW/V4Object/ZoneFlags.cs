using System;
using System.Runtime.InteropServices;

namespace AW
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [Serializable]
    public sealed class ZoneFlags
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
}