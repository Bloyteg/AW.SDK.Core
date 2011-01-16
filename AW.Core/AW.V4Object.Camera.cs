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

    public sealed class Camera : V4Object
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private class CameraData
        {
            public byte version = 1;
            public CameraFlags flags = new CameraFlags();
            public float zoom = 1.0f;
            public byte name_len;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] reserved = new byte[12];
        }

        private string _name = String.Empty;
        private CameraData _cameraData = new CameraData();
        private byte[] _remainder;

        public CameraFlags Flags
        {
            get { return _cameraData.flags; }
            set { _cameraData.flags = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public float Zoom
        {
            get { return _cameraData.zoom; }
            set { _cameraData.zoom = value; }
        }

        internal override byte[] GetData()
        {
            _cameraData.name_len = (byte)System.Text.Encoding.UTF8.GetByteCount(_name);
            return Utilities.Miscellaneous.ConcatArrays(Utilities.Miscellaneous.StructToBytes(_cameraData),
                                             System.Text.Encoding.UTF8.GetBytes(_name),
                                             new byte[] { 0 }
                                            );
        }

        internal override void SetData(byte[] data)
        {
            _cameraData = Utilities.Miscellaneous.BytesToStruct<CameraData>(data, 0);
            int size = data.Length - Marshal.SizeOf(typeof(CameraData));
            _remainder = new byte[size];

            Array.ConstrainedCopy(data, data.Length - size, _remainder, 0, size);
            _name = System.Text.Encoding.UTF8.GetString(_remainder, 0, _cameraData.name_len);
        }
    }
}