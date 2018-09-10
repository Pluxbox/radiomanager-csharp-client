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
    /// BroadcastEPGDay
    /// </summary>
    [DataContract]
    public partial class BroadcastEPGDay :  IEquatable<BroadcastEPGDay>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcastEPGDay" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BroadcastEPGDay() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcastEPGDay" /> class.
        /// </summary>
        /// <param name="Day">Day.</param>
        /// <param name="Results">Results (required).</param>
        public BroadcastEPGDay(DateTime? Day = default(DateTime?), List<BroadcastEPGResult> Results = default(List<BroadcastEPGResult>))
        {
            // to ensure "Results" is required (not null)
            if (Results == null)
            {
                throw new InvalidDataException("Results is a required property for BroadcastEPGDay and cannot be null");
            }
            else
            {
                this.Results = Results;
            }
            this.Day = Day;
        }
        
        /// <summary>
        /// Gets or Sets Day
        /// </summary>
        [DataMember(Name="day", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Day { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<BroadcastEPGResult> Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BroadcastEPGDay {\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(input as BroadcastEPGDay);
        }

        /// <summary>
        /// Returns true if BroadcastEPGDay instances are equal
        /// </summary>
        /// <param name="input">Instance of BroadcastEPGDay to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BroadcastEPGDay input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Day == input.Day ||
                    (this.Day != null &&
                    this.Day.Equals(input.Day))
                ) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(input.Results)
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
                if (this.Day != null)
                    hashCode = hashCode * 59 + this.Day.GetHashCode();
                if (this.Results != null)
                    hashCode = hashCode * 59 + this.Results.GetHashCode();
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
