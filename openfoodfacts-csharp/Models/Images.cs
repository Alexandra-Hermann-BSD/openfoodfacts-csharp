
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using OpenFoodFactsCSharp.Interfaces;

namespace OpenFoodFactsCSharp.Models
{
    /// <summary>
    /// A class for an image dictionary.
    /// </summary>
    public class Images : IImages
    {
        private readonly IDictionary<string, object> _other;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Images() => _other = new Dictionary<string, object>();

        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => _other.GetEnumerator();

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_other).GetEnumerator();

        /// <inheritdoc />
        public void Add(KeyValuePair<string, object> item) => _other.Add(item);

        /// <inheritdoc />
        public void Clear() => _other.Clear();

        /// <inheritdoc />
        public bool Contains(KeyValuePair<string, object> item) => _other.Contains(item);

        /// <inheritdoc />
        public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex) => _other.CopyTo(array, arrayIndex);

        /// <inheritdoc />
        public bool Remove(KeyValuePair<string, object> item) => _other.Remove(item);

        /// <inheritdoc />
        public int Count => _other.Count;

        /// <inheritdoc />
        public bool IsReadOnly => _other.IsReadOnly;

        /// <inheritdoc />
        public bool ContainsKey(string key) => _other.ContainsKey(key);

        /// <inheritdoc />
        public void Add(string key, object value) => _other.Add(key, value);

        /// <inheritdoc />
        public bool Remove(string key) => _other.Remove(key);

        /// <inheritdoc />
        public bool TryGetValue(string key, out object value) => _other.TryGetValue(key, out value);

        /// <inheritdoc />
        public object this[string key]
        {
            get => _other[key];
            set => _other[key] = value;
        }

        /// <inheritdoc />
        public ICollection<string> Keys => _other.Keys;

        /// <inheritdoc />
        public ICollection<object> Values => _other.Values;

        /// <inheritdoc />
        public void Add(string[] keys) => Add(keys as ICollection<string>);

        /// <inheritdoc />
        public void Add(ICollection<string> keys)
        {
            foreach (string key in keys.Where(k => !_other.ContainsKey(k)))
            {
                Add(key);
            }
        }

        /// <inheritdoc />
        public void Add(string key)
        {
            if (!ContainsKey(key))
            {
                Add(key, null);
            }
        }
    }
}
