// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

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
    /// ArrayTest
    /// </summary>
    public partial class ArrayTest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayTest" /> class.
        /// </summary>
        /// <param name="arrayArrayOfInteger">arrayArrayOfInteger</param>
        /// <param name="arrayArrayOfModel">arrayArrayOfModel</param>
        /// <param name="arrayOfString">arrayOfString</param>
        [JsonConstructor]
        public ArrayTest(Option<List<List<long>>> arrayArrayOfInteger = default, Option<List<List<ReadOnlyFirst>>> arrayArrayOfModel = default, Option<List<string>> arrayOfString = default)
        {
            ArrayArrayOfIntegerOption = arrayArrayOfInteger;
            ArrayArrayOfModelOption = arrayArrayOfModel;
            ArrayOfStringOption = arrayOfString;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of ArrayArrayOfInteger
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<List<long>>> ArrayArrayOfIntegerOption { get; private set; }

        /// <summary>
        /// Gets or Sets ArrayArrayOfInteger
        /// </summary>
        [JsonPropertyName("array_array_of_integer")]
        public List<List<long>> ArrayArrayOfInteger { get { return this. ArrayArrayOfIntegerOption; } set { this.ArrayArrayOfIntegerOption = new Option<List<List<long>>>(value); } }

        /// <summary>
        /// Used to track the state of ArrayArrayOfModel
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<List<ReadOnlyFirst>>> ArrayArrayOfModelOption { get; private set; }

        /// <summary>
        /// Gets or Sets ArrayArrayOfModel
        /// </summary>
        [JsonPropertyName("array_array_of_model")]
        public List<List<ReadOnlyFirst>> ArrayArrayOfModel { get { return this. ArrayArrayOfModelOption; } set { this.ArrayArrayOfModelOption = new Option<List<List<ReadOnlyFirst>>>(value); } }

        /// <summary>
        /// Used to track the state of ArrayOfString
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>> ArrayOfStringOption { get; private set; }

        /// <summary>
        /// Gets or Sets ArrayOfString
        /// </summary>
        [JsonPropertyName("array_of_string")]
        public List<string> ArrayOfString { get { return this. ArrayOfStringOption; } set { this.ArrayOfStringOption = new Option<List<string>>(value); } }

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
            sb.Append("class ArrayTest {\n");
            sb.Append("  ArrayArrayOfInteger: ").Append(ArrayArrayOfInteger).Append("\n");
            sb.Append("  ArrayArrayOfModel: ").Append(ArrayArrayOfModel).Append("\n");
            sb.Append("  ArrayOfString: ").Append(ArrayOfString).Append("\n");
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
    /// A Json converter for type <see cref="ArrayTest" />
    /// </summary>
    public class ArrayTestJsonConverter : JsonConverter<ArrayTest>
    {
        /// <summary>
        /// Deserializes json to <see cref="ArrayTest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ArrayTest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<List<long>>> arrayArrayOfInteger = default;
            Option<List<List<ReadOnlyFirst>>> arrayArrayOfModel = default;
            Option<List<string>> arrayOfString = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "array_array_of_integer":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                arrayArrayOfInteger = new Option<List<List<long>>>(JsonSerializer.Deserialize<List<List<long>>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "array_array_of_model":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                arrayArrayOfModel = new Option<List<List<ReadOnlyFirst>>>(JsonSerializer.Deserialize<List<List<ReadOnlyFirst>>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "array_of_string":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                arrayOfString = new Option<List<string>>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (arrayArrayOfInteger.IsSet && arrayArrayOfInteger.Value == null)
                throw new ArgumentNullException(nameof(arrayArrayOfInteger), "Property is not nullable for class ArrayTest.");

            if (arrayArrayOfModel.IsSet && arrayArrayOfModel.Value == null)
                throw new ArgumentNullException(nameof(arrayArrayOfModel), "Property is not nullable for class ArrayTest.");

            if (arrayOfString.IsSet && arrayOfString.Value == null)
                throw new ArgumentNullException(nameof(arrayOfString), "Property is not nullable for class ArrayTest.");

            return new ArrayTest(arrayArrayOfInteger, arrayArrayOfModel, arrayOfString);
        }

        /// <summary>
        /// Serializes a <see cref="ArrayTest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="arrayTest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ArrayTest arrayTest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, arrayTest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ArrayTest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="arrayTest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, ArrayTest arrayTest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (arrayTest.ArrayArrayOfIntegerOption.IsSet && arrayTest.ArrayArrayOfInteger == null)
                throw new ArgumentNullException(nameof(arrayTest.ArrayArrayOfInteger), "Property is required for class ArrayTest.");

            if (arrayTest.ArrayArrayOfModelOption.IsSet && arrayTest.ArrayArrayOfModel == null)
                throw new ArgumentNullException(nameof(arrayTest.ArrayArrayOfModel), "Property is required for class ArrayTest.");

            if (arrayTest.ArrayOfStringOption.IsSet && arrayTest.ArrayOfString == null)
                throw new ArgumentNullException(nameof(arrayTest.ArrayOfString), "Property is required for class ArrayTest.");

            if (arrayTest.ArrayArrayOfIntegerOption.IsSet)
            {
                writer.WritePropertyName("array_array_of_integer");
                JsonSerializer.Serialize(writer, arrayTest.ArrayArrayOfInteger, jsonSerializerOptions);
            }
            if (arrayTest.ArrayArrayOfModelOption.IsSet)
            {
                writer.WritePropertyName("array_array_of_model");
                JsonSerializer.Serialize(writer, arrayTest.ArrayArrayOfModel, jsonSerializerOptions);
            }
            if (arrayTest.ArrayOfStringOption.IsSet)
            {
                writer.WritePropertyName("array_of_string");
                JsonSerializer.Serialize(writer, arrayTest.ArrayOfString, jsonSerializerOptions);
            }
        }
    }
}
