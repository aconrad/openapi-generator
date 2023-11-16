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
    /// Pig
    /// </summary>
    public partial class Pig : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pig" /> class.
        /// </summary>
        /// <param name="basquePig"></param>
        /// <param name="className">className</param>
        public Pig(BasquePig basquePig, string className)
        {
            BasquePig = basquePig;
            ClassName = className;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pig" /> class.
        /// </summary>
        /// <param name="danishPig"></param>
        /// <param name="className">className</param>
        public Pig(DanishPig danishPig, string className)
        {
            DanishPig = danishPig;
            ClassName = className;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets BasquePig
        /// </summary>
        public BasquePig BasquePig { get; set; }

        /// <summary>
        /// Gets or Sets DanishPig
        /// </summary>
        public DanishPig DanishPig { get; set; }

        /// <summary>
        /// Gets or Sets ClassName
        /// </summary>
        [JsonPropertyName("className")]
        public string ClassName { get; set; }

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
            sb.Append("class Pig {\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Pig" />
    /// </summary>
    public class PigJsonConverter : JsonConverter<Pig>
    {
        /// <summary>
        /// Deserializes json to <see cref="Pig" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Pig Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> className = default;

            BasquePig basquePig = null;
            DanishPig danishPig = null;

            Utf8JsonReader utf8JsonReaderDiscriminator = utf8JsonReader;
            while (utf8JsonReaderDiscriminator.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReaderDiscriminator.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReaderDiscriminator.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReaderDiscriminator.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReaderDiscriminator.CurrentDepth)
                    break;

                if (utf8JsonReaderDiscriminator.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReaderDiscriminator.CurrentDepth - 1)
                {
                    string localVarJsonPropertyName = utf8JsonReaderDiscriminator.GetString();
                    utf8JsonReaderDiscriminator.Read();
                    if (localVarJsonPropertyName.Equals("className"))
                    {
                        string discriminator = utf8JsonReaderDiscriminator.GetString();
                        if (discriminator.Equals("BasquePig"))
                        {
                            Utf8JsonReader utf8JsonReaderBasquePig = utf8JsonReader;
                            basquePig = JsonSerializer.Deserialize<BasquePig>(ref utf8JsonReaderBasquePig, jsonSerializerOptions);
                        }
                        if (discriminator.Equals("DanishPig"))
                        {
                            Utf8JsonReader utf8JsonReaderDanishPig = utf8JsonReader;
                            danishPig = JsonSerializer.Deserialize<DanishPig>(ref utf8JsonReaderDanishPig, jsonSerializerOptions);
                        }
                    }
                }
            }

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
                        case "className":
                            className = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!className.IsSet)
                throw new ArgumentException("Property is required for class Pig.", nameof(className));

            if (className.IsSet && className.Value == null)
                throw new ArgumentNullException(nameof(className), "Property is not nullable for class Pig.");

            if (basquePig != null)
                return new Pig(basquePig, className.Value);

            if (danishPig != null)
                return new Pig(danishPig, className.Value);

            throw new JsonException();
        }

        /// <summary>
        /// Serializes a <see cref="Pig" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="pig"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Pig pig, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            if (pig.BasquePig != null) {
                BasquePigJsonConverter basquePigJsonConverter = (BasquePigJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(pig.BasquePig.GetType()));
                basquePigJsonConverter.WriteProperties(ref writer, pig.BasquePig, jsonSerializerOptions);
            }

            if (pig.DanishPig != null) {
                DanishPigJsonConverter danishPigJsonConverter = (DanishPigJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(pig.DanishPig.GetType()));
                danishPigJsonConverter.WriteProperties(ref writer, pig.DanishPig, jsonSerializerOptions);
            }

            WriteProperties(ref writer, pig, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Pig" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="pig"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, Pig pig, JsonSerializerOptions jsonSerializerOptions)
        {
            if (pig.ClassName == null)
                throw new ArgumentNullException(nameof(pig.ClassName), "Property is required for class Pig.");

            writer.WriteString("className", pig.ClassName);
        }
    }
}
