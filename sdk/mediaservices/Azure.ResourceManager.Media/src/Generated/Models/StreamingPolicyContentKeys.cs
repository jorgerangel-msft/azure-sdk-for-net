// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Class to specify properties of all content keys in Streaming Policy. </summary>
    public partial class StreamingPolicyContentKeys
    {
        /// <summary> Initializes a new instance of StreamingPolicyContentKeys. </summary>
        public StreamingPolicyContentKeys()
        {
            KeyToTrackMappings = new ChangeTrackingList<StreamingPolicyContentKey>();
        }

        /// <summary> Initializes a new instance of StreamingPolicyContentKeys. </summary>
        /// <param name="defaultKey"> Default content key for an encryption scheme. </param>
        /// <param name="keyToTrackMappings"> Representing tracks needs separate content key. </param>
        internal StreamingPolicyContentKeys(EncryptionSchemeDefaultKey defaultKey, IList<StreamingPolicyContentKey> keyToTrackMappings)
        {
            DefaultKey = defaultKey;
            KeyToTrackMappings = keyToTrackMappings;
        }

        /// <summary> Default content key for an encryption scheme. </summary>
        public EncryptionSchemeDefaultKey DefaultKey { get; set; }
        /// <summary> Representing tracks needs separate content key. </summary>
        public IList<StreamingPolicyContentKey> KeyToTrackMappings { get; }
    }
}
