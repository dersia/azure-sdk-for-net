// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EdgeZones.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EdgeZones
{
    /// <summary>
    /// A class representing the ExtendedZone data model.
    /// Resource that represents an Azure Extended Zone available to a subscription for registering and unregistering.
    /// </summary>
    public partial class ExtendedZoneData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ExtendedZoneData"/>. </summary>
        internal ExtendedZoneData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExtendedZoneData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Status of the last operation performed by the subscription on the Edge Zone resource. </param>
        /// <param name="registrationState"> Indicates the Azure Extended Zone registration’s approval status. </param>
        /// <param name="displayName"> Display name of the Azure Extended Zone. </param>
        /// <param name="regionalDisplayName"> Regional display name of the Azure Extended Zone. </param>
        /// <param name="regionType"> Type of region for the Azure Extended Zone. </param>
        /// <param name="regionCategory"> Category of region for the Azure Extended Zone. </param>
        /// <param name="geography"> Geography of the Azure Extended Zone. </param>
        /// <param name="geographyGroup"> The Geography Group of the Azure Extended Zone. </param>
        /// <param name="longitude"> The Longitude of the Azure Extended Zone. </param>
        /// <param name="latitude"> The Latitude of the Azure Extended Zone. </param>
        /// <param name="homeLocation"> The Home Location of the Azure Extended Zone. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExtendedZoneData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, EdgeZonesProvisioningState? provisioningState, EdgeZonesRegistrationState? registrationState, string displayName, string regionalDisplayName, string regionType, string regionCategory, string geography, string geographyGroup, string longitude, string latitude, string homeLocation, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            RegistrationState = registrationState;
            DisplayName = displayName;
            RegionalDisplayName = regionalDisplayName;
            RegionType = regionType;
            RegionCategory = regionCategory;
            Geography = geography;
            GeographyGroup = geographyGroup;
            Longitude = longitude;
            Latitude = latitude;
            HomeLocation = homeLocation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Status of the last operation performed by the subscription on the Edge Zone resource. </summary>
        public EdgeZonesProvisioningState? ProvisioningState { get; }
        /// <summary> Indicates the Azure Extended Zone registration’s approval status. </summary>
        public EdgeZonesRegistrationState? RegistrationState { get; }
        /// <summary> Display name of the Azure Extended Zone. </summary>
        public string DisplayName { get; }
        /// <summary> Regional display name of the Azure Extended Zone. </summary>
        public string RegionalDisplayName { get; }
        /// <summary> Type of region for the Azure Extended Zone. </summary>
        public string RegionType { get; }
        /// <summary> Category of region for the Azure Extended Zone. </summary>
        public string RegionCategory { get; }
        /// <summary> Geography of the Azure Extended Zone. </summary>
        public string Geography { get; }
        /// <summary> The Geography Group of the Azure Extended Zone. </summary>
        public string GeographyGroup { get; }
        /// <summary> The Longitude of the Azure Extended Zone. </summary>
        public string Longitude { get; }
        /// <summary> The Latitude of the Azure Extended Zone. </summary>
        public string Latitude { get; }
        /// <summary> The Home Location of the Azure Extended Zone. </summary>
        public string HomeLocation { get; }
    }
}
