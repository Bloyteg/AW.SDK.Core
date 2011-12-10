// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
using System;

namespace AW
{
    partial class Instance
    {
        #region Instance manage methods
        /// <summary>
        /// Logs the instance into the universe using the Attributes.LoginOwner, Attributes.LoginPrivilegePassword, Attributes.LoginName, and Attributes.LoginApplication that were set earlier.
        /// If CallbackLogin is not set, this is a blocking operation.
        /// </summary>
        public Result Login()
        {
            SetInstance();
            return (Result)NativeMethods.aw_login();
        }

        /// <summary>
        /// Causes the instance to enter the specified world.
        /// If CallbackEnter is not set, this is a blocking operation.
        /// </summary>
        /// <param name="world">The name of the world to enter.</param>
        public Result Enter(string world)
        {
            SetInstance();
            return (Result)NativeMethods.aw_enter(world);
        }

        ///<summary>
        /// Causes the instance to leave the current world.
        /// It is not necessary to call this method when disconnecting or changing worlds.
        ///</summary>
        public Result Exit()
        {
            SetInstance();
            return (Result)NativeMethods.aw_exit();
        }

        /// <summary>
        /// Causes the instance to change state within the world.
        /// </summary>     
        public Result StateChange()
        {
            SetInstance();
            return (Result)NativeMethods.aw_state_change();
        }
        #endregion

        #region Event manipulation methods
        public Result ObjectClick()
        {
            SetInstance();
            return (Result)NativeMethods.aw_object_click();
        }

        public Result ObjectSelect()
        {
            SetInstance();
            return (Result)NativeMethods.aw_object_select();
        }

        public Result AvatarClick(int session)
        {
            SetInstance();
            return (Result)NativeMethods.aw_avatar_click(session);
        }

        public Result UrlSend(int session, string url, string target)
        {
            SetInstance();
            return (Result)NativeMethods.aw_url_send(session, url, target);
        }

        public Result UrlClick(string url)
        {
            SetInstance();
            return (Result)NativeMethods.aw_url_click(url);
        }

        public Result Teleport(int session)
        {
            SetInstance();
            return (Result)NativeMethods.aw_teleport(session);
        }

        public Result AvatarSet(int session)
        {
            SetInstance();
            return (Result)NativeMethods.aw_avatar_set(session);
        }

        public Result AvatarReload(int citizen, int session)
        {
            SetInstance();
            return (Result)NativeMethods.aw_avatar_reload(citizen, session);
        }

        public Result ToolbarClick()
        {
            SetInstance();
            return (Result)NativeMethods.aw_toolbar_click();
        }

        public Result Noise(int session)
        {
            SetInstance();
            return (Result)NativeMethods.aw_noise(session);
        }

        public Result CameraSet(int session)
        {
            SetInstance();
            return (Result)NativeMethods.aw_camera_set(session);
        }

        public Result BotmenuSend()
        {
            SetInstance();
            return (Result)NativeMethods.aw_botmenu_send();
        }

        public Result ObjectBump()
        {
            SetInstance();
            return (Result)NativeMethods.aw_object_bump();
        }
        #endregion

        #region Information query methods
        public Result WorldList()
        {
            SetInstance();
            return (Result)NativeMethods.aw_world_list();
        }

        public Result Address(int session)
        {
            SetInstance();
            return (Result)NativeMethods.aw_address(session);
        }

        public Result UserList()
        {
            SetInstance();
            return (Result)NativeMethods.aw_user_list();
        }

        public Result AvatarLocation(int citizen, int sessionId, string name)
        {
            SetInstance();
            return (Result)NativeMethods.aw_avatar_location(citizen, sessionId, name);
        }
        #endregion

        #region Communication methods
        public Result Say(string message)
        {
            SetInstance();
            return (Result)NativeMethods.aw_say(message);
        }

        public Result Say(string message, object arg0)
        {
            SetInstance();
            return (Result)NativeMethods.aw_say(string.Format(message, arg0));
        }

        public Result Say(string message, object arg0, object arg1)
        {
            SetInstance();
            return (Result)NativeMethods.aw_say(string.Format(message, arg0, arg1));
        }

        public Result Say(string message, object arg0, object arg1, object arg2)
        {
            SetInstance();
            return (Result)NativeMethods.aw_say(string.Format(message, arg0, arg1, arg2));
        }

        public Result Say(string message, params object[] args)
        {
            SetInstance();
            return (Result)NativeMethods.aw_say(string.Format(message, args));
        }

        public Result Whisper(int session, string message)
        {
            SetInstance();
            return (Result)NativeMethods.aw_whisper(session, message);
        }

        public Result Whisper(int session, string message, object arg0)
        {
            SetInstance();
            return (Result)NativeMethods.aw_whisper(session, string.Format(message, arg0));
        }

