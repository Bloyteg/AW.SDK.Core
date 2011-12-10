// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
using System;
using System.Runtime.InteropServices;

namespace AW
{
    /// <summary>
    /// <see cref="Instance" /> is used to create and manage a SDK instance.
    /// Instances are used to either manage bots or world server administration.
    /// Each instance manages its own events, callbacks, and state.
    /// </summary>
    /// <remarks>
    /// This class <b>DOES NOT</b> does not represent the SDK as a whole, but rather a small unit of the SDK.
    /// This class should not be mistaken as the entire SDK by novice programmers and programmers moving over from Visual Basic 6.
    /// For more information on how multiple instances work, please refer to the "Multiple Instances" topic under the Concepts section.
    /// </remarks>
    public sealed partial class Instance : IInstance
    {
        /**
         * Private stuff not privy to the user.
         */
        private readonly IntPtr _instance;
        private bool _disposed;

        #region public members

        /// <summary>
        /// Indicates that the instance is in the process of being disposed.
        /// </summary>
        public event InstanceEventHandler Disposing;

        #endregion

        #region Static Constructors / Destructors
#pragma warning disable 169
        /// <summary>
        /// Static destructor for handling when the final instance of the class is garbage collected.
        /// </summary>
        private static readonly Utilities.StaticDestructor Destructor = new Utilities.StaticDestructor(Utility.Terminate);
#pragma warning restore 169

