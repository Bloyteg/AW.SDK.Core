// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
using System;
using System.Runtime.InteropServices;

namespace AW
{
    internal class NativeMethods
    {
        #region Delegates
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void Event();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void Callback(int rc);
        #endregion

        #region Original methods
        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_init(int build);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_init_bind(int build, int addr);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern void aw_term();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true, EntryPoint="aw_createW")]
        public static extern int aw_create(string domain, int port, out IntPtr instance);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_create_resolved(int address, int port, out IntPtr instance);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_destroy();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern IntPtr aw_instance();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_instance_set(IntPtr instance);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_login();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_wait(int milliseconds);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_int(Attributes a);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_int_set(Attributes a, int value);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true, EntryPoint="aw_stringW")]
        public static extern IntPtr aw_string(Attributes a);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true, EntryPoint="aw_string_setW")]
        public static extern int aw_string_set(Attributes a, string value);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_bool(Attributes a);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_bool_set(Attributes a, bool value);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern float aw_float(Attributes a);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_float_set(Attributes a, float value);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern IntPtr aw_data(Attributes a, out int length);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_data_set(Attributes a, IntPtr value, int length);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern Callback aw_callback(AW_CALLBACK c);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_callback_set(AW_CALLBACK c, Callback cb);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_instance_callback_set(AW_CALLBACK c, Callback cb);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern Event aw_event(AW_EVENT a);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_event_set(AW_EVENT a, Event ev);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_instance_event_set(AW_EVENT a, Event ev);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true, EntryPoint="aw_enterW")]
        public static extern int aw_enter(string world);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_exit();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true, EntryPoint="aw_sayW")]
        public static extern int aw_say(string message);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true, EntryPoint="aw_whisperW")]
        public static extern int aw_whisper(int sessionId, string message);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_state_change();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true, EntryPoint="aw_citizen_attributes_by_nameW")]
        public static extern int aw_citizen_attributes_by_name(string name);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_citizen_attributes_by_number(int citizen);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_citizen_add();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_citizen_change();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_citizen_delete(int citizen);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_citizen_next();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_citizen_previous();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_license_add();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true, EntryPoint="aw_license_attributesW")]
        public static extern int aw_license_attributes(string name);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_license_change();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true, EntryPoint="aw_license_deleteW")]
        public static extern int aw_license_delete(string name);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_license_next();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_license_previous();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_world_list();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_object_add();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_object_change();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_object_delete();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_object_load();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_query(int xSector, int zSector, int[,] sequence);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_query_5x5(int xSector, int zSector, int[,] sequence);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_random();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_world_attributes_change();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_universe_attributes_change();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_session();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_world_eject();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_sector_from_cell(int cell);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_universe_ejection_add();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_universe_ejection_delete(int address);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_universe_ejection_lookup();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_universe_ejection_next();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_universe_ejection_previous();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_object_click();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_object_select();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_avatar_click(int sessionId);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_address(int sessionId);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true, EntryPoint="aw_url_sendW")]
        public static extern int aw_url_send(int sessionId, string url, string target);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true, EntryPoint="aw_url_clickW")]
        public static extern int aw_url_click(string url);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_teleport(int sessionId);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_world_ejection_add();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_world_ejection_delete();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_world_ejection_lookup();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_world_ejection_next();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_world_ejection_previous();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true, EntryPoint="aw_world_attribute_setW")]
        public static extern int aw_world_attribute_set(int attribute, string value);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true, EntryPoint="aw_world_attribute_getW")]
        public static extern int aw_world_attribute_get(int attribute, out int readOnly, string value);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_delete_all_objects();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_cell_next();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_world_reload_registry();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_world_attributes_reset();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_terrain_set(int x, int z, int count, int texture, int[] heights);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_terrain_query(int pageX, int pageZ, long sequence);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_terrain_next();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_terrain_delete_all();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_terrain_load_node();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_console_message(int sessionId);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_avatar_set(int sessionId);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_avatar_reload(int citizen, int sessionId);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_world_instance_set(int citizen, int worldInstance);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_world_instance_get(int citizen);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_botgram_send();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_toolbar_click();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_user_list();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_noise(int sessionId);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_world_attributes_send(int sessionId);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_camera_set(int sessionId);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_botmenu_send();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_object_bump();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_traffic_count(out int trafficIn, out int trafficOut);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_tick();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true, EntryPoint="aw_check_rightW")]
        public static extern bool aw_check_right(int citizen, string str);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true, EntryPoint="aw_check_right_allW")]
        public static extern bool aw_check_right_all(string str);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern bool aw_has_world_right(int citizen, Attributes right);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern bool aw_has_world_right_all(Attributes right);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_mover_set_state(int id, int state, int modelNumber);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_mover_set_position(int id, int x, int y, int z, int yaw, int pitch, int roll);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_mover_rider_add(int id, int session, int dist, int angle, int yDelta, int yawDelta, int pitchDelta);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_mover_rider_change(int id, int session, int dist, int angle, int yDelta, int yawDelta, int pitchDelta);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_mover_rider_delete(int id, int session);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_mover_links(int id);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true, EntryPoint="aw_server_adminW")]
        public static extern int aw_server_admin(string domain, int port, string password, out IntPtr instance);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_server_world_add();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_server_world_delete(int id);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_server_world_change(int id);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_server_world_list();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_server_world_start(int id);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_server_world_stop(int id);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_server_world_set(int id);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_server_world_instance_set(int id);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_server_world_instance_add(int id, int instanceId);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_server_world_instance_delete(int id, int instanceId);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true, EntryPoint="aw_avatar_locationW")]
        public static extern int aw_avatar_location(int citizen, int sessionId, string name);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_hud_create();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_hud_click();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_hud_destroy(int session, int id);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_hud_clear(int session);

        #endregion

        #region Build 70 additions
        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_cav_request(int citizen, int session);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_cav_change();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_cav_delete();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_world_cav_request(int citizen, int session);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_world_cav_change();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_world_cav_delete();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_object_query();

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_zip(IntPtr dataOut, out int lengthOut, IntPtr dataIn, int lengthIn);

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_unzip(IntPtr dataOut, out int lengthOut, IntPtr dataIn, int lengthIn);

        #endregion

        #region Build 84 additions

        [DllImport("aw.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int aw_laser_beam();

        #endregion
    }
}
