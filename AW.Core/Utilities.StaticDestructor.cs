using System;

namespace Utilities
{
    /// <summary>
    /// Used to add a static destructor to classes, so when the last instance of a class is destroyed
    /// it will clean up any static resources as needed.
    /// </summary>
    internal class StaticDestructor
    {
        /// <summary>
        /// The delegate that is invoked when the destructor is called.
        /// </summary>
        public delegate void Handler();
        private Handler doDestroy;

        /// <summary>
        /// Creates a new static destructor with the specified delegate to handle the destruction.
        /// </summary>
        /// <param name="method">The delegate that will handle destruction.</param>
        public StaticDestructor(Handler method)
        {
            doDestroy = method;
        }

        ~StaticDestructor()
        {
            doDestroy();
        }
    }
}