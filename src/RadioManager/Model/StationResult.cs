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
    /// StationResult
    /// </summary>
    [DataContract]
        public partial class StationResult :  IEquatable<StationResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StationResult" /> class.
        /// </summary>
        /// <param name="station">station.</param>
        public StationResult(Object station = default(Object))
        {
            this.Station = station;
        }
        
        /// <summary>
        /// Gets or Sets Station
        /// </summary>
        [DataMember(Name="station", EmitDefaultValue=false)]
        public Object Station { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StationResult {\n");
            sb.Append("  Station: ").Append(Station).Append("\n");
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
            return this.Equals(input as StationResult);
        }

        /// <summary>
        /// Returns true if StationResult instances are equal
        /// </summary>
        /// <param name="input">Instance of StationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StationResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Station == input.Station ||
                    (this.Station != null &&
                    this.Station.Equals(input.Station))
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
                if (this.Station != null)
                    hashCode = hashCode * 59 + this.Station.GetHashCode();
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
