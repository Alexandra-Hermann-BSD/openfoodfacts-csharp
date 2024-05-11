// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.Serialization;
using OpenFoodFactsCSharp.Attributes;
using OpenFoodFactsCSharp.EventHandler;

namespace OpenFoodFactsCSharp.Interfaces
{
    /// <summary>
    /// Interface for an ingredient.
    /// </summary>
    [Changeable]
    public interface IIngredient : ISerializable
    {
        /// <summary>
        /// Happens, when <see cref="FromPalmOil"/> has changed.
        /// </summary>
        event ChangeEventHandler<string> FromPalmOilChanged;

        /// <summary>
        /// Gets or sets if the ingredient is from palm oil.
        /// </summary>
        /// <value>Is the ingredient from palm oil.</value>
        [Changeable]
        string FromPalmOil { get; set; }

        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        /// <value>The ID</value>
        [Changeable]
        string Id { get; set; }

        /// <summary>
        /// Gets or sets the origin.
        /// </summary>
        /// <value>The origin</value>
        [Changeable]
        string Origin { get; set; }

        /// <summary>
        /// Gets or sets the percentage amount.
        /// </summary>
        /// <value>The percentage amount</value>
        [Changeable]
        string Percent { get; set; }

        /// <summary>
        /// Gets or sets the rank.
        /// </summary>
        /// <value>The rank</value>
        /// <remarks>Nullable</remarks>
        [Changeable]
        int? Rank { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>The text</value>
        [Changeable]
        string Text { get; set; }

        /// <summary>
        /// Gets or sets if the ingredient is vegan.
        /// </summary>
        /// <value>Is the ingredient vegan?</value>
        [Changeable]
        string Vegan { get; set; }

        /// <summary>
        /// Gets or sets if the ingredient is vegetarian.
        /// </summary>
        /// <value>Is the ingredient vegetarian?</value>
        [Changeable]
        string Vegetarian { get; set; }

        /// <summary>
        /// Happens, if the <see cref="Id"/> has changed.
        /// </summary>
        event ChangeEventHandler<string> IdChanged;

        /// <summary>
        /// Happens, if the <see cref="Origin"/> has changed.
        /// </summary>
        event ChangeEventHandler<string> OriginChanged;

        /// <summary>
        /// Happens, if <see cref="Percent"/> has changed.
        /// </summary>
        event ChangeEventHandler<string> PercentChanged;

        /// <summary>
        /// Happens, if <see cref="Rank"/> has changed?
        /// </summary>
        event ChangeEventHandler<int?> RankChanged;

        /// <summary>
        /// Happens, if the <see cref="Text"/> has changed.
        /// </summary>
        event ChangeEventHandler<string> TextChanged;

        /// <summary>
        /// Happens, if <see cref="Vegan"/> has changed.
        /// </summary>
        event ChangeEventHandler<string> VeganChanged;

        /// <summary>
        /// Happens, if <see cref="Vegetarian"/> has changed.
        /// </summary>
        event ChangeEventHandler<string> VegetarianChanged;
    }
}
