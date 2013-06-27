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
            public readonly ClothFlags flags = new ClothFlags();            // AW_CLOTH_FLAGS
            public ClothAnchor anchor_type;      // AW_CLOTH_ANCHORS
            public ClothAnchorPosition anchor_pos;       // AW_CLOTH_ANCHOR_POS, for fabric
            public Vector anchor_offset = new Vector();    // offset to anchor, 'local pose'
            public Vector orientation = new Vector();      // normalized rotation angles
            public Vector dimension = new Vector { XMagnitude = 1, YMagnitude = 1, ZMagnitude = 1 };        // dimension for fabric, scaling for models
            public byte resolution = 8;       // fabric only, divisor to size
            // render options
            public float opacity = 1.0f;
            public uint color = 0xFFFFFFFF;            // COLORREF
            public float time_until_static; // time in seconds
            // physics behavior
            public float bending_stiffness = 0.5f;
            public float stretching_stiffness = 1.0f;
            public float compression_limit = 1.0f;
            public float compression_stiffness = 1.0f;
            public float hard_stretch_limit;
            public float damping_coeff = 0.1f;
            public float collision_response = 0.5f;
            public float tear_factor = 2.0f;
            public float attachment_response = 0.5f;
            public float attachment_tear_factor = 2.0f;
            public float min_adhere_velocity;
            // physics properties
            public float density = 1.0f;          // mass = 1/3 * triangleArea * density
            public float thickness = 0.5f;
            public float friction = 0.5f;
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
        [NonSerialized]
        private readonly ClothData _clothData = new ClothData();

        [FieldValueOrdinal(1)]
        private string _name;
        [FieldValueOrdinal(2)]
        private string _anchor;
        [FieldValueOrdinal(3)]
        private string _texture;
        [FieldValueOrdinal(4)]
        private string _model;

        public Cloth()
        {
            Name = string.Empty;
            Anchor = string.Empty;
            Texture = string.Empty;
            Model = string.Empty;
        }

        public ClothType Type
        {
            get { return _clothData.type; }
            set { _clothData.type = value; }
        }

        public ClothShape Shape
        {
            get { return _clothData.shape; }
            set { _clothData.shape = value; }
        }

        public ClothFlags Flags
        {
            get { return _clothData.flags; }
        }

        public ClothAnchor AnchorType
        {
            get { return _clothData.anchor_type; }
            set { _clothData.anchor_type = value; }
        }

        public ClothAnchorPosition AnchorPos
        {
            get { return _clothData.anchor_pos; }
            set { _clothData.anchor_pos = value; }
        }

        public Vector AnchorOffset
        {
            get { return _clothData.anchor_offset; }
            set { _clothData.anchor_offset = value; }
        }

        public Vector Orientation
        {
            get { return _clothData.orientation; }
            set { _clothData.orientation = value; }
        }

        public Vector Dimension
        {
            get { return _clothData.dimension; }
            set { _clothData.dimension = value; }
        }

        public byte Resolution
        {
            get { return _clothData.resolution; }
            set { _clothData.resolution = value; }
        }

        public float Opacity
        {
            get { return _clothData.opacity; }
            set { _clothData.opacity = value; }
        }

        public Color Color
        {
            get { return (int)_clothData.color; }
            set { _clothData.color = (uint)(int)value; }
        }

        public float TimeUntilStatic
        {
            get { return _clothData.time_until_static; }
            set { _clothData.time_until_static = value; }
        }

        public float BendingStiffness
        {
            get { return _clothData.bending_stiffness; }
            set { _clothData.bending_stiffness = value; }
        }

        public float StretchingStiffness
        {
            get { return _clothData.stretching_stiffness; }
            set { _clothData.stretching_stiffness = value; }
        }

        public float CompressionLimit
        {
            get { return _clothData.compression_limit; }
            set { _clothData.compression_limit = value; }
        }

        public float CompressionStiffness
        {
            get { return _clothData.compression_stiffness; }
            set { _clothData.compression_stiffness = value; }
        }

        public float HardStretchLimit
        {
            get { return _clothData.hard_stretch_limit; }
            set { _clothData.hard_stretch_limit = value; }
        }

        public float DampingCoeff
        {
            get { return _clothData.damping_coeff; }
            set { _clothData.damping_coeff = value; }
        }

        public float CollisionResponse
        {
            get { return _clothData.collision_response; }
            set { _clothData.collision_response = value; }
        }

        public float TearFactor
        {
            get { return _clothData.tear_factor; }
            set { _clothData.tear_factor = value; }
        }

        public float AttachmentResponse
        {
            get { return _clothData.attachment_response; }
            set { _clothData.attachment_response = value; }
        }

        public float AttachmentTearFactor
        {
            get { return _clothData.attachment_tear_factor; }
            set { _clothData.attachment_tear_factor = value; }
        }

        public float MinAdhereVelocity
        {
            get { return _clothData.min_adhere_velocity; }
            set { _clothData.min_adhere_velocity = value; }
        }

        public float Density
        {
            get { return _clothData.density; }
            set { _clothData.density = value; }
        }

        public float Thickness
        {
            get { return _clothData.thickness; }
            set { _clothData.thickness = value; }
        }

        public float Friction
        {
            get { return _clothData.friction; }
            set { _clothData.friction = value; }
        }

        public Vector Wind
        {
            get { return _clothData.wind; }
            set { _clothData.wind = value; }
        }

        public float Pressure
        {
            get { return _clothData.pressure; }
            set { _clothData.pressure = value; }
        }

        public Vector ValidBounds
        {
            get { return _clothData.valid_bounds; }
            set { _clothData.valid_bounds = value; }
        }

        public float PenetrationDepth
        {
            get { return _clothData.penetration_depth; }
            set { _clothData.penetration_depth = value; }
        }

        public float MaxDeformationDistance
        {
            get { return _clothData.max_deformation_distance; }
            set { _clothData.max_deformation_distance = value; }
        }

        public float ImpulseThreshold
        {
            get { return _clothData.impulse_threshold; }
            set { _clothData.impulse_threshold = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Anchor
        {
            get { return _anchor; }
            set { _anchor = value; }
        }

        public string Texture
        {
            get { return _texture; }
            set { _texture = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
    }
}
