// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace OpenFoodFactsCSharp.Attributes
{
    /// <summary>
    /// A custom <see cref="Attribute"/> that declares if a class has changeable properties or if a property is changeable.
    /// In this case, it is meant that the changes of a property can be followed by an event.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Interface|AttributeTargets.Property, AllowMultiple = true)]
    public class ChangeableAttribute : Attribute
    {
        /// <summary>
        /// Constructor with an optional setting, if the marked class or property has a changing event.
        /// </summary>
        /// <param name="isChangeable">[optional] Has the marked class or property a changing event?</param>
        public ChangeableAttribute(bool isChangeable = true) => IsChangeable = isChangeable;

        /// <summary>
        /// Gets if the marked property or class has changing evens.
        /// </summary>
        public bool IsChangeable { get; }
    }
}
