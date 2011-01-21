using System;
using System.Runtime.InteropServices;
using System.Text;

namespace AW
{
    public sealed class Zone : V4Object<Zone>
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private class ZoneData
        {
            public Vector size = new Vector();
            public byte version = 1;
            public byte shape;
            public byte priority;
            public float gravity = 1.0f;
            public float friction = 1.0f;
            public ZoneFlags flags = new ZoneFlags();
            public uint color = 0xFFFFFFFF;
            public short fog_min;
            public short fog_max = 100;
            public short footstep_len ;
            public short ambient_len;
            public byte camera_len;
            public byte target_cur_len;
            public byte voip_rights_len;
            public byte name_len;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public byte[] reserved;
        }

        private ZoneData _zoneData = new ZoneData();
        private byte[] _remainder;
        private string _footstep = string.Empty;
        private string _ambient = string.Empty;
        private string _camera = string.Empty;
        private string _targetCursor = string.Empty;
        private string _voipRights = string.Empty;
        private string _name = string.Empty;

        public ZoneFlags Flags
        {
            get { return _zoneData.flags; }
            set { _zoneData.flags = value; }
        }

        public Vector Size
        {
            get { return _zoneData.size; }
            set { _zoneData.size = value; }
        }

        public ZoneType Shape
        {
            get { return (ZoneType)_zoneData.shape; }
            set { _zoneData.shape = (byte)value; }
        }

        public byte Priority
        {
            get { return _zoneData.priority; }
            set { _zoneData.priority = value; }
        }

        public float Gravity
        {
            get { return _zoneData.gravity; }
            set { _zoneData.gravity = value; }
        }

        public float Friction
        {
            get { return _zoneData.friction; }
            set { _zoneData.friction = value; }
        }

        public Color Color
        {
            get
            {
                return (int)_zoneData.color;
            }

            set
            {
                _zoneData.color = (uint)(int)value;
            }
        }

        public short FogMinimum
        {
            get { return _zoneData.fog_min; }
            set { _zoneData.fog_min = value; }
        }
        public short FogMaximum
        {
            get { return _zoneData.fog_max; }
            set { _zoneData.fog_max = value; }
        }

        public string Footstep
        {
            get { return _footstep; }
            set { _footstep = value; }
        }

        public string Ambient
        {
            get { return _ambient; }
            set { _ambient = value; }
        }

        public string Camera
        {
            get { return _camera; }
            set { _camera = value; }
        }

        public string TargetCursor
        {
            get { return _targetCursor; }
            set { _targetCursor = value; }
        }

        public string VoipRights
        {
            get { return _voipRights; }
            set { _voipRights = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        internal override byte[] GetData()
        {
            _zoneData.footstep_len = (short)Encoding.UTF8.GetByteCount(_footstep);
            _zoneData.ambient_len = (short)Encoding.UTF8.GetByteCount(_ambient);
            _zoneData.camera_len = (byte)Encoding.UTF8.GetByteCount(_camera);
            _zoneData.target_cur_len = (byte)Encoding.UTF8.GetByteCount(_targetCursor);
            _zoneData.voip_rights_len = (byte)Encoding.UTF8.GetByteCount(_voipRights);
            _zoneData.name_len = (byte)Encoding.UTF8.GetByteCount(_name);

            return Utilities.Miscellaneous.ConcatArrays(Utilities.Miscellaneous.StructToBytes(_zoneData),
                                                        Encoding.UTF8.GetBytes(_footstep),
                                                        Encoding.UTF8.GetBytes(_ambient),
                                                        Encoding.UTF8.GetBytes(_camera),
                                                        Encoding.UTF8.GetBytes(_targetCursor),
                                                        Encoding.UTF8.GetBytes(_voipRights),
                                                        Encoding.UTF8.GetBytes(_name),
                                                        new byte[] {0});

        }

        internal override void SetData(byte[] data)
        {
            _zoneData = Utilities.Miscellaneous.BytesToStruct<ZoneData>(data, 0);
            int size = data.Length - Marshal.SizeOf(typeof(ZoneData));
            _remainder = new byte[size];
            Array.ConstrainedCopy(data, data.Length - size, _remainder, 0, size);

            _footstep = Encoding.UTF8.GetString(_remainder, 0, _zoneData.footstep_len);
            _ambient = Encoding.UTF8.GetString(_remainder, _zoneData.footstep_len, _zoneData.ambient_len);
            _camera = Encoding.UTF8.GetString(_remainder, _zoneData.footstep_len + _zoneData.ambient_len, _zoneData.camera_len);
            _targetCursor = Encoding.UTF8.GetString(_remainder, _zoneData.footstep_len + _zoneData.ambient_len + _zoneData.camera_len, _zoneData.target_cur_len);
            _voipRights = Encoding.UTF8.GetString(_remainder, _zoneData.voip_rights_len + _zoneData.footstep_len + _zoneData.ambient_len + _zoneData.camera_len, _zoneData.voip_rights_len);
            _name = Encoding.UTF8.GetString(_remainder, _zoneData.voip_rights_len + _zoneData.footstep_len + _zoneData.ambient_len + _zoneData.camera_len + _zoneData.voip_rights_len, _zoneData.name_len);
        }
    }
}