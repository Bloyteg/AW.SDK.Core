// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
using System;
using System.Runtime.InteropServices;

namespace AW
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [Serializable]
    public sealed class CameraFlags
    {
        [Flags]
        private enum Flags : ushort
        {
            TrackUser = 0x01
        }

        private Flags flags;

        public bool TrackUser
        {
            get
            {
                return (flags & Flags.TrackUser) == Flags.TrackUser;
            }

            set
            {
                if(value)
                {
                    flags |= Flags.TrackUser;
                }
                else
                {
                    flags &= ~Flags.TrackUser;
                }
            }
        }
    }
}