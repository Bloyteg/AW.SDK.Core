// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
namespace AW
{
    /// <summary>
    /// The state which a mover is in.
    /// </summary>
    enum MoverState
    {
        /// <summary>
        /// Never set by the SDK.
        /// </summary>
        Idle, 

        /// <summary>
        /// The mover is in the start state.
        /// </summary>
        Start,

        /// <summary>
        /// Never set by the SDK.
        /// </summary>
        Move,

        /// <summary>
        /// The mover is pasued.
        /// </summary>
        Pause,

        /// <summary>
        /// The mover continues to the next position.
        /// </summary>
        Continue,

        /// <summary>
        /// The mover is stopped.
        /// </summary>
        Stop,

        /// <summary>
        /// The mover is reset to its default location.
        /// </summary>
        Reset
    }


    /// <summary>
    /// The type of mover.
    /// </summary>
    public enum MoverType
    {
        /// <summary>
        /// The mover is passive.  The position is controlled by the user.
        /// </summary>
        Passive,

        /// <summary>
        /// The mover is active.  The position is controlled by the server.
        /// </summary>
        Active,

        /// <summary>
        /// The mover is an item attached to a limb on an avatar.
        /// </summary>
        Item
    }

}