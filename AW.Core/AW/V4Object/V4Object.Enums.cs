// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
namespace AW
{
    /// <summary>
    /// The type of object represented by the <see cref="AW.Attributes.ObjectType" /> attribute.
    /// </summary>
    public enum ObjectType
    {
        /// <summary>
        /// The object is a 3d model.  This is any non-V4 object.
        /// </summary>
        V3 = 0,

        /// <summary>
        /// The object type is unknown.
        /// </summary>
        Unknown,

        /// <summary>
        /// The object is a zone.
        /// </summary>
        Zone,

        /// <summary>
        /// The object is a particle emitter.
        /// </summary>
        Particle,

        /// <summary>
        /// The object is a mover.
        /// </summary>
        Mover,

        /// <summary>
        /// The object is a camera.
        /// </summary>
        Camera,

        /// <summary>
        /// The object is a cloth type.
        /// </summary>
        Cloth
    }
}