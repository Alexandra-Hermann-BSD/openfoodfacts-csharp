using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using JetBrains.Annotations;
using Newtonsoft.Json;
using OpenFoodFactsCSharp.Attributes;
using OpenFoodFactsCSharp.Interfaces;

namespace OpenFoodFactsCSharp.Models
{
    [Changeable]
    [Serializable]
    public class Nutriments : ISerializable, IHasOtherValues<object>
    {
        private float? _salt;
        private float? _saltServing;
        private float? _salt100G;
        private string _saltUnit;

        private float? _fat;
        private float? _fatServing;
        private float? _fat100G;
        private string _fatUnit;

        private float? _saturatedFat;
        private float? _saturatedFatServing;
        private float? _saturatedFat100G;
        private string _saturatedFatUnit;

        private float? _sugars;
        private float? _sugarsServing;
        private float? _sugars100G;
        private string _sugarsUnit;

        private float? _carbohydrates;
        private float? _carbohydratesServing;
        private float? _carbohydrates100G;
        private string _carbohydratesUnit;

        private float? _energyKcal100G;
        private float? _energyKcalServing;
        private string _energyKcalUnit;

        private float? _proteins;
        private float? _proteinsServing;
        private float? _proteins100G;
        private string _proteinsUnit;

        private IOtherValues<object> _other = new OtherValues<object>();

        protected Nutriments([NotNull]SerializationInfo info, StreamingContext context)
        {
            _salt = info.GetValue(nameof(_salt), typeof(float?)) as float?;
            _saltServing = info.GetValue(nameof(_saltServing), typeof(float?)) as float?;
            _salt100G = info.GetValue(nameof(_salt100G), typeof(float?)) as float?;
            _saltUnit = info.GetString(nameof(_saltUnit));

            _fat = info.GetValue(nameof(_fat), typeof(float?)) as float?;
            _fatServing = info.GetValue(nameof(_fatServing), typeof(float?)) as float?;
            _fat100G = info.GetValue(nameof(_fat100G), typeof(float?)) as float?;
            _fatUnit = info.GetString(nameof(_fatUnit));

            _saturatedFat = info.GetValue(nameof(_saturatedFat), typeof(float?)) as float?;
            _saturatedFatServing = info.GetValue(nameof(_saturatedFatServing), typeof(float?)) as float?;
            _saturatedFat100G = info.GetValue(nameof(_saturatedFat100G), typeof(float?)) as float?;
            _saturatedFatUnit = info.GetString(nameof(_saturatedFatUnit));

            _sugars = info.GetValue(nameof(_sugars), typeof(float?)) as float?;
            _sugarsServing = info.GetValue(nameof(_sugarsServing), typeof(float?)) as float?;
            _sugars100G = info.GetValue(nameof(_sugars100G), typeof(float?)) as float?;
            _sugarsUnit = info.GetString(nameof(_sugarsUnit));

            _carbohydrates = info.GetValue(nameof(_carbohydrates), typeof(float?)) as float?;
            _carbohydratesServing = info.GetValue(nameof(_carbohydratesServing), typeof(float?)) as float?;
            _carbohydrates100G = info.GetValue(nameof(_carbohydrates100G), typeof(float?)) as float?;
            _carbohydratesUnit = info.GetString(nameof(_carbohydratesUnit));

            _energyKcal100G = info.GetValue(nameof(_energyKcal100G), typeof(float?)) as float?;
            _energyKcalServing = info.GetValue(nameof(_energyKcalServing), typeof(float?)) as float?;
            _energyKcalUnit = info.GetString(nameof(_energyKcalUnit));

            _proteins = info.GetValue(nameof(_proteins), typeof(float?)) as float?;
            _proteinsServing = info.GetValue(nameof(_proteinsServing), typeof(float?)) as float?;
            _proteins100G = info.GetValue(nameof(_proteins100G), typeof(float?)) as float?;
            _proteinsUnit = info.GetString(nameof(_proteinsUnit));

            _other = info.GetValue(nameof(_other), typeof(IOtherValues<object> )) as IOtherValues<object> ;
        }

        [Changeable]
        [JsonProperty("salt")]
        public float? Salt
        {
            get => _salt;
            set { _salt = value; }
        }

        [Changeable]
        [JsonProperty("salt_serving")]
        public float? SaltServing
        {
            get => _saltServing;
            set { _saltServing = value; }
        }

        [Changeable]
        [JsonProperty("salt_100g")]
        public float? Salt100g
        {
            get => _salt100G;
            set { _salt100G = value; }
        }

