namespace AW
{
    partial class Instance
    {
        /// <summary>
        /// Stores data set by the user, associated with the instance.
        /// </summary>
        public object UserData
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
                return InterOp.aw_session();
            }
        }
    }
}