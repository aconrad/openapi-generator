/*
 * Echo Server API
 *
 * Echo Server API
 *
 * The version of the OpenAPI document: 0.1.0
 * Contact: team@openapitools.org
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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Bird
    /// </summary>
    [DataContract(Name = "Bird")]
    public partial class Bird : IEquatable<Bird>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bird" /> class.
        /// </summary>
        /// <param name="size">size.</param>
        /// <param name="color">color.</param>
        public Bird(string size = default(string), string color = default(string))
        {
            Size = size;
            Color = color;
        }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public string Size { get; set; }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name = "color", EmitDefaultValue = false)]
        public string Color { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Bird {\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
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
            return Equals(input as Bird);
        }

        /// <summary>
        /// Returns true if Bird instances are equal
        /// </summary>
        /// <param name="input">Instance of Bird to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Bird input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    Size == input.Size ||
					Size.Equals(input.Size)
                ) && 
                (
                    Color == input.Color ||
					Color.Equals(input.Color)
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
				hashCode = (hashCode * 59) + Size.GetHashCode();
				hashCode = (hashCode * 59) + Color.GetHashCode();
                return hashCode;
            }
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

}
