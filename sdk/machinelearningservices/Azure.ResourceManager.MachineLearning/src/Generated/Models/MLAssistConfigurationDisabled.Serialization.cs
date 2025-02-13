// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MLAssistConfigurationDisabled : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("mlAssist"u8);
            writer.WriteStringValue(MlAssist.ToString());
            writer.WriteEndObject();
        }

        internal static MLAssistConfigurationDisabled DeserializeMLAssistConfigurationDisabled(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MLAssistConfigurationType mlAssist = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mlAssist"u8))
                {
                    mlAssist = new MLAssistConfigurationType(property.Value.GetString());
                    continue;
                }
            }
            return new MLAssistConfigurationDisabled(mlAssist);
        }
    }
}
