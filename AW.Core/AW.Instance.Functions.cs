namespace AW
{
    partial class Instance
    {
        #region Instance manage methods
        public int Login()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_login());
        }

        public int Enter(string world)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_enter(world));
        }

        public int Exit()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_exit());
        }

        public int StateChange()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_state_change());
        }
        #endregion

        #region Event manipulation methods
        public int ObjectClick()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_object_click());
        }

        public int ObjectSelect()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_object_select());
        }

        public int AvatarClick(int session)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_avatar_click(session));
        }

        public int UrlSend(int session, string url, string target)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_url_send(session, url, target));
        }

        public int UrlClick(string url)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_url_click(url));
        }

        public int Teleport(int session)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_teleport(session));
        }

        public int AvatarSet(int session)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_avatar_set(session));
        }

        public int AvatarReload(int citizen, int session)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_avatar_reload(citizen, session));
        }

        public int ToolbarClick()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_toolbar_click());
        }

        public int Noise(int session)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_noise(session));
        }

        public int CameraSet(int session)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_camera_set(session));
        }

        public int BotmenuSend()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_botmenu_send());
        }

        public int ObjectBump()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_object_bump());
        }
        #endregion

        #region Information query methods
        public int WorldList()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_world_list());
        }

        public int Address(int session)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_address(session));
        }

        public int UserList()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_user_list());
        }

        public int AvatarLocation(int citizen, int sessionId, string name)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_avatar_location(citizen, sessionId, name));
        }
        #endregion

        #region Communication methods
        public int Say(string message)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_say(message));
        }

        public int Say(string message, object arg0)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_say(string.Format(message, arg0)));
        }

        public int Say(string message, object arg0, object arg1)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_say(string.Format(message, arg0, arg1)));
        }

        public int Say(string message, object arg0, object arg1, object arg2)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_say(string.Format(message, arg0, arg1, arg2)));
        }

        public int Say(string message, params object[] args)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_say(string.Format(message, args)));
        }

        public int Whisper(int session, string message)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_whisper(session, message));
        }

        public int Whisper(int session, string message, object arg0)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_whisper(session, string.Format(message, arg0)));
        }

        public int Whisper(int session, string message, object arg0, object arg1)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_whisper(session, string.Format(message, arg0, arg1)));
        }

        public int Whisper(int session, string message, object arg0, object arg1, object arg2)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_whisper(session, string.Format(message, arg0, arg1, arg2)));
        }

        public int Whisper(int session, string message, params object[] args)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_whisper(session, string.Format(message, args)));
        }

        public int ConsoleMessage(int session)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_console_message(session));
        }

        public int BotgramSend()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_botgram_send());
        }
        #endregion

        #region Property methods
        public int Query(int xSector, int zSector, int[,] sequence)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_query(xSector, zSector, sequence));
        }

        public int Query5x5(int xSector, int zSector, int[,] sequence)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_query_5x5(xSector, zSector, sequence));
        }

        public int ObjectQuery()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_object_query());
        }

        public int CellNext()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_cell_next());
        }

        public int ObjectAdd()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_object_add());
        }

        public int ObjectChange()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_object_change());
        }

        public int ObjectDelete()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_object_delete());
        }

        public int ObjectLoad()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_object_load());
        }

        public int DeleteAllObjects()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_delete_all_objects());
        }
        #endregion

        #region Terrain methods
        public int TerrainSet(int x, int z, int texture, int[] heights)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_terrain_set(x, z, heights.Length, texture, heights));
        }

        public int TerrainQuery(int pageX, int pageZ, ulong sequence)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_terrain_query(pageX, pageZ, sequence));
        }

        public int TerrainNext()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_terrain_next());
        }

        public int TerrainDeleteAll()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_terrain_delete_all());
        }

        public int TerrainLoadNode()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_terrain_load_node());
        }
        #endregion

        #region Mover methods
        public int MoverSetState(int id, int state, int modelNum)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_mover_set_state(id, state, modelNum));
        }

        public int MoverSetPosition(int id, int x, int y, int z, int yaw, int pitch, int roll)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_mover_set_position(id, x, y, z, yaw, pitch, roll));
        }

        public int MoverRiderAdd(int id, int session, int dist, int angle, int yDelta, int yawDelta, int pitchDelta)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_mover_rider_add(id, session, dist, angle, yDelta, yawDelta, pitchDelta));
        }

        public int MoverRiderChange(int id, int session, int dist, int angle, int yDelta, int yawDelta, int pitchDelta)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_mover_rider_change(id, session, dist, angle, yDelta, yawDelta, pitchDelta));
        }

        public int MoverRiderDelete(int id, int session)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_mover_rider_delete(id, session));
        }

        public int MoverLinks(int id)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_mover_links(id));
        }
        #endregion

        #region HUD methods
        public int HudCreate()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_hud_create());
        }

        public int HudClick()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_hud_click());
        }

        public int HudDestroy(int session, int id)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_hud_destroy(session, id));
        }

        public int HudClear(int session)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_hud_clear(session));
        }

        public int TrafficCount(out int inTraffic, out int outTraffic)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_traffic_count(out inTraffic, out outTraffic));
        }
        #endregion

        #region CAV manipulation methods
        public int CavRequest(int citizen, int session)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_cav_request(citizen, session));
        }

        public int CavChange()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_cav_change());
        }

        public int CavDelete()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_cav_delete());
        }

        public int WorldCavRequest(int citizen, int session)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_world_cav_request(citizen, session));
        }

        public int WorldCavChange()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_world_cav_change());
        }

        public int WorldCavDelete()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_world_cav_delete());
        }
        #endregion

        #region Universe related methods
        #region Universe management methods
        public int UniverseAttributesChange()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_universe_attributes_change());
        }

        public int UniverseEjectionAdd()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_universe_ejection_add());
        }

        public int UniverseEjectionDelete(int address)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_universe_ejection_delete(address));
        }

        public int UniverseEjectionLookup()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_universe_ejection_lookup());
        }

        public int UniverseEjectionNext()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_universe_ejection_next());
        }

        public int UniverseEjectionPrevious()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_universe_ejection_previous());
        }
        #endregion

        #region Citizen methods
        public int CitizenAttributesByName(string name)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_citizen_attributes_by_name(name));
        }

        public int CitizenAttributesByNumber(int citizen)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_citizen_attributes_by_number(citizen));
        }

        public int CitizenAdd()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_citizen_add());
        }

        public int CitizenChange()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_citizen_change());
        }

        public int CitizenDelete(int citizen)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_citizen_delete(citizen));
        }

        public int CitizenNext()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_citizen_next());
        }

        public int CitizenPrevious()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_citizen_previous());
        }
        #endregion

        #region World license methods
        public int LicenseAdd()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_license_add());
        }

        public int LicenseAttributes(string name)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_license_attributes(name));
        }

        public int LicenseChange()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_license_change());
        }

        public int LicenseDelete(string name)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_license_delete(name));
        }

        public int LicenseNext()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_license_next());
        }

        public int LicensePrevious()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_license_previous());
        }
        #endregion
        #endregion

        #region World related methods
        #region World management methods
        public int WorldAttributesChange()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_world_attributes_change());
        }

        public int WorldEject()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_world_eject());
        }

        public int WorldReloadRegistry()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_world_reload_registry());
        }

        public int WorldAttributesReset()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_world_attributes_reset());
        }

        public int WorldInstanceSet(int citizen, int worldInstance)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_world_instance_set(citizen, worldInstance));
        }

        public int WorldInstanceGet(int citizen)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_world_instance_get(citizen));
        }

        public int WorldAttributesSend(int session)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_world_attributes_send(session));
        }

        public int WorldEjectionAdd()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_world_ejection_add());
        }

        public int WorldEjectionDelete()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_world_ejection_delete());
        }

        public int WorldEjectionLookup()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_world_ejection_lookup());
        }

        public int WorldEjectionNext()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_world_ejection_next());
        }

        public int WorldEjectionPrevious()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_world_ejection_previous());
        }

        public int WorldAttributeSet(int attribute, string value)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_world_attribute_set(attribute, value));
        }

        public int WorldAttributeGet(int attribute, out bool readOnly, string value)
        {
            SetInstance();
            int ro;
            int ret = InterOp.aw_world_attribute_get(attribute, out ro, value);
            readOnly = ro != 0;
            return InstanceException.Assert(ret);
        }
        #endregion

        #region Rights Checking Methods
        public bool CheckRight(int citizen, string rightString)
        {
            SetInstance();
            return InterOp.aw_check_right(citizen, rightString);
        }

        public bool CheckRightAll(string rightString)
        {
            SetInstance();
            return InterOp.aw_check_right_all(rightString);
        }

        public bool HasWorldRight(int citizen, Attributes right)
        {
            SetInstance();
            return InterOp.aw_has_world_right(citizen, right);
        }

        public bool HasWorldRightAll(Attributes right)
        {
            SetInstance();
            return InterOp.aw_has_world_right_all(right);
        }
        #endregion
        #endregion

        #region World server management methods
        public int ServerWorldAdd()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_server_world_add());
        }

        public int ServerWorldDelete(int id)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_server_world_delete(id));
        }

        public int ServerWorldChange(int id)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_server_world_change(id));
        }

        public int ServerWorldList()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_server_world_list());
        }

        public int ServerWorldStart(int id)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_server_world_start(id));
        }

        public int ServerWorldStop(int id)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_server_world_stop(id));
        }

        public int ServerWorldSet(int id)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_server_world_set(id));
        }

        public int ServerWorldInstanceSet(int id)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_server_world_instance_set(id));
        }

        public int ServerWorldInstanceAdd(int id, int instanceId)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_server_world_instance_add(id, instanceId));
        }

        public int ServerWorldInstanceDelete(int id, int instanceId)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_server_world_instance_delete(id, instanceId));
        }
        #endregion

        #region Laser Beam methods

        public int LaserBeam()
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_laser_beam());
        }

        #endregion
    }
}