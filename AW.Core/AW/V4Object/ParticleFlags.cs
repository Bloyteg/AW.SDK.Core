using System;
using System.Runtime.InteropServices;

namespace AW
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [Serializable]
    public sealed class ParticleFlags
    {
        [Flags]
        private enum Flags : ushort
        {
            Interpolate =   0x0001,
            Gravity =       0x0002,
            ZoneCollision = 0x0004,
            ZoneExclusive = 0x0008,
            CameraEmit =    0x0010,
            LinkToMover =   0x0020,
            DrawInFront =   0x0040,
            ApplyRotation = 0x0080
        }

        private Flags flags;

        public bool Interpolate
        {
            get { return (flags & Flags.Interpolate) == Flags.Interpolate; }

            set
            {
                if (value)
                {
                    flags |= Flags.Interpolate;
                }
                else
                {
                    flags &= ~Flags.Interpolate;
                }
            }
        }

        public bool Gravity
        {
            get { return (flags & Flags.Gravity) == Flags.Gravity; }

            set
            {
                if (value)
                {
                    flags |= Flags.Gravity;
                }
                else
                {
                    flags &= ~Flags.Gravity;
                }
            }
        }

        public bool ZoneCollision
        {
            get { return (flags & Flags.ZoneCollision) == Flags.ZoneCollision; }

            set
            {
                if (value)
                {
                    flags |= Flags.ZoneCollision;
                }
                else
                {
                    flags &= ~Flags.ZoneCollision;
                }
            }
        }

        public bool ZoneExclusive
        {
            get { return (flags & Flags.ZoneExclusive) == Flags.ZoneExclusive; }

            set
            {
                if (value)
                {
                    flags |= Flags.ZoneExclusive;
                }
                else
                {
                    flags &= ~Flags.ZoneExclusive;
                }
            }
        }

        public bool CameraEmit
        {
            get { return (flags & Flags.CameraEmit) == Flags.CameraEmit; }

            set
            {
                if (value)
                {
                    flags |= Flags.CameraEmit;
                }
                else
                {
                    flags &= ~Flags.CameraEmit;
                }
            }
        }

        public bool LinkToMover
        {
            get { return (flags & Flags.LinkToMover) == Flags.LinkToMover; }

            set
            {
                if (value)
                {
                    flags |= Flags.LinkToMover;
                }
                else
                {
                    flags &= ~Flags.LinkToMover;
                }
            }
        }

        public bool DrawInFront
        {
            get { return (flags & Flags.DrawInFront) == Flags.DrawInFront; }

            set
            {
                if (value)
                {
                    flags |= Flags.DrawInFront;
                }
                else
                {
                    flags &= ~Flags.DrawInFront;
                }
            }
        }

        public bool ApplyRotation
        {
            get { return (flags & Flags.ApplyRotation) == Flags.ApplyRotation; }

            set
            {
                if (value)
                {
                    flags |= Flags.ApplyRotation;
                }
                else
                {
                    flags &= ~Flags.ApplyRotation;
                }
            }
        }
    }
}