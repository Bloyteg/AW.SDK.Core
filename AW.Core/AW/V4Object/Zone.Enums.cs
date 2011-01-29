// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
namespace AW
{
    /// <summary>
    /// The shape of a zone.
    /// <seealso cref="AW.Zone"/>
    /// </summary>
    public enum ZoneType
    {
        /// <summary>
        /// Zone area is represented by a cube or rectangular prism.
        /// </summary>
        Cube,

        /// <summary>
        /// Zone area is represented by a cylinder.
        /// </summary>
        Cylinder,

        /// <summary>
        /// Zone area is represented by a sphere.
        /// </summary>
        Sphere
    }
}