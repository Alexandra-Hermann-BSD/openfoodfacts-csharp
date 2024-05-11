// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace OpenFoodFactsCSharp.Interfaces
{
    /// <summary>
    /// Interface for objects that have other values
    /// </summary>
    public interface IHasOtherValues<T>
    {
        /// <summary>
        /// Gets a dictionary for other values.
        /// </summary>
        /// <value>A dictionary for other values</value>
        IOtherValues<object> Other { get; }
    }
}
