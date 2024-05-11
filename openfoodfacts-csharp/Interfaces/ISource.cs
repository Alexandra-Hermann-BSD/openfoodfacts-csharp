// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.Serialization;
using Newtonsoft.Json;
using OpenFoodFactsCSharp.Attributes;
using OpenFoodFactsCSharp.EventHandler;

namespace OpenFoodFactsCSharp.Interfaces
{
    /// <summary>
    /// An interface for the source
    /// </summary>
    [Changeable]
    public interface ISource : ISerializable
    {
        /// <summary>
        /// Happens when <see cref="Fields"/> where set to a new array.
        /// </summary>
        event ChangeEventHandler<string[]> FieldsChanged;

        /// <summary>
        /// Gets or sets an array of fields.
        /// </summary>
        /// <value>An array of fields</value>
        [Changeable]
        string[] Fields { get; set; }

        /// <summary>
        /// Happens, when the <see cref="Id"/> has changed.
        /// </summary>
        event ChangeEventHandler<string> IdChanged;

        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        /// <value>The ID</value>
        [Changeable]
        string Id { get; set; }

        /// <summary>
        /// Happens, when the <see cref="Images"/> were set to a new array.
        /// </summary>
        event ChangeEventHandler<string[]> ImagesChanged;

        /// <summary>
        /// Gets or sets an array of images (as <see cref="string"/>)
        /// </summary>
        /// <value>An array of images</value>
        [Changeable]
        string[] Images { get; set; }

        /// <summary>
        /// Happens, when the <see cref="ImportT"/> has changed.
        /// </summary>
        event ChangeEventHandler<long?> ImportTChanged;

        /// <summary>
        /// Gets or sets an import type.
        /// </summary>
        /// <value>An import type</value>
        /// <remarks>Nullable <see cref="long"/></remarks>
        [Changeable]
        [JsonProperty("import_t")]
        long? ImportT { get; set; }

        /// <summary>
        /// Happens, when the <see cref="Manufacturer"/> has changed.
        /// </summary>
        event ChangeEventHandler<string> ManufacturerChanged;

        /// <summary>
        /// Gets or sets the manufacturer.
        /// </summary>
        /// <value>The manufacturer</value>
        [Changeable]
        string Manufacturer { get; set; }

        /// <summary>
        /// Happens, if the <see cref="Name"/> has changed.
        /// </summary>
        event ChangeEventHandler<string> NameChanged;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name</value>
        [Changeable]
        string Name { get; set; }

        /// <summary>
        /// Happens, when the <see cref="Url"/> has changed.
        /// </summary>
        event ChangeEventHandler<string> UrlChanged;

        /// <summary>
        /// Gets or sets the Url.
        /// </summary>
        /// <value>The Url</value>
        [Changeable]
        string Url { get; set; }
    }
}
