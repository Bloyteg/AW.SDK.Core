using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace AW
{
    /// <summary>
    /// The type of chat as specified by the <see cref="AW.Attributes.ChatType" /> attribute.
    /// </summary>
    public enum ChatTypes
    {
        /// <summary>
        /// Represents messages that were sent by normal users via public chat.
        /// </summary>
        Said,

        /// <summary>
        /// Represents messages that were sent by public speakers via public chat.
        /// </summary>
        Broadcast,

        /// <summary>
        /// Represents chat that was sent via whispers.
        /// </summary>
        Whisper,
    }

    /// <summary>
    /// The world status as specified by the <see cref="AW.Attributes.WorldlistStatus" /> attribute.
    /// </summary>
    public enum WorldStatus
    {
        /// <summary>
        /// World status is unknown.
        /// </summary>
        Unknown,

        /// <summary>
        /// World is available for public entry.
        /// </summary>
        Public,

        /// <summary>
        /// World is not available for public entry.
        /// </summary>
        Private,

        /// <summary>
        /// World is currently not running.
        /// </summary>
        Stopped
    }

    /// <summary>
    /// The world status as specified by the <see cref="AW.Attributes.ServerState" /> attribute.
    /// </summary>
    public enum ServerStatus
    {
        /// <summary>
        /// World server is stopped.
        /// </summary>
        Stopped,

        /// <summary>
        /// World server is starting.
        /// </summary>
        Starting,

        /// <summary>
        /// World server is waiting for a response from the universe server.
        /// </summary>
        StartWait,

        /// <summary>
        /// World server is running.
        /// </summary>
        Running
    }

    /// <summary>
    /// The type of ejection specified by the <see cref="AW.Attributes.EjectionType" /> attribute.
    /// </summary>
    public enum EjectionType
    {
        /// <summary>
        /// Citizen was ejected based off their IP address.
        /// </summary>
        ByAddress,
        /// <summary>
        /// Citizen was ejected based off their MAC address.
        /// </summary>
        ByComputer,

        /// <summary>
        /// Citizen was ejected based off their citizen number.
        /// </summary>
        ByCitizen
    }

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
        TrackAhead
    }

    /// <summary>
    /// The citizen registration method as specified by the <see cref="AW.Attributes.UniverseRegisterMethod" /> attribute.
    /// </summary>
    public enum RegisterMethod
    {
        /// <summary>
        /// The citizen is registered monthly.
        /// </summary>
        Monthly,

        /// <summary>
        /// The citizen is registered yearly.
        /// </summary>
        Annual,

        /// <summary>
        /// User specified registration type.
        /// </summary>
        User
    }

    /// <summary>
    /// The state that an avatar is currently in.
    /// Flags used by the <see cref="AW.Attributes.AvatarState" /> attribute to determine which state the avatar is in. Set by <see cref="AW.Instance.AvatarSet" />.
    /// </summary>
    public enum AvatarStates
    {
        /// <summary>
        /// Avatar is walking.
        /// </summary>
        StateWalking,

        /// <summary>
        /// Avatar is running.
        /// </summary>
        StateRunning,

        /// <summary>
        /// Avatar is flying.
        /// </summary>
        StateFlying,

        /// <summary>
        /// Avatar is swimming.
        /// </summary>
        StateSwimming,

        /// <summary>
        /// Avatar is falling.
        /// </summary>
        StateFalling,

        /// <summary>
        /// Avatar is jumping.
        /// </summary>
        StateJumping,

        /// <summary>
        /// Avatar is warping.
        /// </summary>
        StateWarping,

        /// <summary>
        /// Avatar is riding.
        /// </summary>
        StateRiding,

        /// <summary>
        /// Avatar is sliding.
        /// </summary>
        StateSliding1,

        /// <summary>
        /// Avatar is sliding.
        /// </summary>
        StateSliding2,

        /// <summary>
        /// Avatar is sliding.
        /// </summary>
        StateSliding3,

        /// <summary>
        /// Avatar is climbing.
        /// </summary>
        StateClimbing
    }

    /// <summary>
    /// Combinable flags used by the <see cref="AW.Attributes.AvatarFlags" /> attribute to determine which attributes are set by <see cref="AW.Instance.AvatarSet" />.
    /// </summary>
    [Flags]
    public enum AvatarSetFlag
    {
        /// <summary>
        /// Default value.  Only sets the type and gesture of the avatar.
        /// </summary>
        None = 0x00,

        /// <summary>
        /// Sets the position of the avatar.
        /// </summary>
        Position = 0x01,

        /// <summary>
        /// Sets the type of the avatar.
        /// </summary>
        Type = 0x02,

        /// <summary>
        /// Sets the gesture of the avatar.
        /// </summary>
        Gesture = 0x04,

        /// <summary>
        /// Sets the state of the avatar.
        /// </summary>
        State = 0x08
    }

    /// <summary>
    /// The entity type.
    /// </summary>
    public enum EntityType
    {
        /// <summary>
        /// Not used a such.
        /// </summary>
        Avatar,

        /// <summary>
        /// Entity is a mover.
        /// </summary>
        Mover
    }

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
        Camera
    }

    /// <summary>
    /// The origin point of a HUD when being placed on the screen.
    /// This is the location in which the HUD will be position relative to.
    /// Represented by the <see cref="AW.Attributes.HudElementOrigin" /> attribute.
    /// </summary>
    public enum HudOrigin
    {
        /// <summary>
        /// The top left corner of the user's screen.
        /// </summary>
        TopLeft = 0,

        /// <summary>
        /// The middle of the top edge of the user's screen.
        /// </summary>
        Top,

        /// <summary>
        /// The top right corner of the user's screen.
        /// </summary>
        TopRight,

        /// <summary>
        /// The middle of the left edge of the user's screen.
        /// </summary>
        Left,

        /// <summary>
        /// The center of the user's screen.
        /// </summary>
        Center,

        /// <summary>
        /// The middle of the right edge of the user's screen.
        /// </summary>
        Right,

        /// <summary>
        /// The bottom left corner of the user's screen.
        /// </summary>
        BottomLeft,

        /// <summary>
        /// The middle of the bottom edge of the user's screen.
        /// </summary>
        Bottom,

        /// <summary>
        /// The bottom right corner of the user's screen.
        /// </summary>
        BottomRight
    }

    /// <summary>
    /// The type of HUD to be drawn, represented by the <see cref="AW.Attributes.HudElementType" /> attribute.
    /// </summary>
    public enum HudType
    {
        /// <summary>
        /// The text specified by the <see cref="AW.Attributes.HudElementText" /> attribute is drawn on the user's screen.
        /// </summary>
        Text = 0,

        /// <summary>
        /// The image specified by the <see cref="AW.Attributes.HudElementText" /> attribute is drawn on the user's screen.
        /// </summary>
        Image,

        /// <summary>
        /// Not currently available to the SDK.
        /// </summary>
        Model
    }

    /// <summary>
    /// Combinable flags to set different attributes for the HUD.
    /// Represented by the <see cref="AW.Attributes.HudElementFlags" /> attribute.
    /// </summary>
    [Flags]
    public enum HudElementFlag
    {
        /// <summary>
        /// Specifies that the HUD element will raise the <see cref="AW.Instance.EventHudClick" /> event when clicked by the user.
        /// </summary>
        Clicks = 0x0001,

        /// <summary>
        /// Specifies that the texture should be resized as needed to force it to fit within the HUD element. By default it will only show as many pixels as it can.
        /// </summary>
        Stretch = 0x0002,

        /// <summary>
        /// Specifies that the HUD element will perform an additive blend when rendering, thus making it appear to "glow". 
        /// </summary>
        Additive = 0x0004,

        /// <summary>
        /// Currently not available to the SDK.
        /// </summary>
        SizePercent = 0x0008,

        /// <summary>
        /// Specifies that the HUD element will smoothly adjust to its new position, color, texture mapping, and opacity over a period of a half-second when updated.
        /// </summary>
        Transition = 0x0010,

        /// <summary>
        /// Specified along with the transition flag. Then when the HUD element is updated it will move to the new position and then back, with a total round-trip time of one second. 
        /// </summary>
        Temporary = 0x0020,

        /// <summary>
        /// Specifies that the HUD element will download its texture from the universe texture path instead of the local world texture path. 
        /// </summary>
        UniversePath = 0x0040,

        /// <summary>
        /// Specifies that the HUD element will lock the edges of its texture, thus preventing it from tiling. If the texture is not big enough to fill the given element space, then the edges are repeated instead of wrapping around to the other side of the texture.
        /// </summary>
        Clamp = 0x0080,

        /// <summary>
        /// Specifies that the HUD element will be highlighted.  This means that the element slowly pulses between a glowing version and the regular version.
        /// </summary>
        Highlight = 0x0100,
    }

    /// <summary>
    /// Cominable flags used by the <see cref="AW.Attributes.WorldEnableCav"/> attribute to specify what type of Custom Avatars are available and to whom.
    /// </summary>
    [Flags]
    public enum EnableCavFlag
    {
        /// <summary>
        /// Citizens can use their universal Custom Avatar.
        /// </summary>
        Citizen = 0x01,

        /// <summary>
        /// Bots can use the universal Custom Avatar of their owner.
        /// </summary>
        Bot = 0x02,

        /// <summary>
        /// Tourists can use a universal Custom Avatar.
        /// </summary>
        Tourist = 0x04,

        /// <summary>
        /// Citizens can use their world Custom Avatar.
        /// </summary>
        WorldCitizen = 0x10,

        /// <summary>
        /// Bots can use the world Custom Avatar of their owner.
        /// </summary>
        WorldBot = 0x20,

        /// <summary>
        /// Tourists can use a world Custom Avatar.
        /// </summary>
        WorldTourist = 0x40
    }
}
