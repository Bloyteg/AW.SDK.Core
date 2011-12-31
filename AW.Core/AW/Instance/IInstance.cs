// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
using System;

namespace AW
{
    /// <summary>
    /// Delegate used for handling SDK events.
    /// </summary>
    /// <param name="sender"></param>
    public delegate void InstanceEventHandler(IInstance sender);

    /// <summary>
    /// Delegate used for handling SDK callbacks. 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="result"></param>
    public delegate void InstanceCallbackHandler(IInstance sender, Result result);

    /// <summary>
    /// Exposes SDK instance operations for performing bot and world server administration.
    /// </summary>
    public partial interface IInstance : IDisposable
    {
        /// <summary>
        /// Stores data set by the user, associated with the instance.
        /// </summary>
        object Tag { get; set; }

        /// <summary>
        /// Returns the session associated with the instance.  This will change if connection is lost to the universe and re-established.
        /// </summary>
        int Session { get; }

        /// <summary>
        /// Indicates that the referenced <see cref="AW.Instance" /> has been disposed of.
        /// </summary>
        /// <remarks>
        /// If the <see cref="AW.Instance" /> has been disposed (as indicated by this property) do not attempt to call any methods.
        /// You will need to reconstruct the instance.
        /// </remarks>
        bool IsDisposed { get; }

        /// <summary>
        /// Container of attribute properties available to this instance.  Used to set and get the various attributes related to the different SDK operations.
        /// </summary>
        IAttributeProvider Attributes { get; }

        /// <summary>
        /// Sets the attribute Attributes.ObjectData of the instance to the data represented by the V4 object.
        /// </summary>
        /// <typeparam name="TV4Object">The type of the V4 object being used.</typeparam>
        /// <param name="v4Object">The V4 object representing the data to be set.</param>
        void SetV4Object<TV4Object>(TV4Object v4Object)
            where TV4Object : IV4Object, new();

        /// <summary>
        /// Retrieves a V4 object from the Attributes.ObjectData attribute of the instance.
        /// </summary>
        /// <typeparam name="TV4Object">the type of V4 object to be returned.</typeparam>
        /// <returns></returns>
        TV4Object GetV4Object<TV4Object>()
            where TV4Object : IV4Object, new();

        /// <summary>
        /// Logs the instance into the universe using the Attributes.LoginOwner, Attributes.LoginPrivilegePassword, Attributes.LoginName, and Attributes.LoginApplication that were set earlier.
        /// If CallbackLogin is not set, this is a blocking operation.
        /// </summary>
        Result Login();

        /// <summary>
        /// Causes the instance to enter the specified world.
        /// If CallbackEnter is not set, this is a blocking operation.
        /// </summary>
        /// <param name="world">The name of the world to enter.</param>
        Result Enter(string world);

        ///<summary>
        /// Causes the instance to leave the current world.
        /// It is not necessary to call this method when disconnecting or changing worlds.
        ///</summary>
        Result Exit();

        /// <summary>
        /// Causes the instance to change state within the world.
        /// </summary>     
        Result StateChange();

