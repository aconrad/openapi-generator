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
    /// EnumTest
    /// </summary>
    public partial class EnumTest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumTest" /> class.
        /// </summary>
        /// <param name="enumStringRequired">enumStringRequired</param>
        /// <param name="enumInteger">enumInteger</param>
        /// <param name="enumIntegerOnly">enumIntegerOnly</param>
        /// <param name="enumNumber">enumNumber</param>
        /// <param name="enumString">enumString</param>
        /// <param name="outerEnum">outerEnum</param>
        /// <param name="outerEnumDefaultValue">outerEnumDefaultValue</param>
        /// <param name="outerEnumInteger">outerEnumInteger</param>
        /// <param name="outerEnumIntegerDefaultValue">outerEnumIntegerDefaultValue</param>
        [JsonConstructor]
        public EnumTest(EnumStringRequiredEnum enumStringRequired, Option<EnumIntegerEnum?> enumInteger = default, Option<EnumIntegerOnlyEnum?> enumIntegerOnly = default, Option<EnumNumberEnum?> enumNumber = default, Option<EnumStringEnum?> enumString = default, Option<OuterEnum?> outerEnum = default, Option<OuterEnumDefaultValue?> outerEnumDefaultValue = default, Option<OuterEnumInteger?> outerEnumInteger = default, Option<OuterEnumIntegerDefaultValue?> outerEnumIntegerDefaultValue = default)
        {
            EnumStringRequired = enumStringRequired;
            EnumIntegerOption = enumInteger;
            EnumIntegerOnlyOption = enumIntegerOnly;
            EnumNumberOption = enumNumber;
            EnumStringOption = enumString;
            OuterEnumOption = outerEnum;
            OuterEnumDefaultValueOption = outerEnumDefaultValue;
            OuterEnumIntegerOption = outerEnumInteger;
            OuterEnumIntegerDefaultValueOption = outerEnumIntegerDefaultValue;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines EnumStringRequired
        /// </summary>
        public enum EnumStringRequiredEnum
        {
            /// <summary>
            /// Enum UPPER for value: UPPER
            /// </summary>
            UPPER = 1,

            /// <summary>
            /// Enum Lower for value: lower
            /// </summary>
            Lower = 2,

            /// <summary>
            /// Enum Empty for value: 
            /// </summary>
            Empty = 3,

            /// <summary>
            /// Enum ValuewithTab for value: Value\twith tab
            /// </summary>
            ValuewithTab = 4,

            /// <summary>
            /// Enum ValueWithQuote for value: Value with \&quot; quote
            /// </summary>
            ValueWithQuote = 5,

            /// <summary>
            /// Enum ValueWithEscapedQuote for value: Value with escaped \&quot; quote
            /// </summary>
            ValueWithEscapedQuote = 6,

            /// <summary>
            /// Enum Duplicatevalue for value: Duplicate\nvalue
            /// </summary>
            Duplicatevalue = 7,

            /// <summary>
            /// Enum Duplicatevalue2 for value: Duplicate\r\nvalue
            /// </summary>
            Duplicatevalue2 = 8
        }

        /// <summary>
        /// Returns a <see cref="EnumStringRequiredEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static EnumStringRequiredEnum EnumStringRequiredEnumFromString(string value)
        {
            if (value.Equals("UPPER"))
                return EnumStringRequiredEnum.UPPER;

            if (value.Equals("lower"))
                return EnumStringRequiredEnum.Lower;

            if (value.Equals(""))
                return EnumStringRequiredEnum.Empty;

            if (value.Equals("Value\twith tab"))
                return EnumStringRequiredEnum.ValuewithTab;

            if (value.Equals("Value with \" quote"))
                return EnumStringRequiredEnum.ValueWithQuote;

            if (value.Equals("Value with escaped \" quote"))
                return EnumStringRequiredEnum.ValueWithEscapedQuote;

            if (value.Equals("Duplicate\nvalue"))
                return EnumStringRequiredEnum.Duplicatevalue;

            if (value.Equals("Duplicate\r\nvalue"))
                return EnumStringRequiredEnum.Duplicatevalue2;

            throw new NotImplementedException($"Could not convert value to type EnumStringRequiredEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="EnumStringRequiredEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumStringRequiredEnum? EnumStringRequiredEnumFromStringOrDefault(string value)
        {
            if (value.Equals("UPPER"))
                return EnumStringRequiredEnum.UPPER;

            if (value.Equals("lower"))
                return EnumStringRequiredEnum.Lower;

            if (value.Equals(""))
                return EnumStringRequiredEnum.Empty;

            if (value.Equals("Value\twith tab"))
                return EnumStringRequiredEnum.ValuewithTab;

            if (value.Equals("Value with \" quote"))
                return EnumStringRequiredEnum.ValueWithQuote;

            if (value.Equals("Value with escaped \" quote"))
                return EnumStringRequiredEnum.ValueWithEscapedQuote;

            if (value.Equals("Duplicate\nvalue"))
                return EnumStringRequiredEnum.Duplicatevalue;

            if (value.Equals("Duplicate\r\nvalue"))
                return EnumStringRequiredEnum.Duplicatevalue2;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="EnumStringRequiredEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string EnumStringRequiredEnumToJsonValue(EnumStringRequiredEnum value)
        {
            if (value == EnumStringRequiredEnum.UPPER)
                return "UPPER";

            if (value == EnumStringRequiredEnum.Lower)
                return "lower";

            if (value == EnumStringRequiredEnum.Empty)
                return "";

            if (value == EnumStringRequiredEnum.ValuewithTab)
                return "Value\twith tab";

            if (value == EnumStringRequiredEnum.ValueWithQuote)
                return "Value with \" quote";

            if (value == EnumStringRequiredEnum.ValueWithEscapedQuote)
                return "Value with escaped \" quote";

            if (value == EnumStringRequiredEnum.Duplicatevalue)
                return "Duplicate\nvalue";

            if (value == EnumStringRequiredEnum.Duplicatevalue2)
                return "Duplicate\r\nvalue";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets EnumStringRequired
        /// </summary>
        [JsonPropertyName("enum_string_required")]
        public EnumStringRequiredEnum EnumStringRequired { get; set; }

        /// <summary>
        /// Defines EnumInteger
        /// </summary>
        public enum EnumIntegerEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_MINUS_1 for value: -1
            /// </summary>
            NUMBER_MINUS_1 = -1
        }

        /// <summary>
        /// Returns a <see cref="EnumIntegerEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static EnumIntegerEnum EnumIntegerEnumFromString(string value)
        {
            if (value.Equals((1).ToString()))
                return EnumIntegerEnum.NUMBER_1;

            if (value.Equals((-1).ToString()))
                return EnumIntegerEnum.NUMBER_MINUS_1;

            throw new NotImplementedException($"Could not convert value to type EnumIntegerEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="EnumIntegerEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumIntegerEnum? EnumIntegerEnumFromStringOrDefault(string value)
        {
            if (value.Equals((1).ToString()))
                return EnumIntegerEnum.NUMBER_1;

            if (value.Equals((-1).ToString()))
                return EnumIntegerEnum.NUMBER_MINUS_1;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="EnumIntegerEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int EnumIntegerEnumToJsonValue(EnumIntegerEnum value)
        {
            return (int) value;
        }

        /// <summary>
        /// Used to track the state of EnumInteger
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<EnumIntegerEnum?> EnumIntegerOption { get; private set; }

        /// <summary>
        /// Gets or Sets EnumInteger
        /// </summary>
        [JsonPropertyName("enum_integer")]
        public EnumIntegerEnum? EnumInteger { get { return this.EnumIntegerOption; } set { this.EnumIntegerOption = new(value); } }

        /// <summary>
        /// Defines EnumIntegerOnly
        /// </summary>
        public enum EnumIntegerOnlyEnum
        {
            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2,

            /// <summary>
            /// Enum NUMBER_MINUS_2 for value: -2
            /// </summary>
            NUMBER_MINUS_2 = -2
        }

        /// <summary>
        /// Returns a <see cref="EnumIntegerOnlyEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static EnumIntegerOnlyEnum EnumIntegerOnlyEnumFromString(string value)
        {
            if (value.Equals((2).ToString()))
                return EnumIntegerOnlyEnum.NUMBER_2;

            if (value.Equals((-2).ToString()))
                return EnumIntegerOnlyEnum.NUMBER_MINUS_2;

            throw new NotImplementedException($"Could not convert value to type EnumIntegerOnlyEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="EnumIntegerOnlyEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumIntegerOnlyEnum? EnumIntegerOnlyEnumFromStringOrDefault(string value)
        {
            if (value.Equals((2).ToString()))
                return EnumIntegerOnlyEnum.NUMBER_2;

            if (value.Equals((-2).ToString()))
                return EnumIntegerOnlyEnum.NUMBER_MINUS_2;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="EnumIntegerOnlyEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int EnumIntegerOnlyEnumToJsonValue(EnumIntegerOnlyEnum value)
        {
            return (int) value;
        }

        /// <summary>
        /// Used to track the state of EnumIntegerOnly
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<EnumIntegerOnlyEnum?> EnumIntegerOnlyOption { get; private set; }

        /// <summary>
        /// Gets or Sets EnumIntegerOnly
        /// </summary>
        [JsonPropertyName("enum_integer_only")]
        public EnumIntegerOnlyEnum? EnumIntegerOnly { get { return this.EnumIntegerOnlyOption; } set { this.EnumIntegerOnlyOption = new(value); } }

        /// <summary>
        /// Defines EnumNumber
        /// </summary>
        public enum EnumNumberEnum
        {
            /// <summary>
            /// Enum NUMBER_1_DOT_1 for value: 1.1
            /// </summary>
            NUMBER_1_DOT_1 = 1,

            /// <summary>
            /// Enum NUMBER_MINUS_1_DOT_2 for value: -1.2
            /// </summary>
            NUMBER_MINUS_1_DOT_2 = 2
        }

        /// <summary>
        /// Returns a <see cref="EnumNumberEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static EnumNumberEnum EnumNumberEnumFromString(string value)
        {
            if (value.Equals("1.1"))
                return EnumNumberEnum.NUMBER_1_DOT_1;

            if (value.Equals("-1.2"))
                return EnumNumberEnum.NUMBER_MINUS_1_DOT_2;

            throw new NotImplementedException($"Could not convert value to type EnumNumberEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="EnumNumberEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumNumberEnum? EnumNumberEnumFromStringOrDefault(string value)
        {
            if (value.Equals("1.1"))
                return EnumNumberEnum.NUMBER_1_DOT_1;

            if (value.Equals("-1.2"))
                return EnumNumberEnum.NUMBER_MINUS_1_DOT_2;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="EnumNumberEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static double EnumNumberEnumToJsonValue(EnumNumberEnum? value)
        {
            if (value == EnumNumberEnum.NUMBER_1_DOT_1)
                return 1.1;

            if (value == EnumNumberEnum.NUMBER_MINUS_1_DOT_2)
                return -1.2;

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Used to track the state of EnumNumber
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<EnumNumberEnum?> EnumNumberOption { get; private set; }

        /// <summary>
        /// Gets or Sets EnumNumber
        /// </summary>
        [JsonPropertyName("enum_number")]
        public EnumNumberEnum? EnumNumber { get { return this.EnumNumberOption; } set { this.EnumNumberOption = new(value); } }

        /// <summary>
        /// Defines EnumString
        /// </summary>
        public enum EnumStringEnum
        {
            /// <summary>
            /// Enum UPPER for value: UPPER
            /// </summary>
            UPPER = 1,

            /// <summary>
            /// Enum Lower for value: lower
            /// </summary>
            Lower = 2,

            /// <summary>
            /// Enum Empty for value: 
            /// </summary>
            Empty = 3,

            /// <summary>
            /// Enum ValuewithTab for value: Value\twith tab
            /// </summary>
            ValuewithTab = 4,

            /// <summary>
            /// Enum ValueWithQuote for value: Value with \&quot; quote
            /// </summary>
            ValueWithQuote = 5,

            /// <summary>
            /// Enum ValueWithEscapedQuote for value: Value with escaped \&quot; quote
            /// </summary>
            ValueWithEscapedQuote = 6,

            /// <summary>
            /// Enum Duplicatevalue for value: Duplicate\nvalue
            /// </summary>
            Duplicatevalue = 7,

            /// <summary>
            /// Enum Duplicatevalue2 for value: Duplicate\r\nvalue
            /// </summary>
            Duplicatevalue2 = 8
        }

        /// <summary>
        /// Returns a <see cref="EnumStringEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static EnumStringEnum EnumStringEnumFromString(string value)
        {
            if (value.Equals("UPPER"))
                return EnumStringEnum.UPPER;

            if (value.Equals("lower"))
                return EnumStringEnum.Lower;

            if (value.Equals(""))
                return EnumStringEnum.Empty;

            if (value.Equals("Value\twith tab"))
                return EnumStringEnum.ValuewithTab;

            if (value.Equals("Value with \" quote"))
                return EnumStringEnum.ValueWithQuote;

            if (value.Equals("Value with escaped \" quote"))
                return EnumStringEnum.ValueWithEscapedQuote;

            if (value.Equals("Duplicate\nvalue"))
                return EnumStringEnum.Duplicatevalue;

            if (value.Equals("Duplicate\r\nvalue"))
                return EnumStringEnum.Duplicatevalue2;

            throw new NotImplementedException($"Could not convert value to type EnumStringEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="EnumStringEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumStringEnum? EnumStringEnumFromStringOrDefault(string value)
        {
            if (value.Equals("UPPER"))
                return EnumStringEnum.UPPER;

            if (value.Equals("lower"))
                return EnumStringEnum.Lower;

            if (value.Equals(""))
                return EnumStringEnum.Empty;

            if (value.Equals("Value\twith tab"))
                return EnumStringEnum.ValuewithTab;

            if (value.Equals("Value with \" quote"))
                return EnumStringEnum.ValueWithQuote;

            if (value.Equals("Value with escaped \" quote"))
                return EnumStringEnum.ValueWithEscapedQuote;

            if (value.Equals("Duplicate\nvalue"))
                return EnumStringEnum.Duplicatevalue;

            if (value.Equals("Duplicate\r\nvalue"))
                return EnumStringEnum.Duplicatevalue2;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="EnumStringEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string EnumStringEnumToJsonValue(EnumStringEnum? value)
        {
            if (value == EnumStringEnum.UPPER)
                return "UPPER";

            if (value == EnumStringEnum.Lower)
                return "lower";

            if (value == EnumStringEnum.Empty)
                return "";

            if (value == EnumStringEnum.ValuewithTab)
                return "Value\twith tab";

            if (value == EnumStringEnum.ValueWithQuote)
                return "Value with \" quote";

            if (value == EnumStringEnum.ValueWithEscapedQuote)
                return "Value with escaped \" quote";

            if (value == EnumStringEnum.Duplicatevalue)
                return "Duplicate\nvalue";

            if (value == EnumStringEnum.Duplicatevalue2)
                return "Duplicate\r\nvalue";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Used to track the state of EnumString
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<EnumStringEnum?> EnumStringOption { get; private set; }

        /// <summary>
        /// Gets or Sets EnumString
        /// </summary>
        [JsonPropertyName("enum_string")]
        public EnumStringEnum? EnumString { get { return this.EnumStringOption; } set { this.EnumStringOption = new(value); } }

        /// <summary>
        /// Used to track the state of OuterEnum
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<OuterEnum?> OuterEnumOption { get; private set; }

        /// <summary>
        /// Gets or Sets OuterEnum
        /// </summary>
        [JsonPropertyName("outerEnum")]
        public OuterEnum? OuterEnum { get { return this.OuterEnumOption; } set { this.OuterEnumOption = new(value); } }

        /// <summary>
        /// Used to track the state of OuterEnumDefaultValue
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<OuterEnumDefaultValue?> OuterEnumDefaultValueOption { get; private set; }

        /// <summary>
        /// Gets or Sets OuterEnumDefaultValue
        /// </summary>
        [JsonPropertyName("outerEnumDefaultValue")]
        public OuterEnumDefaultValue? OuterEnumDefaultValue { get { return this.OuterEnumDefaultValueOption; } set { this.OuterEnumDefaultValueOption = new(value); } }

        /// <summary>
        /// Used to track the state of OuterEnumInteger
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<OuterEnumInteger?> OuterEnumIntegerOption { get; private set; }

        /// <summary>
        /// Gets or Sets OuterEnumInteger
        /// </summary>
        [JsonPropertyName("outerEnumInteger")]
        public OuterEnumInteger? OuterEnumInteger { get { return this.OuterEnumIntegerOption; } set { this.OuterEnumIntegerOption = new(value); } }

        /// <summary>
        /// Used to track the state of OuterEnumIntegerDefaultValue
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<OuterEnumIntegerDefaultValue?> OuterEnumIntegerDefaultValueOption { get; private set; }

        /// <summary>
        /// Gets or Sets OuterEnumIntegerDefaultValue
        /// </summary>
        [JsonPropertyName("outerEnumIntegerDefaultValue")]
        public OuterEnumIntegerDefaultValue? OuterEnumIntegerDefaultValue { get { return this.OuterEnumIntegerDefaultValueOption; } set { this.OuterEnumIntegerDefaultValueOption = new(value); } }

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
            sb.Append("class EnumTest {\n");
            sb.Append("  EnumStringRequired: ").Append(EnumStringRequired).Append("\n");
            sb.Append("  EnumInteger: ").Append(EnumInteger).Append("\n");
            sb.Append("  EnumIntegerOnly: ").Append(EnumIntegerOnly).Append("\n");
            sb.Append("  EnumNumber: ").Append(EnumNumber).Append("\n");
            sb.Append("  EnumString: ").Append(EnumString).Append("\n");
            sb.Append("  OuterEnum: ").Append(OuterEnum).Append("\n");
            sb.Append("  OuterEnumDefaultValue: ").Append(OuterEnumDefaultValue).Append("\n");
            sb.Append("  OuterEnumInteger: ").Append(OuterEnumInteger).Append("\n");
            sb.Append("  OuterEnumIntegerDefaultValue: ").Append(OuterEnumIntegerDefaultValue).Append("\n");
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
    /// A Json converter for type <see cref="EnumTest" />
    /// </summary>
    public class EnumTestJsonConverter : JsonConverter<EnumTest>
    {
        /// <summary>
        /// Deserializes json to <see cref="EnumTest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EnumTest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<EnumTest.EnumStringRequiredEnum?> enumStringRequired = default;
            Option<EnumTest.EnumIntegerEnum?> enumInteger = default;
            Option<EnumTest.EnumIntegerOnlyEnum?> enumIntegerOnly = default;
            Option<EnumTest.EnumNumberEnum?> enumNumber = default;
            Option<EnumTest.EnumStringEnum?> enumString = default;
            Option<OuterEnum?> outerEnum = default;
            Option<OuterEnumDefaultValue?> outerEnumDefaultValue = default;
            Option<OuterEnumInteger?> outerEnumInteger = default;
            Option<OuterEnumIntegerDefaultValue?> outerEnumIntegerDefaultValue = default;

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
                        case "enum_string_required":
                            string enumStringRequiredRawValue = utf8JsonReader.GetString();
                            if (enumStringRequiredRawValue != null)
                                enumStringRequired = new Option<EnumTest.EnumStringRequiredEnum?>(EnumTest.EnumStringRequiredEnumFromStringOrDefault(enumStringRequiredRawValue));
                            break;
                        case "enum_integer":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                enumInteger = new Option<EnumTest.EnumIntegerEnum?>((EnumTest.EnumIntegerEnum)utf8JsonReader.GetInt32());
                            break;
                        case "enum_integer_only":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                enumIntegerOnly = new Option<EnumTest.EnumIntegerOnlyEnum?>((EnumTest.EnumIntegerOnlyEnum)utf8JsonReader.GetInt32());
                            break;
                        case "enum_number":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                enumNumber = new Option<EnumTest.EnumNumberEnum?>((EnumTest.EnumNumberEnum)utf8JsonReader.GetInt32());
                            break;
                        case "enum_string":
                            string enumStringRawValue = utf8JsonReader.GetString();
                            if (enumStringRawValue != null)
                                enumString = new Option<EnumTest.EnumStringEnum?>(EnumTest.EnumStringEnumFromStringOrDefault(enumStringRawValue));
                            break;
                        case "outerEnum":
                            string outerEnumRawValue = utf8JsonReader.GetString();
                            if (outerEnumRawValue != null)
                                outerEnum = new Option<OuterEnum?>(OuterEnumValueConverter.FromStringOrDefault(outerEnumRawValue));
                            break;
                        case "outerEnumDefaultValue":
                            string outerEnumDefaultValueRawValue = utf8JsonReader.GetString();
                            if (outerEnumDefaultValueRawValue != null)
                                outerEnumDefaultValue = new Option<OuterEnumDefaultValue?>(OuterEnumDefaultValueValueConverter.FromStringOrDefault(outerEnumDefaultValueRawValue));
                            break;
                        case "outerEnumInteger":
                            string outerEnumIntegerRawValue = utf8JsonReader.GetString();
                            if (outerEnumIntegerRawValue != null)
                                outerEnumInteger = new Option<OuterEnumInteger?>(OuterEnumIntegerValueConverter.FromStringOrDefault(outerEnumIntegerRawValue));
                            break;
                        case "outerEnumIntegerDefaultValue":
                            string outerEnumIntegerDefaultValueRawValue = utf8JsonReader.GetString();
                            if (outerEnumIntegerDefaultValueRawValue != null)
                                outerEnumIntegerDefaultValue = new Option<OuterEnumIntegerDefaultValue?>(OuterEnumIntegerDefaultValueValueConverter.FromStringOrDefault(outerEnumIntegerDefaultValueRawValue));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!enumStringRequired.IsSet)
                throw new ArgumentException("Property is required for class EnumTest.", nameof(enumStringRequired));

            if (enumStringRequired.IsSet && enumStringRequired.Value == null)
                throw new ArgumentNullException(nameof(enumStringRequired), "Property is not nullable for class EnumTest.");

            if (enumInteger.IsSet && enumInteger.Value == null)
                throw new ArgumentNullException(nameof(enumInteger), "Property is not nullable for class EnumTest.");

            if (enumIntegerOnly.IsSet && enumIntegerOnly.Value == null)
                throw new ArgumentNullException(nameof(enumIntegerOnly), "Property is not nullable for class EnumTest.");

            if (enumNumber.IsSet && enumNumber.Value == null)
                throw new ArgumentNullException(nameof(enumNumber), "Property is not nullable for class EnumTest.");

            if (enumString.IsSet && enumString.Value == null)
                throw new ArgumentNullException(nameof(enumString), "Property is not nullable for class EnumTest.");

            if (outerEnumDefaultValue.IsSet && outerEnumDefaultValue.Value == null)
                throw new ArgumentNullException(nameof(outerEnumDefaultValue), "Property is not nullable for class EnumTest.");

            if (outerEnumInteger.IsSet && outerEnumInteger.Value == null)
                throw new ArgumentNullException(nameof(outerEnumInteger), "Property is not nullable for class EnumTest.");

            if (outerEnumIntegerDefaultValue.IsSet && outerEnumIntegerDefaultValue.Value == null)
                throw new ArgumentNullException(nameof(outerEnumIntegerDefaultValue), "Property is not nullable for class EnumTest.");

            return new EnumTest(enumStringRequired.Value.Value, enumInteger, enumIntegerOnly, enumNumber, enumString, outerEnum, outerEnumDefaultValue, outerEnumInteger, outerEnumIntegerDefaultValue);
        }

        /// <summary>
        /// Serializes a <see cref="EnumTest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="enumTest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EnumTest enumTest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, enumTest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EnumTest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="enumTest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, EnumTest enumTest, JsonSerializerOptions jsonSerializerOptions)
        {
            var enumStringRequiredRawValue = EnumTest.EnumStringRequiredEnumToJsonValue(enumTest.EnumStringRequired);
            if (enumStringRequiredRawValue != null)
                writer.WriteString("enum_string_required", enumStringRequiredRawValue);
            else
                writer.WriteNull("enum_string_required");

            if (enumTest.EnumIntegerOption.IsSet)
                writer.WriteNumber("enum_integer", EnumTest.EnumIntegerEnumToJsonValue(enumTest.EnumIntegerOption.Value.Value));

            if (enumTest.EnumIntegerOnlyOption.IsSet)
                writer.WriteNumber("enum_integer_only", EnumTest.EnumIntegerOnlyEnumToJsonValue(enumTest.EnumIntegerOnlyOption.Value.Value));

            if (enumTest.EnumNumberOption.IsSet)
                writer.WriteNumber("enum_number", EnumTest.EnumNumberEnumToJsonValue(enumTest.EnumNumberOption.Value.Value));

            var enumStringRawValue = EnumTest.EnumStringEnumToJsonValue(enumTest.EnumStringOption.Value.Value);
            if (enumStringRawValue != null)
                writer.WriteString("enum_string", enumStringRawValue);
            else
                writer.WriteNull("enum_string");

            if (enumTest.OuterEnumOption.IsSet)
                if (enumTest.OuterEnumOption.Value != null)
                {
                    var outerEnumRawValue = OuterEnumValueConverter.ToJsonValue(enumTest.OuterEnumOption.Value.Value);
                    writer.WriteString("outerEnum", outerEnumRawValue);
                }
                else
                    writer.WriteNull("outerEnum");
            if (enumTest.OuterEnumDefaultValueOption.IsSet)
            {
                var outerEnumDefaultValueRawValue = OuterEnumDefaultValueValueConverter.ToJsonValue(enumTest.OuterEnumDefaultValue.Value);
                writer.WriteString("outerEnumDefaultValue", outerEnumDefaultValueRawValue);
            }
            if (enumTest.OuterEnumIntegerOption.IsSet)
            {
                var outerEnumIntegerRawValue = OuterEnumIntegerValueConverter.ToJsonValue(enumTest.OuterEnumInteger.Value);
                writer.WriteNumber("outerEnumInteger", outerEnumIntegerRawValue);
            }
            if (enumTest.OuterEnumIntegerDefaultValueOption.IsSet)
            {
                var outerEnumIntegerDefaultValueRawValue = OuterEnumIntegerDefaultValueValueConverter.ToJsonValue(enumTest.OuterEnumIntegerDefaultValue.Value);
                writer.WriteNumber("outerEnumIntegerDefaultValue", outerEnumIntegerDefaultValueRawValue);
            }
        }
    }
}
