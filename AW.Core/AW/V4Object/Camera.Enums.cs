// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
namespace AW
{
    /// <summary>
    /// The target of a camera as specified by the <see cref="AW.Attributes.CameraTargetType" /> attribute.
    /// </summary>
    public enum CameraType
    {
        /// <summary>
        /// The default tracking method.
        /// </summary>
        TrackDefault,

        /// <summary>
        /// The camera tracks the avatar.
        /// </summary>
        TrackAvatar,

        /// <summary>
        /// The camera tracks the location of an object.
        /// </summary>
        TrackObject,

        /// <summary>
        /// The camera tracks from ahead.
        /// </summary>
        TrackAhead,

        TrackSelfFirstPerson,

        TrackSelfLocked,

        TrackSelfChase,

        TrackSelfFront,
    }
}