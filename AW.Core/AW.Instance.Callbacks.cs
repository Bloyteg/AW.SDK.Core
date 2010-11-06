 


	
//This code was auto-generated.  It is not recommended to modify it.
//If you wish to change this code, please update the template associated with it.
using System;
using System.Runtime.InteropServices;

namespace AW
{
	partial class Instance
	{
		#region CallbackLogin
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackLogin;
		private InterOp.Callback nativeCallbackLogin;

		//Native callback handler.
		private void OnCallbackLogin(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackLogin(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_LOGIN from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackLogin
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackLogin == null)
				{
					SetInstance();
					nativeCallbackLogin = new InterOp.Callback(OnCallbackLogin);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_LOGIN, nativeCallbackLogin);
				}

				managedCallbackLogin += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackLogin -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackLogin == null)
				{
					SetInstance();
					nativeCallbackLogin = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_LOGIN, null);
				}
			}
		}
		#endregion
		
		#region CallbackEnter
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackEnter;
		private InterOp.Callback nativeCallbackEnter;

		//Native callback handler.
		private void OnCallbackEnter(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackEnter(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_ENTER from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackEnter
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackEnter == null)
				{
					SetInstance();
					nativeCallbackEnter = new InterOp.Callback(OnCallbackEnter);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ENTER, nativeCallbackEnter);
				}

				managedCallbackEnter += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackEnter -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackEnter == null)
				{
					SetInstance();
					nativeCallbackEnter = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ENTER, null);
				}
			}
		}
		#endregion
		
		#region CallbackObjectResult
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackObjectResult;
		private InterOp.Callback nativeCallbackObjectResult;

		//Native callback handler.
		private void OnCallbackObjectResult(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackObjectResult(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_OBJECT_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackObjectResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackObjectResult == null)
				{
					SetInstance();
					nativeCallbackObjectResult = new InterOp.Callback(OnCallbackObjectResult);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_OBJECT_RESULT, nativeCallbackObjectResult);
				}

				managedCallbackObjectResult += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackObjectResult -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackObjectResult == null)
				{
					SetInstance();
					nativeCallbackObjectResult = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_OBJECT_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackLicenseAttributes
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackLicenseAttributes;
		private InterOp.Callback nativeCallbackLicenseAttributes;

		//Native callback handler.
		private void OnCallbackLicenseAttributes(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackLicenseAttributes(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_LICENSE_ATTRIBUTES from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackLicenseAttributes
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackLicenseAttributes == null)
				{
					SetInstance();
					nativeCallbackLicenseAttributes = new InterOp.Callback(OnCallbackLicenseAttributes);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_LICENSE_ATTRIBUTES, nativeCallbackLicenseAttributes);
				}

				managedCallbackLicenseAttributes += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackLicenseAttributes -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackLicenseAttributes == null)
				{
					SetInstance();
					nativeCallbackLicenseAttributes = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_LICENSE_ATTRIBUTES, null);
				}
			}
		}
		#endregion
		
		#region CallbackLicenseResult
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackLicenseResult;
		private InterOp.Callback nativeCallbackLicenseResult;

		//Native callback handler.
		private void OnCallbackLicenseResult(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackLicenseResult(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_LICENSE_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackLicenseResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackLicenseResult == null)
				{
					SetInstance();
					nativeCallbackLicenseResult = new InterOp.Callback(OnCallbackLicenseResult);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_LICENSE_RESULT, nativeCallbackLicenseResult);
				}

				managedCallbackLicenseResult += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackLicenseResult -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackLicenseResult == null)
				{
					SetInstance();
					nativeCallbackLicenseResult = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_LICENSE_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackCitizenAttributes
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackCitizenAttributes;
		private InterOp.Callback nativeCallbackCitizenAttributes;

		//Native callback handler.
		private void OnCallbackCitizenAttributes(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackCitizenAttributes(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_CITIZEN_ATTRIBUTES from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackCitizenAttributes
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackCitizenAttributes == null)
				{
					SetInstance();
					nativeCallbackCitizenAttributes = new InterOp.Callback(OnCallbackCitizenAttributes);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CITIZEN_ATTRIBUTES, nativeCallbackCitizenAttributes);
				}

				managedCallbackCitizenAttributes += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackCitizenAttributes -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackCitizenAttributes == null)
				{
					SetInstance();
					nativeCallbackCitizenAttributes = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CITIZEN_ATTRIBUTES, null);
				}
			}
		}
		#endregion
		
		#region CallbackCitizenResult
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackCitizenResult;
		private InterOp.Callback nativeCallbackCitizenResult;

		//Native callback handler.
		private void OnCallbackCitizenResult(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackCitizenResult(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_CITIZEN_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackCitizenResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackCitizenResult == null)
				{
					SetInstance();
					nativeCallbackCitizenResult = new InterOp.Callback(OnCallbackCitizenResult);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CITIZEN_RESULT, nativeCallbackCitizenResult);
				}

				managedCallbackCitizenResult += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackCitizenResult -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackCitizenResult == null)
				{
					SetInstance();
					nativeCallbackCitizenResult = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CITIZEN_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackQuery
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackQuery;
		private InterOp.Callback nativeCallbackQuery;

		//Native callback handler.
		private void OnCallbackQuery(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackQuery(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_QUERY from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackQuery
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackQuery == null)
				{
					SetInstance();
					nativeCallbackQuery = new InterOp.Callback(OnCallbackQuery);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_QUERY, nativeCallbackQuery);
				}

				managedCallbackQuery += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackQuery -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackQuery == null)
				{
					SetInstance();
					nativeCallbackQuery = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_QUERY, null);
				}
			}
		}
		#endregion
		
		#region CallbackUniverseEjection
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackUniverseEjection;
		private InterOp.Callback nativeCallbackUniverseEjection;

		//Native callback handler.
		private void OnCallbackUniverseEjection(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackUniverseEjection(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_UNIVERSE_EJECTION from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackUniverseEjection
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackUniverseEjection == null)
				{
					SetInstance();
					nativeCallbackUniverseEjection = new InterOp.Callback(OnCallbackUniverseEjection);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_UNIVERSE_EJECTION, nativeCallbackUniverseEjection);
				}

				managedCallbackUniverseEjection += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackUniverseEjection -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackUniverseEjection == null)
				{
					SetInstance();
					nativeCallbackUniverseEjection = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_UNIVERSE_EJECTION, null);
				}
			}
		}
		#endregion
		
		#region CallbackUniverseEjectionResult
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackUniverseEjectionResult;
		private InterOp.Callback nativeCallbackUniverseEjectionResult;

		//Native callback handler.
		private void OnCallbackUniverseEjectionResult(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackUniverseEjectionResult(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_UNIVERSE_EJECTION_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackUniverseEjectionResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackUniverseEjectionResult == null)
				{
					SetInstance();
					nativeCallbackUniverseEjectionResult = new InterOp.Callback(OnCallbackUniverseEjectionResult);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_UNIVERSE_EJECTION_RESULT, nativeCallbackUniverseEjectionResult);
				}

				managedCallbackUniverseEjectionResult += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackUniverseEjectionResult -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackUniverseEjectionResult == null)
				{
					SetInstance();
					nativeCallbackUniverseEjectionResult = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_UNIVERSE_EJECTION_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackAddress
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackAddress;
		private InterOp.Callback nativeCallbackAddress;

		//Native callback handler.
		private void OnCallbackAddress(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackAddress(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_ADDRESS from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackAddress
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackAddress == null)
				{
					SetInstance();
					nativeCallbackAddress = new InterOp.Callback(OnCallbackAddress);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ADDRESS, nativeCallbackAddress);
				}

				managedCallbackAddress += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackAddress -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackAddress == null)
				{
					SetInstance();
					nativeCallbackAddress = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ADDRESS, null);
				}
			}
		}
		#endregion
		
		#region CallbackWorldEjection
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackWorldEjection;
		private InterOp.Callback nativeCallbackWorldEjection;

		//Native callback handler.
		private void OnCallbackWorldEjection(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackWorldEjection(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_WORLD_EJECTION from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackWorldEjection
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackWorldEjection == null)
				{
					SetInstance();
					nativeCallbackWorldEjection = new InterOp.Callback(OnCallbackWorldEjection);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_EJECTION, nativeCallbackWorldEjection);
				}

				managedCallbackWorldEjection += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackWorldEjection -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackWorldEjection == null)
				{
					SetInstance();
					nativeCallbackWorldEjection = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_EJECTION, null);
				}
			}
		}
		#endregion
		
		#region CallbackWorldEjectionResult
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackWorldEjectionResult;
		private InterOp.Callback nativeCallbackWorldEjectionResult;

		//Native callback handler.
		private void OnCallbackWorldEjectionResult(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackWorldEjectionResult(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_WORLD_EJECTION_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackWorldEjectionResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackWorldEjectionResult == null)
				{
					SetInstance();
					nativeCallbackWorldEjectionResult = new InterOp.Callback(OnCallbackWorldEjectionResult);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_EJECTION_RESULT, nativeCallbackWorldEjectionResult);
				}

				managedCallbackWorldEjectionResult += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackWorldEjectionResult -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackWorldEjectionResult == null)
				{
					SetInstance();
					nativeCallbackWorldEjectionResult = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_EJECTION_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackAdminWorldList
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackAdminWorldList;
		private InterOp.Callback nativeCallbackAdminWorldList;

		//Native callback handler.
		private void OnCallbackAdminWorldList(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackAdminWorldList(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_ADMIN_WORLD_LIST from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackAdminWorldList
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackAdminWorldList == null)
				{
					SetInstance();
					nativeCallbackAdminWorldList = new InterOp.Callback(OnCallbackAdminWorldList);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ADMIN_WORLD_LIST, nativeCallbackAdminWorldList);
				}

				managedCallbackAdminWorldList += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackAdminWorldList -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackAdminWorldList == null)
				{
					SetInstance();
					nativeCallbackAdminWorldList = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ADMIN_WORLD_LIST, null);
				}
			}
		}
		#endregion
		
		#region CallbackAdminWorldResult
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackAdminWorldResult;
		private InterOp.Callback nativeCallbackAdminWorldResult;

		//Native callback handler.
		private void OnCallbackAdminWorldResult(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackAdminWorldResult(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_ADMIN_WORLD_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackAdminWorldResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackAdminWorldResult == null)
				{
					SetInstance();
					nativeCallbackAdminWorldResult = new InterOp.Callback(OnCallbackAdminWorldResult);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ADMIN_WORLD_RESULT, nativeCallbackAdminWorldResult);
				}

				managedCallbackAdminWorldResult += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackAdminWorldResult -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackAdminWorldResult == null)
				{
					SetInstance();
					nativeCallbackAdminWorldResult = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ADMIN_WORLD_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackDeleteAllObjectsResult
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackDeleteAllObjectsResult;
		private InterOp.Callback nativeCallbackDeleteAllObjectsResult;

		//Native callback handler.
		private void OnCallbackDeleteAllObjectsResult(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackDeleteAllObjectsResult(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_DELETE_ALL_OBJECTS_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackDeleteAllObjectsResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackDeleteAllObjectsResult == null)
				{
					SetInstance();
					nativeCallbackDeleteAllObjectsResult = new InterOp.Callback(OnCallbackDeleteAllObjectsResult);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_DELETE_ALL_OBJECTS_RESULT, nativeCallbackDeleteAllObjectsResult);
				}

				managedCallbackDeleteAllObjectsResult += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackDeleteAllObjectsResult -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackDeleteAllObjectsResult == null)
				{
					SetInstance();
					nativeCallbackDeleteAllObjectsResult = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_DELETE_ALL_OBJECTS_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackCellResult
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackCellResult;
		private InterOp.Callback nativeCallbackCellResult;

		//Native callback handler.
		private void OnCallbackCellResult(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackCellResult(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_CELL_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackCellResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackCellResult == null)
				{
					SetInstance();
					nativeCallbackCellResult = new InterOp.Callback(OnCallbackCellResult);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CELL_RESULT, nativeCallbackCellResult);
				}

				managedCallbackCellResult += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackCellResult -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackCellResult == null)
				{
					SetInstance();
					nativeCallbackCellResult = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CELL_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackReloadRegistry
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackReloadRegistry;
		private InterOp.Callback nativeCallbackReloadRegistry;

		//Native callback handler.
		private void OnCallbackReloadRegistry(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackReloadRegistry(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_RELOAD_REGISTRY from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackReloadRegistry
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackReloadRegistry == null)
				{
					SetInstance();
					nativeCallbackReloadRegistry = new InterOp.Callback(OnCallbackReloadRegistry);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_RELOAD_REGISTRY, nativeCallbackReloadRegistry);
				}

				managedCallbackReloadRegistry += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackReloadRegistry -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackReloadRegistry == null)
				{
					SetInstance();
					nativeCallbackReloadRegistry = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_RELOAD_REGISTRY, null);
				}
			}
		}
		#endregion
		
		#region CallbackAttributesResetResult
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackAttributesResetResult;
		private InterOp.Callback nativeCallbackAttributesResetResult;

		//Native callback handler.
		private void OnCallbackAttributesResetResult(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackAttributesResetResult(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_ATTRIBUTES_RESET_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackAttributesResetResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackAttributesResetResult == null)
				{
					SetInstance();
					nativeCallbackAttributesResetResult = new InterOp.Callback(OnCallbackAttributesResetResult);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ATTRIBUTES_RESET_RESULT, nativeCallbackAttributesResetResult);
				}

				managedCallbackAttributesResetResult += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackAttributesResetResult -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackAttributesResetResult == null)
				{
					SetInstance();
					nativeCallbackAttributesResetResult = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ATTRIBUTES_RESET_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackAdmin
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackAdmin;
		private InterOp.Callback nativeCallbackAdmin;

		//Native callback handler.
		private void OnCallbackAdmin(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackAdmin(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_ADMIN from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackAdmin
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackAdmin == null)
				{
					SetInstance();
					nativeCallbackAdmin = new InterOp.Callback(OnCallbackAdmin);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ADMIN, nativeCallbackAdmin);
				}

				managedCallbackAdmin += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackAdmin -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackAdmin == null)
				{
					SetInstance();
					nativeCallbackAdmin = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ADMIN, null);
				}
			}
		}
		#endregion
		
		#region CallbackTerrainSetResult
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackTerrainSetResult;
		private InterOp.Callback nativeCallbackTerrainSetResult;

		//Native callback handler.
		private void OnCallbackTerrainSetResult(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackTerrainSetResult(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_TERRAIN_SET_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackTerrainSetResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackTerrainSetResult == null)
				{
					SetInstance();
					nativeCallbackTerrainSetResult = new InterOp.Callback(OnCallbackTerrainSetResult);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_TERRAIN_SET_RESULT, nativeCallbackTerrainSetResult);
				}

				managedCallbackTerrainSetResult += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackTerrainSetResult -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackTerrainSetResult == null)
				{
					SetInstance();
					nativeCallbackTerrainSetResult = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_TERRAIN_SET_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackTerrainNextResult
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackTerrainNextResult;
		private InterOp.Callback nativeCallbackTerrainNextResult;

		//Native callback handler.
		private void OnCallbackTerrainNextResult(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackTerrainNextResult(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_TERRAIN_NEXT_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackTerrainNextResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackTerrainNextResult == null)
				{
					SetInstance();
					nativeCallbackTerrainNextResult = new InterOp.Callback(OnCallbackTerrainNextResult);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_TERRAIN_NEXT_RESULT, nativeCallbackTerrainNextResult);
				}

				managedCallbackTerrainNextResult += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackTerrainNextResult -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackTerrainNextResult == null)
				{
					SetInstance();
					nativeCallbackTerrainNextResult = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_TERRAIN_NEXT_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackTerrainDeleteAllResult
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackTerrainDeleteAllResult;
		private InterOp.Callback nativeCallbackTerrainDeleteAllResult;

		//Native callback handler.
		private void OnCallbackTerrainDeleteAllResult(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackTerrainDeleteAllResult(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_TERRAIN_DELETE_ALL_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackTerrainDeleteAllResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackTerrainDeleteAllResult == null)
				{
					SetInstance();
					nativeCallbackTerrainDeleteAllResult = new InterOp.Callback(OnCallbackTerrainDeleteAllResult);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_TERRAIN_DELETE_ALL_RESULT, nativeCallbackTerrainDeleteAllResult);
				}

				managedCallbackTerrainDeleteAllResult += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackTerrainDeleteAllResult -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackTerrainDeleteAllResult == null)
				{
					SetInstance();
					nativeCallbackTerrainDeleteAllResult = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_TERRAIN_DELETE_ALL_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackTerrainLoadNodeResult
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackTerrainLoadNodeResult;
		private InterOp.Callback nativeCallbackTerrainLoadNodeResult;

		//Native callback handler.
		private void OnCallbackTerrainLoadNodeResult(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackTerrainLoadNodeResult(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_TERRAIN_LOAD_NODE_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackTerrainLoadNodeResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackTerrainLoadNodeResult == null)
				{
					SetInstance();
					nativeCallbackTerrainLoadNodeResult = new InterOp.Callback(OnCallbackTerrainLoadNodeResult);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_TERRAIN_LOAD_NODE_RESULT, nativeCallbackTerrainLoadNodeResult);
				}

				managedCallbackTerrainLoadNodeResult += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackTerrainLoadNodeResult -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackTerrainLoadNodeResult == null)
				{
					SetInstance();
					nativeCallbackTerrainLoadNodeResult = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_TERRAIN_LOAD_NODE_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackBotgramResult
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackBotgramResult;
		private InterOp.Callback nativeCallbackBotgramResult;

		//Native callback handler.
		private void OnCallbackBotgramResult(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackBotgramResult(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_BOTGRAM_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackBotgramResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackBotgramResult == null)
				{
					SetInstance();
					nativeCallbackBotgramResult = new InterOp.Callback(OnCallbackBotgramResult);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_BOTGRAM_RESULT, nativeCallbackBotgramResult);
				}

				managedCallbackBotgramResult += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackBotgramResult -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackBotgramResult == null)
				{
					SetInstance();
					nativeCallbackBotgramResult = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_BOTGRAM_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackUserList
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackUserList;
		private InterOp.Callback nativeCallbackUserList;

		//Native callback handler.
		private void OnCallbackUserList(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackUserList(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_USER_LIST from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackUserList
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackUserList == null)
				{
					SetInstance();
					nativeCallbackUserList = new InterOp.Callback(OnCallbackUserList);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_USER_LIST, nativeCallbackUserList);
				}

				managedCallbackUserList += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackUserList -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackUserList == null)
				{
					SetInstance();
					nativeCallbackUserList = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_USER_LIST, null);
				}
			}
		}
		#endregion
		
		#region CallbackBotmenuResult
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackBotmenuResult;
		private InterOp.Callback nativeCallbackBotmenuResult;

		//Native callback handler.
		private void OnCallbackBotmenuResult(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackBotmenuResult(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_BOTMENU_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackBotmenuResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackBotmenuResult == null)
				{
					SetInstance();
					nativeCallbackBotmenuResult = new InterOp.Callback(OnCallbackBotmenuResult);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_BOTMENU_RESULT, nativeCallbackBotmenuResult);
				}

				managedCallbackBotmenuResult += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackBotmenuResult -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackBotmenuResult == null)
				{
					SetInstance();
					nativeCallbackBotmenuResult = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_BOTMENU_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackCav
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackCav;
		private InterOp.Callback nativeCallbackCav;

		//Native callback handler.
		private void OnCallbackCav(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackCav(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_CAV from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackCav
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackCav == null)
				{
					SetInstance();
					nativeCallbackCav = new InterOp.Callback(OnCallbackCav);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CAV, nativeCallbackCav);
				}

				managedCallbackCav += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackCav -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackCav == null)
				{
					SetInstance();
					nativeCallbackCav = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CAV, null);
				}
			}
		}
		#endregion
		
		#region CallbackCavResult
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackCavResult;
		private InterOp.Callback nativeCallbackCavResult;

		//Native callback handler.
		private void OnCallbackCavResult(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackCavResult(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_CAV_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackCavResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackCavResult == null)
				{
					SetInstance();
					nativeCallbackCavResult = new InterOp.Callback(OnCallbackCavResult);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CAV_RESULT, nativeCallbackCavResult);
				}

				managedCallbackCavResult += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackCavResult -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackCavResult == null)
				{
					SetInstance();
					nativeCallbackCavResult = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CAV_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackWorldInstance
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackWorldInstance;
		private InterOp.Callback nativeCallbackWorldInstance;

		//Native callback handler.
		private void OnCallbackWorldInstance(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackWorldInstance(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_WORLD_INSTANCE from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackWorldInstance
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackWorldInstance == null)
				{
					SetInstance();
					nativeCallbackWorldInstance = new InterOp.Callback(OnCallbackWorldInstance);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_INSTANCE, nativeCallbackWorldInstance);
				}

				managedCallbackWorldInstance += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackWorldInstance -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackWorldInstance == null)
				{
					SetInstance();
					nativeCallbackWorldInstance = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_INSTANCE, null);
				}
			}
		}
		#endregion
		
		#region CallbackHudResult
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackHudResult;
		private InterOp.Callback nativeCallbackHudResult;

		//Native callback handler.
		private void OnCallbackHudResult(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackHudResult(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_HUD_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackHudResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackHudResult == null)
				{
					SetInstance();
					nativeCallbackHudResult = new InterOp.Callback(OnCallbackHudResult);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_HUD_RESULT, nativeCallbackHudResult);
				}

				managedCallbackHudResult += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackHudResult -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackHudResult == null)
				{
					SetInstance();
					nativeCallbackHudResult = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_HUD_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackAvatarLocation
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackAvatarLocation;
		private InterOp.Callback nativeCallbackAvatarLocation;

		//Native callback handler.
		private void OnCallbackAvatarLocation(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackAvatarLocation(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_AVATAR_LOCATION from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackAvatarLocation
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackAvatarLocation == null)
				{
					SetInstance();
					nativeCallbackAvatarLocation = new InterOp.Callback(OnCallbackAvatarLocation);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_AVATAR_LOCATION, nativeCallbackAvatarLocation);
				}

				managedCallbackAvatarLocation += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackAvatarLocation -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackAvatarLocation == null)
				{
					SetInstance();
					nativeCallbackAvatarLocation = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_AVATAR_LOCATION, null);
				}
			}
		}
		#endregion
		
		#region CallbackObjectQuery
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackObjectQuery;
		private InterOp.Callback nativeCallbackObjectQuery;

		//Native callback handler.
		private void OnCallbackObjectQuery(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackObjectQuery(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_OBJECT_QUERY from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackObjectQuery
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackObjectQuery == null)
				{
					SetInstance();
					nativeCallbackObjectQuery = new InterOp.Callback(OnCallbackObjectQuery);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_OBJECT_QUERY, nativeCallbackObjectQuery);
				}

				managedCallbackObjectQuery += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackObjectQuery -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackObjectQuery == null)
				{
					SetInstance();
					nativeCallbackObjectQuery = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_OBJECT_QUERY, null);
				}
			}
		}
		#endregion
		
		#region CallbackWorldCavResult
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackWorldCavResult;
		private InterOp.Callback nativeCallbackWorldCavResult;

		//Native callback handler.
		private void OnCallbackWorldCavResult(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackWorldCavResult(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_WORLD_CAV_RESULT from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackWorldCavResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackWorldCavResult == null)
				{
					SetInstance();
					nativeCallbackWorldCavResult = new InterOp.Callback(OnCallbackWorldCavResult);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_CAV_RESULT, nativeCallbackWorldCavResult);
				}

				managedCallbackWorldCavResult += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackWorldCavResult -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackWorldCavResult == null)
				{
					SetInstance();
					nativeCallbackWorldCavResult = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_CAV_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackWorldCav
		//Declare the types to handle both the managed and native callbacks.
		private InstanceCallbackDelegate managedCallbackWorldCav;
		private InterOp.Callback nativeCallbackWorldCav;

		//Native callback handler.
		private void OnCallbackWorldCav(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackWorldCav(this, error);
		}

		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_WORLD_CAV from the C SDK.
		/// </summary>
		public event InstanceCallbackDelegate CallbackWorldCav
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackWorldCav == null)
				{
					SetInstance();
					nativeCallbackWorldCav = new InterOp.Callback(OnCallbackWorldCav);
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_CAV, nativeCallbackWorldCav);
				}

				managedCallbackWorldCav += value;
			}

			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackWorldCav -= value;

				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackWorldCav == null)
				{
					SetInstance();
					nativeCallbackWorldCav = null;
					InterOp.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_CAV, null);
				}
			}
		}
		#endregion
		
		}
}