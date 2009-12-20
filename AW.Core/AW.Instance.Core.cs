using System;
using System.Runtime.InteropServices;

namespace AW
{
    /// <summary>
    /// <see cref="AW.Instance" /> is used to create and manage a SDK instance.
    /// Instances are used to either manage bots or world server administration.
    /// Each instance manages its own events, callbacks, and state.
    /// </summary>
    /// <remarks>
    /// This class <b>DOES NOT</b> does not represent the SDK as a whole, but rather a small unit of the SDK.
    /// This class should not be mistaken as the entire SDK by novice programmers and programmers moving over from Visual Basic 6.
    /// For more information on how multiple instances work, please refer to the "Multiple Instances" topic under the Concepts section.
    /// </remarks>
    public sealed partial class Instance : IDisposable
    {
        /**
         * Private stuff not privy to the user.
         */
        private IntPtr instance;
        private bool _disposed = false;

        #region public members
        /// <summary>
        /// Used to handle events sent to the <see cref="AW.Instance" />.
        /// </summary>
        /// <param name="sender">The instance that the event is associated with.</param>
        public delegate void Event(Instance sender);

        /// <summary>
        /// Used to handle callbacks sent to the <see cref="AW.Instance" />.
        /// </summary>
        /// <param name="sender">The instance that the event is associated with.</param>
        /// <param name="error">The error code associated with the callback.  Check this to ensure the callback was successful.</param>
        public delegate void Callback(Instance sender, int error);

        /// <summary>
        /// Indicates that the instance is in the process of being disposed.
        /// </summary>
        public event Event Disposing;

        #endregion

        #region Static Constructors / Destructors
        /// <summary>
        /// Static destructor for handling when the final instance of the class is garbage collected.
        /// </summary>
        private static readonly Utilities.StaticDestructor destructor = new Utilities.StaticDestructor
        (
            delegate()
            {
                Utility.Terminate();
            }
        );

        /// <summary>
        /// Static constructor.  This initializes the SDK the first time an instance is created.
        /// </summary>
        static Instance()
        {
            int rc = Utility.Initialize();
            if (rc != 0)
                throw new Exception(string.Format("Failed to initialize the SDK (Reason {0}).", rc));
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default instance constructor.  The instance will be created for the default Active Worlds universe.
        /// </summary>
        /// <exception cref="AW.InstanceException">Thrown when the instance failed to be created.</exception>
        public Instance()
        {
            IntPtr tempInstance;
            int rc = InterOp.aw_create(null, 0, out tempInstance);
            InstanceException.Assert(rc);

            instance = tempInstance;
        }

        /// <summary>
        /// Constructs an instance for a non-default universe.
        /// </summary>
        /// <param name="domain">Unresolved domain name (i.e. auth.activeworlds.com).</param>
        /// <param name="port">Port number of the universe server.</param>
        /// <exception cref="AW.InstanceException">Thrown when the instance failed to be created.</exception>
        public Instance(string domain, int port)
        {
            IntPtr tempInstance;
            int rc = InterOp.aw_create(domain, port, out tempInstance);
            InstanceException.Assert(rc);

            instance = tempInstance;
        }

        /// <summary>
        /// Constructs an instance for a non-default universe.
        /// </summary>
        /// <param name="address">IP address of the universe server represented as a 32-bit unsigned integer.  The IP address is stored according to Network Byte Order.</param>
        /// <param name="port">Port number of the universe server.</param>
        /// <exception cref="AW.InstanceException">Thrown when the instance failed to be created.</exception>
        public Instance(uint address, int port)
        {
            IntPtr tempInstance;
            int rc = InterOp.aw_create_resolved(address, port, out tempInstance);
            InstanceException.Assert(rc);

            instance = tempInstance;
        }

        /// <summary>
        /// Constructs an instance for management of a world server.
        /// </summary>
        /// <param name="domain">The address of the world server (domain or IP address).</param>
        /// <param name="port">The port of the world server.</param>
        /// <param name="password">The password required to login to the world server.</param>
        /// <exception cref="AW.InstanceException">Thrown when the instance failed to be created.</exception>
        public Instance(string domain, int port, string password)
        {
            IntPtr tempInstance;
            int rc = InterOp.aw_server_admin(domain, port, password, out tempInstance);
            InstanceException.Assert(rc);

            instance = tempInstance;
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
        /// <exception cref="AW.InstanceException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        public void Dispose()
        {
            _disposed = true;

            if (this.Disposing != null)
            {
                this.Disposing(this);
            }

            if (this.instance != null && Utility.Initialized != false)
            {
                SetInstance();
                int rc = InterOp.aw_destroy();
                InstanceException.Assert(rc);
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
            if (InterOp.aw_instance() != instance)
            {
                int rc;
                if ((rc = InterOp.aw_instance_set(instance)) > 0) throw new InstanceException("Failed to set instance.")
                {
                    ErrorCode = rc
                };
            }
        }

        #region Data setters/getters
        /// <summary>
        /// Sets a string attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be set.</param>
        /// <param name="value">The value of the attribute being set.</param>
        /// <exception cref="AW.InstanceException">Thrown when the instance failed to set the attribute.</exception>
        /// <exception cref="AW.InstanceException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        public int SetString(AW.Attributes attribute, string value)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_string_set(attribute, value));
        }

        /// <summary>
        /// Gets a string attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be accessed.</param>
        /// <returns>The value of the attribute being accessed.</returns>
        /// <exception cref="AW.InstanceException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        public string GetString(AW.Attributes attribute)
        {
            SetInstance();
            return Marshal.PtrToStringAnsi(InterOp.aw_string(attribute));
        }

        /// <summary>
        /// Sets an integer attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be set.</param>
        /// <param name="value">The value of the attribute being set.</param>
        /// <exception cref="AW.InstanceException">Thrown when the instance failed to set the attribute.</exception>
        /// <exception cref="AW.InstanceException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        public int SetInt(AW.Attributes attribute, int value)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_int_set(attribute, value));
        }

        /// <summary>
        /// Gets an integer attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be accessed.</param>
        /// <returns>The value of the attribute being accessed.</returns>
        /// <exception cref="AW.InstanceException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        public int GetInt(AW.Attributes attribute)
        {
            SetInstance();
            return InterOp.aw_int(attribute);
        }

        /// <summary>
        /// Sets a boolean attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be set.</param>
        /// <param name="value">The value of the attribute being set.</param>
        /// <exception cref="AW.InstanceException">Thrown when the instance failed to set the attribute.</exception>
        /// <exception cref="AW.InstanceException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        public int SetBool(AW.Attributes attribute, bool value)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_bool_set(attribute, value));
        }

