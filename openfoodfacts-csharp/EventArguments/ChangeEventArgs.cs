// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace OpenFoodFactsCSharp.EventArguments
{
    /// <summary>
    /// Event arguments for changing objects.
    /// </summary>
    /// <typeparam name="T">The type of the changing object</typeparam>
    public class ChangeEventArgs<T> : EventArgs
    {
        /// <summary>
        /// Constructor with a given old and new value.
        /// </summary>
        /// <param name="oldValue">The given old value</param>
        /// <param name="newValue">The given new value</param>
        public ChangeEventArgs(T oldValue, T newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }

        /// <summary>
        /// Gets the old value.
        /// </summary>
        /// <value>The old value</value>
        public T OldValue { get; }

        /// <summary>
        /// Gets the new value.
        /// </summary>
        /// <value>The new value</value>
        public T NewValue { get; }
    }
}
