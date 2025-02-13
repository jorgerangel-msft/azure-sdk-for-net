// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> Open authentication policy claim. </summary>
    public partial class OpenAuthenticationPolicyClaim
    {
        /// <summary> Initializes a new instance of OpenAuthenticationPolicyClaim. </summary>
        public OpenAuthenticationPolicyClaim()
        {
        }

        /// <summary> Initializes a new instance of OpenAuthenticationPolicyClaim. </summary>
        /// <param name="name"> The name of the claim. </param>
        /// <param name="value"> The value of the claim. </param>
        internal OpenAuthenticationPolicyClaim(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary> The name of the claim. </summary>
        public string Name { get; set; }
        /// <summary> The value of the claim. </summary>
        public string Value { get; set; }
    }
}
