// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ApplicationInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApplicationInsights
{
    public partial class WorkbookTemplateData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsDefined(Author))
            {
                writer.WritePropertyName("author"u8);
                writer.WriteStringValue(Author);
            }
            if (Optional.IsDefined(TemplateData))
            {
                writer.WritePropertyName("templateData"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(TemplateData);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(TemplateData.ToString()).RootElement);
#endif
            }
            if (Optional.IsCollectionDefined(Galleries))
            {
                writer.WritePropertyName("galleries"u8);
                writer.WriteStartArray();
                foreach (var item in Galleries)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LocalizedGalleries))
            {
                writer.WritePropertyName("localized"u8);
                writer.WriteStartObject();
                foreach (var item in LocalizedGalleries)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item0 in item.Value)
                    {
                        writer.WriteObjectValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static WorkbookTemplateData DeserializeWorkbookTemplateData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<int> priority = default;
            Optional<string> author = default;
            Optional<BinaryData> templateData = default;
            Optional<IList<WorkbookTemplateGallery>> galleries = default;
            Optional<IDictionary<string, IList<WorkbookTemplateLocalizedGallery>>> localized = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("priority"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            priority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("author"u8))
                        {
                            author = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("templateData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            templateData = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("galleries"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WorkbookTemplateGallery> array = new List<WorkbookTemplateGallery>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(WorkbookTemplateGallery.DeserializeWorkbookTemplateGallery(item));
                            }
                            galleries = array;
                            continue;
                        }
                        if (property0.NameEquals("localized"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, IList<WorkbookTemplateLocalizedGallery>> dictionary = new Dictionary<string, IList<WorkbookTemplateLocalizedGallery>>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    List<WorkbookTemplateLocalizedGallery> array = new List<WorkbookTemplateLocalizedGallery>();
                                    foreach (var item in property1.Value.EnumerateArray())
                                    {
                                        array.Add(WorkbookTemplateLocalizedGallery.DeserializeWorkbookTemplateLocalizedGallery(item));
                                    }
                                    dictionary.Add(property1.Name, array);
                                }
                            }
                            localized = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new WorkbookTemplateData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(priority), author.Value, templateData.Value, Optional.ToList(galleries), Optional.ToDictionary(localized));
        }
    }
}
