// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    public partial class NetworkFabricRoutePolicyResource : IJsonModel<NetworkFabricRoutePolicyData>
    {
        void IJsonModel<NetworkFabricRoutePolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<NetworkFabricRoutePolicyData>)Data).Write(writer, options);

        NetworkFabricRoutePolicyData IJsonModel<NetworkFabricRoutePolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<NetworkFabricRoutePolicyData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<NetworkFabricRoutePolicyData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        NetworkFabricRoutePolicyData IPersistableModel<NetworkFabricRoutePolicyData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<NetworkFabricRoutePolicyData>(data, options);

        string IPersistableModel<NetworkFabricRoutePolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<NetworkFabricRoutePolicyData>)Data).GetFormatFromOptions(options);
    }
}
