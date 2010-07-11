using System;

namespace Utilities
{
    /// <summary>
    /// Interface representing an indexed property.
    /// </summary>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    /// <typeparam name="TReturn">The type of the return.</typeparam>
    public interface IIndexedProperty<TKey, TReturn>
    {
        /// <summary>
        /// Indexed property.
        /// </summary>
        /// <param name="key">The key to search for.</param>
        /// <returns>The value associated with the key.</returns>
        TReturn this[TKey key]
        {
            get;
            set;
        }
    }

    /// <summary>
    /// Represents an indexed property that uses delegated methods to get and set the properties accordingly.
    /// </summary>
    /// <typeparam name="TKey">The type of the key being used to locate items.</typeparam>
    /// <typeparam name="TReturn">The return type of the getter method.</typeparam>
    internal class IndexedProperty<TKey, TReturn> : IIndexedProperty<TKey, TReturn>
    {
        public delegate void Setter(TKey key, TReturn value);
        public delegate TReturn Getter(TKey key);

        private Getter _getter = null;
        private Setter _setter = null;

        public IndexedProperty(Getter getter)
        {
            _getter = getter;
        }

        public IndexedProperty(Getter getter, Setter setter)
        {
            _getter = getter;
            _setter = setter;
        }

        public TReturn this[TKey key]
        {
            get
            {
                return _getter(key);
            }

            set
            {
                if (_setter != null)
                {
                    _setter(key, value);
                }
                else
                {
                    throw new ArgumentException("Property is read-only.");
                }
            }
        }
    }
}