// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
using System;
using System.Runtime.InteropServices;

namespace AW
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [Serializable]
    public sealed class MoverFlags
    {
        [Flags]
        private enum Flags : uint
        {
            Loop = 0x00000001,
            UseObjectTag = 0x00000002,
            BumpAdd = 0x00000004,
            ClickToStart = 0x00000008,
            ClickToPause = 0x00000010,
            LockPosition = 0x00000020,
            LockYaw = 0x00000040,
            LockPitch = 0x00000080,
            SingleRider = 0x00000100,
            NoAutoYaw = 0x00000200,
            EmptyReset = 0x00000400,
            DisableFlying = 0x00000800,
            KeepOnWater = 0x00001000,
            DisableUpwardMovement = 0x00002000,
            InvisibleAvatar = 0x00004000,
            ExitEjectUpwards = 0x00008000,
            ExitNonSolid = 0x00010000,
            AvatarApplyTiltX = 0x00020000,
            AvatarApplyTiltZ = 0x00040000,
            ObjectLink = 0x00080000,
            DisableMove = 0x00100000,
            TiltByTerrain = 0x00200000,
            DisableExplicitSequences = 0x00400000,
            TurnInPlace = 0x00800000,
            DisableTeleports = 0x01000000,
            DetachOnTeleport = 0x02000000
        }

        private Flags flags;

        public bool Loop
        {
            get
            {
                return (flags & Flags.Loop) == Flags.Loop;
            }

            set
            {
                if(value)
                {
                    flags |= Flags.Loop;
                }
                else
                {
                    flags &= ~Flags.Loop;
                }
            }
        }

        public bool UseObjectTag
        {
            get { return (flags & Flags.UseObjectTag) == Flags.UseObjectTag; }

            set
            {
                if (value)
                {
                    flags |= Flags.UseObjectTag;
                }
                else
                {
                    flags &= ~Flags.UseObjectTag;
                }
            }
        }

        public bool BumpAdd
        {
            get { return (flags & Flags.BumpAdd) == Flags.BumpAdd; }

            set
            {
                if (value)
                {
                    flags |= Flags.BumpAdd;
                }
                else
                {
                    flags &= ~Flags.BumpAdd;
                }
            }
        }

        public bool ClickToStart
        {
            get { return (flags & Flags.ClickToStart) == Flags.ClickToStart; }

            set
            {
                if (value)
                {
                    flags |= Flags.ClickToStart;
                }
                else
                {
                    flags &= ~Flags.ClickToStart;
                }
            }
        }

        public bool ClickToPause
        {
            get { return (flags & Flags.ClickToPause) == Flags.ClickToPause; }

            set
            {
                if (value)
                {
                    flags |= Flags.ClickToPause;
                }
                else
                {
                    flags &= ~Flags.ClickToPause;
                }
            }
        }

        public bool LockPosition
        {
            get { return (flags & Flags.LockPosition) == Flags.LockPosition; }

            set
            {
                if (value)
                {
                    flags |= Flags.LockPosition;
                }
                else
                {
                    flags &= ~Flags.LockPosition;
                }
            }
        }

        public bool LockYaw
        {
            get { return (flags & Flags.LockYaw) == Flags.LockYaw; }

            set
            {
                if (value)
                {
                    flags |= Flags.LockYaw;
                }
                else
                {
                    flags &= ~Flags.LockYaw;
                }
            }
        }

        public bool LockPitch
        {
            get { return (flags & Flags.LockPitch) == Flags.LockPitch; }

            set
            {
                if (value)
                {
                    flags |= Flags.LockPitch;
                }
                else
                {
                    flags &= ~Flags.LockPitch;
                }
            }
        }

        public bool SingleRider
        {
            get { return (flags & Flags.SingleRider) == Flags.SingleRider; }

            set
            {
                if (value)
                {
                    flags |= Flags.SingleRider;
                }
                else
                {
                    flags &= ~Flags.SingleRider;
                }
            }
        }

        public bool NoAutoYaw
        {
            get { return (flags & Flags.NoAutoYaw) == Flags.NoAutoYaw; }

            set
            {
                if (value)
                {
                    flags |= Flags.NoAutoYaw;
                }
                else
                {
                    flags &= ~Flags.NoAutoYaw;
                }
            }
        }

        public bool EmptyReset
        {
            get { return (flags & Flags.EmptyReset) == Flags.EmptyReset; }

            set
            {
                if (value)
                {
                    flags |= Flags.EmptyReset;
                }
                else
                {
                    flags &= ~Flags.EmptyReset;
                }
            }
        }

        public bool DisableFlying
        {
            get { return (flags & Flags.DisableFlying) == Flags.DisableFlying; }

            set
            {
                if (value)
                {
                    flags |= Flags.DisableFlying;
                }
                else
                {
                    flags &= ~Flags.DisableFlying;
                }
            }
        }

        public bool KeepOnWater
        {
            get { return (flags & Flags.KeepOnWater) == Flags.KeepOnWater; }

            set
            {
                if (value)
                {
                    flags |= Flags.KeepOnWater;
                }
                else
                {
                    flags &= ~Flags.KeepOnWater;
                }
            }
        }

        public bool DisableUpwardMovement
        {
            get { return (flags & Flags.DisableUpwardMovement) == Flags.DisableUpwardMovement; }

            set
            {
                if (value)
                {
                    flags |= Flags.DisableUpwardMovement;
                }
                else
                {
                    flags &= ~Flags.DisableUpwardMovement;
                }
            }
        }

        public bool InvisibleAvatar
        {
            get { return (flags & Flags.InvisibleAvatar) == Flags.InvisibleAvatar; }

            set
            {
                if (value)
                {
                    flags |= Flags.InvisibleAvatar;
                }
                else
                {
                    flags &= ~Flags.InvisibleAvatar;
                }
            }
        }

        public bool ExitEjectUpwards
        {
            get { return (flags & Flags.ExitEjectUpwards) == Flags.ExitEjectUpwards; }

            set
            {
                if (value)
                {
                    flags |= Flags.ExitEjectUpwards;
                }
                else
                {
                    flags &= ~Flags.ExitEjectUpwards;
                }
            }
        }

        public bool ExitNonSolid
        {
            get { return (flags & Flags.ExitNonSolid) == Flags.ExitNonSolid; }

            set
            {
                if (value)
                {
                    flags |= Flags.ExitNonSolid;
                }
                else
                {
                    flags &= ~Flags.ExitNonSolid;
                }
            }
        }

        public bool AvatarApplyTiltX
        {
            get { return (flags & Flags.AvatarApplyTiltX) == Flags.AvatarApplyTiltX; }

            set
            {
                if (value)
                {
                    flags |= Flags.AvatarApplyTiltX;
                }
                else
                {
                    flags &= ~Flags.AvatarApplyTiltX;
                }
            }
        }

        public bool AvatarApplyTiltZ
        {
            get { return (flags & Flags.AvatarApplyTiltZ) == Flags.AvatarApplyTiltZ; }

            set
            {
                if (value)
                {
                    flags |= Flags.AvatarApplyTiltZ;
                }
                else
                {
                    flags &= ~Flags.AvatarApplyTiltZ;
                }
            }
        }

        public bool ObjectLink
        {
            get { return (flags & Flags.ObjectLink) == Flags.ObjectLink; }

            set
            {
                if (value)
                {
                    flags |= Flags.ObjectLink;
                }
                else
                {
                    flags &= ~Flags.ObjectLink;
                }
            }
        }

        public bool DisableMove
        {
            get { return (flags & Flags.DisableMove) == Flags.DisableMove; }

            set
            {
                if (value)
                {
                    flags |= Flags.DisableMove;
                }
                else
                {
                    flags &= ~Flags.DisableMove;
                }
            }
        }

        public bool TiltByTerrain
        {
            get { return (flags & Flags.TiltByTerrain) == Flags.TiltByTerrain; }

            set
            {
                if (value)
                {
                    flags |= Flags.TiltByTerrain;
                }
                else
                {
                    flags &= ~Flags.TiltByTerrain;
                }
            }
        }

        public bool DisableExplicitSequences
        {
            get { return (flags & Flags.DisableExplicitSequences) == Flags.DisableExplicitSequences; }

            set
            {
                if (value)
                {
                    flags |= Flags.DisableExplicitSequences;
                }
                else
                {
                    flags &= ~Flags.DisableExplicitSequences;
                }
            }
        }

        public bool TurnInPlace
        {
            get { return (flags & Flags.TurnInPlace) == Flags.TurnInPlace; }

            set
            {
                if (value)
                {
                    flags |= Flags.TurnInPlace;
                }
                else
                {
                    flags &= ~Flags.TurnInPlace;
                }
            }
        }

        public bool DisableTeleports
        {
            get { return (flags & Flags.DisableTeleports) == Flags.DisableTeleports; }

            set
            {
                if (value)
                {
                    flags |= Flags.DisableTeleports;
                }
                else
                {
                    flags &= ~Flags.DisableTeleports;
                }
            }
        }

        public bool DetachOnTeleport
        {
            get { return (flags & Flags.DetachOnTeleport) == Flags.DetachOnTeleport; }

            set
            {
                if (value)
                {
                    flags |= Flags.DetachOnTeleport;
                }
                else
                {
                    flags &= ~Flags.DetachOnTeleport;
                }
            }
        }
    }
}