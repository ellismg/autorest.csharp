// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class AutocompleteResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Coverage != null)
            {
                writer.WritePropertyName("@search.coverage");
                writer.WriteNumberValue(Coverage.Value);
            }
            if (Results != null)
            {
                writer.WritePropertyName("value");
                writer.WriteStartArray();
                foreach (var item in Results)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
        internal static AutocompleteResult DeserializeAutocompleteResult(JsonElement element)
        {
            AutocompleteResult result = new AutocompleteResult();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@search.coverage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Coverage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Results = new List<AutocompleteItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Results.Add(AutocompleteItem.DeserializeAutocompleteItem(item));
                    }
                    continue;
                }
            }
            return result;
        }
    }
}