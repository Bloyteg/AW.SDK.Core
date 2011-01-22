using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace AW
{
    public sealed class Mover : V4Object<Mover>
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private class MoverData
        {
            public byte version = 1;
            public byte type;
            public MoverFlags flags = new MoverFlags();
            public short locked_pos_x;
            public short locked_pos_y;
            public short locked_pos_z;
            public short locked_yaw;
            public short locked_pitch;
            public byte glide_factor;     // -100 to +100
            public byte speed_factor = 1;      // 0.0 to 25.5 max (* 10)
            public byte friction_factor = 1;   // 0.0 to 25.5 max (* 10)
            public byte accel_tilt_x;     // -127 to +127
            public byte accel_tilt_z;     // -127 to +127
            public byte turn_factor = 1;       // 0.0 to 25.5 max (* 10)
            public byte avatar_tag;        // 0 to 255
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public sbyte[] reserved1;      // Bytes reserverd for future use /9 bytes
            public byte name_len;          // length of 1st string in str_data
            public byte seq_len;           // length of 2nd string in str_data
            public byte script_len;        // length of 3rd string in str_data
            public byte sound_len;         // length of 4rd string in str_data
            public short waypoints_len;   // length of 5th string in str_data
            public byte bump_name_len;     // length of 6th string in str_data
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public sbyte[] reserved2;      // Bytes reserverd for future use /2 bytes
        }

        private MoverData _moverData = new MoverData();
        private byte[] _remainder;

        private readonly List<Waypoint> _waypoints = new List<Waypoint>();
        private string _name = string.Empty;
        private string _sequence = string.Empty;
        private string _script = string.Empty;
        private string _sound = string.Empty;
        private string _bumpName = string.Empty;

        public MoverFlags Flags
        {
            get { return _moverData.flags; }
            set { _moverData.flags = value; }
        }

        public MoverType Type
        {
            get { return (MoverType)_moverData.type; }
            set { _moverData.type = (byte)value; }
        }

        public short LockedPositionX
        {
            get { return _moverData.locked_pos_x; }
            set { _moverData.locked_pos_x = value; }
        }

        public short LockedPositionY
        {
            get { return _moverData.locked_pos_y; }
            set { _moverData.locked_pos_y = value; }
        }

        public short LockedPositionZ
        {
            get { return _moverData.locked_pos_z; }
            set { _moverData.locked_pos_z = value; }
        }

        public short LockedYaw
        {
            get { return _moverData.locked_yaw; }
            set { _moverData.locked_yaw = value; }
        }

        public short LockedPitch
        {
            get { return _moverData.locked_pitch; }
            set { _moverData.locked_pitch = value; }
        }

        public byte GlideFactor
        {
            get { return _moverData.glide_factor; }
            set { _moverData.glide_factor = value; }
        }

        public byte SpeedFactor
        {
            get { return _moverData.speed_factor; }
            set { _moverData.speed_factor = value; }
        }

        public byte FrictionFactor
        {
            get { return _moverData.friction_factor; }
            set { _moverData.friction_factor = value; }
        }

        public byte AccelerationTiltX
        {
            get { return _moverData.accel_tilt_x; }
            set { _moverData.accel_tilt_x = value; }
        }

        public byte AccelerationTiltZ
        {
            get { return _moverData.accel_tilt_z; }
            set { _moverData.accel_tilt_z = value; }
        }

        public byte TurnFactor
        {
            get { return _moverData.turn_factor; }
            set { _moverData.turn_factor = value; }
        }

        public byte AvatarTag
        {
            get { return _moverData.avatar_tag; }
            set { _moverData.avatar_tag = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Sequence
        {
            get { return _sequence; }
            set { _sequence = value; }
        }

        public string Script
        {
            get { return _script; }
            set { _script = value; }
        }

        public string Sound
        {
            get { return _sound; }
            set { _sound = value; }
        }

        public IList<Waypoint> Waypoints
        {
            get { return _waypoints; }
        }

        public string BumpName
        {
            get { return _bumpName; }
            set { _bumpName = value; }
        }

        internal override byte[] GetData()
        {
            int waypointSize = Marshal.SizeOf(typeof(Waypoint)) + 1;

            _moverData.name_len = (byte)Encoding.UTF8.GetByteCount(_name);
            _moverData.seq_len = (byte)Encoding.UTF8.GetByteCount(_sequence);
            _moverData.script_len = (byte)Encoding.UTF8.GetByteCount(_script);
            _moverData.sound_len = (byte)Encoding.UTF8.GetByteCount(_sound);
            _moverData.waypoints_len = (short)(_waypoints.Count * waypointSize);
            _moverData.bump_name_len = (byte)Encoding.UTF8.GetByteCount(_bumpName);

            byte[] outData = Utilities.Miscellaneous.ConcatArrays(Utilities.Miscellaneous.StructToBytes(_moverData),
                                                       Encoding.UTF8.GetBytes(_name),
                                                       Encoding.UTF8.GetBytes(_sequence),
                                                       Encoding.UTF8.GetBytes(_script),
                                                       Encoding.UTF8.GetBytes(_sound)
                                                      );

            foreach (Waypoint wp in _waypoints)
            {
                outData = Utilities.Miscellaneous.ConcatArrays(outData,
                                                    Utilities.Miscellaneous.StructToBytes(wp),
                                                    new byte[] { 0 }
                                                   );
            }

            return Utilities.Miscellaneous.ConcatArrays(outData,
                                             Encoding.UTF8.GetBytes(_bumpName),
                                             new byte[] { 0 }
                                            );

        }

        internal override void SetData(byte[] data)
        {
            int waypointSize = Marshal.SizeOf(typeof(Waypoint)) + 1;

            _moverData = Utilities.Miscellaneous.BytesToStruct<MoverData>(data, 0);
            int size = data.Length - Marshal.SizeOf(typeof(MoverData));
            _remainder = new byte[size];
            Array.ConstrainedCopy(data, data.Length - size, _remainder, 0, size);

            _name = Encoding.UTF8.GetString(_remainder, 0, _moverData.name_len);
            _sequence = Encoding.UTF8.GetString(_remainder, _moverData.name_len, _moverData.seq_len);
            _script = Encoding.UTF8.GetString(_remainder, _moverData.name_len + _moverData.seq_len, _moverData.script_len);
            _sound = Encoding.UTF8.GetString(_remainder, _moverData.name_len + _moverData.seq_len + _moverData.script_len, _moverData.sound_len);
            //waypoints before bumpName.
            _bumpName = Encoding.UTF8.GetString(_remainder, _moverData.name_len + _moverData.seq_len + _moverData.script_len + _moverData.sound_len + _moverData.waypoints_len, _moverData.bump_name_len);

            // waypoints
            int waypointPosition = _moverData.name_len + _moverData.seq_len + _moverData.script_len + _moverData.sound_len;
            int totalWaypoints = _moverData.waypoints_len / waypointSize;

            for (int i = 0; i < totalWaypoints; ++i)
            {
                _waypoints.Add(Utilities.Miscellaneous.BytesToStruct<Waypoint>(_remainder, waypointPosition));
                waypointPosition += waypointSize;
            }
        }
    }
}