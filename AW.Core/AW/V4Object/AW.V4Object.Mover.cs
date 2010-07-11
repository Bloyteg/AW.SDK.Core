using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace AW
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [Serializable]
    public sealed class MoverFlags
    {
        private uint flags;

        private static readonly uint[] flagValues = {    0x00000001,    //Loop                      0
                                                         0x00000002,    //UseObjectTag              1
                                                         0x00000004,    //BumpAdd                   2
                                                         0x00000008,    //ClickToStart              3
                                                         0x00000010,    //ClickToPause              4
                                                         0x00000020,    //LockPosition              5
                                                         0x00000040,    //LockYaw                   6
                                                         0x00000080,    //LockPitch                 7
                                                         0x00000100,    //SingleRider               8
                                                         0x00000200,    //NoAutoYaw                 9
                                                         0x00000400,    //EmptyReset                10
                                                         0x00000800,    //DisableFlying             11
                                                         0x00001000,    //KeepOnWater               12
                                                         0x00002000,    //DisableUpwardMovement     13
                                                         0x00004000,    //InvisibleAvatar           14
                                                         0x00008000,    //ExitEjectUpwards          15
                                                         0x00010000,    //ExitNonSolid              16
                                                         0x00020000,    //AvatarApplyTiltX          17
                                                         0x00040000,    //AvatarApplyTiltZ          18
                                                         0x00080000,    //ObjectLink                19
                                                         0x00100000,    //DisableMove               20
                                                         0x00200000,    //TiltByTerrain             21
                                                         0x00400000,    //DisableExplicitSequences  22
                                                         0x00800000,    //TurnInPlace               23
                                                         0x01000000,    //DisableTeleports          24
                                                         0x02000000     //DetachOnTeleport          25
                                                    };

        public bool Loop
        {
            get
            {
                return (flags & flagValues[0]) == flagValues[0];
            }

            set
            {
                flags = (value == true ? (uint)(flags | flagValues[0]) : (uint)(flags & ~flagValues[0]));
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
                flags = (value == true ? (uint)(flags | flagValues[1]) : (uint)(flags & ~flagValues[1]));
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
                flags = (value == true ? (uint)(flags | flagValues[2]) : (uint)(flags & ~flagValues[2]));
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
                flags = (value == true ? (uint)(flags | flagValues[3]) : (uint)(flags & ~flagValues[3]));
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
                flags = (value == true ? (uint)(flags | flagValues[4]) : (uint)(flags & ~flagValues[4]));
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
                flags = (value == true ? (uint)(flags | flagValues[5]) : (uint)(flags & ~flagValues[5]));
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
                flags = (value == true ? (uint)(flags | flagValues[6]) : (uint)(flags & ~flagValues[6]));
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
                flags = (value == true ? (uint)(flags | flagValues[7]) : (uint)(flags & ~flagValues[7]));
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
                flags = (value == true ? (uint)(flags | flagValues[8]) : (uint)(flags & ~flagValues[8]));
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
                flags = (value == true ? (uint)(flags | flagValues[9]) : (uint)(flags & ~flagValues[9]));
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
                flags = (value == true ? (uint)(flags | flagValues[10]) : (uint)(flags & ~flagValues[10]));
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
                flags = (value == true ? (uint)(flags | flagValues[11]) : (uint)(flags & ~flagValues[11]));
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
                flags = (value == true ? (uint)(flags | flagValues[12]) : (uint)(flags & ~flagValues[12]));
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
                flags = (value == true ? (uint)(flags | flagValues[13]) : (uint)(flags & ~flagValues[13]));
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
                flags = (value == true ? (uint)(flags | flagValues[14]) : (uint)(flags & ~flagValues[14]));
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
                flags = (value == true ? (uint)(flags | flagValues[15]) : (uint)(flags & ~flagValues[15]));
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
                flags = (value == true ? (uint)(flags | flagValues[16]) : (uint)(flags & ~flagValues[16]));
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
                flags = (value == true ? (uint)(flags | flagValues[17]) : (uint)(flags & ~flagValues[17]));
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
                flags = (value == true ? (uint)(flags | flagValues[18]) : (uint)(flags & ~flagValues[18]));
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
                flags = (value == true ? (uint)(flags | flagValues[19]) : (uint)(flags & ~flagValues[19]));
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
                flags = (value == true ? (uint)(flags | flagValues[20]) : (uint)(flags & ~flagValues[20]));
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
                flags = (value == true ? (uint)(flags | flagValues[21]) : (uint)(flags & ~flagValues[21]));
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
                flags = (value == true ? (uint)(flags | flagValues[22]) : (uint)(flags & ~flagValues[22]));
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
                flags = (value == true ? (uint)(flags | flagValues[23]) : (uint)(flags & ~flagValues[23]));
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
                flags = (value == true ? (uint)(flags | flagValues[24]) : (uint)(flags & ~flagValues[24]));
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
                flags = (value == true ? (uint)(flags | flagValues[25]) : (uint)(flags & ~flagValues[25]));
            }
        }
    }

    public sealed class Mover : V4Object
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private class MoverData
        {
            public byte version = 1;
            public byte type = 0;
            public MoverFlags flags = new MoverFlags();
            public short locked_pos_x = 0;
            public short locked_pos_y = 0;
            public short locked_pos_z = 0;
            public short locked_yaw = 0;
            public short locked_pitch = 0;
            public sbyte glide_factor = 0;     // -100 to +100
            public byte speed_factor = 1;      // 0.0 to 25.5 max (* 10)
            public byte friction_factor = 1;   // 0.0 to 25.5 max (* 10)
            public sbyte accel_tilt_x = 0;     // -127 to +127
            public sbyte accel_tilt_z = 0;     // -127 to +127
            public byte turn_factor = 1;       // 0.0 to 25.5 max (* 10)
            public byte avatar_tag = 0;        // 0 to 255
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public sbyte[] reserved1;      // Bytes reserverd for future use /9 bytes
            public byte name_len = 0;          // length of 1st string in str_data
            public byte seq_len = 0;           // length of 2nd string in str_data
            public byte script_len = 0;        // length of 3rd string in str_data
            public byte sound_len = 0;         // length of 4rd string in str_data
            public ushort waypoints_len = 0;   // length of 5th string in str_data
            public byte bump_name_len = 0;     // length of 6th string in str_data
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public sbyte[] reserved2;      // Bytes reserverd for future use /2 bytes
        }

        private MoverData moverData = new MoverData();
        private byte[] remainder;

        private List<Waypoint> waypoints = new List<Waypoint>();
        private string name = string.Empty;
        private string sequence = string.Empty;
        private string script = string.Empty;
        private string sound = string.Empty;
        private string bumpName = string.Empty;

        public MoverFlags Flags
        {
            get { return moverData.flags; }
            set { moverData.flags = value; }
        }

        public MoverType Type
        {
            get { return (MoverType)moverData.type; }
            set { moverData.type = (byte)value; }
        }

        public short LockedPositionX
        {
            get { return moverData.locked_pos_x; }
            set { moverData.locked_pos_x = value; }
        }

        public short LockedPositionY
        {
            get { return moverData.locked_pos_y; }
            set { moverData.locked_pos_y = value; }
        }

        public short LockedPositionZ
        {
            get { return moverData.locked_pos_z; }
            set { moverData.locked_pos_z = value; }
        }

        public short LockedYaw
        {
            get { return moverData.locked_yaw; }
            set { moverData.locked_yaw = value; }
        }

        public short LockedPitch
        {
            get { return moverData.locked_pitch; }
            set { moverData.locked_pitch = value; }
        }

        public sbyte GlideFactor
        {
            get { return moverData.glide_factor; }
            set { moverData.glide_factor = value; }
        }

        public byte SpeedFactor
        {
            get { return moverData.speed_factor; }
            set { moverData.speed_factor = value; }
        }

        public byte FrictionFactor
        {
            get { return moverData.friction_factor; }
            set { moverData.friction_factor = value; }
        }

        public sbyte AccelerationTiltX
        {
            get { return moverData.accel_tilt_x; }
            set { moverData.accel_tilt_x = value; }
        }

        public sbyte AccelerationTiltZ
        {
            get { return moverData.accel_tilt_z; }
            set { moverData.accel_tilt_z = value; }
        }

        public byte TurnFactor
        {
            get { return moverData.turn_factor; }
            set { moverData.turn_factor = value; }
        }

        public byte AvatarTag
        {
            get { return moverData.avatar_tag; }
            set { moverData.avatar_tag = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Sequence
        {
            get { return sequence; }
            set { sequence = value; }
        }

        public string Script
        {
            get { return script; }
            set { script = value; }
        }

        public string Sound
        {
            get { return sound; }
            set { sound = value; }
        }

        public List<Waypoint> Waypoints
        {
            get { return waypoints; }
        }

        public string BumpName
        {
            get { return bumpName; }
            set { bumpName = value; }
        }

        internal override byte[] GetData()
        {
            int waypointSize = Marshal.SizeOf(typeof(Waypoint)) + 1;

            moverData.name_len = (byte)System.Text.UTF8Encoding.UTF8.GetByteCount(name);
            moverData.seq_len = (byte)System.Text.UTF8Encoding.UTF8.GetByteCount(sequence);
            moverData.script_len = (byte)System.Text.UTF8Encoding.UTF8.GetByteCount(script);
            moverData.sound_len = (byte)System.Text.UTF8Encoding.UTF8.GetByteCount(sound);
            moverData.waypoints_len = (ushort)(waypoints.Count * waypointSize);
            moverData.bump_name_len = (byte)System.Text.UTF8Encoding.UTF8.GetByteCount(bumpName);

            byte[] outData = Utilities.Miscellaneous.ConcatArrays(Utilities.Miscellaneous.StructToBytes(moverData),
                                                       System.Text.UTF8Encoding.UTF8.GetBytes(name),
                                                       System.Text.UTF8Encoding.UTF8.GetBytes(sequence),
                                                       System.Text.UTF8Encoding.UTF8.GetBytes(script),
                                                       System.Text.UTF8Encoding.UTF8.GetBytes(sound)
                                                      );

            foreach (Waypoint wp in waypoints)
            {
                outData = Utilities.Miscellaneous.ConcatArrays(outData,
                                                    Utilities.Miscellaneous.StructToBytes(wp),
                                                    new byte[] { 0 }
                                                   );
            }

            return Utilities.Miscellaneous.ConcatArrays(outData,
                                             System.Text.UTF8Encoding.UTF8.GetBytes(bumpName),
                                             new byte[] { 0 }
                                            );

        }

        internal override void SetData(byte[] data)
        {
            int waypointSize = Marshal.SizeOf(typeof(Waypoint)) + 1;

            moverData = Utilities.Miscellaneous.BytesToStruct<MoverData>(data, 0);
            int size = data.Length - Marshal.SizeOf(typeof(MoverData));
            remainder = new byte[size];
            Array.ConstrainedCopy(data, data.Length - size, remainder, 0, size);

            name = System.Text.UTF8Encoding.UTF8.GetString(remainder, 0, moverData.name_len);
            sequence = System.Text.UTF8Encoding.UTF8.GetString(remainder, moverData.name_len, moverData.seq_len);
            script = System.Text.UTF8Encoding.UTF8.GetString(remainder, moverData.name_len + moverData.seq_len, moverData.script_len);
            sound = System.Text.UTF8Encoding.UTF8.GetString(remainder, moverData.name_len + moverData.seq_len + moverData.script_len, moverData.sound_len);
            //waypoints before bumpName.
            bumpName = System.Text.UTF8Encoding.UTF8.GetString(remainder, moverData.name_len + moverData.seq_len + moverData.script_len + moverData.sound_len + moverData.waypoints_len, moverData.bump_name_len);

            // waypoints
            int waypointPosition = moverData.name_len + moverData.seq_len + moverData.script_len + moverData.sound_len;
            int totalWaypoints = moverData.waypoints_len / waypointSize;

            for (int i = 0; i < totalWaypoints; ++i)
            {
                waypoints.Add(Utilities.Miscellaneous.BytesToStruct<Waypoint>(remainder, waypointPosition));
                waypointPosition += waypointSize;
            }
        }
    }
}