        public Result Whisper(int session, string message, object arg0, object arg1)
        {
            SetInstance();
            return (Result)NativeMethods.aw_whisper(session, string.Format(message, arg0, arg1));
        }

        public Result Whisper(int session, string message, object arg0, object arg1, object arg2)
        {
            SetInstance();
            return (Result)NativeMethods.aw_whisper(session, string.Format(message, arg0, arg1, arg2));
        }

        public Result Whisper(int session, string message, params object[] args)
        {
            SetInstance();
            return (Result)NativeMethods.aw_whisper(session, string.Format(message, args));
        }

        public Result ConsoleMessage(int session)
        {
            SetInstance();
            return (Result)NativeMethods.aw_console_message(session);
        }

        public Result BotgramSend()
        {
            SetInstance();
            return (Result)NativeMethods.aw_botgram_send();
        }
        #endregion

        #region Property methods
        public Result Query(int xSector, int zSector, int[,] sequence)
        {
            SetInstance();
            return (Result)NativeMethods.aw_query(xSector, zSector, sequence);
        }

        public Result Query5x5(int xSector, int zSector, int[,] sequence)
        {
            SetInstance();
            return (Result)NativeMethods.aw_query_5x5(xSector, zSector, sequence);
        }

        public Result ObjectQuery()
        {
            SetInstance();
            return (Result)NativeMethods.aw_object_query();
        }

        public Result CellNext()
        {
            SetInstance();
            return (Result)NativeMethods.aw_cell_next();
        }

        public Result ObjectAdd()
        {
            SetInstance();
            return (Result)NativeMethods.aw_object_add();
        }

        public Result ObjectChange()
        {
            SetInstance();
            return (Result)NativeMethods.aw_object_change();
        }

        public Result ObjectDelete()
        {
            SetInstance();
            return (Result)NativeMethods.aw_object_delete();
        }

        public Result ObjectLoad()
        {
            SetInstance();
            return (Result)NativeMethods.aw_object_load();
        }

        public Result DeleteAllObjects()
        {
            SetInstance();
            return (Result)NativeMethods.aw_delete_all_objects();
        }
        #endregion

        #region Terrain methods
        public Result TerrainSet(int x, int z, int texture, int[] heights)
        {
            SetInstance();
            return (Result)NativeMethods.aw_terrain_set(x, z, heights.Length, texture, heights);
        }

        public Result TerrainQuery(int pageX, int pageZ, long sequence)
        {
            SetInstance();
            return (Result)NativeMethods.aw_terrain_query(pageX, pageZ, sequence);
        }

        public Result TerrainNext()
        {
            SetInstance();
            return (Result)NativeMethods.aw_terrain_next();
        }

        public Result TerrainDeleteAll()
        {
            SetInstance();
            return (Result)NativeMethods.aw_terrain_delete_all();
        }

        public Result TerrainLoadNode()
        {
            SetInstance();
            return (Result)NativeMethods.aw_terrain_load_node();
        }
        #endregion

        #region Mover methods
        public Result MoverSetState(int id, int state, int modelNum)
        {
            SetInstance();
            return (Result)NativeMethods.aw_mover_set_state(id, state, modelNum);
        }

        public Result MoverSetPosition(int id, int x, int y, int z, int yaw, int pitch, int roll)
        {
            SetInstance();
            return (Result)NativeMethods.aw_mover_set_position(id, x, y, z, yaw, pitch, roll);
        }

        public Result MoverRiderAdd(int id, int session, int dist, int angle, int yDelta, int yawDelta, int pitchDelta)
        {
            SetInstance();
            return (Result)NativeMethods.aw_mover_rider_add(id, session, dist, angle, yDelta, yawDelta, pitchDelta);
        }

        public Result MoverRiderChange(int id, int session, int dist, int angle, int yDelta, int yawDelta, int pitchDelta)
        {
            SetInstance();
            return (Result)NativeMethods.aw_mover_rider_change(id, session, dist, angle, yDelta, yawDelta, pitchDelta);
        }

        public Result MoverRiderDelete(int id, int session)
        {
            SetInstance();
            return (Result)NativeMethods.aw_mover_rider_delete(id, session);
        }

        public Result MoverLinks(int id)
        {
            SetInstance();
            return (Result)NativeMethods.aw_mover_links(id);
        }
        #endregion

        #region HUD methods
        public Result HudCreate()
        {
            SetInstance();
            return (Result)NativeMethods.aw_hud_create();
        }

        public Result HudClick()
        {
            SetInstance();
            return (Result)NativeMethods.aw_hud_click();
        }

        public Result HudDestroy(int session, int id)
        {
            SetInstance();
            return (Result)NativeMethods.aw_hud_destroy(session, id);
        }

