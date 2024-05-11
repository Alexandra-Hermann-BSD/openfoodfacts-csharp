// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace OpenFoodFactsCSharp.Interfaces
{
    /// <summary>
    /// Interface for a dictionary of other values
    /// </summary>
    public interface IOtherValues<T> : IDictionary<string, T>
    {
        /// <summary>
        /// Adds an array of keys.
        /// </summary>
        /// <param name="keys">The array of keys</param>
        void Add(string[] keys);

        /// <summary>
        /// Adds a collection of keys.
        /// </summary>
        /// <param name="keys">The collection of keys</param>
        void Add(ICollection<string> keys);

        /// <summary>
        /// Adds a key without a value.
        /// </summary>
        /// <param name="key">The Key to add</param>
        /// <remarks>If <paramref name="key"/> already exists in <see cref="IDictionary{TKey,TValue}.Keys"/>, nothing will happen</remarks>
        void Add(string key);
    }
}
