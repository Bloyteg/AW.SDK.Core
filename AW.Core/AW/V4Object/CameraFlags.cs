using System;
using System.Runtime.InteropServices;

namespace AW
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [Serializable]
    public sealed class CameraFlags
    {
        private ushort flags;
        private static readonly byte[] flagValues = { 0x01 };

        public bool TrackUser
        {
            get
            {
                return (flags & flagValues[0]) == flagValues[0];
            }

            set
            {
                flags = (ushort) (value ? (flags | flagValues[0]) : (flags & ~flagValues[0]));
            }
        }
    }
}