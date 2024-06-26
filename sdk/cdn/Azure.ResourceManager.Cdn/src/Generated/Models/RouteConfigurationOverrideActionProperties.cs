// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for the route configuration override action. </summary>
    public partial class RouteConfigurationOverrideActionProperties
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

        /// <summary> Initializes a new instance of <see cref="RouteConfigurationOverrideActionProperties"/>. </summary>
        /// <param name="actionType"></param>
        public RouteConfigurationOverrideActionProperties(RouteConfigurationOverrideActionType actionType)
        {
            ActionType = actionType;
        }

        /// <summary> Initializes a new instance of <see cref="RouteConfigurationOverrideActionProperties"/>. </summary>
        /// <param name="actionType"></param>
        /// <param name="originGroupOverride"> A reference to the origin group override configuration. Leave empty to use the default origin group on route. </param>
        /// <param name="cacheConfiguration"> The caching configuration associated with this rule. To disable caching, do not provide a cacheConfiguration object. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RouteConfigurationOverrideActionProperties(RouteConfigurationOverrideActionType actionType, OriginGroupOverride originGroupOverride, CacheConfiguration cacheConfiguration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ActionType = actionType;
            OriginGroupOverride = originGroupOverride;
            CacheConfiguration = cacheConfiguration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RouteConfigurationOverrideActionProperties"/> for deserialization. </summary>
        internal RouteConfigurationOverrideActionProperties()
        {
        }

        /// <summary> Gets or sets the action type. </summary>
        public RouteConfigurationOverrideActionType ActionType { get; set; }
        /// <summary> A reference to the origin group override configuration. Leave empty to use the default origin group on route. </summary>
        public OriginGroupOverride OriginGroupOverride { get; set; }
        /// <summary> The caching configuration associated with this rule. To disable caching, do not provide a cacheConfiguration object. </summary>
        public CacheConfiguration CacheConfiguration { get; set; }
    }
}
