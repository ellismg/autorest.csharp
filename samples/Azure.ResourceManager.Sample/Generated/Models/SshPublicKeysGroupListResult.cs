// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Sample
{
    /// <summary> The list SSH public keys operation response. </summary>
    internal partial class SshPublicKeysGroupListResult
    {
        /// <summary> Initializes a new instance of SshPublicKeysGroupListResult. </summary>
        /// <param name="value"> The list of SSH public keys. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal SshPublicKeysGroupListResult(IEnumerable<SshPublicKeyData> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of SshPublicKeysGroupListResult. </summary>
        /// <param name="value"> The list of SSH public keys. </param>
        /// <param name="nextLink"> The URI to fetch the next page of SSH public keys. Call ListNext() with this URI to fetch the next page of SSH public keys. </param>
        internal SshPublicKeysGroupListResult(IReadOnlyList<SshPublicKeyData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of SSH public keys. </summary>
        public IReadOnlyList<SshPublicKeyData> Value { get; }
        /// <summary> The URI to fetch the next page of SSH public keys. Call ListNext() with this URI to fetch the next page of SSH public keys. </summary>
        public string NextLink { get; }
    }
}