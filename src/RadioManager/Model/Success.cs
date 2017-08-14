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
    /// Success
    /// </summary>
    [DataContract]
    public partial class Success :  IEquatable<Success>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Success" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Success() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Success" /> class.
        /// </summary>
        /// <param name="_Success">Describes whatever has succeeded (required).</param>
        public Success(string _Success = default(string))
        {
            // to ensure "_Success" is required (not null)
            if (_Success == null)
            {
                throw new InvalidDataException("_Success is a required property for Success and cannot be null");
            }
            else
            {
                this._Success = _Success;
            }
        }
        
        /// <summary>
        /// Describes whatever has succeeded
        /// </summary>
        /// <value>Describes whatever has succeeded</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public string _Success { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Success {\n");
            sb.Append("  _Success: ").Append(_Success).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Success);
        }

        /// <summary>
        /// Returns true if Success instances are equal
        /// </summary>
        /// <param name="other">Instance of Success to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Success other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Success == other._Success ||
                    this._Success != null &&
                    this._Success.Equals(other._Success)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this._Success != null)
                    hash = hash * 59 + this._Success.GetHashCode();
                return hash;
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