        public Result HudClear(int session)
        {
            SetInstance();
            return (Result)NativeMethods.aw_hud_clear(session);
        }

        public Result TrafficCount(out int inTraffic, out int outTraffic)
        {
            SetInstance();
            return (Result)NativeMethods.aw_traffic_count(out inTraffic, out outTraffic);
        }
        #endregion

        #region CAV manipulation methods
        public Result CavRequest(int citizen, int session)
        {
            SetInstance();
            return (Result)NativeMethods.aw_cav_request(citizen, session);
        }

        public Result CavChange()
        {
            SetInstance();
            return (Result)NativeMethods.aw_cav_change();
        }

        public Result CavDelete()
        {
            SetInstance();
            return (Result)NativeMethods.aw_cav_delete();
        }

        public Result WorldCavRequest(int citizen, int session)
        {
            SetInstance();
            return (Result)NativeMethods.aw_world_cav_request(citizen, session);
        }

        public Result WorldCavChange()
        {
            SetInstance();
            return (Result)NativeMethods.aw_world_cav_change();
        }

        public Result WorldCavDelete()
        {
            SetInstance();
            return (Result)NativeMethods.aw_world_cav_delete();
        }
        #endregion

        #region Universe related methods
        #region Universe management methods
        public Result UniverseAttributesChange()
        {
            SetInstance();
            return (Result)NativeMethods.aw_universe_attributes_change();
        }

        public Result UniverseEjectionAdd()
        {
            SetInstance();
            return (Result)NativeMethods.aw_universe_ejection_add();
        }

        public Result UniverseEjectionDelete(int address)
        {
            SetInstance();
            return (Result)NativeMethods.aw_universe_ejection_delete(address);
        }

        public Result UniverseEjectionLookup()
        {
            SetInstance();
            return (Result)NativeMethods.aw_universe_ejection_lookup();
        }

        public Result UniverseEjectionNext()
        {
            SetInstance();
            return (Result)NativeMethods.aw_universe_ejection_next();
        }

        public Result UniverseEjectionPrevious()
        {
            SetInstance();
            return (Result)NativeMethods.aw_universe_ejection_previous();
        }
        #endregion

        #region Citizen methods
        public Result CitizenAttributesByName(string name)
        {
            SetInstance();
            return (Result)NativeMethods.aw_citizen_attributes_by_name(name);
        }

        public Result CitizenAttributesByNumber(int citizen)
        {
            SetInstance();
            return (Result)NativeMethods.aw_citizen_attributes_by_number(citizen);
        }

        public Result CitizenAdd()
        {
            SetInstance();
            return (Result)NativeMethods.aw_citizen_add();
        }

        public Result CitizenChange()
        {
            SetInstance();
            return (Result)NativeMethods.aw_citizen_change();
        }

        public Result CitizenDelete(int citizen)
        {
            SetInstance();
            return (Result)NativeMethods.aw_citizen_delete(citizen);
        }

        public Result CitizenNext()
        {
            SetInstance();
            return (Result)NativeMethods.aw_citizen_next();
        }

        public Result CitizenPrevious()
        {
            SetInstance();
            return (Result)NativeMethods.aw_citizen_previous();
        }
        #endregion

        #region World license methods
        public Result LicenseAdd()
        {
            SetInstance();
            return (Result)NativeMethods.aw_license_add();
        }

        public Result LicenseAttributes(string name)
        {
            SetInstance();
            return (Result)NativeMethods.aw_license_attributes(name);
        }

        public Result LicenseChange()
        {
            SetInstance();
            return (Result)NativeMethods.aw_license_change();
        }

        public Result LicenseDelete(string name)
        {
            SetInstance();
            return (Result)NativeMethods.aw_license_delete(name);
        }

        public Result LicenseNext()
        {
            SetInstance();
            return (Result)NativeMethods.aw_license_next();
        }

        public Result LicensePrevious()
        {
            SetInstance();
            return (Result)NativeMethods.aw_license_previous();
        }
        #endregion
        #endregion

        #region World related methods
        #region World management methods
        public Result WorldAttributesChange()
        {
            SetInstance();
            return (Result)NativeMethods.aw_world_attributes_change();
        }

        public Result WorldEject()
        {
            SetInstance();
            return (Result)NativeMethods.aw_world_eject();
        }

        public Result WorldReloadRegistry()
        {
            SetInstance();
            return (Result)NativeMethods.aw_world_reload_registry();
        }

        public Result WorldAttributesReset()
        {
            SetInstance();
            return (Result)NativeMethods.aw_world_attributes_reset();
        }

        public Result WorldInstanceSet(int citizen, int worldInstance)
        {
            SetInstance();
            return (Result)NativeMethods.aw_world_instance_set(citizen, worldInstance);
        }

