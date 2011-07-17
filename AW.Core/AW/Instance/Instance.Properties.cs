// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
namespace AW
{
    partial class Instance
    {
        public IAttributeProvider Attributes
        {
            get; 
            internal set;
        }

        /// <summary>
        /// Stores data set by the user, associated with the instance.
        /// </summary>
        public object Tag
        {
            get;
            set;
        }

        /// <summary>
        /// Returns the session associated with the instance.  This will change if connection is lost to the universe and re-established.
        /// </summary>
        public int Session
        {
            get
            {
                SetInstance();
                return NativeMethods.aw_session();
            }
        }
    }
}