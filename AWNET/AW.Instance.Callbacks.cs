//This code was auto-generated.  It is not recommended to modify it.
//If you wish to change this code, please update the template associated with it.
using System;
using System.Runtime.InteropServices;

namespace AW
{
	partial class Instance
	{
	
		#region CallbackCreate
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackCreate;
		private Importer.Callback nativeCallbackCreate;
	
		//Native callback handler.
		private void OnCallbackCreate(int error)
		{
			//Passes off the callback to the managed callback handler.
			managedCallbackCreate(this, error);
		}
	
		//Managed callback handler.
		/// <summary>
		/// Handles AW_CALLBACK_CREATE from the C SDK.
		/// </summary>
		public event Callback CallbackCreate
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackCreate == null)
				{
					SetInstance();
					nativeCallbackCreate = new Importer.Callback(OnCallbackCreate);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CREATE, nativeCallbackCreate);
				}
	
				managedCallbackCreate += value;
			}
	
			//Handles removing a delegate from the callback.
			remove
			{
				managedCallbackCreate -= value;
	
				//If the callback is null, remove the native callback for the instance.
				if (managedCallbackCreate == null)
				{
					SetInstance();
					nativeCallbackCreate = null;
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CREATE, null);
				}
			}
		}
		#endregion
		
		#region CallbackLogin
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackLogin;
		private Importer.Callback nativeCallbackLogin;
	
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
		public event Callback CallbackLogin
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackLogin == null)
				{
					SetInstance();
					nativeCallbackLogin = new Importer.Callback(OnCallbackLogin);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_LOGIN, nativeCallbackLogin);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_LOGIN, null);
				}
			}
		}
		#endregion
		
		#region CallbackEnter
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackEnter;
		private Importer.Callback nativeCallbackEnter;
	
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
		public event Callback CallbackEnter
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackEnter == null)
				{
					SetInstance();
					nativeCallbackEnter = new Importer.Callback(OnCallbackEnter);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ENTER, nativeCallbackEnter);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ENTER, null);
				}
			}
		}
		#endregion
		
		#region CallbackObjectResult
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackObjectResult;
		private Importer.Callback nativeCallbackObjectResult;
	
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
		public event Callback CallbackObjectResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackObjectResult == null)
				{
					SetInstance();
					nativeCallbackObjectResult = new Importer.Callback(OnCallbackObjectResult);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_OBJECT_RESULT, nativeCallbackObjectResult);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_OBJECT_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackLicenseAttributes
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackLicenseAttributes;
		private Importer.Callback nativeCallbackLicenseAttributes;
	
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
		public event Callback CallbackLicenseAttributes
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackLicenseAttributes == null)
				{
					SetInstance();
					nativeCallbackLicenseAttributes = new Importer.Callback(OnCallbackLicenseAttributes);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_LICENSE_ATTRIBUTES, nativeCallbackLicenseAttributes);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_LICENSE_ATTRIBUTES, null);
				}
			}
		}
		#endregion
		
		#region CallbackLicenseResult
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackLicenseResult;
		private Importer.Callback nativeCallbackLicenseResult;
	
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
		public event Callback CallbackLicenseResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackLicenseResult == null)
				{
					SetInstance();
					nativeCallbackLicenseResult = new Importer.Callback(OnCallbackLicenseResult);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_LICENSE_RESULT, nativeCallbackLicenseResult);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_LICENSE_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackCitizenAttributes
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackCitizenAttributes;
		private Importer.Callback nativeCallbackCitizenAttributes;
	
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
		public event Callback CallbackCitizenAttributes
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackCitizenAttributes == null)
				{
					SetInstance();
					nativeCallbackCitizenAttributes = new Importer.Callback(OnCallbackCitizenAttributes);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CITIZEN_ATTRIBUTES, nativeCallbackCitizenAttributes);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CITIZEN_ATTRIBUTES, null);
				}
			}
		}
		#endregion
		
		#region CallbackCitizenResult
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackCitizenResult;
		private Importer.Callback nativeCallbackCitizenResult;
	
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
		public event Callback CallbackCitizenResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackCitizenResult == null)
				{
					SetInstance();
					nativeCallbackCitizenResult = new Importer.Callback(OnCallbackCitizenResult);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CITIZEN_RESULT, nativeCallbackCitizenResult);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CITIZEN_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackQuery
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackQuery;
		private Importer.Callback nativeCallbackQuery;
	
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
		public event Callback CallbackQuery
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackQuery == null)
				{
					SetInstance();
					nativeCallbackQuery = new Importer.Callback(OnCallbackQuery);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_QUERY, nativeCallbackQuery);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_QUERY, null);
				}
			}
		}
		#endregion
		
		#region CallbackUniverseEjection
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackUniverseEjection;
		private Importer.Callback nativeCallbackUniverseEjection;
	
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
		public event Callback CallbackUniverseEjection
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackUniverseEjection == null)
				{
					SetInstance();
					nativeCallbackUniverseEjection = new Importer.Callback(OnCallbackUniverseEjection);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_UNIVERSE_EJECTION, nativeCallbackUniverseEjection);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_UNIVERSE_EJECTION, null);
				}
			}
		}
		#endregion
		
		#region CallbackUniverseEjectionResult
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackUniverseEjectionResult;
		private Importer.Callback nativeCallbackUniverseEjectionResult;
	
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
		public event Callback CallbackUniverseEjectionResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackUniverseEjectionResult == null)
				{
					SetInstance();
					nativeCallbackUniverseEjectionResult = new Importer.Callback(OnCallbackUniverseEjectionResult);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_UNIVERSE_EJECTION_RESULT, nativeCallbackUniverseEjectionResult);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_UNIVERSE_EJECTION_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackAddress
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackAddress;
		private Importer.Callback nativeCallbackAddress;
	
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
		public event Callback CallbackAddress
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackAddress == null)
				{
					SetInstance();
					nativeCallbackAddress = new Importer.Callback(OnCallbackAddress);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ADDRESS, nativeCallbackAddress);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ADDRESS, null);
				}
			}
		}
		#endregion
		
		#region CallbackWorldEjection
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackWorldEjection;
		private Importer.Callback nativeCallbackWorldEjection;
	
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
		public event Callback CallbackWorldEjection
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackWorldEjection == null)
				{
					SetInstance();
					nativeCallbackWorldEjection = new Importer.Callback(OnCallbackWorldEjection);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_EJECTION, nativeCallbackWorldEjection);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_EJECTION, null);
				}
			}
		}
		#endregion
		
		#region CallbackWorldEjectionResult
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackWorldEjectionResult;
		private Importer.Callback nativeCallbackWorldEjectionResult;
	
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
		public event Callback CallbackWorldEjectionResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackWorldEjectionResult == null)
				{
					SetInstance();
					nativeCallbackWorldEjectionResult = new Importer.Callback(OnCallbackWorldEjectionResult);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_EJECTION_RESULT, nativeCallbackWorldEjectionResult);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_EJECTION_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackAdminWorldList
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackAdminWorldList;
		private Importer.Callback nativeCallbackAdminWorldList;
	
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
		public event Callback CallbackAdminWorldList
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackAdminWorldList == null)
				{
					SetInstance();
					nativeCallbackAdminWorldList = new Importer.Callback(OnCallbackAdminWorldList);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ADMIN_WORLD_LIST, nativeCallbackAdminWorldList);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ADMIN_WORLD_LIST, null);
				}
			}
		}
		#endregion
		
		#region CallbackAdminWorldResult
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackAdminWorldResult;
		private Importer.Callback nativeCallbackAdminWorldResult;
	
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
		public event Callback CallbackAdminWorldResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackAdminWorldResult == null)
				{
					SetInstance();
					nativeCallbackAdminWorldResult = new Importer.Callback(OnCallbackAdminWorldResult);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ADMIN_WORLD_RESULT, nativeCallbackAdminWorldResult);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ADMIN_WORLD_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackDeleteAllObjectsResult
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackDeleteAllObjectsResult;
		private Importer.Callback nativeCallbackDeleteAllObjectsResult;
	
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
		public event Callback CallbackDeleteAllObjectsResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackDeleteAllObjectsResult == null)
				{
					SetInstance();
					nativeCallbackDeleteAllObjectsResult = new Importer.Callback(OnCallbackDeleteAllObjectsResult);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_DELETE_ALL_OBJECTS_RESULT, nativeCallbackDeleteAllObjectsResult);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_DELETE_ALL_OBJECTS_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackCellResult
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackCellResult;
		private Importer.Callback nativeCallbackCellResult;
	
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
		public event Callback CallbackCellResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackCellResult == null)
				{
					SetInstance();
					nativeCallbackCellResult = new Importer.Callback(OnCallbackCellResult);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CELL_RESULT, nativeCallbackCellResult);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CELL_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackReloadRegistry
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackReloadRegistry;
		private Importer.Callback nativeCallbackReloadRegistry;
	
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
		public event Callback CallbackReloadRegistry
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackReloadRegistry == null)
				{
					SetInstance();
					nativeCallbackReloadRegistry = new Importer.Callback(OnCallbackReloadRegistry);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_RELOAD_REGISTRY, nativeCallbackReloadRegistry);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_RELOAD_REGISTRY, null);
				}
			}
		}
		#endregion
		
		#region CallbackAttributesResetResult
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackAttributesResetResult;
		private Importer.Callback nativeCallbackAttributesResetResult;
	
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
		public event Callback CallbackAttributesResetResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackAttributesResetResult == null)
				{
					SetInstance();
					nativeCallbackAttributesResetResult = new Importer.Callback(OnCallbackAttributesResetResult);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ATTRIBUTES_RESET_RESULT, nativeCallbackAttributesResetResult);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ATTRIBUTES_RESET_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackAdmin
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackAdmin;
		private Importer.Callback nativeCallbackAdmin;
	
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
		public event Callback CallbackAdmin
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackAdmin == null)
				{
					SetInstance();
					nativeCallbackAdmin = new Importer.Callback(OnCallbackAdmin);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ADMIN, nativeCallbackAdmin);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_ADMIN, null);
				}
			}
		}
		#endregion
		
		#region CallbackTerrainSetResult
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackTerrainSetResult;
		private Importer.Callback nativeCallbackTerrainSetResult;
	
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
		public event Callback CallbackTerrainSetResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackTerrainSetResult == null)
				{
					SetInstance();
					nativeCallbackTerrainSetResult = new Importer.Callback(OnCallbackTerrainSetResult);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_TERRAIN_SET_RESULT, nativeCallbackTerrainSetResult);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_TERRAIN_SET_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackTerrainNextResult
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackTerrainNextResult;
		private Importer.Callback nativeCallbackTerrainNextResult;
	
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
		public event Callback CallbackTerrainNextResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackTerrainNextResult == null)
				{
					SetInstance();
					nativeCallbackTerrainNextResult = new Importer.Callback(OnCallbackTerrainNextResult);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_TERRAIN_NEXT_RESULT, nativeCallbackTerrainNextResult);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_TERRAIN_NEXT_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackTerrainDeleteAllResult
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackTerrainDeleteAllResult;
		private Importer.Callback nativeCallbackTerrainDeleteAllResult;
	
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
		public event Callback CallbackTerrainDeleteAllResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackTerrainDeleteAllResult == null)
				{
					SetInstance();
					nativeCallbackTerrainDeleteAllResult = new Importer.Callback(OnCallbackTerrainDeleteAllResult);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_TERRAIN_DELETE_ALL_RESULT, nativeCallbackTerrainDeleteAllResult);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_TERRAIN_DELETE_ALL_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackTerrainLoadNodeResult
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackTerrainLoadNodeResult;
		private Importer.Callback nativeCallbackTerrainLoadNodeResult;
	
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
		public event Callback CallbackTerrainLoadNodeResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackTerrainLoadNodeResult == null)
				{
					SetInstance();
					nativeCallbackTerrainLoadNodeResult = new Importer.Callback(OnCallbackTerrainLoadNodeResult);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_TERRAIN_LOAD_NODE_RESULT, nativeCallbackTerrainLoadNodeResult);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_TERRAIN_LOAD_NODE_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackBotgramResult
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackBotgramResult;
		private Importer.Callback nativeCallbackBotgramResult;
	
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
		public event Callback CallbackBotgramResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackBotgramResult == null)
				{
					SetInstance();
					nativeCallbackBotgramResult = new Importer.Callback(OnCallbackBotgramResult);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_BOTGRAM_RESULT, nativeCallbackBotgramResult);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_BOTGRAM_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackUserList
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackUserList;
		private Importer.Callback nativeCallbackUserList;
	
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
		public event Callback CallbackUserList
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackUserList == null)
				{
					SetInstance();
					nativeCallbackUserList = new Importer.Callback(OnCallbackUserList);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_USER_LIST, nativeCallbackUserList);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_USER_LIST, null);
				}
			}
		}
		#endregion
		
		#region CallbackBotmenuResult
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackBotmenuResult;
		private Importer.Callback nativeCallbackBotmenuResult;
	
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
		public event Callback CallbackBotmenuResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackBotmenuResult == null)
				{
					SetInstance();
					nativeCallbackBotmenuResult = new Importer.Callback(OnCallbackBotmenuResult);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_BOTMENU_RESULT, nativeCallbackBotmenuResult);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_BOTMENU_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackCav
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackCav;
		private Importer.Callback nativeCallbackCav;
	
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
		public event Callback CallbackCav
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackCav == null)
				{
					SetInstance();
					nativeCallbackCav = new Importer.Callback(OnCallbackCav);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CAV, nativeCallbackCav);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CAV, null);
				}
			}
		}
		#endregion
		
		#region CallbackCavResult
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackCavResult;
		private Importer.Callback nativeCallbackCavResult;
	
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
		public event Callback CallbackCavResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackCavResult == null)
				{
					SetInstance();
					nativeCallbackCavResult = new Importer.Callback(OnCallbackCavResult);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CAV_RESULT, nativeCallbackCavResult);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_CAV_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackWorldInstance
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackWorldInstance;
		private Importer.Callback nativeCallbackWorldInstance;
	
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
		public event Callback CallbackWorldInstance
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackWorldInstance == null)
				{
					SetInstance();
					nativeCallbackWorldInstance = new Importer.Callback(OnCallbackWorldInstance);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_INSTANCE, nativeCallbackWorldInstance);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_INSTANCE, null);
				}
			}
		}
		#endregion
		
		#region CallbackHudResult
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackHudResult;
		private Importer.Callback nativeCallbackHudResult;
	
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
		public event Callback CallbackHudResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackHudResult == null)
				{
					SetInstance();
					nativeCallbackHudResult = new Importer.Callback(OnCallbackHudResult);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_HUD_RESULT, nativeCallbackHudResult);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_HUD_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackAvatarLocation
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackAvatarLocation;
		private Importer.Callback nativeCallbackAvatarLocation;
	
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
		public event Callback CallbackAvatarLocation
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackAvatarLocation == null)
				{
					SetInstance();
					nativeCallbackAvatarLocation = new Importer.Callback(OnCallbackAvatarLocation);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_AVATAR_LOCATION, nativeCallbackAvatarLocation);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_AVATAR_LOCATION, null);
				}
			}
		}
		#endregion
		
		#region CallbackObjectQuery
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackObjectQuery;
		private Importer.Callback nativeCallbackObjectQuery;
	
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
		public event Callback CallbackObjectQuery
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackObjectQuery == null)
				{
					SetInstance();
					nativeCallbackObjectQuery = new Importer.Callback(OnCallbackObjectQuery);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_OBJECT_QUERY, nativeCallbackObjectQuery);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_OBJECT_QUERY, null);
				}
			}
		}
		#endregion
		
		#region CallbackWorldCavResult
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackWorldCavResult;
		private Importer.Callback nativeCallbackWorldCavResult;
	
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
		public event Callback CallbackWorldCavResult
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackWorldCavResult == null)
				{
					SetInstance();
					nativeCallbackWorldCavResult = new Importer.Callback(OnCallbackWorldCavResult);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_CAV_RESULT, nativeCallbackWorldCavResult);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_CAV_RESULT, null);
				}
			}
		}
		#endregion
		
		#region CallbackWorldCav
		//Declare the types to handle both the managed and native callbacks.
		private Instance.Callback managedCallbackWorldCav;
		private Importer.Callback nativeCallbackWorldCav;
	
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
		public event Callback CallbackWorldCav
		{
			//Handles hooking a new delegate to the callback.
			add
			{
				//If the callback is null, set the native callback for the instance.
				if (managedCallbackWorldCav == null)
				{
					SetInstance();
					nativeCallbackWorldCav = new Importer.Callback(OnCallbackWorldCav);
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_CAV, nativeCallbackWorldCav);
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
					Importer.aw_instance_callback_set(AW_CALLBACK.AW_CALLBACK_WORLD_CAV, null);
				}
			}
		}
		#endregion
		
	}
}