        [Changeable]
        [JsonProperty("salt_unit")]
        public string SaltUnit
        {
            get => _saltUnit;
            set { _saltUnit = value; }
        }

        [Changeable]
        [JsonProperty("fat")]
        public float? Fat
        {
            get => _fat;
            set { _fat = value; }
        }

        [Changeable]
        [JsonProperty("fat_serving")]
        public float? FatServing
        {
            get => _fatServing;
            set { _fatServing = value; }
        }

        [Changeable]
        [JsonProperty("fat_100g")]
        public float? Fat100g
        {
            get => _fat100G;
            set { _fat100G = value; }
        }

        [Changeable]
        [JsonProperty("fat_unit")]
        public string FatUnit
        {
            get => _fatUnit;
            set { _fatUnit = value; }
        }

        [Changeable]
        [JsonProperty("saturated-fat")]
        public float? SaturatedFat
        {
            get => _saturatedFat;
            set { _saturatedFat = value; }
        }

        [Changeable]
        [JsonProperty("saturated-fat_serving")]
        public float? SaturatedFatServing
        {
            get => _saturatedFatServing;
            set { _saturatedFatServing = value; }
        }

        [Changeable]
        [JsonProperty("saturated-fat_100g")]
        public float? SaturatedFat100g
        {
            get => _saturatedFat100G;
            set { _saturatedFat100G = value; }
        }

        [Changeable]
        [JsonProperty("saturated-fat_unit")]
        public string SaturatedFatUnit
        {
            get => _saturatedFatUnit;
            set { _saturatedFatUnit = value; }
        }

        [Changeable]
        [JsonProperty("sugars")]
        public float? Sugars
        {
            get => _sugars;
            set { _sugars = value; }
        }

        [Changeable]
        [JsonProperty("sugars_serving")]
        public float? SugarsServing
        {
            get => _sugarsServing;
            set { _sugarsServing = value; }
        }

        [Changeable]
        [JsonProperty("sugars_100g")]
        public float? Sugars100g
        {
            get => _sugars100G;
            set { _sugars100G = value; }
        }

        [Changeable]
        [JsonProperty("sugars_unit")]
        public string SugarsUnit
        {
            get => _sugarsUnit;
            set { _sugarsUnit = value; }
        }

        [Changeable]
        [JsonProperty("carbohydrates")]
        public float? Carbohydrates
        {
            get => _carbohydrates;
            set { _carbohydrates = value; }
        }

        [Changeable]
        [JsonProperty("carbohydrates_serving")]
        public float? CarbohydratesServing
        {
            get => _carbohydratesServing;
            set { _carbohydratesServing = value; }
        }

        [Changeable]
        [JsonProperty("carbohydrates_100g")]
        public float? Carbohydrates100g
        {
            get => _carbohydrates100G;
            set { _carbohydrates100G = value; }
        }

        [Changeable]
        [JsonProperty("carbohydrates_unit")]
        public string CarbohydratesUnit
        {
            get => _carbohydratesUnit;
            set { _carbohydratesUnit = value; }
        }

        [Changeable]
        [JsonProperty("energy-kcal_100g")]
        public float? EnergyKcal100g
        {
            get => _energyKcal100G;
            set { _energyKcal100G = value; }
        }

        [Changeable]
        [JsonProperty("energy-kcal_serving")]
        public float? EnergyKcalServing
        {
            get => _energyKcalServing;
            set { _energyKcalServing = value; }
        }

        [Changeable]
        [JsonProperty("energy-kcal_unit")]
        public string EnergyKcalUnit
        {
            get => _energyKcalUnit;
            set { _energyKcalUnit = value; }
        }

        [Changeable]
        [JsonProperty("proteins")]
        public float? Proteins
        {
            get => _proteins;
            set { _proteins = value; }
        }

        [Changeable]
        [JsonProperty("proteins_serving")]
        public float? ProteinsServing
        {
            get => _proteinsServing;
            set { _proteinsServing = value; }
        }

        [Changeable]
        [JsonProperty("proteins_100g")]
        public float? Proteins100g
        {
            get => _proteins100G;
            set { _proteins100G = value; }
        }

        [Changeable]
        [JsonProperty("proteins_unit")]
        public string ProteinsUnit
        {
            get => _proteinsUnit;
            set { _proteinsUnit = value; }
        }

        // ... and other nutrients ...

        // To capture any unexpected properties
        /// <inheritdoc />
        public IOtherValues<object> Other => _other;

        /// <inheritdoc />
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
        }
    }
}
