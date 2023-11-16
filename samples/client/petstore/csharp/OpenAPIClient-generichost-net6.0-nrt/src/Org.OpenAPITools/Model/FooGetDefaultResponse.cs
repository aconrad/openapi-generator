// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// FooGetDefaultResponse
    /// </summary>
    public partial class FooGetDefaultResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FooGetDefaultResponse" /> class.
        /// </summary>
        /// <param name="varString">varString</param>
        [JsonConstructor]
        public FooGetDefaultResponse(Option<Foo?> varString = default)
        {
            VarStringOption = varString;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of VarString
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Foo?> VarStringOption { get; private set; }

        /// <summary>
        /// Gets or Sets VarString
        /// </summary>
        [JsonPropertyName("string")]
        public Foo? VarString { get { return this. VarStringOption; } set { this.VarStringOption = new(value); } }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FooGetDefaultResponse {\n");
            sb.Append("  VarString: ").Append(VarString).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="FooGetDefaultResponse" />
    /// </summary>
    public class FooGetDefaultResponseJsonConverter : JsonConverter<FooGetDefaultResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="FooGetDefaultResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override FooGetDefaultResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<Foo?> varString = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "string":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                varString = new Option<Foo?>(JsonSerializer.Deserialize<Foo>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (varString.IsSet && varString.Value == null)
                throw new ArgumentNullException(nameof(varString), "Property is not nullable for class FooGetDefaultResponse.");

            return new FooGetDefaultResponse(varString);
        }

        /// <summary>
        /// Serializes a <see cref="FooGetDefaultResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="fooGetDefaultResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, FooGetDefaultResponse fooGetDefaultResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, fooGetDefaultResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="FooGetDefaultResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="fooGetDefaultResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, FooGetDefaultResponse fooGetDefaultResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (fooGetDefaultResponse.VarStringOption.IsSet && fooGetDefaultResponse.VarString == null)
                throw new ArgumentNullException(nameof(fooGetDefaultResponse.VarString), "Property is required for class FooGetDefaultResponse.");

            if (fooGetDefaultResponse.VarStringOption.IsSet)
            {
                writer.WritePropertyName("string");
                JsonSerializer.Serialize(writer, fooGetDefaultResponse.VarString, jsonSerializerOptions);
            }
        }
    }
}
