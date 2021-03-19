// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace ModelWithConverterUsage.Models
{
    /// <summary> The ModelStruct. </summary>
    public readonly partial struct ModelStruct
    {
        /// <summary> Initializes a new instance of ModelStruct. </summary>
        /// <param name="modelProperty"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelProperty"/> is null. </exception>
        public ModelStruct(string modelProperty)
        {
            if (modelProperty == null)
            {
                throw new ArgumentNullException(nameof(modelProperty));
            }

            ModelProperty = modelProperty;
        }

        /// <summary> . </summary>
        public string ModelProperty { get; }
    }
}