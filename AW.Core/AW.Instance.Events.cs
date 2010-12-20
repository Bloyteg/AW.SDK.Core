 


	
//This code was auto-generated.  It is not recommended to modify it.
//If you wish to change this code, please update the template associated with it.
using System;
using System.Runtime.InteropServices;

namespace AW
{
	partial interface IInstance
	{
			event InstanceEventDelegate EventAdminWorldInfo;
			event InstanceEventDelegate EventAdminWorldDelete;
			event InstanceEventDelegate EventAvatarAdd;
			event InstanceEventDelegate EventAvatarChange;
			event InstanceEventDelegate EventAvatarDelete;
			event InstanceEventDelegate EventAvatarClick;
			event InstanceEventDelegate EventAvatarReload;
			event InstanceEventDelegate EventBotgram;
			event InstanceEventDelegate EventBotmenu;
			event InstanceEventDelegate EventCellBegin;
			event InstanceEventDelegate EventCellObject;
			event InstanceEventDelegate EventCellEnd;
			event InstanceEventDelegate EventChat;
			event InstanceEventDelegate EventConsoleMessage;
			event InstanceEventDelegate EventEntityAdd;
			event InstanceEventDelegate EventEntityChange;
			event InstanceEventDelegate EventEntityDelete;
			event InstanceEventDelegate EventEntityRiderAdd;
			event InstanceEventDelegate EventEntityRiderChange;
			event InstanceEventDelegate EventEntityRiderDelete;
			event InstanceEventDelegate EventEntityLinks;
			event InstanceEventDelegate EventHudClick;
			event InstanceEventDelegate EventNoise;
			event InstanceEventDelegate EventObjectAdd;
			event InstanceEventDelegate EventObjectDelete;
			event InstanceEventDelegate EventObjectClick;
			event InstanceEventDelegate EventObjectBump;
			event InstanceEventDelegate EventObjectSelect;
			event InstanceEventDelegate EventTeleport;
			event InstanceEventDelegate EventTerrainBegin;
			event InstanceEventDelegate EventTerrainChanged;
			event InstanceEventDelegate EventTerrainData;
			event InstanceEventDelegate EventTerrainEnd;
			event InstanceEventDelegate EventToolbarClick;
			event InstanceEventDelegate EventUniverseAttributes;
			event InstanceEventDelegate EventUniverseDisconnect;
			event InstanceEventDelegate EventUrl;
			event InstanceEventDelegate EventUrlClick;
			event InstanceEventDelegate EventUserInfo;
			event InstanceEventDelegate EventWorldAttributes;
			event InstanceEventDelegate EventWorldDisconnect;
			event InstanceEventDelegate EventWorldInfo;
			event InstanceEventDelegate EventCavDefinitionChange;
			event InstanceEventDelegate EventWorldCavDefinitionChange;
			event InstanceEventDelegate EventLaserBeam;
		}
	
	partial class Instance
	{
		#region EventAdminWorldInfo
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventAdminWorldInfo;
		private InterOp.Event nativeEventAdminWorldInfo;

		//Native event handler.
		private void OnEventAdminWorldInfo()
		{
			//Passes off the event to the managed event handler.
			managedEventAdminWorldInfo(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_ADMIN_WORLD_INFO from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventAdminWorldInfo
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventAdminWorldInfo == null)
				{
					SetInstance();
					nativeEventAdminWorldInfo = new InterOp.Event(OnEventAdminWorldInfo);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_ADMIN_WORLD_INFO, nativeEventAdminWorldInfo);
				}

