using System;

namespace Utilities
{
    internal class StaticDestructor
    {
        public delegate void Handler();
        private Handler doDestroy;

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