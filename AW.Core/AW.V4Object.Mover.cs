using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace AW
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [Serializable]
    public sealed class MoverFlags
    {
        private int flags;

        private static readonly int[] flagValues = {
                                                       0x00000001, //Loop                      0
                                                       0x00000002, //UseObjectTag              1
                                                       0x00000004, //BumpAdd                   2
                                                       0x00000008, //ClickToStart              3
                                                       0x00000010, //ClickToPause              4
                                                       0x00000020, //LockPosition              5
                                                       0x00000040, //LockYaw                   6
                                                       0x00000080, //LockPitch                 7
                                                       0x00000100, //SingleRider               8
                                                       0x00000200, //NoAutoYaw                 9
                                                       0x00000400, //EmptyReset                10
                                                       0x00000800, //DisableFlying             11
                                                       0x00001000, //KeepOnWater               12
                                                       0x00002000, //DisableUpwardMovement     13
                                                       0x00004000, //InvisibleAvatar           14
                                                       0x00008000, //ExitEjectUpwards          15
                                                       0x00010000, //ExitNonSolid              16
                                                       0x00020000, //AvatarApplyTiltX          17
                                                       0x00040000, //AvatarApplyTiltZ          18
                                                       0x00080000, //ObjectLink                19
                                                       0x00100000, //DisableMove               20
                                                       0x00200000, //TiltByTerrain             21
                                                       0x00400000, //DisableExplicitSequences  22
                                                       0x00800000, //TurnInPlace               23
                                                       0x01000000, //DisableTeleports          24
                                                       0x02000000 //DetachOnTeleport          25
                                                   };

        public bool Loop
        {
            get
            {
                return (flags & flagValues[0]) == flagValues[0];
            }

            set
            {
                flags = (value ? (flags | flagValues[0]) : (flags & ~flagValues[0]));
            }
        }

        public bool UseObjectTag
        {
            get
            {
                return (flags & flagValues[1]) == flagValues[1];
            }

            set
            {
                flags = (value ? (flags | flagValues[1]) : (flags & ~flagValues[1]));
            }
        }

        public bool BumpAdd
        {
            get
            {
                return (flags & flagValues[2]) == flagValues[2];
            }

            set
            {
                flags = (value ? (flags | flagValues[2]) : (flags & ~flagValues[2]));
            }
        }

        public bool ClickToStart
        {
            get
            {
                return (flags & flagValues[3]) == flagValues[3];
            }

            set
            {
                flags = (value ? (flags | flagValues[3]) : (flags & ~flagValues[3]));
            }
        }

        public bool ClickToPause
        {
            get
            {
                return (flags & flagValues[4]) == flagValues[4];
            }

            set
            {
                flags = (value ? (flags | flagValues[4]) : (flags & ~flagValues[4]));
            }
        }

        public bool LockPosition
        {
            get
            {
                return (flags & flagValues[5]) == flagValues[5];
            }

            set
            {
                flags = (value ? (flags | flagValues[5]) : (flags & ~flagValues[5]));
            }
        }

        public bool LockYaw
        {
            get
            {
                return (flags & flagValues[6]) == flagValues[6];
            }

            set
            {
                flags = (value ? (flags | flagValues[6]) : (flags & ~flagValues[6]));
            }
        }

        public bool LockPitch
        {
            get
            {
                return (flags & flagValues[7]) == flagValues[7];
            }

            set
            {
                flags = (value ? (flags | flagValues[7]) : (flags & ~flagValues[7]));
            }
        }

        public bool SingleRider
        {
            get
            {
                return (flags & flagValues[8]) == flagValues[8];
            }

            set
            {
                flags = (value ? (flags | flagValues[8]) : (flags & ~flagValues[8]));
            }
        }

        public bool NoAutoYaw
        {
            get
            {
                return (flags & flagValues[9]) == flagValues[9];
            }

            set
            {
                flags = (value ? (flags | flagValues[9]) : (flags & ~flagValues[9]));
            }
        }

        public bool EmptyReset
        {
            get
            {
                return (flags & flagValues[10]) == flagValues[10];
            }

            set
            {
                flags = (value ? (flags | flagValues[10]) : (flags & ~flagValues[10]));
            }
        }

        public bool DisableFlying
        {
            get
            {
                return (flags & flagValues[11]) == flagValues[11];
            }

            set
            {
                flags = (value ? (flags | flagValues[11]) : (flags & ~flagValues[11]));
            }
        }

        public bool KeepOnWater
        {
            get
            {
                return (flags & flagValues[12]) == flagValues[12];
            }

            set
            {
                flags = (value ? (flags | flagValues[12]) : (flags & ~flagValues[12]));
            }
        }

        public bool DisableUpwardMovement
        {
            get
            {
                return (flags & flagValues[13]) == flagValues[13];
            }

            set
            {
                flags = (value ? (flags | flagValues[13]) : (flags & ~flagValues[13]));
            }
        }

        public bool InvisibleAvatar
        {
            get
            {
                return (flags & flagValues[14]) == flagValues[14];
            }

            set
            {
                flags = (value ? (flags | flagValues[14]) : (flags & ~flagValues[14]));
            }
        }

        public bool ExitEjectUpwards
        {
            get
            {
                return (flags & flagValues[15]) == flagValues[15];
            }

            set
            {
                flags = (value ? (flags | flagValues[15]) : (flags & ~flagValues[15]));
            }
        }

        public bool ExitNonSolid
        {
            get
            {
                return (flags & flagValues[16]) == flagValues[16];
            }

            set
            {
                flags = (value ? (flags | flagValues[16]) : (flags & ~flagValues[16]));
            }
        }

        public bool AvatarApplyTiltX
        {
            get
            {
                return (flags & flagValues[17]) == flagValues[17];
            }

            set
            {
                flags = (value ? (flags | flagValues[17]) : (flags & ~flagValues[17]));
            }
        }

        public bool AvatarApplyTiltZ
        {
            get
            {
                return (flags & flagValues[18]) == flagValues[18];
            }

            set
            {
                flags = (value ? (flags | flagValues[18]) : (flags & ~flagValues[18]));
            }
        }

        public bool ObjectLink
        {
            get
            {
                return (flags & flagValues[19]) == flagValues[19];
            }

            set
            {
                flags = (value ? (flags | flagValues[19]) : (flags & ~flagValues[19]));
            }
        }

        public bool DisableMove
        {
            get
            {
                return (flags & flagValues[20]) == flagValues[20];
            }

            set
            {
                flags = (value ? (flags | flagValues[20]) : (flags & ~flagValues[20]));
            }
        }

        public bool TiltByTerrain
        {
            get
            {
                return (flags & flagValues[21]) == flagValues[21];
            }

            set
            {
                flags = (value ? (flags | flagValues[21]) : (flags & ~flagValues[21]));
            }
        }

        public bool DisableExplicitSequences
        {
            get
            {
                return (flags & flagValues[22]) == flagValues[22];
            }

            set
            {
                flags = (value ? (flags | flagValues[22]) : (flags & ~flagValues[22]));
            }
        }

        public bool TurnInPlace
        {
            get
            {
                return (flags & flagValues[23]) == flagValues[23];
            }

            set
            {
                flags = (value ? (flags | flagValues[23]) : (flags & ~flagValues[23]));
            }
        }

        public bool DisableTeleports
        {
            get
            {
                return (flags & flagValues[24]) == flagValues[24];
            }

            set
            {
                flags = (value ? (flags | flagValues[24]) : (flags & ~flagValues[24]));
            }
        }

        public bool DetachOnTeleport
        {
            get
            {
                return (flags & flagValues[25]) == flagValues[25];
            }

            set
            {
                flags = (value ? (flags | flagValues[25]) : (flags & ~flagValues[25]));
            }
        }
    }

    public sealed class Mover : V4Object
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

        public List<Waypoint> Waypoints
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