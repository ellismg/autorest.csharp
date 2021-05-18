// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager.Core;

namespace ResourceIdentifierChooser
{
    /// <summary> Model2 inherits from a TrackedResource. </summary>
    public partial class Model2 : TrackedResource<ResourceGroupResourceIdentifier>
    {
        /// <summary> Initializes a new instance of Model2. </summary>
        /// <param name="location"> The location. </param>
        public Model2(LocationData location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of Model2. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="location"> The location. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="mango"> Fruit. </param>
        internal Model2(ResourceGroupResourceIdentifier id, string name, ResourceType type, LocationData location, IDictionary<string, string> tags, string mango) : base(id, name, type, location, tags)
        {
            Mango = mango;
        }

        /// <summary> Fruit. </summary>
        public string Mango { get; set; }
    }
}