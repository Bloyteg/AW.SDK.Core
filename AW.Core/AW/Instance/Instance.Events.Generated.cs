 


	
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
			event InstanceEventHandler AdminWorldInfoReceived;
			event InstanceEventHandler AdminWorldDeleteReceived;
			event InstanceEventHandler AvatarAddReceived;
			event InstanceEventHandler AvatarChangeReceived;
			event InstanceEventHandler AvatarDeleteReceived;
			event InstanceEventHandler AvatarClickReceived;
			event InstanceEventHandler AvatarReloadReceived;
			event InstanceEventHandler BotgramReceived;
			event InstanceEventHandler BotmenuReceived;
			event InstanceEventHandler CellBeginReceived;
			event InstanceEventHandler CellObjectReceived;
			event InstanceEventHandler CellEndReceived;
			event InstanceEventHandler ChatReceived;
			event InstanceEventHandler ConsoleMessageReceived;
			event InstanceEventHandler EntityAddReceived;
			event InstanceEventHandler EntityChangeReceived;
			event InstanceEventHandler EntityDeleteReceived;
			event InstanceEventHandler EntityRiderAddReceived;
			event InstanceEventHandler EntityRiderChangeReceived;
			event InstanceEventHandler EntityRiderDeleteReceived;
			event InstanceEventHandler EntityLinksReceived;
			event InstanceEventHandler HudClickReceived;
			event InstanceEventHandler NoiseReceived;
			event InstanceEventHandler ObjectAddReceived;
			event InstanceEventHandler ObjectDeleteReceived;
			event InstanceEventHandler ObjectClickReceived;
			event InstanceEventHandler ObjectBumpReceived;
			event InstanceEventHandler ObjectSelectReceived;
			event InstanceEventHandler TeleportReceived;
			event InstanceEventHandler TerrainBeginReceived;
			event InstanceEventHandler TerrainChangedReceived;
			event InstanceEventHandler TerrainDataReceived;
			event InstanceEventHandler TerrainEndReceived;
			event InstanceEventHandler ToolbarClickReceived;
			event InstanceEventHandler UniverseAttributesReceived;
			event InstanceEventHandler UniverseDisconnectReceived;
			event InstanceEventHandler UrlReceived;
			event InstanceEventHandler UrlClickReceived;
			event InstanceEventHandler UserInfoReceived;
			event InstanceEventHandler WorldAttributesReceived;
			event InstanceEventHandler WorldDisconnectReceived;
			event InstanceEventHandler WorldInfoReceived;
			event InstanceEventHandler CavDefinitionChangeReceived;
			event InstanceEventHandler WorldCavDefinitionChangeReceived;
			event InstanceEventHandler LaserBeamReceived;
		}
	
	partial class Instance
	{
	private readonly Dictionary<string, EventDelegates> _eventHandlers = new Dictionary<string, EventDelegates>();
	
		
	#region AdminWorldInfoReceived
		const string AW_EVENT_ADMIN_WORLD_INFO = "AW_EVENT_ADMIN_WORLD_INFO";

		//Native event handler.
		private void OnAdminWorldInfoReceived()
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
		public event InstanceEventHandler AdminWorldInfoReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_ADMIN_WORLD_INFO))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_ADMIN_WORLD_INFO, new EventDelegates { Native = OnAdminWorldInfoReceived });
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
		
	#region AdminWorldDeleteReceived
		const string AW_EVENT_ADMIN_WORLD_DELETE = "AW_EVENT_ADMIN_WORLD_DELETE";

		//Native event handler.
		private void OnAdminWorldDeleteReceived()
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
		public event InstanceEventHandler AdminWorldDeleteReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_ADMIN_WORLD_DELETE))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_ADMIN_WORLD_DELETE, new EventDelegates { Native = OnAdminWorldDeleteReceived });
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
		
	#region AvatarAddReceived
		const string AW_EVENT_AVATAR_ADD = "AW_EVENT_AVATAR_ADD";

		//Native event handler.
		private void OnAvatarAddReceived()
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
		public event InstanceEventHandler AvatarAddReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_AVATAR_ADD))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_AVATAR_ADD, new EventDelegates { Native = OnAvatarAddReceived });
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
		
	#region AvatarChangeReceived
		const string AW_EVENT_AVATAR_CHANGE = "AW_EVENT_AVATAR_CHANGE";

		//Native event handler.
		private void OnAvatarChangeReceived()
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
		public event InstanceEventHandler AvatarChangeReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_AVATAR_CHANGE))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_AVATAR_CHANGE, new EventDelegates { Native = OnAvatarChangeReceived });
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
		
	#region AvatarDeleteReceived
		const string AW_EVENT_AVATAR_DELETE = "AW_EVENT_AVATAR_DELETE";

		//Native event handler.
		private void OnAvatarDeleteReceived()
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
		public event InstanceEventHandler AvatarDeleteReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_AVATAR_DELETE))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_AVATAR_DELETE, new EventDelegates { Native = OnAvatarDeleteReceived });
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
		
	#region AvatarClickReceived
		const string AW_EVENT_AVATAR_CLICK = "AW_EVENT_AVATAR_CLICK";

		//Native event handler.
		private void OnAvatarClickReceived()
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
		public event InstanceEventHandler AvatarClickReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_AVATAR_CLICK))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_AVATAR_CLICK, new EventDelegates { Native = OnAvatarClickReceived });
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
		
	#region AvatarReloadReceived
		const string AW_EVENT_AVATAR_RELOAD = "AW_EVENT_AVATAR_RELOAD";

		//Native event handler.
		private void OnAvatarReloadReceived()
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
		public event InstanceEventHandler AvatarReloadReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_AVATAR_RELOAD))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_AVATAR_RELOAD, new EventDelegates { Native = OnAvatarReloadReceived });
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
		
	#region BotgramReceived
		const string AW_EVENT_BOTGRAM = "AW_EVENT_BOTGRAM";

		//Native event handler.
		private void OnBotgramReceived()
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
		public event InstanceEventHandler BotgramReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_BOTGRAM))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_BOTGRAM, new EventDelegates { Native = OnBotgramReceived });
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
		
	#region BotmenuReceived
		const string AW_EVENT_BOTMENU = "AW_EVENT_BOTMENU";

		//Native event handler.
		private void OnBotmenuReceived()
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
		public event InstanceEventHandler BotmenuReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_BOTMENU))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_BOTMENU, new EventDelegates { Native = OnBotmenuReceived });
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
		
	#region CellBeginReceived
		const string AW_EVENT_CELL_BEGIN = "AW_EVENT_CELL_BEGIN";

		//Native event handler.
		private void OnCellBeginReceived()
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
		public event InstanceEventHandler CellBeginReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_CELL_BEGIN))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_CELL_BEGIN, new EventDelegates { Native = OnCellBeginReceived });
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
		
	#region CellObjectReceived
		const string AW_EVENT_CELL_OBJECT = "AW_EVENT_CELL_OBJECT";

		//Native event handler.
		private void OnCellObjectReceived()
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
		public event InstanceEventHandler CellObjectReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_CELL_OBJECT))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_CELL_OBJECT, new EventDelegates { Native = OnCellObjectReceived });
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
		
	#region CellEndReceived
		const string AW_EVENT_CELL_END = "AW_EVENT_CELL_END";

		//Native event handler.
		private void OnCellEndReceived()
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
		public event InstanceEventHandler CellEndReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_CELL_END))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_CELL_END, new EventDelegates { Native = OnCellEndReceived });
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
		
	#region ChatReceived
		const string AW_EVENT_CHAT = "AW_EVENT_CHAT";

		//Native event handler.
		private void OnChatReceived()
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
		public event InstanceEventHandler ChatReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_CHAT))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_CHAT, new EventDelegates { Native = OnChatReceived });
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
		
	#region ConsoleMessageReceived
		const string AW_EVENT_CONSOLE_MESSAGE = "AW_EVENT_CONSOLE_MESSAGE";

		//Native event handler.
		private void OnConsoleMessageReceived()
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
		public event InstanceEventHandler ConsoleMessageReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_CONSOLE_MESSAGE))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_CONSOLE_MESSAGE, new EventDelegates { Native = OnConsoleMessageReceived });
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
		
	#region EntityAddReceived
		const string AW_EVENT_ENTITY_ADD = "AW_EVENT_ENTITY_ADD";

		//Native event handler.
		private void OnEntityAddReceived()
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
		public event InstanceEventHandler EntityAddReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_ENTITY_ADD))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_ENTITY_ADD, new EventDelegates { Native = OnEntityAddReceived });
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
		
	#region EntityChangeReceived
		const string AW_EVENT_ENTITY_CHANGE = "AW_EVENT_ENTITY_CHANGE";

		//Native event handler.
		private void OnEntityChangeReceived()
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
		public event InstanceEventHandler EntityChangeReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_ENTITY_CHANGE))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_ENTITY_CHANGE, new EventDelegates { Native = OnEntityChangeReceived });
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
		
	#region EntityDeleteReceived
		const string AW_EVENT_ENTITY_DELETE = "AW_EVENT_ENTITY_DELETE";

		//Native event handler.
		private void OnEntityDeleteReceived()
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
		public event InstanceEventHandler EntityDeleteReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_ENTITY_DELETE))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_ENTITY_DELETE, new EventDelegates { Native = OnEntityDeleteReceived });
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
		
	#region EntityRiderAddReceived
		const string AW_EVENT_ENTITY_RIDER_ADD = "AW_EVENT_ENTITY_RIDER_ADD";

		//Native event handler.
		private void OnEntityRiderAddReceived()
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
		public event InstanceEventHandler EntityRiderAddReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_ENTITY_RIDER_ADD))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_ENTITY_RIDER_ADD, new EventDelegates { Native = OnEntityRiderAddReceived });
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
		
	#region EntityRiderChangeReceived
		const string AW_EVENT_ENTITY_RIDER_CHANGE = "AW_EVENT_ENTITY_RIDER_CHANGE";

		//Native event handler.
		private void OnEntityRiderChangeReceived()
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
		public event InstanceEventHandler EntityRiderChangeReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_ENTITY_RIDER_CHANGE))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_ENTITY_RIDER_CHANGE, new EventDelegates { Native = OnEntityRiderChangeReceived });
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
		
	#region EntityRiderDeleteReceived
		const string AW_EVENT_ENTITY_RIDER_DELETE = "AW_EVENT_ENTITY_RIDER_DELETE";

		//Native event handler.
		private void OnEntityRiderDeleteReceived()
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
		public event InstanceEventHandler EntityRiderDeleteReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_ENTITY_RIDER_DELETE))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_ENTITY_RIDER_DELETE, new EventDelegates { Native = OnEntityRiderDeleteReceived });
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
		
	#region EntityLinksReceived
		const string AW_EVENT_ENTITY_LINKS = "AW_EVENT_ENTITY_LINKS";

		//Native event handler.
		private void OnEntityLinksReceived()
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
		public event InstanceEventHandler EntityLinksReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_ENTITY_LINKS))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_ENTITY_LINKS, new EventDelegates { Native = OnEntityLinksReceived });
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
		
	#region HudClickReceived
		const string AW_EVENT_HUD_CLICK = "AW_EVENT_HUD_CLICK";

		//Native event handler.
		private void OnHudClickReceived()
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
		public event InstanceEventHandler HudClickReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_HUD_CLICK))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_HUD_CLICK, new EventDelegates { Native = OnHudClickReceived });
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
		
	#region NoiseReceived
		const string AW_EVENT_NOISE = "AW_EVENT_NOISE";

		//Native event handler.
		private void OnNoiseReceived()
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
		public event InstanceEventHandler NoiseReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_NOISE))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_NOISE, new EventDelegates { Native = OnNoiseReceived });
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
		
	#region ObjectAddReceived
		const string AW_EVENT_OBJECT_ADD = "AW_EVENT_OBJECT_ADD";

		//Native event handler.
		private void OnObjectAddReceived()
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
		public event InstanceEventHandler ObjectAddReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_OBJECT_ADD))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_OBJECT_ADD, new EventDelegates { Native = OnObjectAddReceived });
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
		
	#region ObjectDeleteReceived
		const string AW_EVENT_OBJECT_DELETE = "AW_EVENT_OBJECT_DELETE";

		//Native event handler.
		private void OnObjectDeleteReceived()
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
		public event InstanceEventHandler ObjectDeleteReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_OBJECT_DELETE))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_OBJECT_DELETE, new EventDelegates { Native = OnObjectDeleteReceived });
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
		
	#region ObjectClickReceived
		const string AW_EVENT_OBJECT_CLICK = "AW_EVENT_OBJECT_CLICK";

		//Native event handler.
		private void OnObjectClickReceived()
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
		public event InstanceEventHandler ObjectClickReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_OBJECT_CLICK))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_OBJECT_CLICK, new EventDelegates { Native = OnObjectClickReceived });
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
		
	#region ObjectBumpReceived
		const string AW_EVENT_OBJECT_BUMP = "AW_EVENT_OBJECT_BUMP";

		//Native event handler.
		private void OnObjectBumpReceived()
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
		public event InstanceEventHandler ObjectBumpReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_OBJECT_BUMP))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_OBJECT_BUMP, new EventDelegates { Native = OnObjectBumpReceived });
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
		
	#region ObjectSelectReceived
		const string AW_EVENT_OBJECT_SELECT = "AW_EVENT_OBJECT_SELECT";

		//Native event handler.
		private void OnObjectSelectReceived()
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
		public event InstanceEventHandler ObjectSelectReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_OBJECT_SELECT))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_OBJECT_SELECT, new EventDelegates { Native = OnObjectSelectReceived });
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
		
	#region TeleportReceived
		const string AW_EVENT_TELEPORT = "AW_EVENT_TELEPORT";

		//Native event handler.
		private void OnTeleportReceived()
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
		public event InstanceEventHandler TeleportReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_TELEPORT))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_TELEPORT, new EventDelegates { Native = OnTeleportReceived });
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
		
	#region TerrainBeginReceived
		const string AW_EVENT_TERRAIN_BEGIN = "AW_EVENT_TERRAIN_BEGIN";

		//Native event handler.
		private void OnTerrainBeginReceived()
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
		public event InstanceEventHandler TerrainBeginReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_TERRAIN_BEGIN))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_TERRAIN_BEGIN, new EventDelegates { Native = OnTerrainBeginReceived });
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
		
	#region TerrainChangedReceived
		const string AW_EVENT_TERRAIN_CHANGED = "AW_EVENT_TERRAIN_CHANGED";

		//Native event handler.
		private void OnTerrainChangedReceived()
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
		public event InstanceEventHandler TerrainChangedReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_TERRAIN_CHANGED))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_TERRAIN_CHANGED, new EventDelegates { Native = OnTerrainChangedReceived });
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
		
	#region TerrainDataReceived
		const string AW_EVENT_TERRAIN_DATA = "AW_EVENT_TERRAIN_DATA";

		//Native event handler.
		private void OnTerrainDataReceived()
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
		public event InstanceEventHandler TerrainDataReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_TERRAIN_DATA))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_TERRAIN_DATA, new EventDelegates { Native = OnTerrainDataReceived });
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
		
	#region TerrainEndReceived
		const string AW_EVENT_TERRAIN_END = "AW_EVENT_TERRAIN_END";

		//Native event handler.
		private void OnTerrainEndReceived()
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
		public event InstanceEventHandler TerrainEndReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_TERRAIN_END))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_TERRAIN_END, new EventDelegates { Native = OnTerrainEndReceived });
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
		
	#region ToolbarClickReceived
		const string AW_EVENT_TOOLBAR_CLICK = "AW_EVENT_TOOLBAR_CLICK";

		//Native event handler.
		private void OnToolbarClickReceived()
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
		public event InstanceEventHandler ToolbarClickReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_TOOLBAR_CLICK))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_TOOLBAR_CLICK, new EventDelegates { Native = OnToolbarClickReceived });
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
		
	#region UniverseAttributesReceived
		const string AW_EVENT_UNIVERSE_ATTRIBUTES = "AW_EVENT_UNIVERSE_ATTRIBUTES";

		//Native event handler.
		private void OnUniverseAttributesReceived()
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
		public event InstanceEventHandler UniverseAttributesReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_UNIVERSE_ATTRIBUTES))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_UNIVERSE_ATTRIBUTES, new EventDelegates { Native = OnUniverseAttributesReceived });
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
		
	#region UniverseDisconnectReceived
		const string AW_EVENT_UNIVERSE_DISCONNECT = "AW_EVENT_UNIVERSE_DISCONNECT";

		//Native event handler.
		private void OnUniverseDisconnectReceived()
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
		public event InstanceEventHandler UniverseDisconnectReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_UNIVERSE_DISCONNECT))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_UNIVERSE_DISCONNECT, new EventDelegates { Native = OnUniverseDisconnectReceived });
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
		
	#region UrlReceived
		const string AW_EVENT_URL = "AW_EVENT_URL";

		//Native event handler.
		private void OnUrlReceived()
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
		public event InstanceEventHandler UrlReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_URL))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_URL, new EventDelegates { Native = OnUrlReceived });
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
		
	#region UrlClickReceived
		const string AW_EVENT_URL_CLICK = "AW_EVENT_URL_CLICK";

		//Native event handler.
		private void OnUrlClickReceived()
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
		public event InstanceEventHandler UrlClickReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_URL_CLICK))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_URL_CLICK, new EventDelegates { Native = OnUrlClickReceived });
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
		
	#region UserInfoReceived
		const string AW_EVENT_USER_INFO = "AW_EVENT_USER_INFO";

		//Native event handler.
		private void OnUserInfoReceived()
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
		public event InstanceEventHandler UserInfoReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_USER_INFO))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_USER_INFO, new EventDelegates { Native = OnUserInfoReceived });
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
		
	#region WorldAttributesReceived
		const string AW_EVENT_WORLD_ATTRIBUTES = "AW_EVENT_WORLD_ATTRIBUTES";

		//Native event handler.
		private void OnWorldAttributesReceived()
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
		public event InstanceEventHandler WorldAttributesReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_WORLD_ATTRIBUTES))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_WORLD_ATTRIBUTES, new EventDelegates { Native = OnWorldAttributesReceived });
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
		
	#region WorldDisconnectReceived
		const string AW_EVENT_WORLD_DISCONNECT = "AW_EVENT_WORLD_DISCONNECT";

		//Native event handler.
		private void OnWorldDisconnectReceived()
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
		public event InstanceEventHandler WorldDisconnectReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_WORLD_DISCONNECT))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_WORLD_DISCONNECT, new EventDelegates { Native = OnWorldDisconnectReceived });
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
		
	#region WorldInfoReceived
		const string AW_EVENT_WORLD_INFO = "AW_EVENT_WORLD_INFO";

		//Native event handler.
		private void OnWorldInfoReceived()
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
		public event InstanceEventHandler WorldInfoReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_WORLD_INFO))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_WORLD_INFO, new EventDelegates { Native = OnWorldInfoReceived });
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
		
	#region CavDefinitionChangeReceived
		const string AW_EVENT_CAV_DEFINITION_CHANGE = "AW_EVENT_CAV_DEFINITION_CHANGE";

		//Native event handler.
		private void OnCavDefinitionChangeReceived()
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
		public event InstanceEventHandler CavDefinitionChangeReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_CAV_DEFINITION_CHANGE))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_CAV_DEFINITION_CHANGE, new EventDelegates { Native = OnCavDefinitionChangeReceived });
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
		
	#region WorldCavDefinitionChangeReceived
		const string AW_EVENT_WORLD_CAV_DEFINITION_CHANGE = "AW_EVENT_WORLD_CAV_DEFINITION_CHANGE";

		//Native event handler.
		private void OnWorldCavDefinitionChangeReceived()
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
		public event InstanceEventHandler WorldCavDefinitionChangeReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_WORLD_CAV_DEFINITION_CHANGE))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_WORLD_CAV_DEFINITION_CHANGE, new EventDelegates { Native = OnWorldCavDefinitionChangeReceived });
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
		
	#region LaserBeamReceived
		const string AW_EVENT_LASER_BEAM = "AW_EVENT_LASER_BEAM";

		//Native event handler.
		private void OnLaserBeamReceived()
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
		public event InstanceEventHandler LaserBeamReceived
		{
			//Handles hooking a new delegate to the event.
			add
			{
				if(!_eventHandlers.ContainsKey(AW_EVENT_LASER_BEAM))
				{
					SetInstance();
					_eventHandlers.Add(AW_EVENT_LASER_BEAM, new EventDelegates { Native = OnLaserBeamReceived });
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