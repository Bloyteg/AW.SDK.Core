using System;
using System.Runtime.InteropServices;

namespace AW
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [Serializable]
    public sealed class ParticleFlags
    {
        private ushort flags;
        private static readonly ushort[] flagValues = { 0x0001, 0x0002, 0x0004, 0x0008, 0x0010, 0x0020, 0x0040 };
        /**
         *  AW_PARTICLE_FLAG_INTERPOLATE    = 0x01, 0
         *  AW_PARTICLE_FLAG_GRAVITY        = 0x02, 1
         *  AW_PARTICLE_FLAG_COLLIDE_ZONES  = 0x04, 2
         *  AW_PARTICLE_FLAG_ZONE_EXCLUSIVE = 0x08, 3
         *  AW_PARTICLE_FLAG_CAMERA_EMIT    = 0x10, 4
         *  AW_PARTICLE_FLAG_MOVER_LINK     = 0x20, 5
         *  AW_PARTICLE_DRAW_IN_FRONT       = 0x40, 6
         */

        public bool Interpolate
        {
            get
            {
                return (flags & flagValues[0]) == flagValues[0];
            }

            set
            {
                flags = (value == true ? (ushort)(flags | flagValues[0]) : (ushort)(flags & ~flagValues[0]));
            }
        }

        public bool Gravity
        {
            get
            {
                return (flags & flagValues[1]) == flagValues[1];
            }

            set
            {
                flags = (value == true ? (ushort)(flags | flagValues[1]) : (ushort)(flags & ~flagValues[1]));
            }
        }

        public bool ZoneCollision
        {
            get
            {
                return (flags & flagValues[2]) == flagValues[2];
            }

            set
            {
                flags = (value == true ? (ushort)(flags | flagValues[2]) : (ushort)(flags & ~flagValues[2]));
            }
        }

        public bool ZoneExclusive
        {
            get
            {
                return (flags & flagValues[3]) == flagValues[3];
            }

            set
            {
                flags = (value == true ? (ushort)(flags | flagValues[3]) : (ushort)(flags & ~flagValues[3]));
            }
        }

        public bool CameraEmit
        {
            get
            {
                return (flags & flagValues[4]) == flagValues[4];
            }

            set
            {
                flags = (value == true ? (ushort)(flags | flagValues[4]) : (ushort)(flags & ~flagValues[4]));
            }
        }

        public bool LinkToMover
        {
            get
            {
                return (flags & flagValues[5]) == flagValues[5];
            }

            set
            {
                flags = (value == true ? (ushort)(flags | flagValues[5]) : (ushort)(flags & ~flagValues[5]));
            }
        }

        public bool DrawInFront
        {
            get
            {
                return (flags & flagValues[6]) == flagValues[6];
            }

            set
            {
                flags = (value == true ? (ushort)(flags | flagValues[6]) : (ushort)(flags & ~flagValues[6]));
            }
        }
    }

    public sealed class Particle : V4Object
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private class ParticleData
        {
            public VectorRange volume = new VectorRange();
            public byte version = 1;
            public VectorRange speed = new VectorRange();
            public VectorRange accel = new VectorRange();
            public VectorRange angle = new VectorRange();
            public VectorRange spin = new VectorRange();
            public VectorRange size = new VectorRange();
            public uint release_min = 0;
            public uint release_max = 0;
            public ushort release_size = 0;
            public uint lifespan = 0;
            public uint emitter_lifespan = 0;
            public uint fade_in = 0;
            public uint fade_out = 0;
            public uint color_start = 0xFFFFFFFF;
            public uint color_end = 0xFFFFFFFF;
            public float opacity = 1.0f;
            public byte render_style = 0;
            public ParticleFlags flags = new ParticleFlags();
            public byte style = 0;
            public ushort asset_list_len = 0;
            public byte name_len = 0;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] reserved;
        }

        private ParticleData particleData = new ParticleData();
        private byte[] remainder;

        private string assetList = string.Empty;
        private string name = string.Empty;

        public ParticleFlags Flags
        {
            get { return particleData.flags; }
            set { particleData.flags = value; }
        }

        public VectorRange Volume
        {
            get { return particleData.volume; }
            set { particleData.volume = value; }
        }

        public VectorRange Speed
        {
            get { return particleData.speed; }
            set { particleData.speed = value; }
        }

        public VectorRange Acceleration
        {
            get { return particleData.accel; }
            set { particleData.accel = value; }
        }

        public VectorRange Angle
        {
            get { return particleData.angle; }
            set { particleData.angle = value; }
        }

        public VectorRange Spin
        {
            get { return particleData.spin; }
            set { particleData.spin = value; }
        }

        public VectorRange Size
        {
            get { return particleData.size; }
            set { particleData.size = value; }
        }

        public uint ReleaseMinimum
        {
            get { return particleData.release_min; }
            set { particleData.release_min = value; }
        }

        public uint ReleaseMaximum
        {
            get { return particleData.release_max; }
            set { particleData.release_max = value; }
        }

        public ushort ReleaseSize
        {
            get { return particleData.release_size; }
            set { particleData.release_size = value; }
        }

        public uint Lifespan
        {
            get { return particleData.lifespan; }
            set { particleData.lifespan = value; }
        }

        public uint EmitterLifespan
        {
            get { return particleData.emitter_lifespan; }
            set { particleData.emitter_lifespan = value; }
        }

        public uint FadeIn
        {
            get { return particleData.fade_in; }
            set { particleData.fade_in = value; }
        }

        public uint FadeOut
        {
            get { return particleData.fade_out; }
            set { particleData.fade_out = value; }
        }

        public Color ColorStart
        {
            get
            {
                return (Color)particleData.color_start;
            }

            set
            {
                particleData.color_start = (uint)value;
            }
        }

        public Color ColorEnd
        {
            get
            {
                return (Color)particleData.color_end;
            }

            set
            {
                particleData.color_end = (uint)value;
            }
        }

        public float Opacity
        {
            get { return particleData.opacity; }
            set { particleData.opacity = value; }
        }

        public ParticleDrawStyle RenderStyle
        {
            get { return (ParticleDrawStyle)particleData.render_style; }
            set { particleData.render_style = (byte)value; }
        }

        public ParticleType Style
        {
            get { return (ParticleType)particleData.style; }
            set { particleData.style = (byte)value; }
        }

        public string AssetList
        {
            get { return assetList; }
            set { assetList = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected internal override byte[] GetData()
        {
            particleData.asset_list_len = (ushort)System.Text.UTF8Encoding.UTF8.GetByteCount(assetList);
            particleData.name_len = (byte)System.Text.UTF8Encoding.UTF8.GetByteCount(name);

            return Utilities.Miscellaneous.ConcatArrays(Utilities.Miscellaneous.StructToBytes(particleData),
                                             System.Text.UTF8Encoding.UTF8.GetBytes(assetList),
                                             System.Text.UTF8Encoding.UTF8.GetBytes(name),
                                             new byte[] { 0 }
                                            );

        }

        protected internal override void SetData(byte[] data)
        {
            particleData = Utilities.Miscellaneous.BytesToStruct<ParticleData>(data, 0);
            int size = data.Length - Marshal.SizeOf(typeof(ParticleData));
            remainder = new byte[size];
            Array.ConstrainedCopy(data, data.Length - size, remainder, 0, size);

            assetList = System.Text.UTF8Encoding.UTF8.GetString(remainder, 0, particleData.asset_list_len);
            name = System.Text.UTF8Encoding.UTF8.GetString(remainder, particleData.asset_list_len, particleData.name_len);
        }
    }
}