        public Result WorldInstanceGet(int citizen)
        {
            SetInstance();
            return (Result)NativeMethods.aw_world_instance_get(citizen);
        }

        public Result WorldAttributesSend(int session)
        {
            SetInstance();
            return (Result)NativeMethods.aw_world_attributes_send(session);
        }

        public Result WorldEjectionAdd()
        {
            SetInstance();
            return (Result)NativeMethods.aw_world_ejection_add();
        }

        public Result WorldEjectionDelete()
        {
            SetInstance();
            return (Result)NativeMethods.aw_world_ejection_delete();
        }

        public Result WorldEjectionLookup()
        {
            SetInstance();
            return (Result)NativeMethods.aw_world_ejection_lookup();
        }

        public Result WorldEjectionNext()
        {
            SetInstance();
            return (Result)NativeMethods.aw_world_ejection_next();
        }

        public Result WorldEjectionPrevious()
        {
            SetInstance();
            return (Result)NativeMethods.aw_world_ejection_previous();
        }

        public Result WorldAttributeSet(int attribute, string value)
        {
            SetInstance();
            return (Result)NativeMethods.aw_world_attribute_set(attribute, value);
        }

        public Result WorldAttributeGet(int attribute, out bool readOnly, string value)
        {
            SetInstance();
            int ro;
            int ret = NativeMethods.aw_world_attribute_get(attribute, out ro, value);
            readOnly = ro != 0;
            return (Result)ret;
        }
        #endregion

        #region Rights Checking Methods
        public bool CheckRight(int citizen, string rightString)
        {
            SetInstance();
            return NativeMethods.aw_check_right(citizen, rightString);
        }

        public bool CheckRightAll(string rightString)
        {
            SetInstance();
            return NativeMethods.aw_check_right_all(rightString);
        }

        public bool HasWorldRight(int citizen, Attributes right)
        {
            SetInstance();
            return NativeMethods.aw_has_world_right(citizen, right);
        }

        public bool HasWorldRightAll(Attributes right)
        {
            SetInstance();
            return NativeMethods.aw_has_world_right_all(right);
        }
        #endregion
        #endregion

        #region World server management methods
        public Result ServerWorldAdd()
        {
            SetInstance();
            return (Result)NativeMethods.aw_server_world_add();
        }

        public Result ServerWorldDelete(int id)
        {
            SetInstance();
            return (Result)NativeMethods.aw_server_world_delete(id);
        }

        public Result ServerWorldChange(int id)
        {
            SetInstance();
            return (Result)NativeMethods.aw_server_world_change(id);
        }

        public Result ServerWorldList()
        {
            SetInstance();
            return (Result)NativeMethods.aw_server_world_list();
        }

        public Result ServerWorldStart(int id)
        {
            SetInstance();
            return (Result)NativeMethods.aw_server_world_start(id);
        }

        public Result ServerWorldStop(int id)
        {
            SetInstance();
            return (Result)NativeMethods.aw_server_world_stop(id);
        }

        public Result ServerWorldSet(int id)
        {
            SetInstance();
            return (Result)NativeMethods.aw_server_world_set(id);
        }

        public Result ServerWorldInstanceSet(int id)
        {
            SetInstance();
            return (Result)NativeMethods.aw_server_world_instance_set(id);
        }

        public Result ServerWorldInstanceAdd(int id, int instanceId)
        {
            SetInstance();
            return (Result)NativeMethods.aw_server_world_instance_add(id, instanceId);
        }

        public Result ServerWorldInstanceDelete(int id, int instanceId)
        {
            SetInstance();
            return (Result)NativeMethods.aw_server_world_instance_delete(id, instanceId);
        }
        #endregion

        #region Laser Beam methods

        public Result LaserBeam()
        {
            SetInstance();
            return (Result)NativeMethods.aw_laser_beam();
        }

        public Result Listen(ChatChannels channels)
        {
            throw new NotImplementedException();
        }

        public Result SayChannel(ChatChannels channel, string message)
        {
            throw new NotImplementedException();
        }

        public Result SayChannel(ChatChannels channel, string message, object arg0)
        {
            throw new NotImplementedException();
        }

        public Result SayChannel(ChatChannels channel, string message, object arg0, object arg1)
        {
            throw new NotImplementedException();
        }

        public Result SayChannel(ChatChannels channel, string message, object arg0, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }

        public Result SayChannel(ChatChannels channel, string message, params object[] args)
        {
            throw new NotImplementedException();
        }

        public Result ObjectAddSession(int session)
        {
            throw new NotImplementedException();
        }

        public Result ObjectDeleteSession(int session)
        {
            throw new NotImplementedException();
        }

        public Result ServerWorldGet()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}