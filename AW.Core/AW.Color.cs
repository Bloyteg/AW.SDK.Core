using System;
using System.Runtime.InteropServices;

namespace AW
{
    /// <summary>
    /// Represents an RGB color value used by the SDK for V4 objects and world attribute related colors.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential, Pack=0)]
    public sealed class Color
    {
        private byte a;
        private byte b;
        private byte g;
        private byte r;

        /// <summary>
        /// The blue component of the color.  Value range is 0 to 255.
        /// </summary>
        public byte B
        {
            get { return b; }
            set { b = value; }
        }

        /// <summary>
        /// The green component of the color.  Value range is 0 to 255.
        /// </summary>
        public byte G
        {
            get { return g; }
            set { g = value; }
        }

        /// <summary>
        /// The red component of the color.  Value range is 0 to 255.
        /// </summary>
        public byte R
        {
            get { return r; }
            set { r = value; }
        }

        /// <summary>
        /// Constructs the default color.  This color will be black.
        /// </summary>
        public Color()
        {
            this.a = 255;
        }

        /// <summary>
        /// Constructs a color using the specified values.
        /// </summary>
        /// <param name="r">Red component.  Value range is 0 to 255.</param>
        /// <param name="g">Green component.  Value range is 0 to 255.</param>
        /// <param name="b">Blue component.  Value range is 0 to 255.</param>
        public Color(byte r, byte g, byte b)
        {
            this.a = 255;
            this.r = r;
            this.g = g;
            this.b = b;
        }

        /// <summary>
        /// Converts a <see cref="System.Drawing.Color" /> to <see cref="AW.Color" />.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static explicit operator Color(System.Drawing.Color color)
        {
            return new Color() { R = color.R, G = color.G, B = color.B };
        }

        /// <summary>
        /// Converts a <see cref="AW.Color" /> to <see cref="System.Drawing.Color" />.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static explicit operator System.Drawing.Color(Color color)
        {
            return System.Drawing.Color.FromArgb(255, color.R, color.G, color.B);
        }

        /// <summary>
        /// Converts a <see cref="System.UInt32" /> to <see cref="AW.Color" />.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static implicit operator Color(int color)
        {
            return new Color()
            {
                R = (byte)(color  & 0x0000FF),
                G = (byte)((color >> 8) & 0x0000FF),
                B = (byte)((color >> 16) & 0x0000FF)
            };
        }

        /// <summary>
        /// Converts a <see cref="AW.Color" /> to <see cref="System.Int32" />.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static implicit operator int(Color color)
        {
            return (int)(color.R | (color.G << 8) | (color.B << 16));
        }

        /// <summary>
        /// Converts the <see cref="AW.Color" /> into a hexadecimal string.
        /// </summary>
        /// <returns>The string representation of the color.</returns>
        public override string ToString()
        {
            return String.Format("{0:X2}{1:X2}{2:X2}", r, g, b);
        }

        /// <summary>
        /// Converts the hexadecimal string into a <see cref="AW.Color" />.
        /// </summary>
        /// <param name="color">A hexadecimal string representation of the color.</param>
        public static Color FromString(string color)
        {
            Utilities.HexConverter hexConvert = new Utilities.HexConverter(color);
            return new Color( hexConvert.ByteData[0], hexConvert.ByteData[1], hexConvert.ByteData[2]);
        }
    }
}