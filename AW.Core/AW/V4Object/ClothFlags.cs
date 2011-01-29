// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
using System;
using System.Runtime.InteropServices;

namespace AW
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [Serializable]
    class ClothFlags
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
            HardStretchLimit = 0x2000
        }

        private Flags flags;
    }
}
