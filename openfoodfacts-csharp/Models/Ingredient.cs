
using System;
using System.Runtime.Serialization;
using JetBrains.Annotations;
using Newtonsoft.Json;
using OpenFoodFactsCSharp.Attributes;
using OpenFoodFactsCSharp.EventArguments;
using OpenFoodFactsCSharp.EventHandler;
using OpenFoodFactsCSharp.Interfaces;

namespace OpenFoodFactsCSharp.Models
{
    /// <summary>
    /// A class describing an ingredient.
    /// </summary>
    [Serializable]
    [Changeable]
    public class Ingredient : IIngredient
    {
        private string _fromPalmOil;
        private string _id;
        private string _origin;
        private string _percent;
        private int? _rank;
        private string _text;
        private string _vegan;
        private string _vegetarian;

        /// <summary>
        /// Constructor to deserialize-
        /// </summary>
        /// <param name="info">Serialization info</param>
        /// <param name="context">A streaming context</param>
        protected Ingredient([NotNull]SerializationInfo info, StreamingContext context)
        {
            _fromPalmOil = info.GetString(nameof(_fromPalmOil));
            _id = info.GetString(nameof(_id));
            _origin = info.GetString(_origin);
            _percent = info.GetString(_percent);
            _rank = info.GetValue(nameof(_rank), typeof(int?)) as int?;
            _text = info.GetString(nameof(_text));
            _vegan = info.GetString(nameof(_vegan));
            _vegetarian = info.GetString(nameof(_vegetarian));
        }

        /// <inheritdoc />
        public event ChangeEventHandler<string> FromPalmOilChanged;

        /// <inheritdoc />
        [Changeable]
        [JsonProperty("from_palm_oil")]
        public string FromPalmOil
        {
            get => _fromPalmOil;
            set
            {
                if (value != _fromPalmOil)
                {
                    ChangeEventArgs<string> changeEventArgs = new ChangeEventArgs<string>(_fromPalmOil, value);
                    _fromPalmOil = value;
                    FromPalmOilChanged?.Invoke(this, changeEventArgs);
                }
            }
        }

        /// <inheritdoc />
        public event ChangeEventHandler<string> IdChanged;

        /// <inheritdoc />
        [Changeable]
        public string Id
        {
            get => _id;
            set
            {
                if (value != _id)
                {
                    ChangeEventArgs<string> changeEventArgs = new ChangeEventArgs<string>(_id, value);
                    _id = value;
                    IdChanged?.Invoke(this, changeEventArgs);
                }
            }
        }

        /// <inheritdoc />
        public event ChangeEventHandler<string> OriginChanged;

        /// <inheritdoc />
        [Changeable]
        public string Origin
        {
            get => _origin;
            set
            {
                if (value != _origin)
                {
                    ChangeEventArgs<string> changeEventArgs = new ChangeEventArgs<string>(_origin, value);
                    _origin = value;
                    OriginChanged?.Invoke(this, changeEventArgs);
                }
            }
        }

        /// <inheritdoc />
        public event ChangeEventHandler<string> PercentChanged;

        /// <inheritdoc />
        [Changeable]
        public string Percent
        {
            get => _percent;
            set
            {
                if (value != _percent)
                {
                    ChangeEventArgs<string> changeEventArgs = new ChangeEventArgs<string>(_percent, value);
                    _percent = value;
                    PercentChanged?.Invoke(this, changeEventArgs);
                }
            }
        }

        /// <inheritdoc />
        public event ChangeEventHandler<int?> RankChanged;

        /// <inheritdoc />
        [Changeable]
        public int? Rank
        {
            get => _rank;
            set
            {
                if (value != _rank)
                {
                    ChangeEventArgs<int?> changeEventArgs = new ChangeEventArgs<int?>(_rank, value);
                    _rank = value;
                    RankChanged?.Invoke(this, changeEventArgs);
                }
            }
        }

        /// <inheritdoc />
        public event ChangeEventHandler<string> TextChanged;

        /// <inheritdoc />
        [Changeable]
        public string Text
        {
            get => _text;
            set
            {
                if (value != _text)
                {
                    ChangeEventArgs<string> changeEventArgs = new ChangeEventArgs<string>(_text, value);
                    _text = value;
                    TextChanged?.Invoke(this, changeEventArgs);
                }
            }
        }

        /// <inheritdoc />
        public event ChangeEventHandler<string> VeganChanged;

        /// <inheritdoc />
        [Changeable]
        public string Vegan
        {
            get => _vegan;
            set
            {
                if (value != _vegan)
                {
                    ChangeEventArgs<string> changeEventArgs = new ChangeEventArgs<string>(_vegan, value);
                    _vegan = value;
                    VeganChanged?.Invoke(this, changeEventArgs);
                }
            }
        }

        /// <inheritdoc />
        public event ChangeEventHandler<string> VegetarianChanged;

        /// <inheritdoc />
        [Changeable]
        public string Vegetarian
        {
            get => _vegetarian;
            set
            {
                if (value != _vegetarian)
                {
                    ChangeEventArgs<string> changeEventArgs = new ChangeEventArgs<string>(_vegetarian, value);
                    _vegetarian = value;
                    VegetarianChanged?.Invoke(this, changeEventArgs);
                }
            }
        }

        /// <inheritdoc />
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(nameof(_fromPalmOil), _fromPalmOil);
            info.AddValue(nameof(_id), _id);
            info.AddValue(nameof(_origin), _origin);
            info.AddValue(nameof(_percent), _percent);
            info.AddValue(nameof(_rank), _rank);
            info.AddValue(nameof(_text), _text);
            info.AddValue(nameof(_vegan), _vegan);
            info.AddValue(nameof(_vegetarian), _vegetarian);
        }
    }
}
