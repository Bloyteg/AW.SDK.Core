// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
namespace AW
{
    /// <summary>
    /// The type of particle being drawn.
    /// <seealso cref="AW.Particle"/>
    /// </summary>
    public enum ParticleType
    {
        /// <summary>
        /// Particle is a sprite.
        /// </summary>
        Sprite,

        /// <summary>
        /// Particle is a facer.
        /// </summary>
        Facer,

        /// <summary>
        /// Particle is flat.
        /// </summary>
        Flat,

        /// <summary>
        /// Particle is an object model.
        /// </summary>
        Object
    }

    /// <summary>
    /// Represents the drawing style of a particle.
    /// <seealso cref="AW.Particle"/>
    /// </summary>
    public enum ParticleDrawStyle
    {
        /// <summary>
        /// Particle is drawn normally.
        /// </summary>
        Normal,

        /// <summary>
        /// Particle is drawn with a bright tint.
        /// </summary>
        Bright,

        /// <summary>
        /// Particle is drawn with a glow.
        /// </summary>
        Glow
    }
}