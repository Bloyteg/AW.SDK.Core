// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
using System;
using System.Runtime.InteropServices;

namespace AW
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [Serializable]
    public sealed class ClothFlags
    {
        [Flags]
        enum Flags : uint
        {
            Gravity = 0x0001,
            Static = 0x0002,
            Comdamping = 0x0004,
            BendingOrtho = 0x0008,
            SelfCollision = 0x0010,
            CollisionTwoWay = 0x0020,
            AttachmentTwoWay = 0x0040,
            AttachmentTearable = 0x0080,
            Tearable = 0x0100,
            TearableDiagonal = 0x0200, // fabric only
            Pressure = 0x0400, // closed convex hulls only
            Adhere = 0x0800,
            Untangling = 0x1000,
            HardStretchLimit = 0x2000,
            NoTextureMirrorring = 0x4000
        }

        private Flags flags;

        public bool Gravity
        {
            get { return (flags & Flags.Gravity) == Flags.Gravity; }

            set
            {
                if (value)
                {
                    flags |= Flags.Gravity;
                }
                else
                {
                    flags &= ~Flags.Gravity;
                }
            }
        }

        public bool Static
        {
            get { return (flags & Flags.Static) == Flags.Static; }

            set
            {
                if (value)
                {
                    flags |= Flags.Static;
                }
                else
                {
                    flags &= ~Flags.Static;
                }
            }
        }

        public bool Comdamping
        {
            get { return (flags & Flags.Comdamping) == Flags.Comdamping; }

            set
            {
                if (value)
                {
                    flags |= Flags.Comdamping;
                }
                else
                {
                    flags &= ~Flags.Comdamping;
                }
            }
        }

        public bool BendingOrtho
        {
            get { return (flags & Flags.BendingOrtho) == Flags.BendingOrtho; }

            set
            {
                if (value)
                {
                    flags |= Flags.BendingOrtho;
                }
                else
                {
                    flags &= ~Flags.BendingOrtho;
                }
            }
        }

        public bool SelfCollision
        {
            get { return (flags & Flags.SelfCollision) == Flags.SelfCollision; }

            set
            {
                if (value)
                {
                    flags |= Flags.SelfCollision;
                }
                else
                {
                    flags &= ~Flags.SelfCollision;
                }
            }
        }

        public bool CollisionTwoWay
        {
            get { return (flags & Flags.CollisionTwoWay) == Flags.CollisionTwoWay; }

            set
            {
                if (value)
                {
                    flags |= Flags.CollisionTwoWay;
                }
                else
                {
                    flags &= ~Flags.CollisionTwoWay;
                }
            }
        }

        public bool AttachmentTwoWay
        {
            get { return (flags & Flags.AttachmentTwoWay) == Flags.AttachmentTwoWay; }

            set
            {
                if (value)
                {
                    flags |= Flags.AttachmentTwoWay;
                }
                else
                {
                    flags &= ~Flags.AttachmentTwoWay;
                }
            }
        }

        public bool AttachmentTearable
        {
            get { return (flags & Flags.AttachmentTearable) == Flags.AttachmentTearable; }

            set
            {
                if (value)
                {
                    flags |= Flags.AttachmentTearable;
                }
                else
                {
                    flags &= ~Flags.AttachmentTearable;
                }
            }
        }

        public bool Tearable
        {
            get { return (flags & Flags.Tearable) == Flags.Tearable; }

            set
            {
                if (value)
                {
                    flags |= Flags.Tearable;
                }
                else
                {
                    flags &= ~Flags.Tearable;
                }
            }
        }

        public bool TearableDiagonal
        {
            get { return (flags & Flags.TearableDiagonal) == Flags.TearableDiagonal; }

            set
            {
                if (value)
                {
                    flags |= Flags.TearableDiagonal;
                }
                else
                {
                    flags &= ~Flags.TearableDiagonal;
                }
            }
        }

        public bool Pressure
        {
            get { return (flags & Flags.Pressure) == Flags.Pressure; }

            set
            {
                if (value)
                {
                    flags |= Flags.Pressure;
                }
                else
                {
                    flags &= ~Flags.Pressure;
                }
            }
        }

        public bool Adhere
        {
            get { return (flags & Flags.Adhere) == Flags.Adhere; }

            set
            {
                if (value)
                {
                    flags |= Flags.Adhere;
                }
                else
                {
                    flags &= ~Flags.Adhere;
                }
            }
        }

        public bool Untangling
        {
            get { return (flags & Flags.Untangling) == Flags.Untangling; }

            set
            {
                if (value)
                {
                    flags |= Flags.Untangling;
                }
                else
                {
                    flags &= ~Flags.Untangling;
                }
            }
        }

        public bool HardStretchLimit
        {
            get { return (flags & Flags.HardStretchLimit) == Flags.HardStretchLimit; }

            set
            {
                if (value)
                {
                    flags |= Flags.HardStretchLimit;
                }
                else
                {
                    flags &= ~Flags.HardStretchLimit;
                }
            }
        }

        public bool NoTextureMirrorring
        {
            get { return (flags & Flags.NoTextureMirrorring) == Flags.NoTextureMirrorring; }

            set
            {
                if(value)
                {
                    flags = Flags.NoTextureMirrorring;
                }
                else
                {
                    flags &= ~Flags.NoTextureMirrorring;
                }
            }
        }
    }
}
