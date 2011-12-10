// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
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
        private byte _blue;
        private byte _green;
        private byte _red;

        /// <summary>
        /// The blue component of the color.  Value range is 0 to 255.
        /// </summary>
        public byte Blue
        {
            get { return _blue; }
            set { _blue = value; }
        }

        /// <summary>
        /// The green component of the color.  Value range is 0 to 255.
        /// </summary>
        public byte Green
        {
            get { return _green; }
            set { _green = value; }
        }

        /// <summary>
        /// The red component of the color.  Value range is 0 to 255.
        /// </summary>
        public byte Red
        {
            get { return _red; }
            set { _red = value; }
        }

        /// <summary>
        /// Constructs the default color.  This color will be black.
        /// </summary>
        public Color()
        {
            a = 255;
        }

        /// <summary>
        /// Constructs a color using the specified values.
        /// </summary>
        /// <param name="red">Red component.  Value range is 0 to 255.</param>
        /// <param name="green">Green component.  Value range is 0 to 255.</param>
        /// <param name="blue">Blue component.  Value range is 0 to 255.</param>
        public Color(byte red, byte green, byte blue)
        {
            a = 255;
            _red = red;
            _green = green;
            _blue = blue;
        }

        /// <summary>
        /// Converts a <see cref="System.Drawing.Color" /> to <see cref="AW.Color" />.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static explicit operator Color(System.Drawing.Color color)
        {
            return new Color { Red = color.R, Green = color.G, Blue = color.B };
        }

        /// <summary>
        /// Converts a <see cref="AW.Color" /> to <see cref="System.Drawing.Color" />.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static explicit operator System.Drawing.Color(Color color)
        {
            return System.Drawing.Color.FromArgb(255, color.Red, color.Green, color.Blue);
        }

        /// <summary>
        /// Converts a <see cref="System.UInt32" /> to <see cref="AW.Color" />.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static implicit operator Color(int color)
        {
            return new Color
            {
                Red = (byte)(color  & 0x0000FF),
                Green = (byte)((color >> 8) & 0x0000FF),
                Blue = (byte)((color >> 16) & 0x0000FF)
            };
        }

        /// <summary>
        /// Converts a <see cref="AW.Color" /> to <see cref="System.Int32" />.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static implicit operator int(Color color)
        {
            return (color.Red | (color.Green << 8) | (color.Blue << 16));
        }

        /// <summary>
        /// Converts the <see cref="AW.Color" /> into a hexadecimal string.
        /// </summary>
        /// <returns>The string representation of the color.</returns>
        public override string ToString()
        {
            return String.Format("{0:X2}{1:X2}{2:X2}", _red, _green, _blue);
        }

        /// <summary>
        /// Converts the hexadecimal string into a <see cref="AW.Color" />.
        /// </summary>
        /// <param name="color">A hexadecimal string representation of the color.</param>
        public static Color FromString(string color)
        {
            var hexConvert = new Utilities.HexConverter(color);
            return new Color(hexConvert.ByteData[0], hexConvert.ByteData[1], hexConvert.ByteData[2]);
        }
    }
}