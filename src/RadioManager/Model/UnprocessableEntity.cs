/* 
 * RadioManager
 *
 * RadioManager
 *
 * OpenAPI spec version: 2.0
 * Contact: support@pluxbox.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = RadioManager.Client.SwaggerDateConverter;

namespace RadioManager.Model
{
    /// <summary>
    /// UnprocessableEntity
    /// </summary>
    [DataContract]
    public partial class UnprocessableEntity :  IEquatable<UnprocessableEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnprocessableEntity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnprocessableEntity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnprocessableEntity" /> class.
        /// </summary>
        /// <param name="Errors">A list that displays all the missing properties. (required).</param>
        public UnprocessableEntity(List<string> Errors = default(List<string>))
        {
            // to ensure "Errors" is required (not null)
            if (Errors == null)
            {
                throw new InvalidDataException("Errors is a required property for UnprocessableEntity and cannot be null");
            }
            else
            {
                this.Errors = Errors;
            }
        }
        
        /// <summary>
        /// A list that displays all the missing properties.
        /// </summary>
        /// <value>A list that displays all the missing properties.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<string> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnprocessableEntity {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as UnprocessableEntity);
        }

        /// <summary>
        /// Returns true if UnprocessableEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of UnprocessableEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnprocessableEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Errors == input.Errors ||
                    (this.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors))
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
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
