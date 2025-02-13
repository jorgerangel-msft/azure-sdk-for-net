// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Backend address pool settings of an application gateway. </summary>
    public partial class ApplicationGatewayBackendSettings : NetworkResourceData
    {
        /// <summary> Initializes a new instance of ApplicationGatewayBackendSettings. </summary>
        public ApplicationGatewayBackendSettings()
        {
            TrustedRootCertificates = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of ApplicationGatewayBackendSettings. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="port"> The destination port on the backend. </param>
        /// <param name="protocol"> The protocol used to communicate with the backend. </param>
        /// <param name="timeoutInSeconds"> Connection timeout in seconds. Application Gateway will fail the request if response is not received within ConnectionTimeout. Acceptable values are from 1 second to 86400 seconds. </param>
        /// <param name="probe"> Probe resource of an application gateway. </param>
        /// <param name="trustedRootCertificates"> Array of references to application gateway trusted root certificates. </param>
        /// <param name="hostName"> Server name indication to be sent to the backend servers for Tls protocol. </param>
        /// <param name="pickHostNameFromBackendAddress"> Whether to pick server name indication from the host name of the backend server for Tls protocol. Default value is false. </param>
        /// <param name="provisioningState"> The provisioning state of the backend HTTP settings resource. </param>
        internal ApplicationGatewayBackendSettings(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, int? port, ApplicationGatewayProtocol? protocol, int? timeoutInSeconds, WritableSubResource probe, IList<WritableSubResource> trustedRootCertificates, string hostName, bool? pickHostNameFromBackendAddress, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            ETag = etag;
            Port = port;
            Protocol = protocol;
            TimeoutInSeconds = timeoutInSeconds;
            Probe = probe;
            TrustedRootCertificates = trustedRootCertificates;
            HostName = hostName;
            PickHostNameFromBackendAddress = pickHostNameFromBackendAddress;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The destination port on the backend. </summary>
        public int? Port { get; set; }
        /// <summary> The protocol used to communicate with the backend. </summary>
        public ApplicationGatewayProtocol? Protocol { get; set; }
        /// <summary> Connection timeout in seconds. Application Gateway will fail the request if response is not received within ConnectionTimeout. Acceptable values are from 1 second to 86400 seconds. </summary>
        public int? TimeoutInSeconds { get; set; }
        /// <summary> Probe resource of an application gateway. </summary>
        internal WritableSubResource Probe { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier ProbeId
        {
            get => Probe is null ? default : Probe.Id;
            set
            {
                if (Probe is null)
                    Probe = new WritableSubResource();
                Probe.Id = value;
            }
        }

        /// <summary> Array of references to application gateway trusted root certificates. </summary>
        public IList<WritableSubResource> TrustedRootCertificates { get; }
        /// <summary> Server name indication to be sent to the backend servers for Tls protocol. </summary>
        public string HostName { get; set; }
        /// <summary> Whether to pick server name indication from the host name of the backend server for Tls protocol. Default value is false. </summary>
        public bool? PickHostNameFromBackendAddress { get; set; }
        /// <summary> The provisioning state of the backend HTTP settings resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
