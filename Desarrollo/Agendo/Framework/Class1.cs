using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    /// <summary>
    /// Structure to manage deferred instantiation of dependencies for manager classes.
    /// </summary>
    /// <typeparam name="T">Type of the dependency.</typeparam>
    public struct Dependency<T> where T : new()
    {
        private T _reference;

        /// <summary>
        /// Get a reference to an instance of the dependency class.
        /// </summary>
        /// <param name="construct">If <b>true</b>, the dependency will be constructed if necessary.</param>
        /// <returns>A reference to an instance of the dependency class.</returns>
        public T Get(bool construct)
        {
            if (_reference == null && construct)
                Set(new T());
            return _reference;
        }

        /// <summary>
        /// Set the reference to an instance of the dependency class.
        /// </summary>
        /// <param name="value">A reference to an instance of the dependency class.</param>
        public void Set(T value)
        {
            _reference = value;
        }
    }
}
