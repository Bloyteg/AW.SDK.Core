// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
using System;
using System.Runtime.InteropServices;

namespace AW
{
    /// <summary>
    /// A range of two vectors used by the SDK.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    [Serializable]
    public sealed class VectorRange
    {
        Vector minimum = new Vector();
        Vector maximum = new Vector();

        /// <summary>
        /// The mininal range vector.
        /// </summary>
        public Vector Minimum
        {
            get { return minimum; }
            set { minimum = value; }
        }

        /// <summary>
        /// The maximal range vector.
        /// </summary>
        public Vector Maximum
        {
            get { return maximum; }
            set { maximum = value; }
        }
    }
}