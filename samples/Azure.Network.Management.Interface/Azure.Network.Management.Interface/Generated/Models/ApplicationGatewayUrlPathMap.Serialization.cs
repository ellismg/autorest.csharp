// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class ApplicationGatewayUrlPathMap : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Etag != null)
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (DefaultBackendAddressPool != null)
            {
                writer.WritePropertyName("defaultBackendAddressPool");
                writer.WriteObjectValue(DefaultBackendAddressPool);
            }
            if (DefaultBackendHttpSettings != null)
            {
                writer.WritePropertyName("defaultBackendHttpSettings");
                writer.WriteObjectValue(DefaultBackendHttpSettings);
            }
            if (DefaultRewriteRuleSet != null)
            {
                writer.WritePropertyName("defaultRewriteRuleSet");
                writer.WriteObjectValue(DefaultRewriteRuleSet);
            }
            if (DefaultRedirectConfiguration != null)
            {
                writer.WritePropertyName("defaultRedirectConfiguration");
                writer.WriteObjectValue(DefaultRedirectConfiguration);
            }
            if (PathRules != null)
            {
                writer.WritePropertyName("pathRules");
                writer.WriteStartArray();
                foreach (var item in PathRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
        internal static ApplicationGatewayUrlPathMap DeserializeApplicationGatewayUrlPathMap(JsonElement element)
        {
            ApplicationGatewayUrlPathMap result = new ApplicationGatewayUrlPathMap();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("defaultBackendAddressPool"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.DefaultBackendAddressPool = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("defaultBackendHttpSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.DefaultBackendHttpSettings = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("defaultRewriteRuleSet"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.DefaultRewriteRuleSet = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("defaultRedirectConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.DefaultRedirectConfiguration = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("pathRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.PathRules = new List<ApplicationGatewayPathRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                result.PathRules.Add(ApplicationGatewayPathRule.DeserializeApplicationGatewayPathRule(item));
                            }
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.ProvisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return result;
        }
    }
}