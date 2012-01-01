 


	
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
			event InstanceCallbackHandler CallbackLogin;
			event InstanceCallbackHandler CallbackEnter;
			event InstanceCallbackHandler CallbackObjectResult;
			event InstanceCallbackHandler CallbackLicenseAttributes;
			event InstanceCallbackHandler CallbackLicenseResult;
			event InstanceCallbackHandler CallbackCitizenAttributes;
			event InstanceCallbackHandler CallbackCitizenResult;
			event InstanceCallbackHandler CallbackQuery;
			event InstanceCallbackHandler CallbackWorldList;
			event InstanceCallbackHandler CallbackUniverseEjection;
			event InstanceCallbackHandler CallbackUniverseEjectionResult;
			event InstanceCallbackHandler CallbackAddress;
			event InstanceCallbackHandler CallbackWorldEjection;
			event InstanceCallbackHandler CallbackWorldEjectionResult;
			event InstanceCallbackHandler CallbackAdminWorldList;
			event InstanceCallbackHandler CallbackAdminWorldResult;
			event InstanceCallbackHandler CallbackDeleteAllObjectsResult;
			event InstanceCallbackHandler CallbackCellResult;
			event InstanceCallbackHandler CallbackReloadRegistry;
			event InstanceCallbackHandler CallbackAttributesResetResult;
			event InstanceCallbackHandler CallbackAdmin;
			event InstanceCallbackHandler CallbackTerrainSetResult;
			event InstanceCallbackHandler CallbackTerrainNextResult;
			event InstanceCallbackHandler CallbackTerrainDeleteAllResult;
			event InstanceCallbackHandler CallbackTerrainLoadNodeResult;
			event InstanceCallbackHandler CallbackBotgramResult;
			event InstanceCallbackHandler CallbackUserList;
			event InstanceCallbackHandler CallbackBotmenuResult;
			event InstanceCallbackHandler CallbackCav;
			event InstanceCallbackHandler CallbackCavResult;
			event InstanceCallbackHandler CallbackWorldInstance;
			event InstanceCallbackHandler CallbackHudResult;
			event InstanceCallbackHandler CallbackAvatarLocation;
			event InstanceCallbackHandler CallbackObjectQuery;
			event InstanceCallbackHandler CallbackWorldCavResult;
			event InstanceCallbackHandler CallbackWorldCav;
		}
	
	partial class Instance
	{
		private readonly Dictionary<string, CallbackDelegates> _callbackHandlers = new Dictionary<string, CallbackDelegates>();
	
		#region CallbackLogin
	
		const string AW_CALLBACK_LOGIN = "AW_CALLBACK_LOGIN";
	
		//Native callback handler.
		private void OnCallbackLogin(int error)
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
		public event InstanceCallbackHandler CallbackLogin
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_LOGIN))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_LOGIN, new CallbackDelegates { Native = OnCallbackLogin });
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
		
		#region CallbackEnter
	
		const string AW_CALLBACK_ENTER = "AW_CALLBACK_ENTER";
	
		//Native callback handler.
		private void OnCallbackEnter(int error)
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
		public event InstanceCallbackHandler CallbackEnter
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_ENTER))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_ENTER, new CallbackDelegates { Native = OnCallbackEnter });
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
		
		#region CallbackObjectResult
	
		const string AW_CALLBACK_OBJECT_RESULT = "AW_CALLBACK_OBJECT_RESULT";
	
		//Native callback handler.
		private void OnCallbackObjectResult(int error)
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
		public event InstanceCallbackHandler CallbackObjectResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_OBJECT_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_OBJECT_RESULT, new CallbackDelegates { Native = OnCallbackObjectResult });
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
		
		#region CallbackLicenseAttributes
	
		const string AW_CALLBACK_LICENSE_ATTRIBUTES = "AW_CALLBACK_LICENSE_ATTRIBUTES";
	
		//Native callback handler.
		private void OnCallbackLicenseAttributes(int error)
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
		public event InstanceCallbackHandler CallbackLicenseAttributes
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_LICENSE_ATTRIBUTES))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_LICENSE_ATTRIBUTES, new CallbackDelegates { Native = OnCallbackLicenseAttributes });
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
		
		#region CallbackLicenseResult
	
		const string AW_CALLBACK_LICENSE_RESULT = "AW_CALLBACK_LICENSE_RESULT";
	
		//Native callback handler.
		private void OnCallbackLicenseResult(int error)
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
		public event InstanceCallbackHandler CallbackLicenseResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_LICENSE_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_LICENSE_RESULT, new CallbackDelegates { Native = OnCallbackLicenseResult });
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
		
		#region CallbackCitizenAttributes
	
		const string AW_CALLBACK_CITIZEN_ATTRIBUTES = "AW_CALLBACK_CITIZEN_ATTRIBUTES";
	
		//Native callback handler.
		private void OnCallbackCitizenAttributes(int error)
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
		public event InstanceCallbackHandler CallbackCitizenAttributes
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_CITIZEN_ATTRIBUTES))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_CITIZEN_ATTRIBUTES, new CallbackDelegates { Native = OnCallbackCitizenAttributes });
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
		
		#region CallbackCitizenResult
	
		const string AW_CALLBACK_CITIZEN_RESULT = "AW_CALLBACK_CITIZEN_RESULT";
	
		//Native callback handler.
		private void OnCallbackCitizenResult(int error)
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
		public event InstanceCallbackHandler CallbackCitizenResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_CITIZEN_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_CITIZEN_RESULT, new CallbackDelegates { Native = OnCallbackCitizenResult });
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
		
		#region CallbackQuery
	
		const string AW_CALLBACK_QUERY = "AW_CALLBACK_QUERY";
	
		//Native callback handler.
		private void OnCallbackQuery(int error)
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
		public event InstanceCallbackHandler CallbackQuery
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_QUERY))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_QUERY, new CallbackDelegates { Native = OnCallbackQuery });
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
		
		#region CallbackWorldList
	
		const string AW_CALLBACK_WORLD_LIST = "AW_CALLBACK_WORLD_LIST";
	
		//Native callback handler.
		private void OnCallbackWorldList(int error)
		{
			if(_callbackHandlers.ContainsKey(AW_CALLBACK_WORLD_LIST) && _callbackHandlers[AW_CALLBACK_WORLD_LIST].Managed != null)
			{
				_callbackHandlers[AW_CALLBACK_WORLD_LIST].Managed(this, (Result)error);
			}
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_WORLD_LIST from the C SDK.
		/// </summary>
		public event InstanceCallbackHandler CallbackWorldList
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_WORLD_LIST))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_WORLD_LIST, new CallbackDelegates { Native = OnCallbackWorldList });
					NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_LIST, _callbackHandlers[AW_CALLBACK_WORLD_LIST].Native);			
				}
					
				_callbackHandlers[AW_CALLBACK_WORLD_LIST].Managed += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				if(_callbackHandlers.ContainsKey(AW_CALLBACK_WORLD_LIST))
				{
					_callbackHandlers[AW_CALLBACK_WORLD_LIST].Managed -= value;
				
					if(_callbackHandlers[AW_CALLBACK_WORLD_LIST].Managed == null)
					{
						SetInstance();
						NativeMethods.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_LIST, null);
						_callbackHandlers.Remove(AW_CALLBACK_WORLD_LIST);
					}
				}
			}
		}
		#endregion
		
		#region CallbackUniverseEjection
	
		const string AW_CALLBACK_UNIVERSE_EJECTION = "AW_CALLBACK_UNIVERSE_EJECTION";
	
		//Native callback handler.
		private void OnCallbackUniverseEjection(int error)
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
		public event InstanceCallbackHandler CallbackUniverseEjection
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_UNIVERSE_EJECTION))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_UNIVERSE_EJECTION, new CallbackDelegates { Native = OnCallbackUniverseEjection });
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
		
		#region CallbackUniverseEjectionResult
	
		const string AW_CALLBACK_UNIVERSE_EJECTION_RESULT = "AW_CALLBACK_UNIVERSE_EJECTION_RESULT";
	
		//Native callback handler.
		private void OnCallbackUniverseEjectionResult(int error)
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
		public event InstanceCallbackHandler CallbackUniverseEjectionResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_UNIVERSE_EJECTION_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_UNIVERSE_EJECTION_RESULT, new CallbackDelegates { Native = OnCallbackUniverseEjectionResult });
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
		
		#region CallbackAddress
	
		const string AW_CALLBACK_ADDRESS = "AW_CALLBACK_ADDRESS";
	
		//Native callback handler.
		private void OnCallbackAddress(int error)
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
		public event InstanceCallbackHandler CallbackAddress
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_ADDRESS))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_ADDRESS, new CallbackDelegates { Native = OnCallbackAddress });
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
		
		#region CallbackWorldEjection
	
		const string AW_CALLBACK_WORLD_EJECTION = "AW_CALLBACK_WORLD_EJECTION";
	
		//Native callback handler.
		private void OnCallbackWorldEjection(int error)
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
		public event InstanceCallbackHandler CallbackWorldEjection
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_WORLD_EJECTION))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_WORLD_EJECTION, new CallbackDelegates { Native = OnCallbackWorldEjection });
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
		
		#region CallbackWorldEjectionResult
	
		const string AW_CALLBACK_WORLD_EJECTION_RESULT = "AW_CALLBACK_WORLD_EJECTION_RESULT";
	
		//Native callback handler.
		private void OnCallbackWorldEjectionResult(int error)
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
		public event InstanceCallbackHandler CallbackWorldEjectionResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_WORLD_EJECTION_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_WORLD_EJECTION_RESULT, new CallbackDelegates { Native = OnCallbackWorldEjectionResult });
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
		
		#region CallbackAdminWorldList
	
		const string AW_CALLBACK_ADMIN_WORLD_LIST = "AW_CALLBACK_ADMIN_WORLD_LIST";
	
		//Native callback handler.
		private void OnCallbackAdminWorldList(int error)
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
		public event InstanceCallbackHandler CallbackAdminWorldList
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_ADMIN_WORLD_LIST))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_ADMIN_WORLD_LIST, new CallbackDelegates { Native = OnCallbackAdminWorldList });
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
		
		#region CallbackAdminWorldResult
	
		const string AW_CALLBACK_ADMIN_WORLD_RESULT = "AW_CALLBACK_ADMIN_WORLD_RESULT";
	
		//Native callback handler.
		private void OnCallbackAdminWorldResult(int error)
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
		public event InstanceCallbackHandler CallbackAdminWorldResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_ADMIN_WORLD_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_ADMIN_WORLD_RESULT, new CallbackDelegates { Native = OnCallbackAdminWorldResult });
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
		
		#region CallbackDeleteAllObjectsResult
	
		const string AW_CALLBACK_DELETE_ALL_OBJECTS_RESULT = "AW_CALLBACK_DELETE_ALL_OBJECTS_RESULT";
	
		//Native callback handler.
		private void OnCallbackDeleteAllObjectsResult(int error)
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
		public event InstanceCallbackHandler CallbackDeleteAllObjectsResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_DELETE_ALL_OBJECTS_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_DELETE_ALL_OBJECTS_RESULT, new CallbackDelegates { Native = OnCallbackDeleteAllObjectsResult });
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
		
		#region CallbackCellResult
	
		const string AW_CALLBACK_CELL_RESULT = "AW_CALLBACK_CELL_RESULT";
	
		//Native callback handler.
		private void OnCallbackCellResult(int error)
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
		public event InstanceCallbackHandler CallbackCellResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_CELL_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_CELL_RESULT, new CallbackDelegates { Native = OnCallbackCellResult });
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
		
		#region CallbackReloadRegistry
	
		const string AW_CALLBACK_RELOAD_REGISTRY = "AW_CALLBACK_RELOAD_REGISTRY";
	
		//Native callback handler.
		private void OnCallbackReloadRegistry(int error)
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
		public event InstanceCallbackHandler CallbackReloadRegistry
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_RELOAD_REGISTRY))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_RELOAD_REGISTRY, new CallbackDelegates { Native = OnCallbackReloadRegistry });
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
		
		#region CallbackAttributesResetResult
	
		const string AW_CALLBACK_ATTRIBUTES_RESET_RESULT = "AW_CALLBACK_ATTRIBUTES_RESET_RESULT";
	
		//Native callback handler.
		private void OnCallbackAttributesResetResult(int error)
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
		public event InstanceCallbackHandler CallbackAttributesResetResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_ATTRIBUTES_RESET_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_ATTRIBUTES_RESET_RESULT, new CallbackDelegates { Native = OnCallbackAttributesResetResult });
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
		
		#region CallbackAdmin
	
		const string AW_CALLBACK_ADMIN = "AW_CALLBACK_ADMIN";
	
		//Native callback handler.
		private void OnCallbackAdmin(int error)
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
		public event InstanceCallbackHandler CallbackAdmin
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_ADMIN))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_ADMIN, new CallbackDelegates { Native = OnCallbackAdmin });
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
		
		#region CallbackTerrainSetResult
	
		const string AW_CALLBACK_TERRAIN_SET_RESULT = "AW_CALLBACK_TERRAIN_SET_RESULT";
	
		//Native callback handler.
		private void OnCallbackTerrainSetResult(int error)
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
		public event InstanceCallbackHandler CallbackTerrainSetResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_TERRAIN_SET_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_TERRAIN_SET_RESULT, new CallbackDelegates { Native = OnCallbackTerrainSetResult });
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
		
		#region CallbackTerrainNextResult
	
		const string AW_CALLBACK_TERRAIN_NEXT_RESULT = "AW_CALLBACK_TERRAIN_NEXT_RESULT";
	
		//Native callback handler.
		private void OnCallbackTerrainNextResult(int error)
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
		public event InstanceCallbackHandler CallbackTerrainNextResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_TERRAIN_NEXT_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_TERRAIN_NEXT_RESULT, new CallbackDelegates { Native = OnCallbackTerrainNextResult });
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
		
		#region CallbackTerrainDeleteAllResult
	
		const string AW_CALLBACK_TERRAIN_DELETE_ALL_RESULT = "AW_CALLBACK_TERRAIN_DELETE_ALL_RESULT";
	
		//Native callback handler.
		private void OnCallbackTerrainDeleteAllResult(int error)
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
		public event InstanceCallbackHandler CallbackTerrainDeleteAllResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_TERRAIN_DELETE_ALL_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_TERRAIN_DELETE_ALL_RESULT, new CallbackDelegates { Native = OnCallbackTerrainDeleteAllResult });
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
		
		#region CallbackTerrainLoadNodeResult
	
		const string AW_CALLBACK_TERRAIN_LOAD_NODE_RESULT = "AW_CALLBACK_TERRAIN_LOAD_NODE_RESULT";
	
		//Native callback handler.
		private void OnCallbackTerrainLoadNodeResult(int error)
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
		public event InstanceCallbackHandler CallbackTerrainLoadNodeResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_TERRAIN_LOAD_NODE_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_TERRAIN_LOAD_NODE_RESULT, new CallbackDelegates { Native = OnCallbackTerrainLoadNodeResult });
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
		
		#region CallbackBotgramResult
	
		const string AW_CALLBACK_BOTGRAM_RESULT = "AW_CALLBACK_BOTGRAM_RESULT";
	
		//Native callback handler.
		private void OnCallbackBotgramResult(int error)
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
		public event InstanceCallbackHandler CallbackBotgramResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_BOTGRAM_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_BOTGRAM_RESULT, new CallbackDelegates { Native = OnCallbackBotgramResult });
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
		
		#region CallbackUserList
	
		const string AW_CALLBACK_USER_LIST = "AW_CALLBACK_USER_LIST";
	
		//Native callback handler.
		private void OnCallbackUserList(int error)
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
		public event InstanceCallbackHandler CallbackUserList
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_USER_LIST))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_USER_LIST, new CallbackDelegates { Native = OnCallbackUserList });
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
		
		#region CallbackBotmenuResult
	
		const string AW_CALLBACK_BOTMENU_RESULT = "AW_CALLBACK_BOTMENU_RESULT";
	
		//Native callback handler.
		private void OnCallbackBotmenuResult(int error)
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
		public event InstanceCallbackHandler CallbackBotmenuResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_BOTMENU_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_BOTMENU_RESULT, new CallbackDelegates { Native = OnCallbackBotmenuResult });
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
		
		#region CallbackCav
	
		const string AW_CALLBACK_CAV = "AW_CALLBACK_CAV";
	
		//Native callback handler.
		private void OnCallbackCav(int error)
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
		public event InstanceCallbackHandler CallbackCav
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_CAV))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_CAV, new CallbackDelegates { Native = OnCallbackCav });
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
		
		#region CallbackCavResult
	
		const string AW_CALLBACK_CAV_RESULT = "AW_CALLBACK_CAV_RESULT";
	
		//Native callback handler.
		private void OnCallbackCavResult(int error)
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
		public event InstanceCallbackHandler CallbackCavResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_CAV_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_CAV_RESULT, new CallbackDelegates { Native = OnCallbackCavResult });
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
		
		#region CallbackWorldInstance
	
		const string AW_CALLBACK_WORLD_INSTANCE = "AW_CALLBACK_WORLD_INSTANCE";
	
		//Native callback handler.
		private void OnCallbackWorldInstance(int error)
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
		public event InstanceCallbackHandler CallbackWorldInstance
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_WORLD_INSTANCE))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_WORLD_INSTANCE, new CallbackDelegates { Native = OnCallbackWorldInstance });
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
		
		#region CallbackHudResult
	
		const string AW_CALLBACK_HUD_RESULT = "AW_CALLBACK_HUD_RESULT";
	
		//Native callback handler.
		private void OnCallbackHudResult(int error)
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
		public event InstanceCallbackHandler CallbackHudResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_HUD_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_HUD_RESULT, new CallbackDelegates { Native = OnCallbackHudResult });
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
		
		#region CallbackAvatarLocation
	
		const string AW_CALLBACK_AVATAR_LOCATION = "AW_CALLBACK_AVATAR_LOCATION";
	
		//Native callback handler.
		private void OnCallbackAvatarLocation(int error)
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
		public event InstanceCallbackHandler CallbackAvatarLocation
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_AVATAR_LOCATION))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_AVATAR_LOCATION, new CallbackDelegates { Native = OnCallbackAvatarLocation });
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
		
		#region CallbackObjectQuery
	
		const string AW_CALLBACK_OBJECT_QUERY = "AW_CALLBACK_OBJECT_QUERY";
	
		//Native callback handler.
		private void OnCallbackObjectQuery(int error)
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
		public event InstanceCallbackHandler CallbackObjectQuery
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_OBJECT_QUERY))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_OBJECT_QUERY, new CallbackDelegates { Native = OnCallbackObjectQuery });
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
		
		#region CallbackWorldCavResult
	
		const string AW_CALLBACK_WORLD_CAV_RESULT = "AW_CALLBACK_WORLD_CAV_RESULT";
	
		//Native callback handler.
		private void OnCallbackWorldCavResult(int error)
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
		public event InstanceCallbackHandler CallbackWorldCavResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_WORLD_CAV_RESULT))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_WORLD_CAV_RESULT, new CallbackDelegates { Native = OnCallbackWorldCavResult });
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
		
		#region CallbackWorldCav
	
		const string AW_CALLBACK_WORLD_CAV = "AW_CALLBACK_WORLD_CAV";
	
		//Native callback handler.
		private void OnCallbackWorldCav(int error)
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
		public event InstanceCallbackHandler CallbackWorldCav
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				if(!_callbackHandlers.ContainsKey(AW_CALLBACK_WORLD_CAV))
				{
					SetInstance();
					_callbackHandlers.Add(AW_CALLBACK_WORLD_CAV, new CallbackDelegates { Native = OnCallbackWorldCav });
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