        Result ObjectClick();
        Result ObjectSelect();
        Result AvatarClick(int session);
        Result UrlSend(int session, string url, string target);
        Result UrlClick(string url);
        Result Teleport(int session);
        Result AvatarSet(int session);
        Result AvatarReload(int citizen, int session);
        Result ToolbarClick();
        Result Noise(int session);
        Result CameraSet(int session);
        Result BotmenuSend();
        Result ObjectBump();
        Result WorldList();
        Result Address(int session);
        Result UserList();
        Result AvatarLocation(int citizen, int sessionId, string name);
        Result Say(string message);
        Result Say(string message, object arg0);
        Result Say(string message, object arg0, object arg1);
        Result Say(string message, object arg0, object arg1, object arg2);
        Result Say(string message, params object[] args);
        Result Whisper(int session, string message);
        Result Whisper(int session, string message, object arg0);
        Result Whisper(int session, string message, object arg0, object arg1);
        Result Whisper(int session, string message, object arg0, object arg1, object arg2);
        Result Whisper(int session, string message, params object[] args);
        Result ConsoleMessage(int session);
        Result BotgramSend();
        Result Query(int xSector, int zSector, int[,] sequence);
        Result Query5x5(int xSector, int zSector, int[,] sequence);
        Result ObjectQuery();
        Result CellNext();
        Result ObjectAdd();
        Result ObjectChange();
        Result ObjectDelete();
        Result ObjectLoad();
        Result DeleteAllObjects();
        Result TerrainSet(int x, int z, int texture, int[] heights);
        Result TerrainQuery(int pageX, int pageZ, long sequence);
        Result TerrainNext();
        Result TerrainDeleteAll();
        Result TerrainLoadNode();
        Result MoverSetState(int id, int state, int modelNum);
        Result MoverSetPosition(int id, int x, int y, int z, int yaw, int pitch, int roll);
        Result MoverRiderAdd(int id, int session, int dist, int angle, int yDelta, int yawDelta, int pitchDelta);
        Result MoverRiderChange(int id, int session, int dist, int angle, int yDelta, int yawDelta, int pitchDelta);
        Result MoverRiderDelete(int id, int session);
        Result MoverLinks(int id);
        Result HudCreate();
        Result HudClick();
        Result HudDestroy(int session, int id);
        Result HudClear(int session);
        Result TrafficCount(out int inTraffic, out int outTraffic);
        Result CavRequest(int citizen, int session);
        Result CavChange();
        Result CavDelete();
        Result WorldCavRequest(int citizen, int session);
        Result WorldCavChange();
        Result WorldCavDelete();
        Result UniverseAttributesChange();
        Result UniverseEjectionAdd();
        Result UniverseEjectionDelete(int address);
        Result UniverseEjectionLookup();
        Result UniverseEjectionNext();
        Result UniverseEjectionPrevious();
        Result CitizenAttributesByName(string name);
        Result CitizenAttributesByNumber(int citizen);
        Result CitizenAdd();
        Result CitizenChange();
        Result CitizenDelete(int citizen);
        Result CitizenNext();
        Result CitizenPrevious();
        Result LicenseAdd();
        Result LicenseAttributes(string name);
        Result LicenseChange();
        Result LicenseDelete(string name);
        Result LicenseNext();
        Result LicensePrevious();
        Result WorldAttributesChange();
        Result WorldEject();
        Result WorldReloadRegistry();
        Result WorldAttributesReset();
        Result WorldInstanceSet(int citizen, int worldInstance);
        Result WorldInstanceGet(int citizen);
        Result WorldAttributesSend(int session);
        Result WorldEjectionAdd();
        Result WorldEjectionDelete();
        Result WorldEjectionLookup();
        Result WorldEjectionNext();
        Result WorldEjectionPrevious();
        Result WorldAttributeSet(int attribute, string value);
        Result WorldAttributeGet(int attribute, out bool readOnly, string value);
        bool CheckRight(int citizen, string rightString);
        bool CheckRightAll(string rightString);
        bool HasWorldRight(int citizen, Attributes right);
        bool HasWorldRightAll(Attributes right);
        Result ServerWorldAdd();
        Result ServerWorldDelete(int id);
        Result ServerWorldChange(int id);
        Result ServerWorldList();
        Result ServerWorldStart(int id);
        Result ServerWorldStop(int id);
        Result ServerWorldSet(int id);
        Result ServerWorldInstanceSet(int id);
        Result ServerWorldInstanceAdd(int id, int instanceId);
        Result ServerWorldInstanceDelete(int id, int instanceId);
        Result LaserBeam();
        Result Listen(ChatChannels channels);
        Result SayChannel(ChatChannels channel, string message);
        Result SayChannel(ChatChannels channel, string message, object arg0);
        Result SayChannel(ChatChannels channel, string message, object arg0, object arg1);
        Result SayChannel(ChatChannels channel, string message, object arg0, object arg1, object arg2);
        Result SayChannel(ChatChannels channel, string message, params object[] args);
        Result ObjectAddSession(int session);
        Result ObjectDeleteSession(int session);
        Result ServerWorldGet();

        /// <summary>
        /// Indicates that the instance is in the process of being disposed.
        /// </summary>
        event InstanceEventHandler Disposing;

        /// <summary>
        /// Sets a string attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be set.</param>
        /// <param name="value">The value of the attribute being set.</param>
        /// <exception cref="AW.InstanceAttributeException">Thrown when the instance failed to set the attribute.</exception>
        /// <exception cref="AW.InstanceSetFailedException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        [Obsolete("This method is now obsolete, use the IInstance.Attributes property instead.")]
        void SetString(Attributes attribute, string value);

