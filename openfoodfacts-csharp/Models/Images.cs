using System;
using System.Runtime.Serialization;
using OpenFoodFactsCSharp.Interfaces;

namespace OpenFoodFactsCSharp.Models
{
    /// <summary>
    /// A class for an image dictionary.
    /// </summary>
    [Serializable]
    public class Images : IImages
    {
        private readonly IOtherValues<object> _other;

        /// <summary>
        /// Constructor for deserialization.
        /// </summary>
        /// <param name="info">The deserialization info</param>
        /// <param name="context">A streaming context</param>
        protected Images(SerializationInfo info, StreamingContext context) => _other = info.GetValue(nameof(_other), typeof(OtherValues<object>)) as OtherValues<object>;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Images() => _other = new OtherValues<object>();

        /// <summary>
        /// Gets a dictionary for other values.
        /// </summary>
        /// <value>A dictionary for other values</value>
        public IOtherValues<object> Other => _other;

        /// <inheritdoc />
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context) => info.AddValue(nameof(_other), _other);
    }
}