        /// <summary>
        /// Static constructor.  This initializes the SDK the first time an instance is created.
        /// </summary>
        static Instance()
        {
            SDKWrapperException<SDKWrapperInitializationFailedException>.Assert(Utility.Initialize());
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default instance constructor.  The instance will be created for the default Active Worlds universe.
        /// </summary>
        /// <exception cref="InstanceCreationFailedException">Thrown when the instance failed to be created.</exception>
        public Instance()
        {
            IntPtr tempInstance;
            int rc = NativeMethods.aw_create(null, 0, out tempInstance);
            SDKWrapperException<InstanceCreationFailedException>.Assert(rc);

            _instance = tempInstance;
            Attributes = new AttributeProvider(this);
        }

        /// <summary>
        /// Constructs an instance for a non-default universe.
        /// </summary>
        /// <param name="domain">Unresolved domain name (i.e. auth.activeworlds.com).</param>
        /// <param name="port">Port number of the universe server.</param>
        /// <exception cref="InstanceCreationFailedException">Thrown when the instance failed to be created.</exception>
        public Instance(string domain, int port)
        {
            IntPtr tempInstance;
            int rc = NativeMethods.aw_create(domain, port, out tempInstance);
            SDKWrapperException<InstanceCreationFailedException>.Assert(rc);

            _instance = tempInstance;
            Attributes = new AttributeProvider(this);
        }

        /// <summary>
        /// Constructs an instance for a non-default universe.
        /// </summary>
        /// <param name="address">IP address of the universe server represented as a 32-bit unsigned integer.  The IP address is stored according to Network Byte Order.</param>
        /// <param name="port">Port number of the universe server.</param>
        /// <exception cref="InstanceCreationFailedException">Thrown when the instance failed to be created.</exception>
        public Instance(int address, int port)
        {
            IntPtr tempInstance;
            int rc = NativeMethods.aw_create_resolved(address, port, out tempInstance);
            SDKWrapperException<InstanceCreationFailedException>.Assert(rc);

            _instance = tempInstance;
            Attributes = new AttributeProvider(this);
        }

        /// <summary>
        /// Constructs an instance for management of a world server.
        /// </summary>
        /// <param name="domain">The address of the world server (domain or IP address).</param>
        /// <param name="port">The port of the world server.</param>
        /// <param name="password">The password required to login to the world server.</param>
        /// <exception cref="InstanceCreationFailedException">Thrown when the instance failed to be created.</exception>
        public Instance(string domain, int port, string password)
        {
            IntPtr tempInstance;
            int rc = NativeMethods.aw_server_admin(domain, port, password, out tempInstance);
            SDKWrapperException<InstanceCreationFailedException>.Assert(rc);

            _instance = tempInstance;
        }

        #endregion

        #region Disposal
        /// <summary>
        /// Finalizes the current <see cref="AW.Instance" /> to ensure that it is logged out and all allocated memory is freed.
        /// </summary>
        ~Instance()
        {
            if (!IsDisposed)
            {
                Dispose();
            }
        }

        /// <summary>
        /// Used to destroy the current <see cref="AW.Instance" />.
        /// </summary>
        /// <remarks>
        /// This will destroy the instance.  All references to the instance should be broken after calling this method.
        /// Any attempts to operate on an instance after it has been disposed will result in an exception being thrown.
        /// </remarks>
        public void Dispose()
        {
            _disposed = true;

            if (Disposing != null)
            {
                Disposing(this);
            }

            if (Utility.Initialized)
            {
                SetInstance();
                int rc = NativeMethods.aw_destroy();
                SDKWrapperException<InstanceDisposeFailedException>.Assert(rc);
            }

            GC.Collect();
        }

        /// <summary>
        /// Indicates that the referenced <see cref="AW.Instance" /> has been disposed of.
        /// </summary>
        /// <remarks>
        /// If the <see cref="AW.Instance" /> has been disposed (as indicated by this property) do not attempt to call any methods.
        /// You will need to reconstruct the instance.
        /// </remarks>
        public bool IsDisposed
        {
            get
            {
                return _disposed;
            }
        }
        #endregion

        /// <summary>
        /// Internal method for setting the current instance being operated on to the class specific instance.
        /// </summary>
        private void SetInstance()
        {
            if (NativeMethods.aw_instance() == _instance)
            {
                return;
            }

            int rc = NativeMethods.aw_instance_set(_instance);
            SDKWrapperException<InstanceSetFailedException>.Assert(rc);
        }

        #region Data setters/getters
        /// <summary>
        /// Sets a string attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be set.</param>
        /// <param name="value">The value of the attribute being set.</param>
        public void SetString(Attributes attribute, string value)
        {
            SetInstance();
            SDKWrapperException<InstanceAttributeException>.Assert(NativeMethods.aw_string_set(attribute, value));
        }

        /// <summary>
        /// Gets a string attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be accessed.</param>
        /// <returns>The value of the attribute being accessed.</returns>
        public string GetString(Attributes attribute)
        {
            SetInstance();
            return Marshal.PtrToStringUni(NativeMethods.aw_string(attribute));
        }

        /// <summary>
        /// Sets an integer attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be set.</param>
        /// <param name="value">The value of the attribute being set.</param>
        /// <exception cref="AW.InstanceAttributeException">Thrown when the instance failed to set the attribute.</exception>
        /// <exception cref="AW.InstanceSetFailedException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        public void SetInt(Attributes attribute, int value)
        {
            SetInstance();
            SDKWrapperException<InstanceAttributeException>.Assert(NativeMethods.aw_int_set(attribute, value));
        }

        /// <summary>
        /// Gets an integer attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be accessed.</param>
        /// <returns>The value of the attribute being accessed.</returns>
        /// <exception cref="AW.InstanceSetFailedException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        public int GetInt(Attributes attribute)
        {
            SetInstance();
            return NativeMethods.aw_int(attribute);
        }

        /// <summary>
        /// Sets a boolean attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be set.</param>
        /// <param name="value">The value of the attribute being set.</param>
        /// <exception cref="AW.InstanceAttributeException">Thrown when the instance failed to set the attribute.</exception>
        /// <exception cref="AW.InstanceSetFailedException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        public void SetBool(Attributes attribute, bool value)
        {
            SetInstance();
            SDKWrapperException<InstanceAttributeException>.Assert(NativeMethods.aw_bool_set(attribute, value));
        }

        /// <summary>
        /// Gets a boolean attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be accessed.</param>
        /// <returns>The value of the attribute being accessed.</returns>
        /// <exception cref="AW.InstanceSetFailedException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        public bool GetBool(Attributes attribute)
        {
            SetInstance();
            return (NativeMethods.aw_bool(attribute) != 0);
        }

        /// <summary>
        /// Sets a floating point attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be set.</param>
        /// <param name="value">The value of the attribute being set.</param>
        /// <exception cref="AW.InstanceAttributeException">Thrown when the instance failed to set the attribute.</exception>
        /// <exception cref="AW.InstanceSetFailedException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        public void SetFloat(Attributes attribute, float value)
        {
            SetInstance();
            SDKWrapperException<InstanceAttributeException>.Assert(NativeMethods.aw_float_set(attribute, value));
        }

        /// <summary>
        /// Gets a floating point attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be accessed.</param>
        /// <returns>The value of the attribute being accessed.</returns>
        /// <exception cref="AW.InstanceSetFailedException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        public float GetFloat(Attributes attribute)
        {
            SetInstance();
            return NativeMethods.aw_float(attribute);
        }

        /// <summary>
        /// Sets a data (<see cref="System.Array" /> of <see cref="System.Byte" />) attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be set.</param>
        /// <param name="value">The value of the attribute being set.</param>
        public void SetData(Attributes attribute, byte[] value)
        {
            SetInstance();

            IntPtr dest = Marshal.AllocHGlobal(value.Length);
            int errorCode;

            try
            {
                Marshal.Copy(value, 0, dest, value.Length);
                errorCode = NativeMethods.aw_data_set(attribute, dest, value.Length);
            }
            finally
            {
                Marshal.FreeHGlobal(dest);
            }

            SDKWrapperException<InstanceAttributeException>.Assert(errorCode);
        }

        /// <summary>
        /// Gets a data (<see cref="System.Array" /> of <see cref="System.Byte" />) attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be accessed.</param>
        /// <returns>The value of the attribute being accessed.</returns>
        /// <exception cref="AW.InstanceSetFailedException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        public byte[] GetData(Attributes attribute)
        {
            SetInstance();
            int length;
            IntPtr temp = NativeMethods.aw_data(attribute, out length);

            if (length == 0)
                return null;

            var ret = new byte[length];
            Marshal.Copy(temp, ret, 0, length);
            return ret;
        }

        /// <summary>
        /// Takes a string value representing an XML Custom Avatar defition and sets the <see cref="AW.Attributes.CavDefinition" /> attribute accordingly.
        /// </summary>
        /// <param name="cavContents">String representation of the Custom Avatar definition's XML.</param>
        /// <exception cref="AW.InstanceSetFailedException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        public void SetCavData(string cavContents)
        {
            SetInstance();
            SetData(AW.Attributes.CavDefinition, Utility.Zip(System.Text.Encoding.UTF8.GetBytes(cavContents)));
        }

        /// <summary>
        /// Reads the <see cref="AW.Attributes.CavDefinition" /> attribute and returns the XML contained as a string.
        /// </summary>
        /// <returns>String representation of the Custom Avatar definition's XML.</returns>
        /// <exception cref="AW.InstanceSetFailedException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        public string GetCavData()
        {
            SetInstance();
            return System.Text.Encoding.UTF8.GetString(Utility.Unzip(GetData(AW.Attributes.CavDefinition)));
        }
        #endregion
    }
}