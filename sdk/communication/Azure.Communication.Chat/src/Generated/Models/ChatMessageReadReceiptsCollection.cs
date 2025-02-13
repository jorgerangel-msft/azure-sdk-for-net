// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Communication.Chat
{
    /// <summary> A paged collection of chat message read receipts. </summary>
    internal partial class ChatMessageReadReceiptsCollection
    {
        /// <summary> Initializes a new instance of ChatMessageReadReceiptsCollection. </summary>
        /// <param name="value"> Collection of chat message read receipts. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ChatMessageReadReceiptsCollection(IEnumerable<ChatMessageReadReceiptInternal> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of ChatMessageReadReceiptsCollection. </summary>
        /// <param name="value"> Collection of chat message read receipts. </param>
        /// <param name="nextLink"> If there are more chat message read receipts that can be retrieved, the next link will be populated. </param>
        internal ChatMessageReadReceiptsCollection(IReadOnlyList<ChatMessageReadReceiptInternal> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of chat message read receipts. </summary>
        public IReadOnlyList<ChatMessageReadReceiptInternal> Value { get; }
        /// <summary> If there are more chat message read receipts that can be retrieved, the next link will be populated. </summary>
        public string NextLink { get; }
    }
}
