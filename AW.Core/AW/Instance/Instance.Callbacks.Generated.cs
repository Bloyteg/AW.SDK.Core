 


	
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
			event InstanceCallbackHandler LoginCompleted;
			event InstanceCallbackHandler EnterCompleted;
			event InstanceCallbackHandler ObjectResultCompleted;
			event InstanceCallbackHandler LicenseAttributesCompleted;
			event InstanceCallbackHandler LicenseResultCompleted;
			event InstanceCallbackHandler CitizenAttributesCompleted;
			event InstanceCallbackHandler CitizenResultCompleted;
			event InstanceCallbackHandler QueryCompleted;
			event InstanceCallbackHandler UniverseEjectionCompleted;
			event InstanceCallbackHandler UniverseEjectionResultCompleted;
			event InstanceCallbackHandler AddressCompleted;
			event InstanceCallbackHandler WorldEjectionCompleted;
			event InstanceCallbackHandler WorldEjectionResultCompleted;
			event InstanceCallbackHandler AdminWorldListCompleted;
			event InstanceCallbackHandler AdminWorldResultCompleted;
			event InstanceCallbackHandler DeleteAllObjectsResultCompleted;
			event InstanceCallbackHandler CellResultCompleted;
			event InstanceCallbackHandler ReloadRegistryCompleted;
			event InstanceCallbackHandler AttributesResetResultCompleted;
			event InstanceCallbackHandler AdminCompleted;
			event InstanceCallbackHandler TerrainSetResultCompleted;
			event InstanceCallbackHandler TerrainNextResultCompleted;
			event InstanceCallbackHandler TerrainDeleteAllResultCompleted;
			event InstanceCallbackHandler TerrainLoadNodeResultCompleted;
			event InstanceCallbackHandler BotgramResultCompleted;
			event InstanceCallbackHandler UserListCompleted;
			event InstanceCallbackHandler BotmenuResultCompleted;
			event InstanceCallbackHandler CavCompleted;
			event InstanceCallbackHandler CavResultCompleted;
			event InstanceCallbackHandler WorldInstanceCompleted;
			event InstanceCallbackHandler HudResultCompleted;
			event InstanceCallbackHandler AvatarLocationCompleted;
			event InstanceCallbackHandler ObjectQueryCompleted;
			event InstanceCallbackHandler WorldCavResultCompleted;
			event InstanceCallbackHandler WorldCavCompleted;
		}
	
	partial class Instance
	{
		private readonly Dictionary<string, CallbackDelegates> _callbackHandlers = new Dictionary<string, CallbackDelegates>();
	
		#region LoginCompleted
	
		const string AW_CALLBACK_LOGIN = "AW_CALLBACK_LOGIN";
	
		//Native callback handler.
		private void OnLoginCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_LOGIN) && _callbackHandlers[AW_CALLBACK_LOGIN].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_LOGIN].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_LOGIN from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler LoginCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_LOGIN))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_LOGIN, new CallbackDelegates { Native = OnLoginCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_LOGIN, _callbackHandlers[AW_CALLBACK_LOGIN].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_LOGIN].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_LOGIN))
				{
					_callbackHandlers[AW_CALLBACK_LOGIN].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_LOGIN].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_LOGIN, null);
						_callbackHandlers.Remove(AW_CALLBACK_LOGIN);
					}
				}
			}
		}
		#endregion
		
		#region EnterCompleted
	
		const string AW_CALLBACK_ENTER = "AW_CALLBACK_ENTER";
	
		//Native callback handler.
		private void OnEnterCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_ENTER) && _callbackHandlers[AW_CALLBACK_ENTER].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_ENTER].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_ENTER from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler EnterCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_ENTER))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_ENTER, new CallbackDelegates { Native = OnEnterCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ENTER, _callbackHandlers[AW_CALLBACK_ENTER].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_ENTER].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_ENTER))
				{
					_callbackHandlers[AW_CALLBACK_ENTER].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_ENTER].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ENTER, null);
						_callbackHandlers.Remove(AW_CALLBACK_ENTER);
					}
				}
			}
		}
		#endregion
		
		#region ObjectResultCompleted
	
		const string AW_CALLBACK_OBJECT_RESULT = "AW_CALLBACK_OBJECT_RESULT";
	
		//Native callback handler.
		private void OnObjectResultCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_OBJECT_RESULT) && _callbackHandlers[AW_CALLBACK_OBJECT_RESULT].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_OBJECT_RESULT].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_OBJECT_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler ObjectResultCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_OBJECT_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_OBJECT_RESULT, new CallbackDelegates { Native = OnObjectResultCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_OBJECT_RESULT, _callbackHandlers[AW_CALLBACK_OBJECT_RESULT].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_OBJECT_RESULT].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_OBJECT_RESULT))
				{
					_callbackHandlers[AW_CALLBACK_OBJECT_RESULT].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_OBJECT_RESULT].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_OBJECT_RESULT, null);
						_callbackHandlers.Remove(AW_CALLBACK_OBJECT_RESULT);
					}
				}
			}
		}
		#endregion
		
		#region LicenseAttributesCompleted
	
		const string AW_CALLBACK_LICENSE_ATTRIBUTES = "AW_CALLBACK_LICENSE_ATTRIBUTES";
	
		//Native callback handler.
		private void OnLicenseAttributesCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_LICENSE_ATTRIBUTES) && _callbackHandlers[AW_CALLBACK_LICENSE_ATTRIBUTES].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_LICENSE_ATTRIBUTES].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_LICENSE_ATTRIBUTES from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler LicenseAttributesCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_LICENSE_ATTRIBUTES))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_LICENSE_ATTRIBUTES, new CallbackDelegates { Native = OnLicenseAttributesCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_LICENSE_ATTRIBUTES, _callbackHandlers[AW_CALLBACK_LICENSE_ATTRIBUTES].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_LICENSE_ATTRIBUTES].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_LICENSE_ATTRIBUTES))
				{
					_callbackHandlers[AW_CALLBACK_LICENSE_ATTRIBUTES].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_LICENSE_ATTRIBUTES].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_LICENSE_ATTRIBUTES, null);
						_callbackHandlers.Remove(AW_CALLBACK_LICENSE_ATTRIBUTES);
					}
				}
			}
		}
		#endregion
		
		#region LicenseResultCompleted
	
		const string AW_CALLBACK_LICENSE_RESULT = "AW_CALLBACK_LICENSE_RESULT";
	
		//Native callback handler.
		private void OnLicenseResultCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_LICENSE_RESULT) && _callbackHandlers[AW_CALLBACK_LICENSE_RESULT].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_LICENSE_RESULT].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_LICENSE_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler LicenseResultCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_LICENSE_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_LICENSE_RESULT, new CallbackDelegates { Native = OnLicenseResultCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_LICENSE_RESULT, _callbackHandlers[AW_CALLBACK_LICENSE_RESULT].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_LICENSE_RESULT].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_LICENSE_RESULT))
				{
					_callbackHandlers[AW_CALLBACK_LICENSE_RESULT].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_LICENSE_RESULT].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_LICENSE_RESULT, null);
						_callbackHandlers.Remove(AW_CALLBACK_LICENSE_RESULT);
					}
				}
			}
		}
		#endregion
		
		#region CitizenAttributesCompleted
	
		const string AW_CALLBACK_CITIZEN_ATTRIBUTES = "AW_CALLBACK_CITIZEN_ATTRIBUTES";
	
		//Native callback handler.
		private void OnCitizenAttributesCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_CITIZEN_ATTRIBUTES) && _callbackHandlers[AW_CALLBACK_CITIZEN_ATTRIBUTES].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_CITIZEN_ATTRIBUTES].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_CITIZEN_ATTRIBUTES from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler CitizenAttributesCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_CITIZEN_ATTRIBUTES))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_CITIZEN_ATTRIBUTES, new CallbackDelegates { Native = OnCitizenAttributesCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CITIZEN_ATTRIBUTES, _callbackHandlers[AW_CALLBACK_CITIZEN_ATTRIBUTES].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_CITIZEN_ATTRIBUTES].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_CITIZEN_ATTRIBUTES))
				{
					_callbackHandlers[AW_CALLBACK_CITIZEN_ATTRIBUTES].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_CITIZEN_ATTRIBUTES].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CITIZEN_ATTRIBUTES, null);
						_callbackHandlers.Remove(AW_CALLBACK_CITIZEN_ATTRIBUTES);
					}
				}
			}
		}
		#endregion
		
		#region CitizenResultCompleted
	
		const string AW_CALLBACK_CITIZEN_RESULT = "AW_CALLBACK_CITIZEN_RESULT";
	
		//Native callback handler.
		private void OnCitizenResultCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_CITIZEN_RESULT) && _callbackHandlers[AW_CALLBACK_CITIZEN_RESULT].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_CITIZEN_RESULT].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_CITIZEN_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler CitizenResultCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_CITIZEN_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_CITIZEN_RESULT, new CallbackDelegates { Native = OnCitizenResultCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CITIZEN_RESULT, _callbackHandlers[AW_CALLBACK_CITIZEN_RESULT].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_CITIZEN_RESULT].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_CITIZEN_RESULT))
				{
					_callbackHandlers[AW_CALLBACK_CITIZEN_RESULT].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_CITIZEN_RESULT].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CITIZEN_RESULT, null);
						_callbackHandlers.Remove(AW_CALLBACK_CITIZEN_RESULT);
					}
				}
			}
		}
		#endregion
		
		#region QueryCompleted
	
		const string AW_CALLBACK_QUERY = "AW_CALLBACK_QUERY";
	
		//Native callback handler.
		private void OnQueryCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_QUERY) && _callbackHandlers[AW_CALLBACK_QUERY].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_QUERY].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_QUERY from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler QueryCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_QUERY))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_QUERY, new CallbackDelegates { Native = OnQueryCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_QUERY, _callbackHandlers[AW_CALLBACK_QUERY].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_QUERY].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_QUERY))
				{
					_callbackHandlers[AW_CALLBACK_QUERY].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_QUERY].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_QUERY, null);
						_callbackHandlers.Remove(AW_CALLBACK_QUERY);
					}
				}
			}
		}
		#endregion
		
		#region UniverseEjectionCompleted
	
		const string AW_CALLBACK_UNIVERSE_EJECTION = "AW_CALLBACK_UNIVERSE_EJECTION";
	
		//Native callback handler.
		private void OnUniverseEjectionCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_UNIVERSE_EJECTION) && _callbackHandlers[AW_CALLBACK_UNIVERSE_EJECTION].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_UNIVERSE_EJECTION].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_UNIVERSE_EJECTION from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler UniverseEjectionCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_UNIVERSE_EJECTION))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_UNIVERSE_EJECTION, new CallbackDelegates { Native = OnUniverseEjectionCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_UNIVERSE_EJECTION, _callbackHandlers[AW_CALLBACK_UNIVERSE_EJECTION].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_UNIVERSE_EJECTION].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_UNIVERSE_EJECTION))
				{
					_callbackHandlers[AW_CALLBACK_UNIVERSE_EJECTION].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_UNIVERSE_EJECTION].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_UNIVERSE_EJECTION, null);
						_callbackHandlers.Remove(AW_CALLBACK_UNIVERSE_EJECTION);
					}
				}
			}
		}
		#endregion
		
		#region UniverseEjectionResultCompleted
	
		const string AW_CALLBACK_UNIVERSE_EJECTION_RESULT = "AW_CALLBACK_UNIVERSE_EJECTION_RESULT";
	
		//Native callback handler.
		private void OnUniverseEjectionResultCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_UNIVERSE_EJECTION_RESULT) && _callbackHandlers[AW_CALLBACK_UNIVERSE_EJECTION_RESULT].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_UNIVERSE_EJECTION_RESULT].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_UNIVERSE_EJECTION_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler UniverseEjectionResultCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_UNIVERSE_EJECTION_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_UNIVERSE_EJECTION_RESULT, new CallbackDelegates { Native = OnUniverseEjectionResultCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_UNIVERSE_EJECTION_RESULT, _callbackHandlers[AW_CALLBACK_UNIVERSE_EJECTION_RESULT].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_UNIVERSE_EJECTION_RESULT].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_UNIVERSE_EJECTION_RESULT))
				{
					_callbackHandlers[AW_CALLBACK_UNIVERSE_EJECTION_RESULT].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_UNIVERSE_EJECTION_RESULT].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_UNIVERSE_EJECTION_RESULT, null);
						_callbackHandlers.Remove(AW_CALLBACK_UNIVERSE_EJECTION_RESULT);
					}
				}
			}
		}
		#endregion
		
		#region AddressCompleted
	
		const string AW_CALLBACK_ADDRESS = "AW_CALLBACK_ADDRESS";
	
		//Native callback handler.
		private void OnAddressCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_ADDRESS) && _callbackHandlers[AW_CALLBACK_ADDRESS].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_ADDRESS].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_ADDRESS from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler AddressCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_ADDRESS))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_ADDRESS, new CallbackDelegates { Native = OnAddressCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ADDRESS, _callbackHandlers[AW_CALLBACK_ADDRESS].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_ADDRESS].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_ADDRESS))
				{
					_callbackHandlers[AW_CALLBACK_ADDRESS].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_ADDRESS].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ADDRESS, null);
						_callbackHandlers.Remove(AW_CALLBACK_ADDRESS);
					}
				}
			}
		}
		#endregion
		
		#region WorldEjectionCompleted
	
		const string AW_CALLBACK_WORLD_EJECTION = "AW_CALLBACK_WORLD_EJECTION";
	
		//Native callback handler.
		private void OnWorldEjectionCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_WORLD_EJECTION) && _callbackHandlers[AW_CALLBACK_WORLD_EJECTION].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_WORLD_EJECTION].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_WORLD_EJECTION from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler WorldEjectionCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_WORLD_EJECTION))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_WORLD_EJECTION, new CallbackDelegates { Native = OnWorldEjectionCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_EJECTION, _callbackHandlers[AW_CALLBACK_WORLD_EJECTION].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_WORLD_EJECTION].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_WORLD_EJECTION))
				{
					_callbackHandlers[AW_CALLBACK_WORLD_EJECTION].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_WORLD_EJECTION].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_EJECTION, null);
						_callbackHandlers.Remove(AW_CALLBACK_WORLD_EJECTION);
					}
				}
			}
		}
		#endregion
		
		#region WorldEjectionResultCompleted
	
		const string AW_CALLBACK_WORLD_EJECTION_RESULT = "AW_CALLBACK_WORLD_EJECTION_RESULT";
	
		//Native callback handler.
		private void OnWorldEjectionResultCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_WORLD_EJECTION_RESULT) && _callbackHandlers[AW_CALLBACK_WORLD_EJECTION_RESULT].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_WORLD_EJECTION_RESULT].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_WORLD_EJECTION_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler WorldEjectionResultCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_WORLD_EJECTION_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_WORLD_EJECTION_RESULT, new CallbackDelegates { Native = OnWorldEjectionResultCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_EJECTION_RESULT, _callbackHandlers[AW_CALLBACK_WORLD_EJECTION_RESULT].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_WORLD_EJECTION_RESULT].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_WORLD_EJECTION_RESULT))
				{
					_callbackHandlers[AW_CALLBACK_WORLD_EJECTION_RESULT].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_WORLD_EJECTION_RESULT].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_EJECTION_RESULT, null);
						_callbackHandlers.Remove(AW_CALLBACK_WORLD_EJECTION_RESULT);
					}
				}
			}
		}
		#endregion
		
		#region AdminWorldListCompleted
	
		const string AW_CALLBACK_ADMIN_WORLD_LIST = "AW_CALLBACK_ADMIN_WORLD_LIST";
	
		//Native callback handler.
		private void OnAdminWorldListCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_ADMIN_WORLD_LIST) && _callbackHandlers[AW_CALLBACK_ADMIN_WORLD_LIST].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_ADMIN_WORLD_LIST].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_ADMIN_WORLD_LIST from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler AdminWorldListCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_ADMIN_WORLD_LIST))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_ADMIN_WORLD_LIST, new CallbackDelegates { Native = OnAdminWorldListCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ADMIN_WORLD_LIST, _callbackHandlers[AW_CALLBACK_ADMIN_WORLD_LIST].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_ADMIN_WORLD_LIST].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_ADMIN_WORLD_LIST))
				{
					_callbackHandlers[AW_CALLBACK_ADMIN_WORLD_LIST].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_ADMIN_WORLD_LIST].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ADMIN_WORLD_LIST, null);
						_callbackHandlers.Remove(AW_CALLBACK_ADMIN_WORLD_LIST);
					}
				}
			}
		}
		#endregion
		
		#region AdminWorldResultCompleted
	
		const string AW_CALLBACK_ADMIN_WORLD_RESULT = "AW_CALLBACK_ADMIN_WORLD_RESULT";
	
		//Native callback handler.
		private void OnAdminWorldResultCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_ADMIN_WORLD_RESULT) && _callbackHandlers[AW_CALLBACK_ADMIN_WORLD_RESULT].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_ADMIN_WORLD_RESULT].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_ADMIN_WORLD_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler AdminWorldResultCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_ADMIN_WORLD_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_ADMIN_WORLD_RESULT, new CallbackDelegates { Native = OnAdminWorldResultCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ADMIN_WORLD_RESULT, _callbackHandlers[AW_CALLBACK_ADMIN_WORLD_RESULT].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_ADMIN_WORLD_RESULT].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_ADMIN_WORLD_RESULT))
				{
					_callbackHandlers[AW_CALLBACK_ADMIN_WORLD_RESULT].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_ADMIN_WORLD_RESULT].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ADMIN_WORLD_RESULT, null);
						_callbackHandlers.Remove(AW_CALLBACK_ADMIN_WORLD_RESULT);
					}
				}
			}
		}
		#endregion
		
		#region DeleteAllObjectsResultCompleted
	
		const string AW_CALLBACK_DELETE_ALL_OBJECTS_RESULT = "AW_CALLBACK_DELETE_ALL_OBJECTS_RESULT";
	
		//Native callback handler.
		private void OnDeleteAllObjectsResultCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_DELETE_ALL_OBJECTS_RESULT) && _callbackHandlers[AW_CALLBACK_DELETE_ALL_OBJECTS_RESULT].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_DELETE_ALL_OBJECTS_RESULT].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_DELETE_ALL_OBJECTS_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler DeleteAllObjectsResultCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_DELETE_ALL_OBJECTS_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_DELETE_ALL_OBJECTS_RESULT, new CallbackDelegates { Native = OnDeleteAllObjectsResultCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_DELETE_ALL_OBJECTS_RESULT, _callbackHandlers[AW_CALLBACK_DELETE_ALL_OBJECTS_RESULT].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_DELETE_ALL_OBJECTS_RESULT].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_DELETE_ALL_OBJECTS_RESULT))
				{
					_callbackHandlers[AW_CALLBACK_DELETE_ALL_OBJECTS_RESULT].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_DELETE_ALL_OBJECTS_RESULT].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_DELETE_ALL_OBJECTS_RESULT, null);
						_callbackHandlers.Remove(AW_CALLBACK_DELETE_ALL_OBJECTS_RESULT);
					}
				}
			}
		}
		#endregion
		
		#region CellResultCompleted
	
		const string AW_CALLBACK_CELL_RESULT = "AW_CALLBACK_CELL_RESULT";
	
		//Native callback handler.
		private void OnCellResultCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_CELL_RESULT) && _callbackHandlers[AW_CALLBACK_CELL_RESULT].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_CELL_RESULT].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_CELL_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler CellResultCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_CELL_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_CELL_RESULT, new CallbackDelegates { Native = OnCellResultCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CELL_RESULT, _callbackHandlers[AW_CALLBACK_CELL_RESULT].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_CELL_RESULT].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_CELL_RESULT))
				{
					_callbackHandlers[AW_CALLBACK_CELL_RESULT].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_CELL_RESULT].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CELL_RESULT, null);
						_callbackHandlers.Remove(AW_CALLBACK_CELL_RESULT);
					}
				}
			}
		}
		#endregion
		
		#region ReloadRegistryCompleted
	
		const string AW_CALLBACK_RELOAD_REGISTRY = "AW_CALLBACK_RELOAD_REGISTRY";
	
		//Native callback handler.
		private void OnReloadRegistryCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_RELOAD_REGISTRY) && _callbackHandlers[AW_CALLBACK_RELOAD_REGISTRY].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_RELOAD_REGISTRY].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_RELOAD_REGISTRY from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler ReloadRegistryCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_RELOAD_REGISTRY))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_RELOAD_REGISTRY, new CallbackDelegates { Native = OnReloadRegistryCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_RELOAD_REGISTRY, _callbackHandlers[AW_CALLBACK_RELOAD_REGISTRY].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_RELOAD_REGISTRY].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_RELOAD_REGISTRY))
				{
					_callbackHandlers[AW_CALLBACK_RELOAD_REGISTRY].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_RELOAD_REGISTRY].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_RELOAD_REGISTRY, null);
						_callbackHandlers.Remove(AW_CALLBACK_RELOAD_REGISTRY);
					}
				}
			}
		}
		#endregion
		
		#region AttributesResetResultCompleted
	
		const string AW_CALLBACK_ATTRIBUTES_RESET_RESULT = "AW_CALLBACK_ATTRIBUTES_RESET_RESULT";
	
		//Native callback handler.
		private void OnAttributesResetResultCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_ATTRIBUTES_RESET_RESULT) && _callbackHandlers[AW_CALLBACK_ATTRIBUTES_RESET_RESULT].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_ATTRIBUTES_RESET_RESULT].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_ATTRIBUTES_RESET_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler AttributesResetResultCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_ATTRIBUTES_RESET_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_ATTRIBUTES_RESET_RESULT, new CallbackDelegates { Native = OnAttributesResetResultCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ATTRIBUTES_RESET_RESULT, _callbackHandlers[AW_CALLBACK_ATTRIBUTES_RESET_RESULT].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_ATTRIBUTES_RESET_RESULT].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_ATTRIBUTES_RESET_RESULT))
				{
					_callbackHandlers[AW_CALLBACK_ATTRIBUTES_RESET_RESULT].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_ATTRIBUTES_RESET_RESULT].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ATTRIBUTES_RESET_RESULT, null);
						_callbackHandlers.Remove(AW_CALLBACK_ATTRIBUTES_RESET_RESULT);
					}
				}
			}
		}
		#endregion
		
		#region AdminCompleted
	
		const string AW_CALLBACK_ADMIN = "AW_CALLBACK_ADMIN";
	
		//Native callback handler.
		private void OnAdminCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_ADMIN) && _callbackHandlers[AW_CALLBACK_ADMIN].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_ADMIN].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_ADMIN from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler AdminCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_ADMIN))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_ADMIN, new CallbackDelegates { Native = OnAdminCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ADMIN, _callbackHandlers[AW_CALLBACK_ADMIN].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_ADMIN].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_ADMIN))
				{
					_callbackHandlers[AW_CALLBACK_ADMIN].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_ADMIN].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ADMIN, null);
						_callbackHandlers.Remove(AW_CALLBACK_ADMIN);
					}
				}
			}
		}
		#endregion
		
		#region TerrainSetResultCompleted
	
		const string AW_CALLBACK_TERRAIN_SET_RESULT = "AW_CALLBACK_TERRAIN_SET_RESULT";
	
		//Native callback handler.
		private void OnTerrainSetResultCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_TERRAIN_SET_RESULT) && _callbackHandlers[AW_CALLBACK_TERRAIN_SET_RESULT].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_TERRAIN_SET_RESULT].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_TERRAIN_SET_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler TerrainSetResultCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_TERRAIN_SET_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_TERRAIN_SET_RESULT, new CallbackDelegates { Native = OnTerrainSetResultCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_TERRAIN_SET_RESULT, _callbackHandlers[AW_CALLBACK_TERRAIN_SET_RESULT].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_TERRAIN_SET_RESULT].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_TERRAIN_SET_RESULT))
				{
					_callbackHandlers[AW_CALLBACK_TERRAIN_SET_RESULT].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_TERRAIN_SET_RESULT].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_TERRAIN_SET_RESULT, null);
						_callbackHandlers.Remove(AW_CALLBACK_TERRAIN_SET_RESULT);
					}
				}
			}
		}
		#endregion
		
		#region TerrainNextResultCompleted
	
		const string AW_CALLBACK_TERRAIN_NEXT_RESULT = "AW_CALLBACK_TERRAIN_NEXT_RESULT";
	
		//Native callback handler.
		private void OnTerrainNextResultCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_TERRAIN_NEXT_RESULT) && _callbackHandlers[AW_CALLBACK_TERRAIN_NEXT_RESULT].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_TERRAIN_NEXT_RESULT].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_TERRAIN_NEXT_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler TerrainNextResultCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_TERRAIN_NEXT_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_TERRAIN_NEXT_RESULT, new CallbackDelegates { Native = OnTerrainNextResultCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_TERRAIN_NEXT_RESULT, _callbackHandlers[AW_CALLBACK_TERRAIN_NEXT_RESULT].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_TERRAIN_NEXT_RESULT].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_TERRAIN_NEXT_RESULT))
				{
					_callbackHandlers[AW_CALLBACK_TERRAIN_NEXT_RESULT].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_TERRAIN_NEXT_RESULT].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_TERRAIN_NEXT_RESULT, null);
						_callbackHandlers.Remove(AW_CALLBACK_TERRAIN_NEXT_RESULT);
					}
				}
			}
		}
		#endregion
		
		#region TerrainDeleteAllResultCompleted
	
		const string AW_CALLBACK_TERRAIN_DELETE_ALL_RESULT = "AW_CALLBACK_TERRAIN_DELETE_ALL_RESULT";
	
		//Native callback handler.
		private void OnTerrainDeleteAllResultCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_TERRAIN_DELETE_ALL_RESULT) && _callbackHandlers[AW_CALLBACK_TERRAIN_DELETE_ALL_RESULT].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_TERRAIN_DELETE_ALL_RESULT].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_TERRAIN_DELETE_ALL_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler TerrainDeleteAllResultCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_TERRAIN_DELETE_ALL_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_TERRAIN_DELETE_ALL_RESULT, new CallbackDelegates { Native = OnTerrainDeleteAllResultCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_TERRAIN_DELETE_ALL_RESULT, _callbackHandlers[AW_CALLBACK_TERRAIN_DELETE_ALL_RESULT].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_TERRAIN_DELETE_ALL_RESULT].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_TERRAIN_DELETE_ALL_RESULT))
				{
					_callbackHandlers[AW_CALLBACK_TERRAIN_DELETE_ALL_RESULT].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_TERRAIN_DELETE_ALL_RESULT].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_TERRAIN_DELETE_ALL_RESULT, null);
						_callbackHandlers.Remove(AW_CALLBACK_TERRAIN_DELETE_ALL_RESULT);
					}
				}
			}
		}
		#endregion
		
		#region TerrainLoadNodeResultCompleted
	
		const string AW_CALLBACK_TERRAIN_LOAD_NODE_RESULT = "AW_CALLBACK_TERRAIN_LOAD_NODE_RESULT";
	
		//Native callback handler.
		private void OnTerrainLoadNodeResultCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_TERRAIN_LOAD_NODE_RESULT) && _callbackHandlers[AW_CALLBACK_TERRAIN_LOAD_NODE_RESULT].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_TERRAIN_LOAD_NODE_RESULT].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_TERRAIN_LOAD_NODE_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler TerrainLoadNodeResultCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_TERRAIN_LOAD_NODE_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_TERRAIN_LOAD_NODE_RESULT, new CallbackDelegates { Native = OnTerrainLoadNodeResultCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_TERRAIN_LOAD_NODE_RESULT, _callbackHandlers[AW_CALLBACK_TERRAIN_LOAD_NODE_RESULT].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_TERRAIN_LOAD_NODE_RESULT].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_TERRAIN_LOAD_NODE_RESULT))
				{
					_callbackHandlers[AW_CALLBACK_TERRAIN_LOAD_NODE_RESULT].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_TERRAIN_LOAD_NODE_RESULT].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_TERRAIN_LOAD_NODE_RESULT, null);
						_callbackHandlers.Remove(AW_CALLBACK_TERRAIN_LOAD_NODE_RESULT);
					}
				}
			}
		}
		#endregion
		
		#region BotgramResultCompleted
	
		const string AW_CALLBACK_BOTGRAM_RESULT = "AW_CALLBACK_BOTGRAM_RESULT";
	
		//Native callback handler.
		private void OnBotgramResultCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_BOTGRAM_RESULT) && _callbackHandlers[AW_CALLBACK_BOTGRAM_RESULT].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_BOTGRAM_RESULT].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_BOTGRAM_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler BotgramResultCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_BOTGRAM_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_BOTGRAM_RESULT, new CallbackDelegates { Native = OnBotgramResultCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_BOTGRAM_RESULT, _callbackHandlers[AW_CALLBACK_BOTGRAM_RESULT].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_BOTGRAM_RESULT].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_BOTGRAM_RESULT))
				{
					_callbackHandlers[AW_CALLBACK_BOTGRAM_RESULT].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_BOTGRAM_RESULT].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_BOTGRAM_RESULT, null);
						_callbackHandlers.Remove(AW_CALLBACK_BOTGRAM_RESULT);
					}
				}
			}
		}
		#endregion
		
		#region UserListCompleted
	
		const string AW_CALLBACK_USER_LIST = "AW_CALLBACK_USER_LIST";
	
		//Native callback handler.
		private void OnUserListCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_USER_LIST) && _callbackHandlers[AW_CALLBACK_USER_LIST].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_USER_LIST].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_USER_LIST from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler UserListCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_USER_LIST))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_USER_LIST, new CallbackDelegates { Native = OnUserListCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_USER_LIST, _callbackHandlers[AW_CALLBACK_USER_LIST].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_USER_LIST].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_USER_LIST))
				{
					_callbackHandlers[AW_CALLBACK_USER_LIST].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_USER_LIST].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_USER_LIST, null);
						_callbackHandlers.Remove(AW_CALLBACK_USER_LIST);
					}
				}
			}
		}
		#endregion
		
		#region BotmenuResultCompleted
	
		const string AW_CALLBACK_BOTMENU_RESULT = "AW_CALLBACK_BOTMENU_RESULT";
	
		//Native callback handler.
		private void OnBotmenuResultCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_BOTMENU_RESULT) && _callbackHandlers[AW_CALLBACK_BOTMENU_RESULT].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_BOTMENU_RESULT].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_BOTMENU_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler BotmenuResultCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_BOTMENU_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_BOTMENU_RESULT, new CallbackDelegates { Native = OnBotmenuResultCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_BOTMENU_RESULT, _callbackHandlers[AW_CALLBACK_BOTMENU_RESULT].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_BOTMENU_RESULT].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_BOTMENU_RESULT))
				{
					_callbackHandlers[AW_CALLBACK_BOTMENU_RESULT].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_BOTMENU_RESULT].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_BOTMENU_RESULT, null);
						_callbackHandlers.Remove(AW_CALLBACK_BOTMENU_RESULT);
					}
				}
			}
		}
		#endregion
		
		#region CavCompleted
	
		const string AW_CALLBACK_CAV = "AW_CALLBACK_CAV";
	
		//Native callback handler.
		private void OnCavCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_CAV) && _callbackHandlers[AW_CALLBACK_CAV].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_CAV].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_CAV from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler CavCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_CAV))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_CAV, new CallbackDelegates { Native = OnCavCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CAV, _callbackHandlers[AW_CALLBACK_CAV].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_CAV].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_CAV))
				{
					_callbackHandlers[AW_CALLBACK_CAV].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_CAV].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CAV, null);
						_callbackHandlers.Remove(AW_CALLBACK_CAV);
					}
				}
			}
		}
		#endregion
		
		#region CavResultCompleted
	
		const string AW_CALLBACK_CAV_RESULT = "AW_CALLBACK_CAV_RESULT";
	
		//Native callback handler.
		private void OnCavResultCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_CAV_RESULT) && _callbackHandlers[AW_CALLBACK_CAV_RESULT].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_CAV_RESULT].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_CAV_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler CavResultCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_CAV_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_CAV_RESULT, new CallbackDelegates { Native = OnCavResultCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CAV_RESULT, _callbackHandlers[AW_CALLBACK_CAV_RESULT].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_CAV_RESULT].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_CAV_RESULT))
				{
					_callbackHandlers[AW_CALLBACK_CAV_RESULT].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_CAV_RESULT].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CAV_RESULT, null);
						_callbackHandlers.Remove(AW_CALLBACK_CAV_RESULT);
					}
				}
			}
		}
		#endregion
		
		#region WorldInstanceCompleted
	
		const string AW_CALLBACK_WORLD_INSTANCE = "AW_CALLBACK_WORLD_INSTANCE";
	
		//Native callback handler.
		private void OnWorldInstanceCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_WORLD_INSTANCE) && _callbackHandlers[AW_CALLBACK_WORLD_INSTANCE].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_WORLD_INSTANCE].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_WORLD_INSTANCE from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler WorldInstanceCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_WORLD_INSTANCE))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_WORLD_INSTANCE, new CallbackDelegates { Native = OnWorldInstanceCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_INSTANCE, _callbackHandlers[AW_CALLBACK_WORLD_INSTANCE].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_WORLD_INSTANCE].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_WORLD_INSTANCE))
				{
					_callbackHandlers[AW_CALLBACK_WORLD_INSTANCE].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_WORLD_INSTANCE].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_INSTANCE, null);
						_callbackHandlers.Remove(AW_CALLBACK_WORLD_INSTANCE);
					}
				}
			}
		}
		#endregion
		
		#region HudResultCompleted
	
		const string AW_CALLBACK_HUD_RESULT = "AW_CALLBACK_HUD_RESULT";
	
		//Native callback handler.
		private void OnHudResultCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_HUD_RESULT) && _callbackHandlers[AW_CALLBACK_HUD_RESULT].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_HUD_RESULT].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_HUD_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler HudResultCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_HUD_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_HUD_RESULT, new CallbackDelegates { Native = OnHudResultCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_HUD_RESULT, _callbackHandlers[AW_CALLBACK_HUD_RESULT].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_HUD_RESULT].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_HUD_RESULT))
				{
					_callbackHandlers[AW_CALLBACK_HUD_RESULT].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_HUD_RESULT].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_HUD_RESULT, null);
						_callbackHandlers.Remove(AW_CALLBACK_HUD_RESULT);
					}
				}
			}
		}
		#endregion
		
		#region AvatarLocationCompleted
	
		const string AW_CALLBACK_AVATAR_LOCATION = "AW_CALLBACK_AVATAR_LOCATION";
	
		//Native callback handler.
		private void OnAvatarLocationCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_AVATAR_LOCATION) && _callbackHandlers[AW_CALLBACK_AVATAR_LOCATION].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_AVATAR_LOCATION].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_AVATAR_LOCATION from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler AvatarLocationCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_AVATAR_LOCATION))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_AVATAR_LOCATION, new CallbackDelegates { Native = OnAvatarLocationCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_AVATAR_LOCATION, _callbackHandlers[AW_CALLBACK_AVATAR_LOCATION].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_AVATAR_LOCATION].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_AVATAR_LOCATION))
				{
					_callbackHandlers[AW_CALLBACK_AVATAR_LOCATION].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_AVATAR_LOCATION].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_AVATAR_LOCATION, null);
						_callbackHandlers.Remove(AW_CALLBACK_AVATAR_LOCATION);
					}
				}
			}
		}
		#endregion
		
		#region ObjectQueryCompleted
	
		const string AW_CALLBACK_OBJECT_QUERY = "AW_CALLBACK_OBJECT_QUERY";
	
		//Native callback handler.
		private void OnObjectQueryCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_OBJECT_QUERY) && _callbackHandlers[AW_CALLBACK_OBJECT_QUERY].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_OBJECT_QUERY].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_OBJECT_QUERY from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler ObjectQueryCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_OBJECT_QUERY))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_OBJECT_QUERY, new CallbackDelegates { Native = OnObjectQueryCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_OBJECT_QUERY, _callbackHandlers[AW_CALLBACK_OBJECT_QUERY].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_OBJECT_QUERY].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_OBJECT_QUERY))
				{
					_callbackHandlers[AW_CALLBACK_OBJECT_QUERY].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_OBJECT_QUERY].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_OBJECT_QUERY, null);
						_callbackHandlers.Remove(AW_CALLBACK_OBJECT_QUERY);
					}
				}
			}
		}
		#endregion
		
		#region WorldCavResultCompleted
	
		const string AW_CALLBACK_WORLD_CAV_RESULT = "AW_CALLBACK_WORLD_CAV_RESULT";
	
		//Native callback handler.
		private void OnWorldCavResultCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_WORLD_CAV_RESULT) && _callbackHandlers[AW_CALLBACK_WORLD_CAV_RESULT].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_WORLD_CAV_RESULT].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_WORLD_CAV_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler WorldCavResultCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_WORLD_CAV_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_WORLD_CAV_RESULT, new CallbackDelegates { Native = OnWorldCavResultCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_CAV_RESULT, _callbackHandlers[AW_CALLBACK_WORLD_CAV_RESULT].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_WORLD_CAV_RESULT].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_WORLD_CAV_RESULT))
				{
					_callbackHandlers[AW_CALLBACK_WORLD_CAV_RESULT].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_WORLD_CAV_RESULT].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_CAV_RESULT, null);
						_callbackHandlers.Remove(AW_CALLBACK_WORLD_CAV_RESULT);
					}
				}
			}
		}
		#endregion
		
		#region WorldCavCompleted
	
		const string AW_CALLBACK_WORLD_CAV = "AW_CALLBACK_WORLD_CAV";
	
		//Native callback handler.
		private void OnWorldCavCompleted(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_WORLD_CAV) && _callbackHandlers[AW_CALLBACK_WORLD_CAV].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_WORLD_CAV].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_WORLD_CAV from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler WorldCavCompleted
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_WORLD_CAV))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_WORLD_CAV, new CallbackDelegates { Native = OnWorldCavCompleted });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_CAV, _callbackHandlers[AW_CALLBACK_WORLD_CAV].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_WORLD_CAV].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_WORLD_CAV))
				{
					_callbackHandlers[AW_CALLBACK_WORLD_CAV].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_WORLD_CAV].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_CAV, null);
						_callbackHandlers.Remove(AW_CALLBACK_WORLD_CAV);
					}
				}
			}
		}
		#endregion
		
		}
}