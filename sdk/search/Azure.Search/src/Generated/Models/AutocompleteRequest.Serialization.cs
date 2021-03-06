// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Models
{
    public partial class AutocompleteRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (SearchText != null)
            {
                writer.WritePropertyName("search");
                writer.WriteStringValue(SearchText);
            }
            if (AutocompleteMode != null)
            {
                writer.WritePropertyName("autocompleteMode");
                writer.WriteStringValue(AutocompleteMode.Value.ToSerialString());
            }
            if (Filter != null)
            {
                writer.WritePropertyName("filter");
                writer.WriteStringValue(Filter);
            }
            if (UseFuzzyMatching != null)
            {
                writer.WritePropertyName("fuzzy");
                writer.WriteBooleanValue(UseFuzzyMatching.Value);
            }
            if (HighlightPostTag != null)
            {
                writer.WritePropertyName("highlightPostTag");
                writer.WriteStringValue(HighlightPostTag);
            }
            if (HighlightPreTag != null)
            {
                writer.WritePropertyName("highlightPreTag");
                writer.WriteStringValue(HighlightPreTag);
            }
            if (MinimumCoverage != null)
            {
                writer.WritePropertyName("minimumCoverage");
                writer.WriteNumberValue(MinimumCoverage.Value);
            }
            if (SearchFields != null)
            {
                writer.WritePropertyName("searchFields");
                writer.WriteStringValue(SearchFields);
            }
            if (SuggesterName != null)
            {
                writer.WritePropertyName("suggesterName");
                writer.WriteStringValue(SuggesterName);
            }
            if (Top != null)
            {
                writer.WritePropertyName("top");
                writer.WriteNumberValue(Top.Value);
            }
            writer.WriteEndObject();
        }
        internal static AutocompleteRequest DeserializeAutocompleteRequest(JsonElement element)
        {
            AutocompleteRequest result = new AutocompleteRequest();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("search"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.SearchText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autocompleteMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.AutocompleteMode = property.Value.GetString().ToAutocompleteMode();
                    continue;
                }
                if (property.NameEquals("filter"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Filter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fuzzy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.UseFuzzyMatching = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("highlightPostTag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.HighlightPostTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("highlightPreTag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.HighlightPreTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minimumCoverage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.MinimumCoverage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("searchFields"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.SearchFields = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("suggesterName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.SuggesterName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("top"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Top = property.Value.GetInt32();
                    continue;
                }
            }
            return result;
        }
    }
}
