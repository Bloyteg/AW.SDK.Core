// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
using System;
using System.Runtime.InteropServices;
using Utilities.Serialization;

namespace AW
{
    [Serializable]
    public class Cloth : IV4Object
    {
#pragma warning disable 169
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private class ClothData
        {
            public byte version = 1;          // structure version (set by SDK)
            public ClothType type;             // AW_CLOTH_TYPES
            public ClothShape shape;            // AW_CLOTH_FABRIC_SHAPES + AW_CLOTH_METAL_SHAPES
            public ClothFlags flags;            // AW_CLOTH_FLAGS
            public ClothAnchor anchor_type;      // AW_CLOTH_ANCHORS
            public ClothAnchorPosition anchor_pos;       // AW_CLOTH_ANCHOR_POS, for fabric
            public Vector anchor_offset = new Vector();    // offset to anchor, 'local pose'
            public Vector orientation = new Vector();      // normalized rotation angles
            public Vector dimension = new Vector();        // dimension for fabric, scaling for models
            public byte resolution;       // fabric only, divisor to size
            // render options
            public float opacity;
            public uint color;            // COLORREF
            public float time_till_static; // time in seconds
            // physics behavior
            public float bending_stiffness;
            public float stretching_stiffness;
            public float compression_limit;
            public float compression_stiffness;
            public float hard_stretch_limit;
            public float damping_coeff;
            public float collision_response;
            public float tear_factor;
            public float attachment_response;
            public float attachment_tear_factor;
            public float min_adhere_velocity;
            // physics properties
            public float density;          // mass = 1/3 * triangleArea * density
            public float thickness;
            public float friction;
            public float pressure;         // closed convex hull models only
            public Vector wind = new Vector();             // wind acceleration on vertex normals
            public Vector valid_bounds = new Vector();     // triangles outside these bounds are not simulated
            // AW_CLOTH_TYPE_METAL_SHAPE only:
            public float impulse_threshold;
            public float penetration_depth;
            public float max_deformation_distance;
            // appendices
            [FieldSizeOrdinal(1)]
            public byte name_len;         // length of 1st string in str_data, the object's own name
            [FieldSizeOrdinal(2)]
            public byte anchor_len;       // length of 2nd string in str_data, anchor name
            [FieldSizeOrdinal(3)]
            public byte texture_len;      // length of 3rd string in str_data, texture name
            [FieldSizeOrdinal(4)]
            public byte model_len;        // length of 4th string in str_data, model name
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] reserved;     // Bytes reserverd for future use
        }
#pragma warning restore 169

        [FieldSizeProvider]
        private readonly ClothData _clothData = new ClothData();
    }
}
