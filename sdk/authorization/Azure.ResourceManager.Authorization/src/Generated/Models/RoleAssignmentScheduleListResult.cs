// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Authorization;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Role assignment schedule list operation result. </summary>
    internal partial class RoleAssignmentScheduleListResult
    {
        /// <summary> Initializes a new instance of RoleAssignmentScheduleListResult. </summary>
        internal RoleAssignmentScheduleListResult()
        {
            Value = new ChangeTrackingList<RoleAssignmentScheduleData>();
        }

        /// <summary> Initializes a new instance of RoleAssignmentScheduleListResult. </summary>
        /// <param name="value"> Role assignment schedule list. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal RoleAssignmentScheduleListResult(IReadOnlyList<RoleAssignmentScheduleData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Role assignment schedule list. </summary>
        public IReadOnlyList<RoleAssignmentScheduleData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
