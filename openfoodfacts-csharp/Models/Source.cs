
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
    /// The definition of the source.
    /// </summary>
    [Changeable]
    public class Source : ISource
    {
        private string[] _fields;
        private string _id;
        private string[] _images;
        private long? _importT;
        private string _manufacturer;
        private string _name;
        private string _url;

        /// <summary>
        /// Constructor for deserialization.
        /// </summary>
        /// <param name="info">The serialization info</param>
        /// <param name="context">A streaming context</param>
        protected Source([NotNull]SerializationInfo info, StreamingContext context)
        {
            _fields = info.GetValue(nameof(_fields), typeof(string[])) as string[];
            _id = info.GetString(nameof(_id));
            _images = info.GetValue(nameof(_images), typeof(string[])) as string[];
            _importT = info.GetValue(nameof(_importT), typeof(long?)) as long?;
            _manufacturer = info.GetString(nameof(_manufacturer));
            _name = info.GetString(nameof(_name));
            _url = info.GetString(nameof(_url));
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Source()
        {
            Fields = Array.Empty<string>();
            Id = null;
            Images = Array.Empty<string>();
            ImportT = null;
            Manufacturer = null;
            Name = null;
            Url = null;
        }

        /// <inheritdoc />
        public event ChangeEventHandler<string[]> FieldsChanged;

        /// <summary>
        /// Gets or sets an array of fields.
        /// </summary>
        /// <value>An array of fields</value>
        [Changeable]
        public string[] Fields
        {
            get => _fields;
            set
            {
                if (value != _fields)
                {
                    ChangeEventArgs<string[]> changeEventArgs = new ChangeEventArgs<string[]>(_fields, value);
                    _fields = value;

                    FieldsChanged?.Invoke(this, changeEventArgs);
                }
            }
        }

        /// <inheritdoc />
        public event ChangeEventHandler<string> IdChanged;

        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        /// <value>The ID</value>
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
        public event ChangeEventHandler<string[]> ImagesChanged;

        /// <summary>
        /// Gets or sets an array of images (as <see cref="string"/>)
        /// </summary>
        /// <value>An array of images</value>
        [Changeable]
        public string[] Images
        {
            get => _images;
            set
            {
                if (value != _images)
                {
                    ChangeEventArgs<string[]> changeEventArgs = new ChangeEventArgs<string[]>(_images, value);
                    _images = value;
                    ImagesChanged?.Invoke(this, changeEventArgs);
                }
            }
        }

        /// <inheritdoc />
        public event ChangeEventHandler<long?> ImportTChanged;

        /// <summary>
        /// Gets or sets an import type.
        /// </summary>
        /// <value>An import type</value>
        /// <remarks>Nullable <see cref="long"/></remarks>
        [Changeable]
        [JsonProperty("import_t")]
        public long? ImportT
        {
            get => _importT;
            set
            {
                if (value != _importT)
                {
                    ChangeEventArgs<long?> changeEventArgs = new ChangeEventArgs<long?>(_importT, value);
                    _importT = value;
                    ImportTChanged?.Invoke(this, changeEventArgs);
                }
            }
        }

        /// <inheritdoc />
        public event ChangeEventHandler<string> ManufacturerChanged;

        /// <summary>
        /// Gets or sets the manufacturer.
        /// </summary>
        /// <value>The manufacturer</value>
        [Changeable]
        public string Manufacturer
        {
            get => _manufacturer;
            set
            {
                if (value != _manufacturer)
                {
                    ChangeEventArgs<string> changeEventArgs = new ChangeEventArgs<string>(_manufacturer, value);
                    _manufacturer = value;
                    ManufacturerChanged?.Invoke(this, changeEventArgs);
                }
            }
        }

        /// <inheritdoc />
        public event ChangeEventHandler<string> NameChanged;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name</value>
        [Changeable]
        public string Name
        {
            get => _name;
            set
            {
                if (value != _name)
                {
                    ChangeEventArgs<string> changeEventArgs = new ChangeEventArgs<string>(_name, value);
                    _name = value;
                    NameChanged?.Invoke(this, changeEventArgs);
                }
            }
        }

        /// <inheritdoc />
        public event ChangeEventHandler<string> UrlChanged;

        /// <summary>
        /// Gets or sets the Url.
        /// </summary>
        /// <value>The Url</value>
        [Changeable]
        public string Url
        {
            get => _url;
            set
            {
                if (value != _url)
                {
                    ChangeEventArgs<string> changeEventArgs = new ChangeEventArgs<string>(_url, value);
                    _url = value;
                    UrlChanged?.Invoke(this, changeEventArgs);
                }
            }
        }

        /// <inheritdoc />
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(nameof(_fields), _fields);
            info.AddValue(nameof(_id), _id);
            info.AddValue(nameof(_images), _images);
            info.AddValue(nameof(_importT), _importT);
            info.AddValue(nameof(_manufacturer), _manufacturer);
            info.AddValue(nameof(_name), _name);
            info.AddValue(nameof(_url), _url);
        }
    }
}
