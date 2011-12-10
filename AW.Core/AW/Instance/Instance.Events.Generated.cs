 


	
//This code was auto-generated.  It is not recommended to modify it.
//If you wish to change this code, please update the template associated with it.
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Utilities;

namespace AW
{
	partial interface IInstance
	{
			event InstanceEventHandler EventAdminWorldInfo;
			event InstanceEventHandler EventAdminWorldDelete;
			event InstanceEventHandler EventAvatarAdd;
			event InstanceEventHandler EventAvatarChange;
			event InstanceEventHandler EventAvatarDelete;
			event InstanceEventHandler EventAvatarClick;
			event InstanceEventHandler EventAvatarReload;
			event InstanceEventHandler EventBotgram;
			event InstanceEventHandler EventBotmenu;
			event InstanceEventHandler EventCellBegin;
			event InstanceEventHandler EventCellObject;
			event InstanceEventHandler EventCellEnd;
			event InstanceEventHandler EventChat;
			event InstanceEventHandler EventConsoleMessage;
			event InstanceEventHandler EventEntityAdd;
			event InstanceEventHandler EventEntityChange;
			event InstanceEventHandler EventEntityDelete;
			event InstanceEventHandler EventEntityRiderAdd;
			event InstanceEventHandler EventEntityRiderChange;
			event InstanceEventHandler EventEntityRiderDelete;
			event InstanceEventHandler EventEntityLinks;
			event InstanceEventHandler EventHudClick;
			event InstanceEventHandler EventNoise;
			event InstanceEventHandler EventObjectAdd;
			event InstanceEventHandler EventObjectDelete;
			event InstanceEventHandler EventObjectClick;
			event InstanceEventHandler EventObjectBump;
			event InstanceEventHandler EventObjectSelect;
			event InstanceEventHandler EventTeleport;
			event InstanceEventHandler EventTerrainBegin;
			event InstanceEventHandler EventTerrainChanged;
			event InstanceEventHandler EventTerrainData;
			event InstanceEventHandler EventTerrainEnd;
			event InstanceEventHandler EventToolbarClick;
			event InstanceEventHandler EventUniverseAttributes;
			event InstanceEventHandler EventUniverseDisconnect;
			event InstanceEventHandler EventUrl;
			event InstanceEventHandler EventUrlClick;
			event InstanceEventHandler EventUserInfo;
			event InstanceEventHandler EventWorldAttributes;
			event InstanceEventHandler EventWorldDisconnect;
			event InstanceEventHandler EventWorldInfo;
			event InstanceEventHandler EventCavDefinitionChange;
			event InstanceEventHandler EventWorldCavDefinitionChange;
			event InstanceEventHandler EventLaserBeam;
		}
	
	partial class Instance
	{
	private readonly Dictionary<string, EventDelegates> _eventHandlers = new Dictionary<string, EventDelegates>();
	
		
	#region EventAdminWorldInfo
		const string AW_EVENT_ADMIN_WORLD_INFO = "AW_EVENT_ADMIN_WORLD_INFO";

