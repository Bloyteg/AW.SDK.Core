using System;
using System.Runtime.InteropServices;

namespace AW
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [Serializable]
    public sealed class ParticleFlags
    {
        private ushort flags;
        private static readonly ushort[] flagValues = { 0x0001, 0x0002, 0x0004, 0x0008, 0x0010, 0x0020, 0x0040 };
        /**
         *  AW_PARTICLE_FLAG_INTERPOLATE    = 0x01, 0
         *  AW_PARTICLE_FLAG_GRAVITY        = 0x02, 1
         *  AW_PARTICLE_FLAG_COLLIDE_ZONES  = 0x04, 2
         *  AW_PARTICLE_FLAG_ZONE_EXCLUSIVE = 0x08, 3
         *  AW_PARTICLE_FLAG_CAMERA_EMIT    = 0x10, 4
         *  AW_PARTICLE_FLAG_MOVER_LINK     = 0x20, 5
         *  AW_PARTICLE_DRAW_IN_FRONT       = 0x40, 6
         */

        public bool Interpolate
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

        public bool Gravity
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

        public bool ZoneCollision
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

        public bool ZoneExclusive
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

        public bool CameraEmit
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

        public bool LinkToMover
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

        public bool DrawInFront
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
    }
}