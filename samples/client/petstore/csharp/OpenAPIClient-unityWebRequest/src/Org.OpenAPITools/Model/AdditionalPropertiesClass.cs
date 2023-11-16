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
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// AdditionalPropertiesClass
    /// </summary>
    [DataContract(Name = "AdditionalPropertiesClass")]
    public partial class AdditionalPropertiesClass : IEquatable<AdditionalPropertiesClass>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalPropertiesClass" /> class.
        /// </summary>
        /// <param name="mapProperty">mapProperty.</param>
        /// <param name="mapOfMapProperty">mapOfMapProperty.</param>
        /// <param name="anytype1">anytype1.</param>
        /// <param name="mapWithUndeclaredPropertiesAnytype1">mapWithUndeclaredPropertiesAnytype1.</param>
        /// <param name="mapWithUndeclaredPropertiesAnytype2">mapWithUndeclaredPropertiesAnytype2.</param>
        /// <param name="mapWithUndeclaredPropertiesAnytype3">mapWithUndeclaredPropertiesAnytype3.</param>
        /// <param name="emptyMap">an object with no declared properties and no undeclared properties, hence it&#39;s an empty map..</param>
        /// <param name="mapWithUndeclaredPropertiesString">mapWithUndeclaredPropertiesString.</param>
        public AdditionalPropertiesClass(Dictionary<string, string> mapProperty = default(Dictionary<string, string>), Dictionary<string, Dictionary<string, string>> mapOfMapProperty = default(Dictionary<string, Dictionary<string, string>>), Object anytype1 = default(Object), Object mapWithUndeclaredPropertiesAnytype1 = default(Object), Object mapWithUndeclaredPropertiesAnytype2 = default(Object), Dictionary<string, Object> mapWithUndeclaredPropertiesAnytype3 = default(Dictionary<string, Object>), Object emptyMap = default(Object), Dictionary<string, string> mapWithUndeclaredPropertiesString = default(Dictionary<string, string>))
        {
            MapProperty = mapProperty;
            MapOfMapProperty = mapOfMapProperty;
            Anytype1 = anytype1;
            MapWithUndeclaredPropertiesAnytype1 = mapWithUndeclaredPropertiesAnytype1;
            MapWithUndeclaredPropertiesAnytype2 = mapWithUndeclaredPropertiesAnytype2;
            MapWithUndeclaredPropertiesAnytype3 = mapWithUndeclaredPropertiesAnytype3;
            EmptyMap = emptyMap;
            MapWithUndeclaredPropertiesString = mapWithUndeclaredPropertiesString;
        }

        /// <summary>
        /// Gets or Sets MapProperty
        /// </summary>
        [DataMember(Name = "map_property", EmitDefaultValue = false)]
        public Dictionary<string, string> MapProperty { get; set; }

        /// <summary>
        /// Gets or Sets MapOfMapProperty
        /// </summary>
        [DataMember(Name = "map_of_map_property", EmitDefaultValue = false)]
        public Dictionary<string, Dictionary<string, string>> MapOfMapProperty { get; set; }

        /// <summary>
        /// Gets or Sets Anytype1
        /// </summary>
        [DataMember(Name = "anytype_1", EmitDefaultValue = true)]
        public Object Anytype1 { get; set; }

        /// <summary>
        /// Gets or Sets MapWithUndeclaredPropertiesAnytype1
        /// </summary>
        [DataMember(Name = "map_with_undeclared_properties_anytype_1", EmitDefaultValue = false)]
        public Object MapWithUndeclaredPropertiesAnytype1 { get; set; }

        /// <summary>
        /// Gets or Sets MapWithUndeclaredPropertiesAnytype2
        /// </summary>
        [DataMember(Name = "map_with_undeclared_properties_anytype_2", EmitDefaultValue = false)]
        public Object MapWithUndeclaredPropertiesAnytype2 { get; set; }

        /// <summary>
        /// Gets or Sets MapWithUndeclaredPropertiesAnytype3
        /// </summary>
        [DataMember(Name = "map_with_undeclared_properties_anytype_3", EmitDefaultValue = false)]
        public Dictionary<string, Object> MapWithUndeclaredPropertiesAnytype3 { get; set; }

        /// <summary>
        /// an object with no declared properties and no undeclared properties, hence it&#39;s an empty map.
        /// </summary>
        /// <value>an object with no declared properties and no undeclared properties, hence it&#39;s an empty map.</value>
        [DataMember(Name = "empty_map", EmitDefaultValue = false)]
        public Object EmptyMap { get; set; }

        /// <summary>
        /// Gets or Sets MapWithUndeclaredPropertiesString
        /// </summary>
        [DataMember(Name = "map_with_undeclared_properties_string", EmitDefaultValue = false)]
        public Dictionary<string, string> MapWithUndeclaredPropertiesString { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdditionalPropertiesClass {\n");
            sb.Append("  MapProperty: ").Append(MapProperty).Append("\n");
            sb.Append("  MapOfMapProperty: ").Append(MapOfMapProperty).Append("\n");
            sb.Append("  Anytype1: ").Append(Anytype1).Append("\n");
            sb.Append("  MapWithUndeclaredPropertiesAnytype1: ").Append(MapWithUndeclaredPropertiesAnytype1).Append("\n");
            sb.Append("  MapWithUndeclaredPropertiesAnytype2: ").Append(MapWithUndeclaredPropertiesAnytype2).Append("\n");
            sb.Append("  MapWithUndeclaredPropertiesAnytype3: ").Append(MapWithUndeclaredPropertiesAnytype3).Append("\n");
            sb.Append("  EmptyMap: ").Append(EmptyMap).Append("\n");
            sb.Append("  MapWithUndeclaredPropertiesString: ").Append(MapWithUndeclaredPropertiesString).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as AdditionalPropertiesClass);
        }

        /// <summary>
        /// Returns true if AdditionalPropertiesClass instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalPropertiesClass to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalPropertiesClass input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    MapProperty == input.MapProperty ||
                    MapProperty != null &&
                    input.MapProperty != null &&
                    MapProperty.SequenceEqual(input.MapProperty)
                ) && 
                (
                    MapOfMapProperty == input.MapOfMapProperty ||
                    MapOfMapProperty != null &&
                    input.MapOfMapProperty != null &&
                    MapOfMapProperty.SequenceEqual(input.MapOfMapProperty)
                ) && 
                (
                    Anytype1 == input.Anytype1 ||
                    (Anytype1 != null &&
                    Anytype1.Equals(input.Anytype1))
                ) && 
                (
                    MapWithUndeclaredPropertiesAnytype1 == input.MapWithUndeclaredPropertiesAnytype1 ||
					MapWithUndeclaredPropertiesAnytype1.Equals(input.MapWithUndeclaredPropertiesAnytype1)
                ) && 
                (
                    MapWithUndeclaredPropertiesAnytype2 == input.MapWithUndeclaredPropertiesAnytype2 ||
					MapWithUndeclaredPropertiesAnytype2.Equals(input.MapWithUndeclaredPropertiesAnytype2)
                ) && 
                (
                    MapWithUndeclaredPropertiesAnytype3 == input.MapWithUndeclaredPropertiesAnytype3 ||
                    MapWithUndeclaredPropertiesAnytype3 != null &&
                    input.MapWithUndeclaredPropertiesAnytype3 != null &&
                    MapWithUndeclaredPropertiesAnytype3.SequenceEqual(input.MapWithUndeclaredPropertiesAnytype3)
                ) && 
                (
                    EmptyMap == input.EmptyMap ||
					EmptyMap.Equals(input.EmptyMap)
                ) && 
                (
                    MapWithUndeclaredPropertiesString == input.MapWithUndeclaredPropertiesString ||
                    MapWithUndeclaredPropertiesString != null &&
                    input.MapWithUndeclaredPropertiesString != null &&
                    MapWithUndeclaredPropertiesString.SequenceEqual(input.MapWithUndeclaredPropertiesString)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
				hashCode = (hashCode * 59) + MapProperty.GetHashCode();
				hashCode = (hashCode * 59) + MapOfMapProperty.GetHashCode();
                if (Anytype1 != null)
                {
                    hashCode = (hashCode * 59) + Anytype1.GetHashCode();
                }
				hashCode = (hashCode * 59) + MapWithUndeclaredPropertiesAnytype1.GetHashCode();
				hashCode = (hashCode * 59) + MapWithUndeclaredPropertiesAnytype2.GetHashCode();
				hashCode = (hashCode * 59) + MapWithUndeclaredPropertiesAnytype3.GetHashCode();
				hashCode = (hashCode * 59) + EmptyMap.GetHashCode();
				hashCode = (hashCode * 59) + MapWithUndeclaredPropertiesString.GetHashCode();
                return hashCode;
            }
        }

    }

}
