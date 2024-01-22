// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    [PersistableModelProxy(typeof(UnknownDataTransferDataSourceSink))]
    public partial class DataTransferDataSourceSink : IUtf8JsonSerializable, IJsonModel<DataTransferDataSourceSink>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataTransferDataSourceSink>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataTransferDataSourceSink>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataTransferDataSourceSink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataTransferDataSourceSink)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("component"u8);
            writer.WriteStringValue(Component.ToString());
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        DataTransferDataSourceSink IJsonModel<DataTransferDataSourceSink>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataTransferDataSourceSink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataTransferDataSourceSink)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataTransferDataSourceSink(document.RootElement, options);
        }

        internal static DataTransferDataSourceSink DeserializeDataTransferDataSourceSink(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("component", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureBlobStorage": return AzureBlobDataTransferDataSourceSink.DeserializeAzureBlobDataTransferDataSourceSink(element);
                    case "CosmosDBCassandra": return CosmosCassandraDataTransferDataSourceSink.DeserializeCosmosCassandraDataTransferDataSourceSink(element);
                    case "CosmosDBMongo": return CosmosMongoDataTransferDataSourceSink.DeserializeCosmosMongoDataTransferDataSourceSink(element);
                    case "CosmosDBSql": return CosmosSqlDataTransferDataSourceSink.DeserializeCosmosSqlDataTransferDataSourceSink(element);
                }
            }
            return UnknownDataTransferDataSourceSink.DeserializeUnknownDataTransferDataSourceSink(element);
        }

        BinaryData IPersistableModel<DataTransferDataSourceSink>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataTransferDataSourceSink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataTransferDataSourceSink)} does not support '{options.Format}' format.");
            }
        }

        DataTransferDataSourceSink IPersistableModel<DataTransferDataSourceSink>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataTransferDataSourceSink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataTransferDataSourceSink(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataTransferDataSourceSink)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataTransferDataSourceSink>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
