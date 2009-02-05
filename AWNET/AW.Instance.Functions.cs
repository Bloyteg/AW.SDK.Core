using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace AW
{
    partial class Instance
    {
        #region Instance manage methods
        public void Login()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_login());
        }

        public void Enter(string world)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_enter(world));
        }

        public void Exit()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_exit());
        }

        public void StateChange()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_state_change());
        }
        #endregion

        #region Event manipulation methods
        public void ObjectClick()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_object_click());
        }

        public void ObjectSelect()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_object_select());
        }

        public void AvatarClick(int session)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_avatar_click(session));
        }

        public void UrlSend(int session, string url, string target)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_url_send(session, url, target));
        }

        public void UrlClick(string url)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_url_click(url));
        }

        public void Teleport(int session)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_teleport(session));
        }

        public void AvatarSet(int session)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_avatar_set(session));
        }

        public void AvatarReload(int citizen, int session)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_avatar_reload(citizen, session));
        }

        public void ToolbarClick()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_toolbar_click());
        }

        public void Noise(int session)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_noise(session));
        }

        public void CameraSet(int session)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_camera_set(session));
        }

        public void BotmenuSend()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_botmenu_send());
        }

        public void ObjectBump()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_object_bump());
        }
        #endregion

        #region Information query methods
        public void WorldList()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_world_list());
        }

        public void Address(int session)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_address(session));
        }

        public void UserList()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_user_list());
        }

        public void AvatarLocation(int citizen, int sessionId, string name)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_avatar_location(citizen, sessionId, name));
        }
        #endregion

        #region Communication methods
        public void Say(string message)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_say(message));
        }

        public void Say(string message, object arg0)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_say(string.Format(message, arg0)));
        }

        public void Say(string message, object arg0, object arg1)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_say(string.Format(message, arg0, arg1)));
        }

        public void Say(string message, object arg0, object arg1, object arg2)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_say(string.Format(message, arg0, arg1, arg2)));
        }

        public void Say(string message, params object[] args)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_say(string.Format(message, args)));
        }

        public void Whisper(int session, string message)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_whisper(session, message));
        }

        public void Whisper(int session, string message, object arg0)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_whisper(session, string.Format(message, arg0)));
        }

        public void Whisper(int session, string message, object arg0, object arg1)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_whisper(session, string.Format(message, arg0, arg1)));
        }

        public void Whisper(int session, string message, object arg0, object arg1, object arg2)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_whisper(session, string.Format(message, arg0, arg1, arg2)));
        }

        public void Whisper(int session, string message, params object[] args)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_whisper(session, string.Format(message, args)));
        }

        public void ConsoleMessage(int session)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_console_message(session));
        }

        public void BotgramSend()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_botgram_send());
        }
        #endregion

        #region Property methods
        public void Query(int xSector, int zSector, int[,] sequence)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_query(xSector, zSector, sequence));
        }

        public void Query5x5(int xSector, int zSector, int[,] sequence)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_query_5x5(xSector, zSector, sequence));
        }

        public void ObjectQuery()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_object_query());
        }

        public void CellNext()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_cell_next());
        }

        public void ObjectAdd()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_object_add());
        }

        public void ObjectChange()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_object_change());
        }

        public void ObjectDelete()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_object_delete());
        }

        public void ObjectLoad()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_object_load());
        }

        public void DeleteAllObjects()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_delete_all_objects());
        }
        #endregion

        #region Terrain methods
        public void TerrainSet(int x, int z, int texture, int[] heights)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_terrain_set(x, z, heights.Length, texture, heights));
        }

        public void TerrainQuery(int pageX, int pageZ, ulong sequence)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_terrain_query(pageX, pageZ, sequence));
        }

        public void TerrainNext()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_terrain_next());
        }

        public void TerrainDeleteAll()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_terrain_delete_all());
        }

        public void TerrainLoadNode()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_terrain_load_node());
        }
        #endregion

        #region Mover methods
        public void MoverSetState(int id, int state, int modelNum)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_mover_set_state(id, state, modelNum));
        }

        public void MoverSetPosition(int id, int x, int y, int z, int yaw, int pitch, int roll)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_mover_set_position(id, x, y, z, yaw, pitch, roll));
        }

        public void MoverRiderAdd(int id, int session, int dist, int angle, int yDelta, int yawDelta, int pitchDelta)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_mover_rider_add(id, session, dist, angle, yDelta, yawDelta, pitchDelta));
        }

        public void MoverRiderChange(int id, int session, int dist, int angle, int yDelta, int yawDelta, int pitchDelta)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_mover_rider_change(id, session, dist, angle, yDelta, yawDelta, pitchDelta));
        }

        public void MoverRiderDelete(int id, int session)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_mover_rider_delete(id, session));
        }

        public void MoverLinks(int id)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_mover_links(id));
        }
        #endregion

        #region HUD methods
        public void HudCreate()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_hud_create());
        }

        public void HudClick()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_hud_click());
        }

        public void HudDestroy(int session, int id)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_hud_destroy(session, id));
        }

        public void HudClear(int session)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_hud_clear(session));
        }

        public void TrafficCount(out int inTraffic, out int outTraffic)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_traffic_count(out inTraffic, out outTraffic));
        }
        #endregion

        #region CAV manipulation methods
        public void CavRequest(int citizen, int session)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_cav_request(citizen, session));
        }

        public void CavChange()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_cav_change());
        }

        public void CavDelete()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_cav_delete());
        }

        public void WorldCavRequest(int citizen, int session)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_world_cav_request(citizen, session));
        }

        public void WorldCavChange()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_world_cav_change());
        }

        public void WorldCavDelete()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_world_cav_delete());
        }
        #endregion

        #region Universe related methods
        #region Universe management methods
        public void UniverseAttributesChange()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_universe_attributes_change());
        }

        public void UniverseEjectionAdd()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_universe_ejection_add());
        }

        public void UniverseEjectionDelete(int address)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_universe_ejection_delete(address));
        }

        public void UniverseEjectionLookup()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_universe_ejection_lookup());
        }

        public void UniverseEjectionNext()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_universe_ejection_next());
        }

        public void UniverseEjectionPrevious()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_universe_ejection_previous());
        }
        #endregion

        #region Citizen methods
        public void CitizenAttributesByName(string name)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_citizen_attributes_by_name(name));
        }

        public void CitizenAttributesByNumber(int citizen)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_citizen_attributes_by_number(citizen));
        }

        public void CitizenAdd()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_citizen_add());
        }

        public void CitizenChange()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_citizen_change());
        }

        public void CitizenDelete(int citizen)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_citizen_delete(citizen));
        }

        public void CitizenNext()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_citizen_next());
        }

        public void CitizenPrevious()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_citizen_previous());
        }
        #endregion

        #region World license methods
        public void LicenseAdd()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_license_add());
        }

        public void LicenseAttributes(string name)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_license_attributes(name));
        }

        public void LicenseChange()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_license_change());
        }

        public void LicenseDelete(string name)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_license_delete(name));
        }

        public void LicenseNext()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_license_next());
        }

        public void LicensePrevious()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_license_previous());
        }
        #endregion
        #endregion

        #region World related methods
        #region World management methods
        public void WorldAttributesChange()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_world_attributes_change());
        }

        public void WorldEject()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_world_eject());
        }

        public void WorldReloadRegistry()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_world_reload_registry());
        }

        public void WorldAttributesReset()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_world_attributes_reset());
        }

        public void WorldInstanceSet(int citizen, int worldInstance)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_world_instance_set(citizen, worldInstance));
        }

        public void WorldInstanceGet(int citizen)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_world_instance_get(citizen));
        }

        public void WorldAttributesSend(int session)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_world_attributes_send(session));
        }

        public void WorldEjectionAdd()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_world_ejection_add());
        }

        public void WorldEjectionDelete()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_world_ejection_delete());
        }

        public void WorldEjectionLookup()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_world_ejection_lookup());
        }

        public void WorldEjectionNext()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_world_ejection_next());
        }

        public void WorldEjectionPrevious()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_world_ejection_previous());
        }

        public void WorldAttributeSet(int attribute, string value)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_world_attribute_set(attribute, value));
        }

        public void WorldAttributeGet(int attribute, out bool readOnly, string value)
        {
            SetInstance();
            int ro;
            int ret = Importer.aw_world_attribute_get(attribute, out ro, value);
            readOnly = ro != 0;
            InstanceException.Assert(ret);
        }
        #endregion

        #region Rights Checking Methods
        public bool CheckRight(int citizen, string rightString)
        {
            SetInstance();
            return Importer.aw_check_right(citizen, rightString);
        }

        public bool CheckRightAll(string rightString)
        {
            SetInstance();
            return Importer.aw_check_right_all(rightString);
        }

        public bool HasWorldRight(int citizen, Attributes right)
        {
            SetInstance();
            return Importer.aw_has_world_right(citizen, right);
        }

        public bool HasWorldRightAll(Attributes right)
        {
            SetInstance();
            return Importer.aw_has_world_right_all(right);
        }
        #endregion
        #endregion

        #region World server management methods
        public void ServerWorldAdd()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_server_world_add());
        }

        public void ServerWorldDelete(int id)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_server_world_delete(id));
        }

        public void ServerWorldChange(int id)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_server_world_change(id));
        }

        public void ServerWorldList()
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_server_world_list());
        }

        public void ServerWorldStart(int id)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_server_world_start(id));
        }

        public void ServerWorldStop(int id)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_server_world_stop(id));
        }

        public void ServerWorldSet(int id)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_server_world_set(id));
        }

        public void ServerWorldInstanceSet(int id)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_server_world_instance_set(id));
        }

        public void ServerWorldInstanceAdd(int id, int instanceId)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_server_world_instance_add(id, instanceId));
        }

        public void ServerWorldInstanceDelete(int id, int instanceId)
        {
            SetInstance();
            InstanceException.Assert(Importer.aw_server_world_instance_delete(id, instanceId));
        }
        #endregion
    }
}