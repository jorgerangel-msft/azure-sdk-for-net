// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class ScoringRuleOptions
    {
        internal static ScoringRuleOptions DeserializeScoringRuleOptions(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> batchSize = default;
            Optional<IList<ScoringRuleParameterSelector>> scoringParameters = default;
            Optional<bool> allowScoringBatchOfWorkers = default;
            Optional<bool> descendingOrder = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("batchSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    batchSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("scoringParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScoringRuleParameterSelector> array = new List<ScoringRuleParameterSelector>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ScoringRuleParameterSelector(item.GetString()));
                    }
                    scoringParameters = array;
                    continue;
                }
                if (property.NameEquals("allowScoringBatchOfWorkers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowScoringBatchOfWorkers = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("descendingOrder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    descendingOrder = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ScoringRuleOptions(Optional.ToNullable(batchSize), Optional.ToList(scoringParameters), Optional.ToNullable(allowScoringBatchOfWorkers), Optional.ToNullable(descendingOrder));
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ScoringRuleOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeScoringRuleOptions(document.RootElement);
        }
    }
}