        /// <summary>
        /// Gets a boolean attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be accessed.</param>
        /// <returns>The value of the attribute being accessed.</returns>
        /// <exception cref="AW.InstanceException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        public bool GetBool(AW.Attributes attribute)
        {
            SetInstance();
            return (InterOp.aw_bool(attribute) != 0);
        }

        /// <summary>
        /// Sets a floating point attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be set.</param>
        /// <param name="value">The value of the attribute being set.</param>
        /// <exception cref="AW.InstanceException">Thrown when the instance failed to set the attribute.</exception>
        /// <exception cref="AW.InstanceException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        public int SetFloat(AW.Attributes attribute, float value)
        {
            SetInstance();
            return InstanceException.Assert(InterOp.aw_float_set(attribute, value));
        }

        /// <summary>
        /// Gets a floating point attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be accessed.</param>
        /// <returns>The value of the attribute being accessed.</returns>
        /// <exception cref="AW.InstanceException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        public float GetFloat(AW.Attributes attribute)
        {
            SetInstance();
            return InterOp.aw_float(attribute);
        }

        /// <summary>
        /// Sets a data (<see cref="System.Array" /> of <see cref="System.Byte" />) attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be set.</param>
        /// <param name="value">The value of the attribute being set.</param>
        /// <exception cref="AW.InstanceException">Thrown when the instance failed to set the attribute.</exception>
        /// <exception cref="AW.InstanceException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        public int SetData(AW.Attributes attribute, byte[] value)
        {
            SetInstance();

            IntPtr dest = Marshal.AllocHGlobal(value.Length);
            int errorCode = 0;

            try
            {
                Marshal.Copy(value, 0, dest, value.Length);
                errorCode = InterOp.aw_data_set(attribute, dest, (uint)value.Length);
            }
            finally
            {
                Marshal.FreeHGlobal(dest);
            }

            return InstanceException.Assert(errorCode);
        }

        /// <summary>
        /// Gets a data (<see cref="System.Array" /> of <see cref="System.Byte" />) attribute for the current instance.
        /// </summary>
        /// <param name="attribute">The attribute to be accessed.</param>
        /// <returns>The value of the attribute being accessed.</returns>
        /// <exception cref="AW.InstanceException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        public byte[] GetData(AW.Attributes attribute)
        {
            SetInstance();
            uint length;
            IntPtr temp = InterOp.aw_data(attribute, out length);

            if (length == 0)
                return null;

            byte[] ret = new byte[length];
            Marshal.Copy(temp, ret, 0, (int)length);
            return ret;
        }

        /// <summary>
        /// Takes a string value representing an XML Custom Avatar defition and sets the <see cref="AW.Attributes.CavDefinition" /> attribute accordingly.
        /// </summary>
        /// <param name="cavContents">String representation of the Custom Avatar definition's XML.</param>
        /// <exception cref="AW.InstanceException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        public int SetCAVData(string cavContents)
        {
            SetInstance();
            return SetData(Attributes.CavDefinition, Utility.Zip(System.Text.UTF8Encoding.UTF8.GetBytes(cavContents)));
        }

        /// <summary>
        /// Reads the <see cref="AW.Attributes.CavDefinition" /> attribute and returns the XML contained as a string.
        /// </summary>
        /// <returns>String representation of the Custom Avatar definition's XML.</returns>
        /// <exception cref="AW.InstanceException">Thrown when the instance cannot be set properly. 
        /// (i.e. the instance has been destroyed or is not valid).</exception>
        public string GetCAVData()
        {
            SetInstance();
            return System.Text.UTF8Encoding.UTF8.GetString(Utility.Unzip(GetData(Attributes.CavDefinition)));
        }
        #endregion
    }
}