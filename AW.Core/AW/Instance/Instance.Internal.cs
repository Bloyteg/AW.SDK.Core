using System;
using System.Collections.Generic;
using System.Text;

namespace AW
{
    public partial class Instance
    {
        internal Color GetColor(Attributes red, Attributes green, Attributes blue)
        {
            return new Color((byte) GetInt(red), (byte) GetInt(green), (byte) GetInt(blue));
        }

        internal void SetColor(Color value, Attributes red, Attributes green, Attributes blue)
        {
            SetInt(red, value.Red);
            SetInt(green, value.Green);
            SetInt(blue, value.Blue);
        }
    }
}
