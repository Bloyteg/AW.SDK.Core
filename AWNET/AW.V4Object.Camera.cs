using System;
using System.Runtime.InteropServices;

namespace AW
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [Serializable]
    public class CameraFlags
    {
        private ushort flags;// = 0;
        private static readonly byte[] flagValues = { 0x01 };

        public bool TrackUser
        {
            get { return (flags & flagValues[0]) == flagValues[0]; }
            set { flags = (value == true ? (ushort)(flags | flagValues[0]) : (ushort)(flags & ~flagValues[0])); }
        }
    }

    public sealed class Camera : V4Object
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private class CameraData
        {
            public byte version = 1;
            public CameraFlags flags = new CameraFlags();
            public float zoom = 1.0f;
            public byte name_len = 0;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] reserved = new byte[12];
        }

        private string name = String.Empty;
        private CameraData cameraData = new CameraData();
        private byte[] remainder;

        public CameraFlags Flags
        {
            get { return cameraData.flags; }
            set { cameraData.flags = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public float Zoom
        {
            get { return cameraData.zoom; }
            set { cameraData.zoom = value; }
        }

        protected internal override byte[] GetData()
        {
            cameraData.name_len = (byte)name.Length;
            return Utilities.Miscellaneous.ConcatArrays(Utilities.Miscellaneous.StructToBytes(cameraData),
                                             System.Text.UTF8Encoding.ASCII.GetBytes(name),
                                             new byte[] { 0 }
                                            );
        }

        protected internal override void SetData(byte[] data)
        {
            cameraData = Utilities.Miscellaneous.BytesToStruct<CameraData>(data, 0);
            int size = data.Length - Marshal.SizeOf(typeof(CameraData));
            remainder = new byte[size];

            Array.ConstrainedCopy(data, data.Length - size, remainder, 0, size);
            name = System.Text.UTF8Encoding.ASCII.GetString(remainder, 0, cameraData.name_len);
        }
    }
}