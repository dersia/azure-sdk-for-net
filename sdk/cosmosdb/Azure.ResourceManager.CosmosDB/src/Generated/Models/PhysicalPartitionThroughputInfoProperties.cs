// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The properties of an Azure Cosmos DB PhysicalPartitionThroughputInfoProperties object. </summary>
    internal partial class PhysicalPartitionThroughputInfoProperties
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PhysicalPartitionThroughputInfoProperties"/>. </summary>
        public PhysicalPartitionThroughputInfoProperties()
        {
            PhysicalPartitionThroughputInfo = new ChangeTrackingList<PhysicalPartitionThroughputInfoResource>();
        }

        /// <summary> Initializes a new instance of <see cref="PhysicalPartitionThroughputInfoProperties"/>. </summary>
        /// <param name="physicalPartitionThroughputInfo"> Array of physical partition throughput info objects. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PhysicalPartitionThroughputInfoProperties(IList<PhysicalPartitionThroughputInfoResource> physicalPartitionThroughputInfo, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PhysicalPartitionThroughputInfo = physicalPartitionThroughputInfo;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Array of physical partition throughput info objects. </summary>
        public IList<PhysicalPartitionThroughputInfoResource> PhysicalPartitionThroughputInfo { get; }
    }
}
