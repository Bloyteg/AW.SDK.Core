// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
using System;
using System.Runtime.InteropServices;
using Utilities.Serialization;

namespace AW
{
    [Serializable]
    public sealed class Camera : IV4Object
    {
#pragma warning disable 169
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private class CameraData
        {
            public byte version = 1;
            public CameraFlags flags = new CameraFlags();
            public float zoom = 1.0f;
            [FieldValueOrdinal(1)]
            public byte name_len;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] reserved = new byte[12];
        }
#pragma warning restore 169

        [FieldValueOrdinal(1)]
        private string _name = String.Empty;

        [FieldSizeProvider]
        private readonly CameraData _cameraData = new CameraData();

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
    }
}