        /// <summary>
        /// Gets a string attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be accessed.</param>
        /// <returns>The value of the attribute being accessed.</returns>
        /// <exception cref="AW.InstanceSetFailedException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        [Obsolete("This method is now obsolete, use the AW.IInstance.Attributes property instead.")]
        string GetString(Attributes attribute);

        /// <summary>
        /// Sets an integer attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be set.</param>
        /// <param name="value">The value of the attribute being set.</param>
        /// <exception cref="AW.InstanceAttributeException">Thrown when the instance failed to set the attribute.</exception>
        /// <exception cref="AW.InstanceSetFailedException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        [Obsolete("This method is now obsolete, use the AW.IInstance.Attributes property instead.")]
        void SetInt(Attributes attribute, int value);

        /// <summary>
        /// Gets an integer attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be accessed.</param>
        /// <returns>The value of the attribute being accessed.</returns>
        /// <exception cref="AW.InstanceSetFailedException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        [Obsolete("This method is now obsolete, use the AW.IInstance.Attributes property instead.")]
        int GetInt(Attributes attribute);

        /// <summary>
        /// Sets a boolean attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be set.</param>
        /// <param name="value">The value of the attribute being set.</param>
        /// <exception cref="AW.InstanceAttributeException">Thrown when the instance failed to set the attribute.</exception>
        /// <exception cref="AW.InstanceSetFailedException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        [Obsolete("This method is now obsolete, use the AW.IInstance.Attributes property instead.")]
        void SetBool(Attributes attribute, bool value);

        /// <summary>
        /// Gets a boolean attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be accessed.</param>
        /// <returns>The value of the attribute being accessed.</returns>
        /// <exception cref="AW.InstanceSetFailedException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        [Obsolete("This method is now obsolete, use the AW.IInstance.Attributes property instead.")]
        bool GetBool(Attributes attribute);

        /// <summary>
        /// Sets a floating point attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be set.</param>
        /// <param name="value">The value of the attribute being set.</param>
        /// <exception cref="AW.InstanceAttributeException">Thrown when the instance failed to set the attribute.</exception>
        /// <exception cref="AW.InstanceSetFailedException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        [Obsolete("This method is now obsolete, use the IInstance.Attributes property instead.")]
        void SetFloat(Attributes attribute, float value);

        /// <summary>
        /// Gets a floating point attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be accessed.</param>
        /// <returns>The value of the attribute being accessed.</returns>
        /// <exception cref="AW.InstanceSetFailedException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        [Obsolete("This method is now obsolete, use the IInstance.Attributes property instead.")]
        float GetFloat(Attributes attribute);

        /// <summary>
        /// Sets a data (<see cref="System.Array" /> of <see cref="System.Byte" />) attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be set.</param>
        /// <param name="value">The value of the attribute being set.</param>
        /// <exception cref="AW.InstanceAttributeException">Thrown when the instance failed to set the attribute.</exception>
        /// <exception cref="AW.InstanceSetFailedException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        [Obsolete("This method is now obsolete, use the IInstance.Attributes property instead.")]
        void SetData(Attributes attribute, byte[] value);

        /// <summary>
        /// Gets a data (<see cref="System.Array" /> of <see cref="System.Byte" />) attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be accessed.</param>
        /// <returns>The value of the attribute being accessed.</returns>
        /// <exception cref="AW.InstanceSetFailedException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        [Obsolete("This method is now obsolete, use the IInstance.Attributes property instead.")]
        byte[] GetData(Attributes attribute);

        /// <summary>
        /// Takes a string value representing an XML Custom Avatar defition and sets the <see cref="AW.Attributes.CavDefinition" /> attribute accordingly.
        /// </summary>
        /// <param name="cavContents">String representation of the Custom Avatar definition's XML.</param>
        /// <exception cref="AW.InstanceSetFailedException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        void SetCavData(string cavContents);

        /// <summary>
        /// Reads the <see cref="AW.Attributes.CavDefinition" /> attribute and returns the XML contained as a string.
        /// </summary>
        /// <returns>String representation of the Custom Avatar definition's XML.</returns>
        /// <exception cref="AW.InstanceSetFailedException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        string GetCavData();
    }
}
