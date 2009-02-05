//This code was auto-generated.  It is not recommended to modify it.
//If you wish to change this code, please update the template associated with it.
using System;
using System.Runtime.InteropServices;

namespace AW
{
	partial class Instance
	{
	
		#region EventAdminWorldInfo
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventAdminWorldInfo;
		private Importer.Event nativeEventAdminWorldInfo;
	
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
		public event Event EventAdminWorldInfo
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventAdminWorldInfo == null)
				{
					SetInstance();
					nativeEventAdminWorldInfo = new Importer.Event(OnEventAdminWorldInfo);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_ADMIN_WORLD_INFO, nativeEventAdminWorldInfo);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_ADMIN_WORLD_INFO, null);
				}
			}
		}
		#endregion
		
		#region EventAdminWorldDelete
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventAdminWorldDelete;
		private Importer.Event nativeEventAdminWorldDelete;
	
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
		public event Event EventAdminWorldDelete
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventAdminWorldDelete == null)
				{
					SetInstance();
					nativeEventAdminWorldDelete = new Importer.Event(OnEventAdminWorldDelete);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_ADMIN_WORLD_DELETE, nativeEventAdminWorldDelete);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_ADMIN_WORLD_DELETE, null);
				}
			}
		}
		#endregion
		
		#region EventAvatarAdd
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventAvatarAdd;
		private Importer.Event nativeEventAvatarAdd;
	
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
		public event Event EventAvatarAdd
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventAvatarAdd == null)
				{
					SetInstance();
					nativeEventAvatarAdd = new Importer.Event(OnEventAvatarAdd);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_ADD, nativeEventAvatarAdd);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_ADD, null);
				}
			}
		}
		#endregion
		
		#region EventAvatarChange
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventAvatarChange;
		private Importer.Event nativeEventAvatarChange;
	
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
		public event Event EventAvatarChange
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventAvatarChange == null)
				{
					SetInstance();
					nativeEventAvatarChange = new Importer.Event(OnEventAvatarChange);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_CHANGE, nativeEventAvatarChange);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_CHANGE, null);
				}
			}
		}
		#endregion
		
		#region EventAvatarDelete
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventAvatarDelete;
		private Importer.Event nativeEventAvatarDelete;
	
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
		public event Event EventAvatarDelete
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventAvatarDelete == null)
				{
					SetInstance();
					nativeEventAvatarDelete = new Importer.Event(OnEventAvatarDelete);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_DELETE, nativeEventAvatarDelete);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_DELETE, null);
				}
			}
		}
		#endregion
		
		#region EventAvatarClick
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventAvatarClick;
		private Importer.Event nativeEventAvatarClick;
	
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
		public event Event EventAvatarClick
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventAvatarClick == null)
				{
					SetInstance();
					nativeEventAvatarClick = new Importer.Event(OnEventAvatarClick);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_CLICK, nativeEventAvatarClick);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_CLICK, null);
				}
			}
		}
		#endregion
		
		#region EventAvatarReload
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventAvatarReload;
		private Importer.Event nativeEventAvatarReload;
	
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
		public event Event EventAvatarReload
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventAvatarReload == null)
				{
					SetInstance();
					nativeEventAvatarReload = new Importer.Event(OnEventAvatarReload);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_RELOAD, nativeEventAvatarReload);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_RELOAD, null);
				}
			}
		}
		#endregion
		
		#region EventBotgram
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventBotgram;
		private Importer.Event nativeEventBotgram;
	
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
		public event Event EventBotgram
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventBotgram == null)
				{
					SetInstance();
					nativeEventBotgram = new Importer.Event(OnEventBotgram);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_BOTGRAM, nativeEventBotgram);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_BOTGRAM, null);
				}
			}
		}
		#endregion
		
		#region EventBotmenu
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventBotmenu;
		private Importer.Event nativeEventBotmenu;
	
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
		public event Event EventBotmenu
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventBotmenu == null)
				{
					SetInstance();
					nativeEventBotmenu = new Importer.Event(OnEventBotmenu);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_BOTMENU, nativeEventBotmenu);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_BOTMENU, null);
				}
			}
		}
		#endregion
		
		#region EventCellBegin
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventCellBegin;
		private Importer.Event nativeEventCellBegin;
	
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
		public event Event EventCellBegin
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventCellBegin == null)
				{
					SetInstance();
					nativeEventCellBegin = new Importer.Event(OnEventCellBegin);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_CELL_BEGIN, nativeEventCellBegin);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_CELL_BEGIN, null);
				}
			}
		}
		#endregion
		
		#region EventCellObject
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventCellObject;
		private Importer.Event nativeEventCellObject;
	
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
		public event Event EventCellObject
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventCellObject == null)
				{
					SetInstance();
					nativeEventCellObject = new Importer.Event(OnEventCellObject);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_CELL_OBJECT, nativeEventCellObject);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_CELL_OBJECT, null);
				}
			}
		}
		#endregion
		
		#region EventCellEnd
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventCellEnd;
		private Importer.Event nativeEventCellEnd;
	
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
		public event Event EventCellEnd
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventCellEnd == null)
				{
					SetInstance();
					nativeEventCellEnd = new Importer.Event(OnEventCellEnd);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_CELL_END, nativeEventCellEnd);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_CELL_END, null);
				}
			}
		}
		#endregion
		
		#region EventChat
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventChat;
		private Importer.Event nativeEventChat;
	
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
		public event Event EventChat
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventChat == null)
				{
					SetInstance();
					nativeEventChat = new Importer.Event(OnEventChat);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_CHAT, nativeEventChat);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_CHAT, null);
				}
			}
		}
		#endregion
		
		#region EventConsoleMessage
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventConsoleMessage;
		private Importer.Event nativeEventConsoleMessage;
	
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
		public event Event EventConsoleMessage
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventConsoleMessage == null)
				{
					SetInstance();
					nativeEventConsoleMessage = new Importer.Event(OnEventConsoleMessage);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_CONSOLE_MESSAGE, nativeEventConsoleMessage);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_CONSOLE_MESSAGE, null);
				}
			}
		}
		#endregion
		
		#region EventEntityAdd
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventEntityAdd;
		private Importer.Event nativeEventEntityAdd;
	
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
		public event Event EventEntityAdd
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventEntityAdd == null)
				{
					SetInstance();
					nativeEventEntityAdd = new Importer.Event(OnEventEntityAdd);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_ADD, nativeEventEntityAdd);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_ADD, null);
				}
			}
		}
		#endregion
		
		#region EventEntityChange
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventEntityChange;
		private Importer.Event nativeEventEntityChange;
	
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
		public event Event EventEntityChange
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventEntityChange == null)
				{
					SetInstance();
					nativeEventEntityChange = new Importer.Event(OnEventEntityChange);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_CHANGE, nativeEventEntityChange);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_CHANGE, null);
				}
			}
		}
		#endregion
		
		#region EventEntityDelete
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventEntityDelete;
		private Importer.Event nativeEventEntityDelete;
	
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
		public event Event EventEntityDelete
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventEntityDelete == null)
				{
					SetInstance();
					nativeEventEntityDelete = new Importer.Event(OnEventEntityDelete);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_DELETE, nativeEventEntityDelete);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_DELETE, null);
				}
			}
		}
		#endregion
		
		#region EventEntityRiderAdd
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventEntityRiderAdd;
		private Importer.Event nativeEventEntityRiderAdd;
	
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
		public event Event EventEntityRiderAdd
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventEntityRiderAdd == null)
				{
					SetInstance();
					nativeEventEntityRiderAdd = new Importer.Event(OnEventEntityRiderAdd);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_RIDER_ADD, nativeEventEntityRiderAdd);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_RIDER_ADD, null);
				}
			}
		}
		#endregion
		
		#region EventEntityRiderChange
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventEntityRiderChange;
		private Importer.Event nativeEventEntityRiderChange;
	
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
		public event Event EventEntityRiderChange
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventEntityRiderChange == null)
				{
					SetInstance();
					nativeEventEntityRiderChange = new Importer.Event(OnEventEntityRiderChange);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_RIDER_CHANGE, nativeEventEntityRiderChange);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_RIDER_CHANGE, null);
				}
			}
		}
		#endregion
		
		#region EventEntityRiderDelete
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventEntityRiderDelete;
		private Importer.Event nativeEventEntityRiderDelete;
	
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
		public event Event EventEntityRiderDelete
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventEntityRiderDelete == null)
				{
					SetInstance();
					nativeEventEntityRiderDelete = new Importer.Event(OnEventEntityRiderDelete);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_RIDER_DELETE, nativeEventEntityRiderDelete);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_RIDER_DELETE, null);
				}
			}
		}
		#endregion
		
		#region EventEntityLinks
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventEntityLinks;
		private Importer.Event nativeEventEntityLinks;
	
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
		public event Event EventEntityLinks
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventEntityLinks == null)
				{
					SetInstance();
					nativeEventEntityLinks = new Importer.Event(OnEventEntityLinks);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_LINKS, nativeEventEntityLinks);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_LINKS, null);
				}
			}
		}
		#endregion
		
		#region EventHudClick
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventHudClick;
		private Importer.Event nativeEventHudClick;
	
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
		public event Event EventHudClick
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventHudClick == null)
				{
					SetInstance();
					nativeEventHudClick = new Importer.Event(OnEventHudClick);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_HUD_CLICK, nativeEventHudClick);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_HUD_CLICK, null);
				}
			}
		}
		#endregion
		
		#region EventNoise
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventNoise;
		private Importer.Event nativeEventNoise;
	
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
		public event Event EventNoise
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventNoise == null)
				{
					SetInstance();
					nativeEventNoise = new Importer.Event(OnEventNoise);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_NOISE, nativeEventNoise);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_NOISE, null);
				}
			}
		}
		#endregion
		
		#region EventObjectAdd
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventObjectAdd;
		private Importer.Event nativeEventObjectAdd;
	
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
		public event Event EventObjectAdd
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventObjectAdd == null)
				{
					SetInstance();
					nativeEventObjectAdd = new Importer.Event(OnEventObjectAdd);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_ADD, nativeEventObjectAdd);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_ADD, null);
				}
			}
		}
		#endregion
		
		#region EventObjectDelete
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventObjectDelete;
		private Importer.Event nativeEventObjectDelete;
	
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
		public event Event EventObjectDelete
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventObjectDelete == null)
				{
					SetInstance();
					nativeEventObjectDelete = new Importer.Event(OnEventObjectDelete);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_DELETE, nativeEventObjectDelete);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_DELETE, null);
				}
			}
		}
		#endregion
		
		#region EventObjectClick
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventObjectClick;
		private Importer.Event nativeEventObjectClick;
	
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
		public event Event EventObjectClick
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventObjectClick == null)
				{
					SetInstance();
					nativeEventObjectClick = new Importer.Event(OnEventObjectClick);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_CLICK, nativeEventObjectClick);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_CLICK, null);
				}
			}
		}
		#endregion
		
		#region EventObjectBump
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventObjectBump;
		private Importer.Event nativeEventObjectBump;
	
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
		public event Event EventObjectBump
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventObjectBump == null)
				{
					SetInstance();
					nativeEventObjectBump = new Importer.Event(OnEventObjectBump);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_BUMP, nativeEventObjectBump);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_BUMP, null);
				}
			}
		}
		#endregion
		
		#region EventObjectSelect
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventObjectSelect;
		private Importer.Event nativeEventObjectSelect;
	
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
		public event Event EventObjectSelect
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventObjectSelect == null)
				{
					SetInstance();
					nativeEventObjectSelect = new Importer.Event(OnEventObjectSelect);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_SELECT, nativeEventObjectSelect);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_SELECT, null);
				}
			}
		}
		#endregion
		
		#region EventTeleport
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventTeleport;
		private Importer.Event nativeEventTeleport;
	
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
		public event Event EventTeleport
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventTeleport == null)
				{
					SetInstance();
					nativeEventTeleport = new Importer.Event(OnEventTeleport);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_TELEPORT, nativeEventTeleport);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_TELEPORT, null);
				}
			}
		}
		#endregion
		
		#region EventTerrainBegin
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventTerrainBegin;
		private Importer.Event nativeEventTerrainBegin;
	
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
		public event Event EventTerrainBegin
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventTerrainBegin == null)
				{
					SetInstance();
					nativeEventTerrainBegin = new Importer.Event(OnEventTerrainBegin);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_TERRAIN_BEGIN, nativeEventTerrainBegin);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_TERRAIN_BEGIN, null);
				}
			}
		}
		#endregion
		
		#region EventTerrainChanged
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventTerrainChanged;
		private Importer.Event nativeEventTerrainChanged;
	
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
		public event Event EventTerrainChanged
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventTerrainChanged == null)
				{
					SetInstance();
					nativeEventTerrainChanged = new Importer.Event(OnEventTerrainChanged);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_TERRAIN_CHANGED, nativeEventTerrainChanged);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_TERRAIN_CHANGED, null);
				}
			}
		}
		#endregion
		
		#region EventTerrainData
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventTerrainData;
		private Importer.Event nativeEventTerrainData;
	
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
		public event Event EventTerrainData
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventTerrainData == null)
				{
					SetInstance();
					nativeEventTerrainData = new Importer.Event(OnEventTerrainData);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_TERRAIN_DATA, nativeEventTerrainData);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_TERRAIN_DATA, null);
				}
			}
		}
		#endregion
		
		#region EventTerrainEnd
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventTerrainEnd;
		private Importer.Event nativeEventTerrainEnd;
	
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
		public event Event EventTerrainEnd
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventTerrainEnd == null)
				{
					SetInstance();
					nativeEventTerrainEnd = new Importer.Event(OnEventTerrainEnd);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_TERRAIN_END, nativeEventTerrainEnd);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_TERRAIN_END, null);
				}
			}
		}
		#endregion
		
		#region EventToolbarClick
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventToolbarClick;
		private Importer.Event nativeEventToolbarClick;
	
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
		public event Event EventToolbarClick
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventToolbarClick == null)
				{
					SetInstance();
					nativeEventToolbarClick = new Importer.Event(OnEventToolbarClick);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_TOOLBAR_CLICK, nativeEventToolbarClick);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_TOOLBAR_CLICK, null);
				}
			}
		}
		#endregion
		
		#region EventUniverseAttributes
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventUniverseAttributes;
		private Importer.Event nativeEventUniverseAttributes;
	
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
		public event Event EventUniverseAttributes
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventUniverseAttributes == null)
				{
					SetInstance();
					nativeEventUniverseAttributes = new Importer.Event(OnEventUniverseAttributes);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_UNIVERSE_ATTRIBUTES, nativeEventUniverseAttributes);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_UNIVERSE_ATTRIBUTES, null);
				}
			}
		}
		#endregion
		
		#region EventUniverseDisconnect
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventUniverseDisconnect;
		private Importer.Event nativeEventUniverseDisconnect;
	
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
		public event Event EventUniverseDisconnect
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventUniverseDisconnect == null)
				{
					SetInstance();
					nativeEventUniverseDisconnect = new Importer.Event(OnEventUniverseDisconnect);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_UNIVERSE_DISCONNECT, nativeEventUniverseDisconnect);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_UNIVERSE_DISCONNECT, null);
				}
			}
		}
		#endregion
		
		#region EventUrl
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventUrl;
		private Importer.Event nativeEventUrl;
	
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
		public event Event EventUrl
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventUrl == null)
				{
					SetInstance();
					nativeEventUrl = new Importer.Event(OnEventUrl);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_URL, nativeEventUrl);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_URL, null);
				}
			}
		}
		#endregion
		
		#region EventUrlClick
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventUrlClick;
		private Importer.Event nativeEventUrlClick;
	
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
		public event Event EventUrlClick
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventUrlClick == null)
				{
					SetInstance();
					nativeEventUrlClick = new Importer.Event(OnEventUrlClick);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_URL_CLICK, nativeEventUrlClick);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_URL_CLICK, null);
				}
			}
		}
		#endregion
		
		#region EventUserInfo
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventUserInfo;
		private Importer.Event nativeEventUserInfo;
	
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
		public event Event EventUserInfo
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventUserInfo == null)
				{
					SetInstance();
					nativeEventUserInfo = new Importer.Event(OnEventUserInfo);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_USER_INFO, nativeEventUserInfo);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_USER_INFO, null);
				}
			}
		}
		#endregion
		
		#region EventWorldAttributes
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventWorldAttributes;
		private Importer.Event nativeEventWorldAttributes;
	
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
		public event Event EventWorldAttributes
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventWorldAttributes == null)
				{
					SetInstance();
					nativeEventWorldAttributes = new Importer.Event(OnEventWorldAttributes);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_WORLD_ATTRIBUTES, nativeEventWorldAttributes);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_WORLD_ATTRIBUTES, null);
				}
			}
		}
		#endregion
		
		#region EventWorldDisconnect
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventWorldDisconnect;
		private Importer.Event nativeEventWorldDisconnect;
	
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
		public event Event EventWorldDisconnect
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventWorldDisconnect == null)
				{
					SetInstance();
					nativeEventWorldDisconnect = new Importer.Event(OnEventWorldDisconnect);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_WORLD_DISCONNECT, nativeEventWorldDisconnect);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_WORLD_DISCONNECT, null);
				}
			}
		}
		#endregion
		
		#region EventWorldInfo
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventWorldInfo;
		private Importer.Event nativeEventWorldInfo;
	
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
		public event Event EventWorldInfo
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventWorldInfo == null)
				{
					SetInstance();
					nativeEventWorldInfo = new Importer.Event(OnEventWorldInfo);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_WORLD_INFO, nativeEventWorldInfo);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_WORLD_INFO, null);
				}
			}
		}
		#endregion
		
		#region EventCavDefinitionChange
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventCavDefinitionChange;
		private Importer.Event nativeEventCavDefinitionChange;
	
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
		public event Event EventCavDefinitionChange
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventCavDefinitionChange == null)
				{
					SetInstance();
					nativeEventCavDefinitionChange = new Importer.Event(OnEventCavDefinitionChange);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_CAV_DEFINITION_CHANGE, nativeEventCavDefinitionChange);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_CAV_DEFINITION_CHANGE, null);
				}
			}
		}
		#endregion
		
		#region EventWorldCavDefinitionChange
		//Declare the types to handle both the managed and native events.
		private Instance.Event managedEventWorldCavDefinitionChange;
		private Importer.Event nativeEventWorldCavDefinitionChange;
	
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
		public event Event EventWorldCavDefinitionChange
		{
			//Handles hooking a new delegate to the event.
			add
			{
				//If the event is null, set the native event for the instance.
				if (managedEventWorldCavDefinitionChange == null)
				{
					SetInstance();
					nativeEventWorldCavDefinitionChange = new Importer.Event(OnEventWorldCavDefinitionChange);
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_WORLD_CAV_DEFINITION_CHANGE, nativeEventWorldCavDefinitionChange);
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
					Importer.aw_instance_event_set(AW_EVENT.AW_EVENT_WORLD_CAV_DEFINITION_CHANGE, null);
				}
			}
		}
		#endregion
		
	}
}