				managedEventAdminWorldInfo += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventAdminWorldInfo -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventAdminWorldInfo == null)
				{
					SetInstance();
					nativeEventAdminWorldInfo = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_ADMIN_WORLD_INFO, null);
				}
			}
		}
		#endregion
		
		#region EventAdminWorldDelete
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventAdminWorldDelete;
		private InterOp.Event nativeEventAdminWorldDelete;

		//Native event handler.
		private void OnEventAdminWorldDelete()
		{
			//Passes off the event to the managed event handler.
			managedEventAdminWorldDelete(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_ADMIN_WORLD_DELETE from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventAdminWorldDelete
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventAdminWorldDelete == null)
				{
					SetInstance();
					nativeEventAdminWorldDelete = new InterOp.Event(OnEventAdminWorldDelete);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_ADMIN_WORLD_DELETE, nativeEventAdminWorldDelete);
				}

				managedEventAdminWorldDelete += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventAdminWorldDelete -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventAdminWorldDelete == null)
				{
					SetInstance();
					nativeEventAdminWorldDelete = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_ADMIN_WORLD_DELETE, null);
				}
			}
		}
		#endregion
		
		#region EventAvatarAdd
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventAvatarAdd;
		private InterOp.Event nativeEventAvatarAdd;

		//Native event handler.
		private void OnEventAvatarAdd()
		{
			//Passes off the event to the managed event handler.
			managedEventAvatarAdd(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_AVATAR_ADD from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventAvatarAdd
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventAvatarAdd == null)
				{
					SetInstance();
					nativeEventAvatarAdd = new InterOp.Event(OnEventAvatarAdd);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_ADD, nativeEventAvatarAdd);
				}

				managedEventAvatarAdd += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventAvatarAdd -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventAvatarAdd == null)
				{
					SetInstance();
					nativeEventAvatarAdd = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_ADD, null);
				}
			}
		}
		#endregion
		
		#region EventAvatarChange
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventAvatarChange;
		private InterOp.Event nativeEventAvatarChange;

		//Native event handler.
		private void OnEventAvatarChange()
		{
			//Passes off the event to the managed event handler.
			managedEventAvatarChange(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_AVATAR_CHANGE from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventAvatarChange
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventAvatarChange == null)
				{
					SetInstance();
					nativeEventAvatarChange = new InterOp.Event(OnEventAvatarChange);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_CHANGE, nativeEventAvatarChange);
				}

				managedEventAvatarChange += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventAvatarChange -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventAvatarChange == null)
				{
					SetInstance();
					nativeEventAvatarChange = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_CHANGE, null);
				}
			}
		}
		#endregion
		
		#region EventAvatarDelete
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventAvatarDelete;
		private InterOp.Event nativeEventAvatarDelete;

		//Native event handler.
		private void OnEventAvatarDelete()
		{
			//Passes off the event to the managed event handler.
			managedEventAvatarDelete(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_AVATAR_DELETE from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventAvatarDelete
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventAvatarDelete == null)
				{
					SetInstance();
					nativeEventAvatarDelete = new InterOp.Event(OnEventAvatarDelete);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_DELETE, nativeEventAvatarDelete);
				}

				managedEventAvatarDelete += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventAvatarDelete -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventAvatarDelete == null)
				{
					SetInstance();
					nativeEventAvatarDelete = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_DELETE, null);
				}
			}
		}
		#endregion
		
		#region EventAvatarClick
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventAvatarClick;
		private InterOp.Event nativeEventAvatarClick;

		//Native event handler.
		private void OnEventAvatarClick()
		{
			//Passes off the event to the managed event handler.
			managedEventAvatarClick(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_AVATAR_CLICK from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventAvatarClick
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventAvatarClick == null)
				{
					SetInstance();
					nativeEventAvatarClick = new InterOp.Event(OnEventAvatarClick);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_CLICK, nativeEventAvatarClick);
				}

				managedEventAvatarClick += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventAvatarClick -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventAvatarClick == null)
				{
					SetInstance();
					nativeEventAvatarClick = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_CLICK, null);
				}
			}
		}
		#endregion
		
		#region EventAvatarReload
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventAvatarReload;
		private InterOp.Event nativeEventAvatarReload;

		//Native event handler.
		private void OnEventAvatarReload()
		{
			//Passes off the event to the managed event handler.
			managedEventAvatarReload(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_AVATAR_RELOAD from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventAvatarReload
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventAvatarReload == null)
				{
					SetInstance();
					nativeEventAvatarReload = new InterOp.Event(OnEventAvatarReload);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_RELOAD, nativeEventAvatarReload);
				}

				managedEventAvatarReload += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventAvatarReload -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventAvatarReload == null)
				{
					SetInstance();
					nativeEventAvatarReload = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_RELOAD, null);
				}
			}
		}
		#endregion
		
		#region EventBotgram
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventBotgram;
		private InterOp.Event nativeEventBotgram;

		//Native event handler.
		private void OnEventBotgram()
		{
			//Passes off the event to the managed event handler.
			managedEventBotgram(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_BOTGRAM from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventBotgram
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventBotgram == null)
				{
					SetInstance();
					nativeEventBotgram = new InterOp.Event(OnEventBotgram);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_BOTGRAM, nativeEventBotgram);
				}

				managedEventBotgram += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventBotgram -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventBotgram == null)
				{
					SetInstance();
					nativeEventBotgram = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_BOTGRAM, null);
				}
			}
		}
		#endregion
		
		#region EventBotmenu
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventBotmenu;
		private InterOp.Event nativeEventBotmenu;

		//Native event handler.
		private void OnEventBotmenu()
		{
			//Passes off the event to the managed event handler.
			managedEventBotmenu(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_BOTMENU from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventBotmenu
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventBotmenu == null)
				{
					SetInstance();
					nativeEventBotmenu = new InterOp.Event(OnEventBotmenu);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_BOTMENU, nativeEventBotmenu);
				}

				managedEventBotmenu += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventBotmenu -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventBotmenu == null)
				{
					SetInstance();
					nativeEventBotmenu = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_BOTMENU, null);
				}
			}
		}
		#endregion
		
		#region EventCellBegin
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventCellBegin;
		private InterOp.Event nativeEventCellBegin;

		//Native event handler.
		private void OnEventCellBegin()
		{
			//Passes off the event to the managed event handler.
			managedEventCellBegin(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_CELL_BEGIN from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventCellBegin
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventCellBegin == null)
				{
					SetInstance();
					nativeEventCellBegin = new InterOp.Event(OnEventCellBegin);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_CELL_BEGIN, nativeEventCellBegin);
				}

				managedEventCellBegin += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventCellBegin -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventCellBegin == null)
				{
					SetInstance();
					nativeEventCellBegin = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_CELL_BEGIN, null);
				}
			}
		}
		#endregion
		
		#region EventCellObject
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventCellObject;
		private InterOp.Event nativeEventCellObject;

		//Native event handler.
		private void OnEventCellObject()
		{
			//Passes off the event to the managed event handler.
			managedEventCellObject(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_CELL_OBJECT from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventCellObject
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventCellObject == null)
				{
					SetInstance();
					nativeEventCellObject = new InterOp.Event(OnEventCellObject);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_CELL_OBJECT, nativeEventCellObject);
				}

				managedEventCellObject += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventCellObject -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventCellObject == null)
				{
					SetInstance();
					nativeEventCellObject = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_CELL_OBJECT, null);
				}
			}
		}
		#endregion
		
		#region EventCellEnd
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventCellEnd;
		private InterOp.Event nativeEventCellEnd;

		//Native event handler.
		private void OnEventCellEnd()
		{
			//Passes off the event to the managed event handler.
			managedEventCellEnd(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_CELL_END from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventCellEnd
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventCellEnd == null)
				{
					SetInstance();
					nativeEventCellEnd = new InterOp.Event(OnEventCellEnd);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_CELL_END, nativeEventCellEnd);
				}

				managedEventCellEnd += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventCellEnd -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventCellEnd == null)
				{
					SetInstance();
					nativeEventCellEnd = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_CELL_END, null);
				}
			}
		}
		#endregion
		
		#region EventChat
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventChat;
		private InterOp.Event nativeEventChat;

		//Native event handler.
		private void OnEventChat()
		{
			//Passes off the event to the managed event handler.
			managedEventChat(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_CHAT from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventChat
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventChat == null)
				{
					SetInstance();
					nativeEventChat = new InterOp.Event(OnEventChat);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_CHAT, nativeEventChat);
				}

				managedEventChat += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventChat -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventChat == null)
				{
					SetInstance();
					nativeEventChat = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_CHAT, null);
				}
			}
		}
		#endregion
		
		#region EventConsoleMessage
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventConsoleMessage;
		private InterOp.Event nativeEventConsoleMessage;

		//Native event handler.
		private void OnEventConsoleMessage()
		{
			//Passes off the event to the managed event handler.
			managedEventConsoleMessage(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_CONSOLE_MESSAGE from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventConsoleMessage
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventConsoleMessage == null)
				{
					SetInstance();
					nativeEventConsoleMessage = new InterOp.Event(OnEventConsoleMessage);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_CONSOLE_MESSAGE, nativeEventConsoleMessage);
				}

				managedEventConsoleMessage += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventConsoleMessage -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventConsoleMessage == null)
				{
					SetInstance();
					nativeEventConsoleMessage = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_CONSOLE_MESSAGE, null);
				}
			}
		}
		#endregion
		
		#region EventEntityAdd
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventEntityAdd;
		private InterOp.Event nativeEventEntityAdd;

		//Native event handler.
		private void OnEventEntityAdd()
		{
			//Passes off the event to the managed event handler.
			managedEventEntityAdd(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_ENTITY_ADD from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventEntityAdd
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventEntityAdd == null)
				{
					SetInstance();
					nativeEventEntityAdd = new InterOp.Event(OnEventEntityAdd);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_ADD, nativeEventEntityAdd);
				}

				managedEventEntityAdd += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventEntityAdd -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventEntityAdd == null)
				{
					SetInstance();
					nativeEventEntityAdd = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_ADD, null);
				}
			}
		}
		#endregion
		
		#region EventEntityChange
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventEntityChange;
		private InterOp.Event nativeEventEntityChange;

		//Native event handler.
		private void OnEventEntityChange()
		{
			//Passes off the event to the managed event handler.
			managedEventEntityChange(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_ENTITY_CHANGE from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventEntityChange
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventEntityChange == null)
				{
					SetInstance();
					nativeEventEntityChange = new InterOp.Event(OnEventEntityChange);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_CHANGE, nativeEventEntityChange);
				}

				managedEventEntityChange += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventEntityChange -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventEntityChange == null)
				{
					SetInstance();
					nativeEventEntityChange = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_CHANGE, null);
				}
			}
		}
		#endregion
		
		#region EventEntityDelete
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventEntityDelete;
		private InterOp.Event nativeEventEntityDelete;

		//Native event handler.
		private void OnEventEntityDelete()
		{
			//Passes off the event to the managed event handler.
			managedEventEntityDelete(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_ENTITY_DELETE from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventEntityDelete
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventEntityDelete == null)
				{
					SetInstance();
					nativeEventEntityDelete = new InterOp.Event(OnEventEntityDelete);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_DELETE, nativeEventEntityDelete);
				}

				managedEventEntityDelete += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventEntityDelete -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventEntityDelete == null)
				{
					SetInstance();
					nativeEventEntityDelete = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_DELETE, null);
				}
			}
		}
		#endregion
		
		#region EventEntityRiderAdd
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventEntityRiderAdd;
		private InterOp.Event nativeEventEntityRiderAdd;

		//Native event handler.
		private void OnEventEntityRiderAdd()
		{
			//Passes off the event to the managed event handler.
			managedEventEntityRiderAdd(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_ENTITY_RIDER_ADD from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventEntityRiderAdd
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventEntityRiderAdd == null)
				{
					SetInstance();
					nativeEventEntityRiderAdd = new InterOp.Event(OnEventEntityRiderAdd);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_RIDER_ADD, nativeEventEntityRiderAdd);
				}

				managedEventEntityRiderAdd += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventEntityRiderAdd -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventEntityRiderAdd == null)
				{
					SetInstance();
					nativeEventEntityRiderAdd = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_RIDER_ADD, null);
				}
			}
		}
		#endregion
		
		#region EventEntityRiderChange
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventEntityRiderChange;
		private InterOp.Event nativeEventEntityRiderChange;

		//Native event handler.
		private void OnEventEntityRiderChange()
		{
			//Passes off the event to the managed event handler.
			managedEventEntityRiderChange(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_ENTITY_RIDER_CHANGE from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventEntityRiderChange
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventEntityRiderChange == null)
				{
					SetInstance();
					nativeEventEntityRiderChange = new InterOp.Event(OnEventEntityRiderChange);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_RIDER_CHANGE, nativeEventEntityRiderChange);
				}

				managedEventEntityRiderChange += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventEntityRiderChange -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventEntityRiderChange == null)
				{
					SetInstance();
					nativeEventEntityRiderChange = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_RIDER_CHANGE, null);
				}
			}
		}
		#endregion
		
		#region EventEntityRiderDelete
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventEntityRiderDelete;
		private InterOp.Event nativeEventEntityRiderDelete;

		//Native event handler.
		private void OnEventEntityRiderDelete()
		{
			//Passes off the event to the managed event handler.
			managedEventEntityRiderDelete(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_ENTITY_RIDER_DELETE from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventEntityRiderDelete
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventEntityRiderDelete == null)
				{
					SetInstance();
					nativeEventEntityRiderDelete = new InterOp.Event(OnEventEntityRiderDelete);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_RIDER_DELETE, nativeEventEntityRiderDelete);
				}

				managedEventEntityRiderDelete += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventEntityRiderDelete -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventEntityRiderDelete == null)
				{
					SetInstance();
					nativeEventEntityRiderDelete = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_RIDER_DELETE, null);
				}
			}
		}
		#endregion
		
		#region EventEntityLinks
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventEntityLinks;
		private InterOp.Event nativeEventEntityLinks;

		//Native event handler.
		private void OnEventEntityLinks()
		{
			//Passes off the event to the managed event handler.
			managedEventEntityLinks(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_ENTITY_LINKS from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventEntityLinks
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventEntityLinks == null)
				{
					SetInstance();
					nativeEventEntityLinks = new InterOp.Event(OnEventEntityLinks);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_LINKS, nativeEventEntityLinks);
				}

				managedEventEntityLinks += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventEntityLinks -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventEntityLinks == null)
				{
					SetInstance();
					nativeEventEntityLinks = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_LINKS, null);
				}
			}
		}
		#endregion
		
		#region EventHudClick
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventHudClick;
		private InterOp.Event nativeEventHudClick;

		//Native event handler.
		private void OnEventHudClick()
		{
			//Passes off the event to the managed event handler.
			managedEventHudClick(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_HUD_CLICK from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventHudClick
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventHudClick == null)
				{
					SetInstance();
					nativeEventHudClick = new InterOp.Event(OnEventHudClick);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_HUD_CLICK, nativeEventHudClick);
				}

				managedEventHudClick += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventHudClick -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventHudClick == null)
				{
					SetInstance();
					nativeEventHudClick = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_HUD_CLICK, null);
				}
			}
		}
		#endregion
		
		#region EventNoise
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventNoise;
		private InterOp.Event nativeEventNoise;

		//Native event handler.
		private void OnEventNoise()
		{
			//Passes off the event to the managed event handler.
			managedEventNoise(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_NOISE from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventNoise
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventNoise == null)
				{
					SetInstance();
					nativeEventNoise = new InterOp.Event(OnEventNoise);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_NOISE, nativeEventNoise);
				}

				managedEventNoise += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventNoise -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventNoise == null)
				{
					SetInstance();
					nativeEventNoise = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_NOISE, null);
				}
			}
		}
		#endregion
		
		#region EventObjectAdd
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventObjectAdd;
		private InterOp.Event nativeEventObjectAdd;

		//Native event handler.
		private void OnEventObjectAdd()
		{
			//Passes off the event to the managed event handler.
			managedEventObjectAdd(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_OBJECT_ADD from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventObjectAdd
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventObjectAdd == null)
				{
					SetInstance();
					nativeEventObjectAdd = new InterOp.Event(OnEventObjectAdd);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_ADD, nativeEventObjectAdd);
				}

				managedEventObjectAdd += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventObjectAdd -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventObjectAdd == null)
				{
					SetInstance();
					nativeEventObjectAdd = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_ADD, null);
				}
			}
		}
		#endregion
		
		#region EventObjectDelete
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventObjectDelete;
		private InterOp.Event nativeEventObjectDelete;

		//Native event handler.
		private void OnEventObjectDelete()
		{
			//Passes off the event to the managed event handler.
			managedEventObjectDelete(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_OBJECT_DELETE from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventObjectDelete
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventObjectDelete == null)
				{
					SetInstance();
					nativeEventObjectDelete = new InterOp.Event(OnEventObjectDelete);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_DELETE, nativeEventObjectDelete);
				}

				managedEventObjectDelete += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventObjectDelete -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventObjectDelete == null)
				{
					SetInstance();
					nativeEventObjectDelete = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_DELETE, null);
				}
			}
		}
		#endregion
		
		#region EventObjectClick
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventObjectClick;
		private InterOp.Event nativeEventObjectClick;

		//Native event handler.
		private void OnEventObjectClick()
		{
			//Passes off the event to the managed event handler.
			managedEventObjectClick(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_OBJECT_CLICK from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventObjectClick
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventObjectClick == null)
				{
					SetInstance();
					nativeEventObjectClick = new InterOp.Event(OnEventObjectClick);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_CLICK, nativeEventObjectClick);
				}

				managedEventObjectClick += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventObjectClick -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventObjectClick == null)
				{
					SetInstance();
					nativeEventObjectClick = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_CLICK, null);
				}
			}
		}
		#endregion
		
		#region EventObjectBump
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventObjectBump;
		private InterOp.Event nativeEventObjectBump;

		//Native event handler.
		private void OnEventObjectBump()
		{
			//Passes off the event to the managed event handler.
			managedEventObjectBump(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_OBJECT_BUMP from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventObjectBump
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventObjectBump == null)
				{
					SetInstance();
					nativeEventObjectBump = new InterOp.Event(OnEventObjectBump);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_BUMP, nativeEventObjectBump);
				}

				managedEventObjectBump += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventObjectBump -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventObjectBump == null)
				{
					SetInstance();
					nativeEventObjectBump = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_BUMP, null);
				}
			}
		}
		#endregion
		
		#region EventObjectSelect
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventObjectSelect;
		private InterOp.Event nativeEventObjectSelect;

		//Native event handler.
		private void OnEventObjectSelect()
		{
			//Passes off the event to the managed event handler.
			managedEventObjectSelect(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_OBJECT_SELECT from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventObjectSelect
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventObjectSelect == null)
				{
					SetInstance();
					nativeEventObjectSelect = new InterOp.Event(OnEventObjectSelect);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_SELECT, nativeEventObjectSelect);
				}

				managedEventObjectSelect += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventObjectSelect -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventObjectSelect == null)
				{
					SetInstance();
					nativeEventObjectSelect = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_SELECT, null);
				}
			}
		}
		#endregion
		
		#region EventTeleport
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventTeleport;
		private InterOp.Event nativeEventTeleport;

		//Native event handler.
		private void OnEventTeleport()
		{
			//Passes off the event to the managed event handler.
			managedEventTeleport(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_TELEPORT from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventTeleport
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventTeleport == null)
				{
					SetInstance();
					nativeEventTeleport = new InterOp.Event(OnEventTeleport);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_TELEPORT, nativeEventTeleport);
				}

				managedEventTeleport += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventTeleport -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventTeleport == null)
				{
					SetInstance();
					nativeEventTeleport = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_TELEPORT, null);
				}
			}
		}
		#endregion
		
		#region EventTerrainBegin
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventTerrainBegin;
		private InterOp.Event nativeEventTerrainBegin;

		//Native event handler.
		private void OnEventTerrainBegin()
		{
			//Passes off the event to the managed event handler.
			managedEventTerrainBegin(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_TERRAIN_BEGIN from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventTerrainBegin
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventTerrainBegin == null)
				{
					SetInstance();
					nativeEventTerrainBegin = new InterOp.Event(OnEventTerrainBegin);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_TERRAIN_BEGIN, nativeEventTerrainBegin);
				}

				managedEventTerrainBegin += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventTerrainBegin -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventTerrainBegin == null)
				{
					SetInstance();
					nativeEventTerrainBegin = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_TERRAIN_BEGIN, null);
				}
			}
		}
		#endregion
		
		#region EventTerrainChanged
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventTerrainChanged;
		private InterOp.Event nativeEventTerrainChanged;

		//Native event handler.
		private void OnEventTerrainChanged()
		{
			//Passes off the event to the managed event handler.
			managedEventTerrainChanged(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_TERRAIN_CHANGED from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventTerrainChanged
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventTerrainChanged == null)
				{
					SetInstance();
					nativeEventTerrainChanged = new InterOp.Event(OnEventTerrainChanged);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_TERRAIN_CHANGED, nativeEventTerrainChanged);
				}

				managedEventTerrainChanged += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventTerrainChanged -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventTerrainChanged == null)
				{
					SetInstance();
					nativeEventTerrainChanged = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_TERRAIN_CHANGED, null);
				}
			}
		}
		#endregion
		
		#region EventTerrainData
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventTerrainData;
		private InterOp.Event nativeEventTerrainData;

		//Native event handler.
		private void OnEventTerrainData()
		{
			//Passes off the event to the managed event handler.
			managedEventTerrainData(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_TERRAIN_DATA from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventTerrainData
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventTerrainData == null)
				{
					SetInstance();
					nativeEventTerrainData = new InterOp.Event(OnEventTerrainData);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_TERRAIN_DATA, nativeEventTerrainData);
				}

				managedEventTerrainData += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventTerrainData -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventTerrainData == null)
				{
					SetInstance();
					nativeEventTerrainData = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_TERRAIN_DATA, null);
				}
			}
		}
		#endregion
		
		#region EventTerrainEnd
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventTerrainEnd;
		private InterOp.Event nativeEventTerrainEnd;

		//Native event handler.
		private void OnEventTerrainEnd()
		{
			//Passes off the event to the managed event handler.
			managedEventTerrainEnd(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_TERRAIN_END from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventTerrainEnd
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventTerrainEnd == null)
				{
					SetInstance();
					nativeEventTerrainEnd = new InterOp.Event(OnEventTerrainEnd);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_TERRAIN_END, nativeEventTerrainEnd);
				}

				managedEventTerrainEnd += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventTerrainEnd -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventTerrainEnd == null)
				{
					SetInstance();
					nativeEventTerrainEnd = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_TERRAIN_END, null);
				}
			}
		}
		#endregion
		
		#region EventToolbarClick
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventToolbarClick;
		private InterOp.Event nativeEventToolbarClick;

		//Native event handler.
		private void OnEventToolbarClick()
		{
			//Passes off the event to the managed event handler.
			managedEventToolbarClick(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_TOOLBAR_CLICK from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventToolbarClick
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventToolbarClick == null)
				{
					SetInstance();
					nativeEventToolbarClick = new InterOp.Event(OnEventToolbarClick);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_TOOLBAR_CLICK, nativeEventToolbarClick);
				}

				managedEventToolbarClick += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventToolbarClick -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventToolbarClick == null)
				{
					SetInstance();
					nativeEventToolbarClick = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_TOOLBAR_CLICK, null);
				}
			}
		}
		#endregion
		
		#region EventUniverseAttributes
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventUniverseAttributes;
		private InterOp.Event nativeEventUniverseAttributes;

		//Native event handler.
		private void OnEventUniverseAttributes()
		{
			//Passes off the event to the managed event handler.
			managedEventUniverseAttributes(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_UNIVERSE_ATTRIBUTES from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventUniverseAttributes
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventUniverseAttributes == null)
				{
					SetInstance();
					nativeEventUniverseAttributes = new InterOp.Event(OnEventUniverseAttributes);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_UNIVERSE_ATTRIBUTES, nativeEventUniverseAttributes);
				}

				managedEventUniverseAttributes += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventUniverseAttributes -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventUniverseAttributes == null)
				{
					SetInstance();
					nativeEventUniverseAttributes = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_UNIVERSE_ATTRIBUTES, null);
				}
			}
		}
		#endregion
		
		#region EventUniverseDisconnect
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventUniverseDisconnect;
		private InterOp.Event nativeEventUniverseDisconnect;

		//Native event handler.
		private void OnEventUniverseDisconnect()
		{
			//Passes off the event to the managed event handler.
			managedEventUniverseDisconnect(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_UNIVERSE_DISCONNECT from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventUniverseDisconnect
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventUniverseDisconnect == null)
				{
					SetInstance();
					nativeEventUniverseDisconnect = new InterOp.Event(OnEventUniverseDisconnect);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_UNIVERSE_DISCONNECT, nativeEventUniverseDisconnect);
				}

				managedEventUniverseDisconnect += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventUniverseDisconnect -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventUniverseDisconnect == null)
				{
					SetInstance();
					nativeEventUniverseDisconnect = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_UNIVERSE_DISCONNECT, null);
				}
			}
		}
		#endregion
		
		#region EventUrl
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventUrl;
		private InterOp.Event nativeEventUrl;

		//Native event handler.
		private void OnEventUrl()
		{
			//Passes off the event to the managed event handler.
			managedEventUrl(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_URL from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventUrl
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventUrl == null)
				{
					SetInstance();
					nativeEventUrl = new InterOp.Event(OnEventUrl);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_URL, nativeEventUrl);
				}

				managedEventUrl += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventUrl -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventUrl == null)
				{
					SetInstance();
					nativeEventUrl = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_URL, null);
				}
			}
		}
		#endregion
		
		#region EventUrlClick
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventUrlClick;
		private InterOp.Event nativeEventUrlClick;

		//Native event handler.
		private void OnEventUrlClick()
		{
			//Passes off the event to the managed event handler.
			managedEventUrlClick(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_URL_CLICK from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventUrlClick
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventUrlClick == null)
				{
					SetInstance();
					nativeEventUrlClick = new InterOp.Event(OnEventUrlClick);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_URL_CLICK, nativeEventUrlClick);
				}

				managedEventUrlClick += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventUrlClick -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventUrlClick == null)
				{
					SetInstance();
					nativeEventUrlClick = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_URL_CLICK, null);
				}
			}
		}
		#endregion
		
		#region EventUserInfo
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventUserInfo;
		private InterOp.Event nativeEventUserInfo;

		//Native event handler.
		private void OnEventUserInfo()
		{
			//Passes off the event to the managed event handler.
			managedEventUserInfo(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_USER_INFO from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventUserInfo
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventUserInfo == null)
				{
					SetInstance();
					nativeEventUserInfo = new InterOp.Event(OnEventUserInfo);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_USER_INFO, nativeEventUserInfo);
				}

				managedEventUserInfo += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventUserInfo -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventUserInfo == null)
				{
					SetInstance();
					nativeEventUserInfo = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_USER_INFO, null);
				}
			}
		}
		#endregion
		
		#region EventWorldAttributes
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventWorldAttributes;
		private InterOp.Event nativeEventWorldAttributes;

		//Native event handler.
		private void OnEventWorldAttributes()
		{
			//Passes off the event to the managed event handler.
			managedEventWorldAttributes(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_WORLD_ATTRIBUTES from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventWorldAttributes
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventWorldAttributes == null)
				{
					SetInstance();
					nativeEventWorldAttributes = new InterOp.Event(OnEventWorldAttributes);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_WORLD_ATTRIBUTES, nativeEventWorldAttributes);
				}

				managedEventWorldAttributes += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventWorldAttributes -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventWorldAttributes == null)
				{
					SetInstance();
					nativeEventWorldAttributes = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_WORLD_ATTRIBUTES, null);
				}
			}
		}
		#endregion
		
		#region EventWorldDisconnect
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventWorldDisconnect;
		private InterOp.Event nativeEventWorldDisconnect;

		//Native event handler.
		private void OnEventWorldDisconnect()
		{
			//Passes off the event to the managed event handler.
			managedEventWorldDisconnect(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_WORLD_DISCONNECT from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventWorldDisconnect
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventWorldDisconnect == null)
				{
					SetInstance();
					nativeEventWorldDisconnect = new InterOp.Event(OnEventWorldDisconnect);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_WORLD_DISCONNECT, nativeEventWorldDisconnect);
				}

				managedEventWorldDisconnect += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventWorldDisconnect -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventWorldDisconnect == null)
				{
					SetInstance();
					nativeEventWorldDisconnect = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_WORLD_DISCONNECT, null);
				}
			}
		}
		#endregion
		
		#region EventWorldInfo
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventWorldInfo;
		private InterOp.Event nativeEventWorldInfo;

		//Native event handler.
		private void OnEventWorldInfo()
		{
			//Passes off the event to the managed event handler.
			managedEventWorldInfo(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_WORLD_INFO from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventWorldInfo
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventWorldInfo == null)
				{
					SetInstance();
					nativeEventWorldInfo = new InterOp.Event(OnEventWorldInfo);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_WORLD_INFO, nativeEventWorldInfo);
				}

				managedEventWorldInfo += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventWorldInfo -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventWorldInfo == null)
				{
					SetInstance();
					nativeEventWorldInfo = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_WORLD_INFO, null);
				}
			}
		}
		#endregion
		
		#region EventCavDefinitionChange
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventCavDefinitionChange;
		private InterOp.Event nativeEventCavDefinitionChange;

		//Native event handler.
		private void OnEventCavDefinitionChange()
		{
			//Passes off the event to the managed event handler.
			managedEventCavDefinitionChange(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_CAV_DEFINITION_CHANGE from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventCavDefinitionChange
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventCavDefinitionChange == null)
				{
					SetInstance();
					nativeEventCavDefinitionChange = new InterOp.Event(OnEventCavDefinitionChange);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_CAV_DEFINITION_CHANGE, nativeEventCavDefinitionChange);
				}

				managedEventCavDefinitionChange += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventCavDefinitionChange -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventCavDefinitionChange == null)
				{
					SetInstance();
					nativeEventCavDefinitionChange = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_CAV_DEFINITION_CHANGE, null);
				}
			}
		}
		#endregion
		
		#region EventWorldCavDefinitionChange
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventWorldCavDefinitionChange;
		private InterOp.Event nativeEventWorldCavDefinitionChange;

		//Native event handler.
		private void OnEventWorldCavDefinitionChange()
		{
			//Passes off the event to the managed event handler.
			managedEventWorldCavDefinitionChange(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_WORLD_CAV_DEFINITION_CHANGE from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventWorldCavDefinitionChange
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventWorldCavDefinitionChange == null)
				{
					SetInstance();
					nativeEventWorldCavDefinitionChange = new InterOp.Event(OnEventWorldCavDefinitionChange);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_WORLD_CAV_DEFINITION_CHANGE, nativeEventWorldCavDefinitionChange);
				}

				managedEventWorldCavDefinitionChange += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventWorldCavDefinitionChange -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventWorldCavDefinitionChange == null)
				{
					SetInstance();
					nativeEventWorldCavDefinitionChange = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_WORLD_CAV_DEFINITION_CHANGE, null);
				}
			}
		}
		#endregion
		
		#region EventLaserBeam
		//Declare the types to handle both the managed and native events.
		private InstanceEventDelegate managedEventLaserBeam;
		private InterOp.Event nativeEventLaserBeam;

		//Native event handler.
		private void OnEventLaserBeam()
		{
			//Passes off the event to the managed event handler.
			managedEventLaserBeam(this);
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_LASER_BEAM from the C SDK.
		/// </summary>
		public event InstanceEventDelegate EventLaserBeam
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventLaserBeam == null)
				{
					SetInstance();
					nativeEventLaserBeam = new InterOp.Event(OnEventLaserBeam);
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_LASER_BEAM, nativeEventLaserBeam);
				}

				managedEventLaserBeam += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				managedEventLaserBeam -= value;

				//If the event is null, remove the native event for the instance.
				if (managedEventLaserBeam == null)
				{
					SetInstance();
					nativeEventLaserBeam = null;
					InterOp.aw_instance_event_set(AW_EVENT.AW_EVENT_LASER_BEAM, null);
				}
			}
		}
		#endregion
		
	}
}