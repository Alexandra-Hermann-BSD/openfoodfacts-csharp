// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using OpenFoodFactsCSharp.EventArguments;

namespace OpenFoodFactsCSharp.EventHandler
{
    /// <summary>
    /// Event handler for changing objects.
    /// </summary>
    /// <typeparam name="T">The type of the changing object</typeparam>
    public delegate void ChangeEventHandler<T>(object sender, ChangeEventArgs<T> e);
}
