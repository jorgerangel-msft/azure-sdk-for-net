// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ServiceNetworking;

namespace Azure.ResourceManager.ServiceNetworking.Models
{
    /// <summary> The response of a Frontend list operation. </summary>
    internal partial class FrontendListResult
    {
        /// <summary> Initializes a new instance of FrontendListResult. </summary>
        /// <param name="value"> The Frontend items on this page. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal FrontendListResult(IEnumerable<FrontendData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of FrontendListResult. </summary>
        /// <param name="value"> The Frontend items on this page. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        internal FrontendListResult(IReadOnlyList<FrontendData> value, Uri nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The Frontend items on this page. </summary>
        public IReadOnlyList<FrontendData> Value { get; }
        /// <summary> The link to the next page of items. </summary>
        public Uri NextLink { get; }
    }
}
