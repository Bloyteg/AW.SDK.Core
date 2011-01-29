// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
using System;

namespace AW
{
    public enum ClothType : byte
    {
        Fabric,
        Object,
        MetalShape
    }

    public enum ClothAnchor : byte
    {
        None,
        Global,
        Object
    }

    internal enum ClothAnchorPosition : byte
    {
        Center,
        Top,
        Bottom,
        Left,
        Right,
        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight
    }

    public enum ClothShape : byte
    {
        FabricQuad = 0,
        FabricDisc = 1,
        MetalBox = 0,
        MetalSphere = 1,
        MetalCapsule = 2
    }
}