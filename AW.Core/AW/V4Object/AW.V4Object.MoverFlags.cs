using System;
using System.Runtime.InteropServices;

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
}