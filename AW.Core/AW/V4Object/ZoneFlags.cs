// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
using System;
using System.Runtime.InteropServices;

namespace AW
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [Serializable]
    public sealed class ZoneFlags
    {
        [Flags]
        private enum Flags
        {
            Water =             0x001,
            BlockParticles =    0x002,
            BlockLights =       0x004,
            BlockWorldLight =   0x008,
            BlockChat =         0x010,
            Visible =           0x020,
            BlockJoin =         0x040,
            Voip =              0x080,
            BlockAudio =        0x100
        }

        private Flags flags;

        public bool Water
        {
            get { return (flags & Flags.Water) == Flags.Water; }

            set
            {
                if (value)
                {
                    flags |= Flags.Water;
                }
                else
                {
                    flags &= ~Flags.Water;
                }
            }
        }

        public bool BlockParticles
        {
            get { return (flags & Flags.BlockParticles) == Flags.BlockParticles; }

            set
            {
                if (value)
                {
                    flags |= Flags.BlockParticles;
                }
                else
                {
                    flags &= ~Flags.BlockParticles;
                }
            }
        }

        public bool BlockLights
        {
            get { return (flags & Flags.BlockLights) == Flags.BlockLights; }

            set
            {
                if (value)
                {
                    flags |= Flags.BlockLights;
                }
                else
                {
                    flags &= ~Flags.BlockLights;
                }
            }
        }

        public bool BlockWorldLight
        {
            get { return (flags & Flags.BlockWorldLight) == Flags.BlockWorldLight; }

            set
            {
                if (value)
                {
                    flags |= Flags.BlockWorldLight;
                }
                else
                {
                    flags &= ~Flags.BlockWorldLight;
                }
            }
        }

        public bool BlockChat
        {
            get { return (flags & Flags.BlockChat) == Flags.BlockChat; }

            set
            {
                if (value)
                {
                    flags |= Flags.BlockChat;
                }
                else
                {
                    flags &= ~Flags.BlockChat;
                }
            }
        }

        public bool Visible
        {
            get { return (flags & Flags.Visible) == Flags.Visible; }

            set
            {
                if (value)
                {
                    flags |= Flags.Visible;
                }
                else
                {
                    flags &= ~Flags.Visible;
                }
            }
        }

        public bool BlockJoin
        {
            get { return (flags & Flags.BlockJoin) == Flags.BlockJoin; }

            set
            {
                if (value)
                {
                    flags |= Flags.BlockJoin;
                }
                else
                {
                    flags &= ~Flags.BlockJoin;
                }
            }
        }

        public bool Voip
        {
            get { return (flags & Flags.Voip) == Flags.Voip; }

            set
            {
                if (value)
                {
                    flags |= Flags.Voip;
                }
                else
                {
                    flags &= ~Flags.Voip;
                }
            }
        }

        public bool BlockAudio
        {
            get { return (flags & Flags.BlockAudio) == Flags.BlockAudio; }

            set
            {
                if (value)
                {
                    flags |= Flags.BlockAudio;
                }
                else
                {
                    flags &= ~Flags.BlockAudio;
                }
            }
        }
    }
}