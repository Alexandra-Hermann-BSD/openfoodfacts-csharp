// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using OpenFoodFactsCSharp.Interfaces;

namespace OpenFoodFactsCSharp.Models
{
    /// <summary>
    /// A class for other values.
    /// </summary>
    /// <typeparam name="T">The type of the other values</typeparam>
    public class OtherValues<T> : IOtherValues<T>
    {
        private readonly IDictionary<string, T> _other  = new Dictionary<string, T>();

        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, T>> GetEnumerator() => _other.GetEnumerator();

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_other).GetEnumerator();

        /// <inheritdoc />
        public void Add(KeyValuePair<string, T> item) => _other.Add(item);

        /// <inheritdoc />
        public void Clear() => _other.Clear();

        /// <inheritdoc />
        public bool Contains(KeyValuePair<string, T> item) => _other.Contains(item);

        /// <inheritdoc />
        public void CopyTo(KeyValuePair<string, T>[] array, int arrayIndex) => _other.CopyTo(array, arrayIndex);

        /// <inheritdoc />
        public bool Remove(KeyValuePair<string, T> item) => _other.Remove(item);

        /// <inheritdoc />
        public int Count => _other.Count;

        /// <inheritdoc />
        public bool IsReadOnly => _other.IsReadOnly;

        /// <inheritdoc />
        public bool ContainsKey(string key) => _other.ContainsKey(key);

        /// <inheritdoc />
        public void Add(string key, T value) => _other.Add(key, value);

        /// <inheritdoc />
        public bool Remove(string key) => _other.Remove(key);

        /// <inheritdoc />
        public bool TryGetValue(string key, out T value) => _other.TryGetValue(key, out value);

        /// <inheritdoc />
        public T this[string key]
        {
            get => _other[key];
            set => _other[key] = value;
        }

        /// <inheritdoc />
        public ICollection<string> Keys => _other.Keys;

        /// <inheritdoc />
        public ICollection<T> Values => _other.Values;

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
                Add(key, default);
            }
        }
    }
}