		//Native event handler.
		private void OnEventAdminWorldInfo()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_ADMIN_WORLD_INFO) && _eventHandlers[AW_EVENT_ADMIN_WORLD_INFO].Managed != null)
			{
				_eventHandlers[AW_EVENT_ADMIN_WORLD_INFO].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_ADMIN_WORLD_INFO from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventAdminWorldInfo
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_ADMIN_WORLD_INFO))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_ADMIN_WORLD_INFO, new EventDelegates { Native = OnEventAdminWorldInfo });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_ADMIN_WORLD_INFO, _eventHandlers[AW_EVENT_ADMIN_WORLD_INFO].Native);			
				}
					
				_eventHandlers[AW_EVENT_ADMIN_WORLD_INFO].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_ADMIN_WORLD_INFO))
				{
					_eventHandlers[AW_EVENT_ADMIN_WORLD_INFO].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_ADMIN_WORLD_INFO].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_ADMIN_WORLD_INFO, null);
						_eventHandlers.Remove(AW_EVENT_ADMIN_WORLD_INFO);
					}
				}
			}
		}
	#endregion
		
	#region EventAdminWorldDelete
		const string AW_EVENT_ADMIN_WORLD_DELETE = "AW_EVENT_ADMIN_WORLD_DELETE";

		//Native event handler.
		private void OnEventAdminWorldDelete()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_ADMIN_WORLD_DELETE) && _eventHandlers[AW_EVENT_ADMIN_WORLD_DELETE].Managed != null)
			{
				_eventHandlers[AW_EVENT_ADMIN_WORLD_DELETE].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_ADMIN_WORLD_DELETE from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventAdminWorldDelete
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_ADMIN_WORLD_DELETE))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_ADMIN_WORLD_DELETE, new EventDelegates { Native = OnEventAdminWorldDelete });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_ADMIN_WORLD_DELETE, _eventHandlers[AW_EVENT_ADMIN_WORLD_DELETE].Native);			
				}
					
				_eventHandlers[AW_EVENT_ADMIN_WORLD_DELETE].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_ADMIN_WORLD_DELETE))
				{
					_eventHandlers[AW_EVENT_ADMIN_WORLD_DELETE].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_ADMIN_WORLD_DELETE].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_ADMIN_WORLD_DELETE, null);
						_eventHandlers.Remove(AW_EVENT_ADMIN_WORLD_DELETE);
					}
				}
			}
		}
	#endregion
		
	#region EventAvatarAdd
		const string AW_EVENT_AVATAR_ADD = "AW_EVENT_AVATAR_ADD";

		//Native event handler.
		private void OnEventAvatarAdd()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_AVATAR_ADD) && _eventHandlers[AW_EVENT_AVATAR_ADD].Managed != null)
			{
				_eventHandlers[AW_EVENT_AVATAR_ADD].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_AVATAR_ADD from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventAvatarAdd
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_AVATAR_ADD))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_AVATAR_ADD, new EventDelegates { Native = OnEventAvatarAdd });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_ADD, _eventHandlers[AW_EVENT_AVATAR_ADD].Native);			
				}
					
				_eventHandlers[AW_EVENT_AVATAR_ADD].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_AVATAR_ADD))
				{
					_eventHandlers[AW_EVENT_AVATAR_ADD].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_AVATAR_ADD].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_ADD, null);
						_eventHandlers.Remove(AW_EVENT_AVATAR_ADD);
					}
				}
			}
		}
	#endregion
		
	#region EventAvatarChange
		const string AW_EVENT_AVATAR_CHANGE = "AW_EVENT_AVATAR_CHANGE";

		//Native event handler.
		private void OnEventAvatarChange()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_AVATAR_CHANGE) && _eventHandlers[AW_EVENT_AVATAR_CHANGE].Managed != null)
			{
				_eventHandlers[AW_EVENT_AVATAR_CHANGE].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_AVATAR_CHANGE from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventAvatarChange
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_AVATAR_CHANGE))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_AVATAR_CHANGE, new EventDelegates { Native = OnEventAvatarChange });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_CHANGE, _eventHandlers[AW_EVENT_AVATAR_CHANGE].Native);			
				}
					
				_eventHandlers[AW_EVENT_AVATAR_CHANGE].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_AVATAR_CHANGE))
				{
					_eventHandlers[AW_EVENT_AVATAR_CHANGE].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_AVATAR_CHANGE].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_CHANGE, null);
						_eventHandlers.Remove(AW_EVENT_AVATAR_CHANGE);
					}
				}
			}
		}
	#endregion
		
	#region EventAvatarDelete
		const string AW_EVENT_AVATAR_DELETE = "AW_EVENT_AVATAR_DELETE";

		//Native event handler.
		private void OnEventAvatarDelete()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_AVATAR_DELETE) && _eventHandlers[AW_EVENT_AVATAR_DELETE].Managed != null)
			{
				_eventHandlers[AW_EVENT_AVATAR_DELETE].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_AVATAR_DELETE from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventAvatarDelete
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_AVATAR_DELETE))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_AVATAR_DELETE, new EventDelegates { Native = OnEventAvatarDelete });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_DELETE, _eventHandlers[AW_EVENT_AVATAR_DELETE].Native);			
				}
					
				_eventHandlers[AW_EVENT_AVATAR_DELETE].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_AVATAR_DELETE))
				{
					_eventHandlers[AW_EVENT_AVATAR_DELETE].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_AVATAR_DELETE].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_DELETE, null);
						_eventHandlers.Remove(AW_EVENT_AVATAR_DELETE);
					}
				}
			}
		}
	#endregion
		
	#region EventAvatarClick
		const string AW_EVENT_AVATAR_CLICK = "AW_EVENT_AVATAR_CLICK";

		//Native event handler.
		private void OnEventAvatarClick()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_AVATAR_CLICK) && _eventHandlers[AW_EVENT_AVATAR_CLICK].Managed != null)
			{
				_eventHandlers[AW_EVENT_AVATAR_CLICK].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_AVATAR_CLICK from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventAvatarClick
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_AVATAR_CLICK))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_AVATAR_CLICK, new EventDelegates { Native = OnEventAvatarClick });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_CLICK, _eventHandlers[AW_EVENT_AVATAR_CLICK].Native);			
				}
					
				_eventHandlers[AW_EVENT_AVATAR_CLICK].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_AVATAR_CLICK))
				{
					_eventHandlers[AW_EVENT_AVATAR_CLICK].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_AVATAR_CLICK].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_CLICK, null);
						_eventHandlers.Remove(AW_EVENT_AVATAR_CLICK);
					}
				}
			}
		}
	#endregion
		
	#region EventAvatarReload
		const string AW_EVENT_AVATAR_RELOAD = "AW_EVENT_AVATAR_RELOAD";

		//Native event handler.
		private void OnEventAvatarReload()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_AVATAR_RELOAD) && _eventHandlers[AW_EVENT_AVATAR_RELOAD].Managed != null)
			{
				_eventHandlers[AW_EVENT_AVATAR_RELOAD].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_AVATAR_RELOAD from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventAvatarReload
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_AVATAR_RELOAD))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_AVATAR_RELOAD, new EventDelegates { Native = OnEventAvatarReload });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_RELOAD, _eventHandlers[AW_EVENT_AVATAR_RELOAD].Native);			
				}
					
				_eventHandlers[AW_EVENT_AVATAR_RELOAD].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_AVATAR_RELOAD))
				{
					_eventHandlers[AW_EVENT_AVATAR_RELOAD].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_AVATAR_RELOAD].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_AVATAR_RELOAD, null);
						_eventHandlers.Remove(AW_EVENT_AVATAR_RELOAD);
					}
				}
			}
		}
	#endregion
		
	#region EventBotgram
		const string AW_EVENT_BOTGRAM = "AW_EVENT_BOTGRAM";

		//Native event handler.
		private void OnEventBotgram()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_BOTGRAM) && _eventHandlers[AW_EVENT_BOTGRAM].Managed != null)
			{
				_eventHandlers[AW_EVENT_BOTGRAM].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_BOTGRAM from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventBotgram
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_BOTGRAM))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_BOTGRAM, new EventDelegates { Native = OnEventBotgram });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_BOTGRAM, _eventHandlers[AW_EVENT_BOTGRAM].Native);			
				}
					
				_eventHandlers[AW_EVENT_BOTGRAM].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_BOTGRAM))
				{
					_eventHandlers[AW_EVENT_BOTGRAM].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_BOTGRAM].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_BOTGRAM, null);
						_eventHandlers.Remove(AW_EVENT_BOTGRAM);
					}
				}
			}
		}
	#endregion
		
	#region EventBotmenu
		const string AW_EVENT_BOTMENU = "AW_EVENT_BOTMENU";

		//Native event handler.
		private void OnEventBotmenu()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_BOTMENU) && _eventHandlers[AW_EVENT_BOTMENU].Managed != null)
			{
				_eventHandlers[AW_EVENT_BOTMENU].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_BOTMENU from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventBotmenu
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_BOTMENU))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_BOTMENU, new EventDelegates { Native = OnEventBotmenu });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_BOTMENU, _eventHandlers[AW_EVENT_BOTMENU].Native);			
				}
					
				_eventHandlers[AW_EVENT_BOTMENU].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_BOTMENU))
				{
					_eventHandlers[AW_EVENT_BOTMENU].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_BOTMENU].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_BOTMENU, null);
						_eventHandlers.Remove(AW_EVENT_BOTMENU);
					}
				}
			}
		}
	#endregion
		
	#region EventCellBegin
		const string AW_EVENT_CELL_BEGIN = "AW_EVENT_CELL_BEGIN";

		//Native event handler.
		private void OnEventCellBegin()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_CELL_BEGIN) && _eventHandlers[AW_EVENT_CELL_BEGIN].Managed != null)
			{
				_eventHandlers[AW_EVENT_CELL_BEGIN].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_CELL_BEGIN from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventCellBegin
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_CELL_BEGIN))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_CELL_BEGIN, new EventDelegates { Native = OnEventCellBegin });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_CELL_BEGIN, _eventHandlers[AW_EVENT_CELL_BEGIN].Native);			
				}
					
				_eventHandlers[AW_EVENT_CELL_BEGIN].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_CELL_BEGIN))
				{
					_eventHandlers[AW_EVENT_CELL_BEGIN].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_CELL_BEGIN].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_CELL_BEGIN, null);
						_eventHandlers.Remove(AW_EVENT_CELL_BEGIN);
					}
				}
			}
		}
	#endregion
		
	#region EventCellObject
		const string AW_EVENT_CELL_OBJECT = "AW_EVENT_CELL_OBJECT";

		//Native event handler.
		private void OnEventCellObject()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_CELL_OBJECT) && _eventHandlers[AW_EVENT_CELL_OBJECT].Managed != null)
			{
				_eventHandlers[AW_EVENT_CELL_OBJECT].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_CELL_OBJECT from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventCellObject
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_CELL_OBJECT))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_CELL_OBJECT, new EventDelegates { Native = OnEventCellObject });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_CELL_OBJECT, _eventHandlers[AW_EVENT_CELL_OBJECT].Native);			
				}
					
				_eventHandlers[AW_EVENT_CELL_OBJECT].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_CELL_OBJECT))
				{
					_eventHandlers[AW_EVENT_CELL_OBJECT].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_CELL_OBJECT].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_CELL_OBJECT, null);
						_eventHandlers.Remove(AW_EVENT_CELL_OBJECT);
					}
				}
			}
		}
	#endregion
		
	#region EventCellEnd
		const string AW_EVENT_CELL_END = "AW_EVENT_CELL_END";

		//Native event handler.
		private void OnEventCellEnd()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_CELL_END) && _eventHandlers[AW_EVENT_CELL_END].Managed != null)
			{
				_eventHandlers[AW_EVENT_CELL_END].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_CELL_END from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventCellEnd
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_CELL_END))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_CELL_END, new EventDelegates { Native = OnEventCellEnd });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_CELL_END, _eventHandlers[AW_EVENT_CELL_END].Native);			
				}
					
				_eventHandlers[AW_EVENT_CELL_END].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_CELL_END))
				{
					_eventHandlers[AW_EVENT_CELL_END].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_CELL_END].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_CELL_END, null);
						_eventHandlers.Remove(AW_EVENT_CELL_END);
					}
				}
			}
		}
	#endregion
		
	#region EventChat
		const string AW_EVENT_CHAT = "AW_EVENT_CHAT";

		//Native event handler.
		private void OnEventChat()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_CHAT) && _eventHandlers[AW_EVENT_CHAT].Managed != null)
			{
				_eventHandlers[AW_EVENT_CHAT].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_CHAT from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventChat
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_CHAT))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_CHAT, new EventDelegates { Native = OnEventChat });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_CHAT, _eventHandlers[AW_EVENT_CHAT].Native);			
				}
					
				_eventHandlers[AW_EVENT_CHAT].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_CHAT))
				{
					_eventHandlers[AW_EVENT_CHAT].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_CHAT].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_CHAT, null);
						_eventHandlers.Remove(AW_EVENT_CHAT);
					}
				}
			}
		}
	#endregion
		
	#region EventConsoleMessage
		const string AW_EVENT_CONSOLE_MESSAGE = "AW_EVENT_CONSOLE_MESSAGE";

		//Native event handler.
		private void OnEventConsoleMessage()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_CONSOLE_MESSAGE) && _eventHandlers[AW_EVENT_CONSOLE_MESSAGE].Managed != null)
			{
				_eventHandlers[AW_EVENT_CONSOLE_MESSAGE].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_CONSOLE_MESSAGE from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventConsoleMessage
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_CONSOLE_MESSAGE))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_CONSOLE_MESSAGE, new EventDelegates { Native = OnEventConsoleMessage });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_CONSOLE_MESSAGE, _eventHandlers[AW_EVENT_CONSOLE_MESSAGE].Native);			
				}
					
				_eventHandlers[AW_EVENT_CONSOLE_MESSAGE].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_CONSOLE_MESSAGE))
				{
					_eventHandlers[AW_EVENT_CONSOLE_MESSAGE].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_CONSOLE_MESSAGE].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_CONSOLE_MESSAGE, null);
						_eventHandlers.Remove(AW_EVENT_CONSOLE_MESSAGE);
					}
				}
			}
		}
	#endregion
		
	#region EventEntityAdd
		const string AW_EVENT_ENTITY_ADD = "AW_EVENT_ENTITY_ADD";

		//Native event handler.
		private void OnEventEntityAdd()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_ENTITY_ADD) && _eventHandlers[AW_EVENT_ENTITY_ADD].Managed != null)
			{
				_eventHandlers[AW_EVENT_ENTITY_ADD].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_ENTITY_ADD from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventEntityAdd
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_ENTITY_ADD))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_ENTITY_ADD, new EventDelegates { Native = OnEventEntityAdd });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_ADD, _eventHandlers[AW_EVENT_ENTITY_ADD].Native);			
				}
					
				_eventHandlers[AW_EVENT_ENTITY_ADD].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_ENTITY_ADD))
				{
					_eventHandlers[AW_EVENT_ENTITY_ADD].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_ENTITY_ADD].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_ADD, null);
						_eventHandlers.Remove(AW_EVENT_ENTITY_ADD);
					}
				}
			}
		}
	#endregion
		
	#region EventEntityChange
		const string AW_EVENT_ENTITY_CHANGE = "AW_EVENT_ENTITY_CHANGE";

		//Native event handler.
		private void OnEventEntityChange()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_ENTITY_CHANGE) && _eventHandlers[AW_EVENT_ENTITY_CHANGE].Managed != null)
			{
				_eventHandlers[AW_EVENT_ENTITY_CHANGE].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_ENTITY_CHANGE from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventEntityChange
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_ENTITY_CHANGE))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_ENTITY_CHANGE, new EventDelegates { Native = OnEventEntityChange });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_CHANGE, _eventHandlers[AW_EVENT_ENTITY_CHANGE].Native);			
				}
					
				_eventHandlers[AW_EVENT_ENTITY_CHANGE].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_ENTITY_CHANGE))
				{
					_eventHandlers[AW_EVENT_ENTITY_CHANGE].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_ENTITY_CHANGE].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_CHANGE, null);
						_eventHandlers.Remove(AW_EVENT_ENTITY_CHANGE);
					}
				}
			}
		}
	#endregion
		
	#region EventEntityDelete
		const string AW_EVENT_ENTITY_DELETE = "AW_EVENT_ENTITY_DELETE";

		//Native event handler.
		private void OnEventEntityDelete()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_ENTITY_DELETE) && _eventHandlers[AW_EVENT_ENTITY_DELETE].Managed != null)
			{
				_eventHandlers[AW_EVENT_ENTITY_DELETE].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_ENTITY_DELETE from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventEntityDelete
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_ENTITY_DELETE))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_ENTITY_DELETE, new EventDelegates { Native = OnEventEntityDelete });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_DELETE, _eventHandlers[AW_EVENT_ENTITY_DELETE].Native);			
				}
					
				_eventHandlers[AW_EVENT_ENTITY_DELETE].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_ENTITY_DELETE))
				{
					_eventHandlers[AW_EVENT_ENTITY_DELETE].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_ENTITY_DELETE].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_DELETE, null);
						_eventHandlers.Remove(AW_EVENT_ENTITY_DELETE);
					}
				}
			}
		}
	#endregion
		
	#region EventEntityRiderAdd
		const string AW_EVENT_ENTITY_RIDER_ADD = "AW_EVENT_ENTITY_RIDER_ADD";

		//Native event handler.
		private void OnEventEntityRiderAdd()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_ENTITY_RIDER_ADD) && _eventHandlers[AW_EVENT_ENTITY_RIDER_ADD].Managed != null)
			{
				_eventHandlers[AW_EVENT_ENTITY_RIDER_ADD].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_ENTITY_RIDER_ADD from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventEntityRiderAdd
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_ENTITY_RIDER_ADD))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_ENTITY_RIDER_ADD, new EventDelegates { Native = OnEventEntityRiderAdd });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_RIDER_ADD, _eventHandlers[AW_EVENT_ENTITY_RIDER_ADD].Native);			
				}
					
				_eventHandlers[AW_EVENT_ENTITY_RIDER_ADD].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_ENTITY_RIDER_ADD))
				{
					_eventHandlers[AW_EVENT_ENTITY_RIDER_ADD].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_ENTITY_RIDER_ADD].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_RIDER_ADD, null);
						_eventHandlers.Remove(AW_EVENT_ENTITY_RIDER_ADD);
					}
				}
			}
		}
	#endregion
		
	#region EventEntityRiderChange
		const string AW_EVENT_ENTITY_RIDER_CHANGE = "AW_EVENT_ENTITY_RIDER_CHANGE";

		//Native event handler.
		private void OnEventEntityRiderChange()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_ENTITY_RIDER_CHANGE) && _eventHandlers[AW_EVENT_ENTITY_RIDER_CHANGE].Managed != null)
			{
				_eventHandlers[AW_EVENT_ENTITY_RIDER_CHANGE].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_ENTITY_RIDER_CHANGE from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventEntityRiderChange
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_ENTITY_RIDER_CHANGE))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_ENTITY_RIDER_CHANGE, new EventDelegates { Native = OnEventEntityRiderChange });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_RIDER_CHANGE, _eventHandlers[AW_EVENT_ENTITY_RIDER_CHANGE].Native);			
				}
					
				_eventHandlers[AW_EVENT_ENTITY_RIDER_CHANGE].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_ENTITY_RIDER_CHANGE))
				{
					_eventHandlers[AW_EVENT_ENTITY_RIDER_CHANGE].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_ENTITY_RIDER_CHANGE].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_RIDER_CHANGE, null);
						_eventHandlers.Remove(AW_EVENT_ENTITY_RIDER_CHANGE);
					}
				}
			}
		}
	#endregion
		
	#region EventEntityRiderDelete
		const string AW_EVENT_ENTITY_RIDER_DELETE = "AW_EVENT_ENTITY_RIDER_DELETE";

		//Native event handler.
		private void OnEventEntityRiderDelete()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_ENTITY_RIDER_DELETE) && _eventHandlers[AW_EVENT_ENTITY_RIDER_DELETE].Managed != null)
			{
				_eventHandlers[AW_EVENT_ENTITY_RIDER_DELETE].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_ENTITY_RIDER_DELETE from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventEntityRiderDelete
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_ENTITY_RIDER_DELETE))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_ENTITY_RIDER_DELETE, new EventDelegates { Native = OnEventEntityRiderDelete });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_RIDER_DELETE, _eventHandlers[AW_EVENT_ENTITY_RIDER_DELETE].Native);			
				}
					
				_eventHandlers[AW_EVENT_ENTITY_RIDER_DELETE].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_ENTITY_RIDER_DELETE))
				{
					_eventHandlers[AW_EVENT_ENTITY_RIDER_DELETE].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_ENTITY_RIDER_DELETE].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_RIDER_DELETE, null);
						_eventHandlers.Remove(AW_EVENT_ENTITY_RIDER_DELETE);
					}
				}
			}
		}
	#endregion
		
	#region EventEntityLinks
		const string AW_EVENT_ENTITY_LINKS = "AW_EVENT_ENTITY_LINKS";

		//Native event handler.
		private void OnEventEntityLinks()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_ENTITY_LINKS) && _eventHandlers[AW_EVENT_ENTITY_LINKS].Managed != null)
			{
				_eventHandlers[AW_EVENT_ENTITY_LINKS].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_ENTITY_LINKS from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventEntityLinks
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_ENTITY_LINKS))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_ENTITY_LINKS, new EventDelegates { Native = OnEventEntityLinks });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_LINKS, _eventHandlers[AW_EVENT_ENTITY_LINKS].Native);			
				}
					
				_eventHandlers[AW_EVENT_ENTITY_LINKS].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_ENTITY_LINKS))
				{
					_eventHandlers[AW_EVENT_ENTITY_LINKS].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_ENTITY_LINKS].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_ENTITY_LINKS, null);
						_eventHandlers.Remove(AW_EVENT_ENTITY_LINKS);
					}
				}
			}
		}
	#endregion
		
	#region EventHudClick
		const string AW_EVENT_HUD_CLICK = "AW_EVENT_HUD_CLICK";

		//Native event handler.
		private void OnEventHudClick()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_HUD_CLICK) && _eventHandlers[AW_EVENT_HUD_CLICK].Managed != null)
			{
				_eventHandlers[AW_EVENT_HUD_CLICK].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_HUD_CLICK from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventHudClick
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_HUD_CLICK))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_HUD_CLICK, new EventDelegates { Native = OnEventHudClick });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_HUD_CLICK, _eventHandlers[AW_EVENT_HUD_CLICK].Native);			
				}
					
				_eventHandlers[AW_EVENT_HUD_CLICK].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_HUD_CLICK))
				{
					_eventHandlers[AW_EVENT_HUD_CLICK].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_HUD_CLICK].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_HUD_CLICK, null);
						_eventHandlers.Remove(AW_EVENT_HUD_CLICK);
					}
				}
			}
		}
	#endregion
		
	#region EventNoise
		const string AW_EVENT_NOISE = "AW_EVENT_NOISE";

		//Native event handler.
		private void OnEventNoise()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_NOISE) && _eventHandlers[AW_EVENT_NOISE].Managed != null)
			{
				_eventHandlers[AW_EVENT_NOISE].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_NOISE from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventNoise
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_NOISE))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_NOISE, new EventDelegates { Native = OnEventNoise });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_NOISE, _eventHandlers[AW_EVENT_NOISE].Native);			
				}
					
				_eventHandlers[AW_EVENT_NOISE].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_NOISE))
				{
					_eventHandlers[AW_EVENT_NOISE].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_NOISE].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_NOISE, null);
						_eventHandlers.Remove(AW_EVENT_NOISE);
					}
				}
			}
		}
	#endregion
		
	#region EventObjectAdd
		const string AW_EVENT_OBJECT_ADD = "AW_EVENT_OBJECT_ADD";

		//Native event handler.
		private void OnEventObjectAdd()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_OBJECT_ADD) && _eventHandlers[AW_EVENT_OBJECT_ADD].Managed != null)
			{
				_eventHandlers[AW_EVENT_OBJECT_ADD].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_OBJECT_ADD from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventObjectAdd
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_OBJECT_ADD))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_OBJECT_ADD, new EventDelegates { Native = OnEventObjectAdd });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_ADD, _eventHandlers[AW_EVENT_OBJECT_ADD].Native);			
				}
					
				_eventHandlers[AW_EVENT_OBJECT_ADD].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_OBJECT_ADD))
				{
					_eventHandlers[AW_EVENT_OBJECT_ADD].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_OBJECT_ADD].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_ADD, null);
						_eventHandlers.Remove(AW_EVENT_OBJECT_ADD);
					}
				}
			}
		}
	#endregion
		
	#region EventObjectDelete
		const string AW_EVENT_OBJECT_DELETE = "AW_EVENT_OBJECT_DELETE";

		//Native event handler.
		private void OnEventObjectDelete()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_OBJECT_DELETE) && _eventHandlers[AW_EVENT_OBJECT_DELETE].Managed != null)
			{
				_eventHandlers[AW_EVENT_OBJECT_DELETE].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_OBJECT_DELETE from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventObjectDelete
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_OBJECT_DELETE))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_OBJECT_DELETE, new EventDelegates { Native = OnEventObjectDelete });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_DELETE, _eventHandlers[AW_EVENT_OBJECT_DELETE].Native);			
				}
					
				_eventHandlers[AW_EVENT_OBJECT_DELETE].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_OBJECT_DELETE))
				{
					_eventHandlers[AW_EVENT_OBJECT_DELETE].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_OBJECT_DELETE].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_DELETE, null);
						_eventHandlers.Remove(AW_EVENT_OBJECT_DELETE);
					}
				}
			}
		}
	#endregion
		
	#region EventObjectClick
		const string AW_EVENT_OBJECT_CLICK = "AW_EVENT_OBJECT_CLICK";

		//Native event handler.
		private void OnEventObjectClick()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_OBJECT_CLICK) && _eventHandlers[AW_EVENT_OBJECT_CLICK].Managed != null)
			{
				_eventHandlers[AW_EVENT_OBJECT_CLICK].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_OBJECT_CLICK from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventObjectClick
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_OBJECT_CLICK))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_OBJECT_CLICK, new EventDelegates { Native = OnEventObjectClick });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_CLICK, _eventHandlers[AW_EVENT_OBJECT_CLICK].Native);			
				}
					
				_eventHandlers[AW_EVENT_OBJECT_CLICK].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_OBJECT_CLICK))
				{
					_eventHandlers[AW_EVENT_OBJECT_CLICK].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_OBJECT_CLICK].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_CLICK, null);
						_eventHandlers.Remove(AW_EVENT_OBJECT_CLICK);
					}
				}
			}
		}
	#endregion
		
	#region EventObjectBump
		const string AW_EVENT_OBJECT_BUMP = "AW_EVENT_OBJECT_BUMP";

		//Native event handler.
		private void OnEventObjectBump()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_OBJECT_BUMP) && _eventHandlers[AW_EVENT_OBJECT_BUMP].Managed != null)
			{
				_eventHandlers[AW_EVENT_OBJECT_BUMP].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_OBJECT_BUMP from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventObjectBump
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_OBJECT_BUMP))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_OBJECT_BUMP, new EventDelegates { Native = OnEventObjectBump });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_BUMP, _eventHandlers[AW_EVENT_OBJECT_BUMP].Native);			
				}
					
				_eventHandlers[AW_EVENT_OBJECT_BUMP].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_OBJECT_BUMP))
				{
					_eventHandlers[AW_EVENT_OBJECT_BUMP].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_OBJECT_BUMP].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_BUMP, null);
						_eventHandlers.Remove(AW_EVENT_OBJECT_BUMP);
					}
				}
			}
		}
	#endregion
		
	#region EventObjectSelect
		const string AW_EVENT_OBJECT_SELECT = "AW_EVENT_OBJECT_SELECT";

		//Native event handler.
		private void OnEventObjectSelect()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_OBJECT_SELECT) && _eventHandlers[AW_EVENT_OBJECT_SELECT].Managed != null)
			{
				_eventHandlers[AW_EVENT_OBJECT_SELECT].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_OBJECT_SELECT from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventObjectSelect
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_OBJECT_SELECT))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_OBJECT_SELECT, new EventDelegates { Native = OnEventObjectSelect });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_SELECT, _eventHandlers[AW_EVENT_OBJECT_SELECT].Native);			
				}
					
				_eventHandlers[AW_EVENT_OBJECT_SELECT].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_OBJECT_SELECT))
				{
					_eventHandlers[AW_EVENT_OBJECT_SELECT].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_OBJECT_SELECT].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_OBJECT_SELECT, null);
						_eventHandlers.Remove(AW_EVENT_OBJECT_SELECT);
					}
				}
			}
		}
	#endregion
		
	#region EventTeleport
		const string AW_EVENT_TELEPORT = "AW_EVENT_TELEPORT";

		//Native event handler.
		private void OnEventTeleport()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_TELEPORT) && _eventHandlers[AW_EVENT_TELEPORT].Managed != null)
			{
				_eventHandlers[AW_EVENT_TELEPORT].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_TELEPORT from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventTeleport
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_TELEPORT))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_TELEPORT, new EventDelegates { Native = OnEventTeleport });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_TELEPORT, _eventHandlers[AW_EVENT_TELEPORT].Native);			
				}
					
				_eventHandlers[AW_EVENT_TELEPORT].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_TELEPORT))
				{
					_eventHandlers[AW_EVENT_TELEPORT].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_TELEPORT].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_TELEPORT, null);
						_eventHandlers.Remove(AW_EVENT_TELEPORT);
					}
				}
			}
		}
	#endregion
		
	#region EventTerrainBegin
		const string AW_EVENT_TERRAIN_BEGIN = "AW_EVENT_TERRAIN_BEGIN";

		//Native event handler.
		private void OnEventTerrainBegin()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_TERRAIN_BEGIN) && _eventHandlers[AW_EVENT_TERRAIN_BEGIN].Managed != null)
			{
				_eventHandlers[AW_EVENT_TERRAIN_BEGIN].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_TERRAIN_BEGIN from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventTerrainBegin
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_TERRAIN_BEGIN))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_TERRAIN_BEGIN, new EventDelegates { Native = OnEventTerrainBegin });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_TERRAIN_BEGIN, _eventHandlers[AW_EVENT_TERRAIN_BEGIN].Native);			
				}
					
				_eventHandlers[AW_EVENT_TERRAIN_BEGIN].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_TERRAIN_BEGIN))
				{
					_eventHandlers[AW_EVENT_TERRAIN_BEGIN].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_TERRAIN_BEGIN].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_TERRAIN_BEGIN, null);
						_eventHandlers.Remove(AW_EVENT_TERRAIN_BEGIN);
					}
				}
			}
		}
	#endregion
		
	#region EventTerrainChanged
		const string AW_EVENT_TERRAIN_CHANGED = "AW_EVENT_TERRAIN_CHANGED";

		//Native event handler.
		private void OnEventTerrainChanged()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_TERRAIN_CHANGED) && _eventHandlers[AW_EVENT_TERRAIN_CHANGED].Managed != null)
			{
				_eventHandlers[AW_EVENT_TERRAIN_CHANGED].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_TERRAIN_CHANGED from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventTerrainChanged
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_TERRAIN_CHANGED))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_TERRAIN_CHANGED, new EventDelegates { Native = OnEventTerrainChanged });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_TERRAIN_CHANGED, _eventHandlers[AW_EVENT_TERRAIN_CHANGED].Native);			
				}
					
				_eventHandlers[AW_EVENT_TERRAIN_CHANGED].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_TERRAIN_CHANGED))
				{
					_eventHandlers[AW_EVENT_TERRAIN_CHANGED].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_TERRAIN_CHANGED].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_TERRAIN_CHANGED, null);
						_eventHandlers.Remove(AW_EVENT_TERRAIN_CHANGED);
					}
				}
			}
		}
	#endregion
		
	#region EventTerrainData
		const string AW_EVENT_TERRAIN_DATA = "AW_EVENT_TERRAIN_DATA";

		//Native event handler.
		private void OnEventTerrainData()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_TERRAIN_DATA) && _eventHandlers[AW_EVENT_TERRAIN_DATA].Managed != null)
			{
				_eventHandlers[AW_EVENT_TERRAIN_DATA].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_TERRAIN_DATA from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventTerrainData
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_TERRAIN_DATA))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_TERRAIN_DATA, new EventDelegates { Native = OnEventTerrainData });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_TERRAIN_DATA, _eventHandlers[AW_EVENT_TERRAIN_DATA].Native);			
				}
					
				_eventHandlers[AW_EVENT_TERRAIN_DATA].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_TERRAIN_DATA))
				{
					_eventHandlers[AW_EVENT_TERRAIN_DATA].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_TERRAIN_DATA].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_TERRAIN_DATA, null);
						_eventHandlers.Remove(AW_EVENT_TERRAIN_DATA);
					}
				}
			}
		}
	#endregion
		
	#region EventTerrainEnd
		const string AW_EVENT_TERRAIN_END = "AW_EVENT_TERRAIN_END";

		//Native event handler.
		private void OnEventTerrainEnd()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_TERRAIN_END) && _eventHandlers[AW_EVENT_TERRAIN_END].Managed != null)
			{
				_eventHandlers[AW_EVENT_TERRAIN_END].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_TERRAIN_END from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventTerrainEnd
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_TERRAIN_END))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_TERRAIN_END, new EventDelegates { Native = OnEventTerrainEnd });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_TERRAIN_END, _eventHandlers[AW_EVENT_TERRAIN_END].Native);			
				}
					
				_eventHandlers[AW_EVENT_TERRAIN_END].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_TERRAIN_END))
				{
					_eventHandlers[AW_EVENT_TERRAIN_END].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_TERRAIN_END].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_TERRAIN_END, null);
						_eventHandlers.Remove(AW_EVENT_TERRAIN_END);
					}
				}
			}
		}
	#endregion
		
	#region EventToolbarClick
		const string AW_EVENT_TOOLBAR_CLICK = "AW_EVENT_TOOLBAR_CLICK";

		//Native event handler.
		private void OnEventToolbarClick()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_TOOLBAR_CLICK) && _eventHandlers[AW_EVENT_TOOLBAR_CLICK].Managed != null)
			{
				_eventHandlers[AW_EVENT_TOOLBAR_CLICK].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_TOOLBAR_CLICK from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventToolbarClick
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_TOOLBAR_CLICK))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_TOOLBAR_CLICK, new EventDelegates { Native = OnEventToolbarClick });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_TOOLBAR_CLICK, _eventHandlers[AW_EVENT_TOOLBAR_CLICK].Native);			
				}
					
				_eventHandlers[AW_EVENT_TOOLBAR_CLICK].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_TOOLBAR_CLICK))
				{
					_eventHandlers[AW_EVENT_TOOLBAR_CLICK].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_TOOLBAR_CLICK].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_TOOLBAR_CLICK, null);
						_eventHandlers.Remove(AW_EVENT_TOOLBAR_CLICK);
					}
				}
			}
		}
	#endregion
		
	#region EventUniverseAttributes
		const string AW_EVENT_UNIVERSE_ATTRIBUTES = "AW_EVENT_UNIVERSE_ATTRIBUTES";

		//Native event handler.
		private void OnEventUniverseAttributes()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_UNIVERSE_ATTRIBUTES) && _eventHandlers[AW_EVENT_UNIVERSE_ATTRIBUTES].Managed != null)
			{
				_eventHandlers[AW_EVENT_UNIVERSE_ATTRIBUTES].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_UNIVERSE_ATTRIBUTES from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventUniverseAttributes
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_UNIVERSE_ATTRIBUTES))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_UNIVERSE_ATTRIBUTES, new EventDelegates { Native = OnEventUniverseAttributes });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_UNIVERSE_ATTRIBUTES, _eventHandlers[AW_EVENT_UNIVERSE_ATTRIBUTES].Native);			
				}
					
				_eventHandlers[AW_EVENT_UNIVERSE_ATTRIBUTES].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_UNIVERSE_ATTRIBUTES))
				{
					_eventHandlers[AW_EVENT_UNIVERSE_ATTRIBUTES].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_UNIVERSE_ATTRIBUTES].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_UNIVERSE_ATTRIBUTES, null);
						_eventHandlers.Remove(AW_EVENT_UNIVERSE_ATTRIBUTES);
					}
				}
			}
		}
	#endregion
		
	#region EventUniverseDisconnect
		const string AW_EVENT_UNIVERSE_DISCONNECT = "AW_EVENT_UNIVERSE_DISCONNECT";

		//Native event handler.
		private void OnEventUniverseDisconnect()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_UNIVERSE_DISCONNECT) && _eventHandlers[AW_EVENT_UNIVERSE_DISCONNECT].Managed != null)
			{
				_eventHandlers[AW_EVENT_UNIVERSE_DISCONNECT].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_UNIVERSE_DISCONNECT from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventUniverseDisconnect
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_UNIVERSE_DISCONNECT))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_UNIVERSE_DISCONNECT, new EventDelegates { Native = OnEventUniverseDisconnect });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_UNIVERSE_DISCONNECT, _eventHandlers[AW_EVENT_UNIVERSE_DISCONNECT].Native);			
				}
					
				_eventHandlers[AW_EVENT_UNIVERSE_DISCONNECT].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_UNIVERSE_DISCONNECT))
				{
					_eventHandlers[AW_EVENT_UNIVERSE_DISCONNECT].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_UNIVERSE_DISCONNECT].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_UNIVERSE_DISCONNECT, null);
						_eventHandlers.Remove(AW_EVENT_UNIVERSE_DISCONNECT);
					}
				}
			}
		}
	#endregion
		
	#region EventUrl
		const string AW_EVENT_URL = "AW_EVENT_URL";

		//Native event handler.
		private void OnEventUrl()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_URL) && _eventHandlers[AW_EVENT_URL].Managed != null)
			{
				_eventHandlers[AW_EVENT_URL].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_URL from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventUrl
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_URL))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_URL, new EventDelegates { Native = OnEventUrl });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_URL, _eventHandlers[AW_EVENT_URL].Native);			
				}
					
				_eventHandlers[AW_EVENT_URL].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_URL))
				{
					_eventHandlers[AW_EVENT_URL].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_URL].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_URL, null);
						_eventHandlers.Remove(AW_EVENT_URL);
					}
				}
			}
		}
	#endregion
		
	#region EventUrlClick
		const string AW_EVENT_URL_CLICK = "AW_EVENT_URL_CLICK";

		//Native event handler.
		private void OnEventUrlClick()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_URL_CLICK) && _eventHandlers[AW_EVENT_URL_CLICK].Managed != null)
			{
				_eventHandlers[AW_EVENT_URL_CLICK].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_URL_CLICK from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventUrlClick
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_URL_CLICK))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_URL_CLICK, new EventDelegates { Native = OnEventUrlClick });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_URL_CLICK, _eventHandlers[AW_EVENT_URL_CLICK].Native);			
				}
					
				_eventHandlers[AW_EVENT_URL_CLICK].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_URL_CLICK))
				{
					_eventHandlers[AW_EVENT_URL_CLICK].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_URL_CLICK].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_URL_CLICK, null);
						_eventHandlers.Remove(AW_EVENT_URL_CLICK);
					}
				}
			}
		}
	#endregion
		
	#region EventUserInfo
		const string AW_EVENT_USER_INFO = "AW_EVENT_USER_INFO";

		//Native event handler.
		private void OnEventUserInfo()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_USER_INFO) && _eventHandlers[AW_EVENT_USER_INFO].Managed != null)
			{
				_eventHandlers[AW_EVENT_USER_INFO].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_USER_INFO from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventUserInfo
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_USER_INFO))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_USER_INFO, new EventDelegates { Native = OnEventUserInfo });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_USER_INFO, _eventHandlers[AW_EVENT_USER_INFO].Native);			
				}
					
				_eventHandlers[AW_EVENT_USER_INFO].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_USER_INFO))
				{
					_eventHandlers[AW_EVENT_USER_INFO].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_USER_INFO].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_USER_INFO, null);
						_eventHandlers.Remove(AW_EVENT_USER_INFO);
					}
				}
			}
		}
	#endregion
		
	#region EventWorldAttributes
		const string AW_EVENT_WORLD_ATTRIBUTES = "AW_EVENT_WORLD_ATTRIBUTES";

		//Native event handler.
		private void OnEventWorldAttributes()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_WORLD_ATTRIBUTES) && _eventHandlers[AW_EVENT_WORLD_ATTRIBUTES].Managed != null)
			{
				_eventHandlers[AW_EVENT_WORLD_ATTRIBUTES].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_WORLD_ATTRIBUTES from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventWorldAttributes
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_WORLD_ATTRIBUTES))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_WORLD_ATTRIBUTES, new EventDelegates { Native = OnEventWorldAttributes });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_WORLD_ATTRIBUTES, _eventHandlers[AW_EVENT_WORLD_ATTRIBUTES].Native);			
				}
					
				_eventHandlers[AW_EVENT_WORLD_ATTRIBUTES].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_WORLD_ATTRIBUTES))
				{
					_eventHandlers[AW_EVENT_WORLD_ATTRIBUTES].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_WORLD_ATTRIBUTES].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_WORLD_ATTRIBUTES, null);
						_eventHandlers.Remove(AW_EVENT_WORLD_ATTRIBUTES);
					}
				}
			}
		}
	#endregion
		
	#region EventWorldDisconnect
		const string AW_EVENT_WORLD_DISCONNECT = "AW_EVENT_WORLD_DISCONNECT";

		//Native event handler.
		private void OnEventWorldDisconnect()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_WORLD_DISCONNECT) && _eventHandlers[AW_EVENT_WORLD_DISCONNECT].Managed != null)
			{
				_eventHandlers[AW_EVENT_WORLD_DISCONNECT].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_WORLD_DISCONNECT from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventWorldDisconnect
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_WORLD_DISCONNECT))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_WORLD_DISCONNECT, new EventDelegates { Native = OnEventWorldDisconnect });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_WORLD_DISCONNECT, _eventHandlers[AW_EVENT_WORLD_DISCONNECT].Native);			
				}
					
				_eventHandlers[AW_EVENT_WORLD_DISCONNECT].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_WORLD_DISCONNECT))
				{
					_eventHandlers[AW_EVENT_WORLD_DISCONNECT].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_WORLD_DISCONNECT].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_WORLD_DISCONNECT, null);
						_eventHandlers.Remove(AW_EVENT_WORLD_DISCONNECT);
					}
				}
			}
		}
	#endregion
		
	#region EventWorldInfo
		const string AW_EVENT_WORLD_INFO = "AW_EVENT_WORLD_INFO";

		//Native event handler.
		private void OnEventWorldInfo()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_WORLD_INFO) && _eventHandlers[AW_EVENT_WORLD_INFO].Managed != null)
			{
				_eventHandlers[AW_EVENT_WORLD_INFO].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_WORLD_INFO from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventWorldInfo
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_WORLD_INFO))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_WORLD_INFO, new EventDelegates { Native = OnEventWorldInfo });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_WORLD_INFO, _eventHandlers[AW_EVENT_WORLD_INFO].Native);			
				}
					
				_eventHandlers[AW_EVENT_WORLD_INFO].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_WORLD_INFO))
				{
					_eventHandlers[AW_EVENT_WORLD_INFO].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_WORLD_INFO].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_WORLD_INFO, null);
						_eventHandlers.Remove(AW_EVENT_WORLD_INFO);
					}
				}
			}
		}
	#endregion
		
	#region EventCavDefinitionChange
		const string AW_EVENT_CAV_DEFINITION_CHANGE = "AW_EVENT_CAV_DEFINITION_CHANGE";

		//Native event handler.
		private void OnEventCavDefinitionChange()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_CAV_DEFINITION_CHANGE) && _eventHandlers[AW_EVENT_CAV_DEFINITION_CHANGE].Managed != null)
			{
				_eventHandlers[AW_EVENT_CAV_DEFINITION_CHANGE].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_CAV_DEFINITION_CHANGE from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventCavDefinitionChange
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_CAV_DEFINITION_CHANGE))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_CAV_DEFINITION_CHANGE, new EventDelegates { Native = OnEventCavDefinitionChange });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_CAV_DEFINITION_CHANGE, _eventHandlers[AW_EVENT_CAV_DEFINITION_CHANGE].Native);			
				}
					
				_eventHandlers[AW_EVENT_CAV_DEFINITION_CHANGE].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_CAV_DEFINITION_CHANGE))
				{
					_eventHandlers[AW_EVENT_CAV_DEFINITION_CHANGE].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_CAV_DEFINITION_CHANGE].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_CAV_DEFINITION_CHANGE, null);
						_eventHandlers.Remove(AW_EVENT_CAV_DEFINITION_CHANGE);
					}
				}
			}
		}
	#endregion
		
	#region EventWorldCavDefinitionChange
		const string AW_EVENT_WORLD_CAV_DEFINITION_CHANGE = "AW_EVENT_WORLD_CAV_DEFINITION_CHANGE";

		//Native event handler.
		private void OnEventWorldCavDefinitionChange()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_WORLD_CAV_DEFINITION_CHANGE) && _eventHandlers[AW_EVENT_WORLD_CAV_DEFINITION_CHANGE].Managed != null)
			{
				_eventHandlers[AW_EVENT_WORLD_CAV_DEFINITION_CHANGE].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_WORLD_CAV_DEFINITION_CHANGE from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventWorldCavDefinitionChange
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_WORLD_CAV_DEFINITION_CHANGE))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_WORLD_CAV_DEFINITION_CHANGE, new EventDelegates { Native = OnEventWorldCavDefinitionChange });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_WORLD_CAV_DEFINITION_CHANGE, _eventHandlers[AW_EVENT_WORLD_CAV_DEFINITION_CHANGE].Native);			
				}
					
				_eventHandlers[AW_EVENT_WORLD_CAV_DEFINITION_CHANGE].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_WORLD_CAV_DEFINITION_CHANGE))
				{
					_eventHandlers[AW_EVENT_WORLD_CAV_DEFINITION_CHANGE].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_WORLD_CAV_DEFINITION_CHANGE].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_WORLD_CAV_DEFINITION_CHANGE, null);
						_eventHandlers.Remove(AW_EVENT_WORLD_CAV_DEFINITION_CHANGE);
					}
				}
			}
		}
	#endregion
		
	#region EventLaserBeam
		const string AW_EVENT_LASER_BEAM = "AW_EVENT_LASER_BEAM";

		//Native event handler.
		private void OnEventLaserBeam()
		{						
			if(_eventHandlers.ContainsKey(AW_EVENT_LASER_BEAM) && _eventHandlers[AW_EVENT_LASER_BEAM].Managed != null)
			{
				_eventHandlers[AW_EVENT_LASER_BEAM].Managed(this);
			}
		}

		//Managed event handler.
		/// <summary>
		/// Handles AW_EVENT_LASER_BEAM from the C SDK.
		/// </summary>
		public event InstanceEventHandler EventLaserBeam
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_LASER_BEAM))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_LASER_BEAM, new EventDelegates { Native = OnEventLaserBeam });
					NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_LASER_BEAM, _eventHandlers[AW_EVENT_LASER_BEAM].Native);			
				}
					
				_eventHandlers[AW_EVENT_LASER_BEAM].Managed += value;
			}

			//Handles removing a delegate from the event.
			remove
			{
				if(_eventHandlers.ContainsKey(AW_EVENT_LASER_BEAM))
				{
					_eventHandlers[AW_EVENT_LASER_BEAM].Managed -= value;
				
					if(_eventHandlers[AW_EVENT_LASER_BEAM].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_event_set(AW_EVENT.AW_EVENT_LASER_BEAM, null);
						_eventHandlers.Remove(AW_EVENT_LASER_BEAM);
					}
				}
			}
		}
	#endregion
	}
}