// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Blueprint.Models
{
    /// <summary> Represents an Azure resource group in a blueprint definition. </summary>
    public partial class ResourceGroupDefinition
    {
        /// <summary> Initializes a new instance of ResourceGroupDefinition. </summary>
        public ResourceGroupDefinition()
        {
            DependsOn = new ChangeTrackingList<string>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of ResourceGroupDefinition. </summary>
        /// <param name="name"> Name of this resourceGroup. Leave empty if the resource group name will be specified during the blueprint assignment. </param>
        /// <param name="location"> Location of this resourceGroup. Leave empty if the resource group location will be specified during the blueprint assignment. </param>
        /// <param name="dependsOn"> Artifacts which need to be deployed before this resource group. </param>
        /// <param name="tags"> Tags to be assigned to this resource group. </param>
        /// <param name="displayName"> DisplayName of this parameter/resourceGroup. </param>
        /// <param name="description"> Description of this parameter/resourceGroup. </param>
        /// <param name="strongType"> StrongType for UI to render rich experience during blueprint assignment. Supported strong types are resourceType, principalId and location. </param>
        internal ResourceGroupDefinition(string name, AzureLocation? location, IList<string> dependsOn, IDictionary<string, string> tags, string displayName, string description, string strongType)
        {
            Name = name;
            Location = location;
            DependsOn = dependsOn;
            Tags = tags;
            DisplayName = displayName;
            Description = description;
            StrongType = strongType;
        }

        /// <summary> Name of this resourceGroup. Leave empty if the resource group name will be specified during the blueprint assignment. </summary>
        public string Name { get; set; }
        /// <summary> Location of this resourceGroup. Leave empty if the resource group location will be specified during the blueprint assignment. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> Artifacts which need to be deployed before this resource group. </summary>
        public IList<string> DependsOn { get; }
        /// <summary> Tags to be assigned to this resource group. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> DisplayName of this parameter/resourceGroup. </summary>
        public string DisplayName { get; set; }
        /// <summary> Description of this parameter/resourceGroup. </summary>
        public string Description { get; set; }
        /// <summary> StrongType for UI to render rich experience during blueprint assignment. Supported strong types are resourceType, principalId and location. </summary>
        public string StrongType { get; set; }
    }
}
