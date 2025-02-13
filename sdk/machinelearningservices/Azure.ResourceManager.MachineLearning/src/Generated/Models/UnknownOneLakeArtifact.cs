// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownOneLakeArtifact. </summary>
    internal partial class UnknownOneLakeArtifact : OneLakeArtifact
    {
        /// <summary> Initializes a new instance of UnknownOneLakeArtifact. </summary>
        /// <param name="artifactName"> [Required] OneLake artifact name. </param>
        /// <param name="artifactType"> [Required] OneLake artifact type. </param>
        internal UnknownOneLakeArtifact(string artifactName, OneLakeArtifactType artifactType) : base(artifactName, artifactType)
        {
            ArtifactType = artifactType;
        }
    }
}
