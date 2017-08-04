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
    /// BroadcastInputOnly
    /// </summary>
    [DataContract]
    public partial class BroadcastInputOnly :  IEquatable<BroadcastInputOnly>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcastInputOnly" /> class.
        /// </summary>
        /// <param name="Tags">Tags.</param>
        /// <param name="Presenters">Presenters.</param>
        public BroadcastInputOnly(List<int?> Tags = default(List<int?>), List<int?> Presenters = default(List<int?>))
        {
            this.Tags = Tags;
            this.Presenters = Presenters;
        }
        
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<int?> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Presenters
        /// </summary>
        [DataMember(Name="presenters", EmitDefaultValue=false)]
        public List<int?> Presenters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BroadcastInputOnly {\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Presenters: ").Append(Presenters).Append("\n");
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
            return this.Equals(input as BroadcastInputOnly);
        }

        /// <summary>
        /// Returns true if BroadcastInputOnly instances are equal
        /// </summary>
        /// <param name="input">Instance of BroadcastInputOnly to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BroadcastInputOnly input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags))
                ) && 
                (
                    this.Presenters == input.Presenters ||
                    (this.Presenters != null &&
                    this.Presenters.SequenceEqual(input.Presenters))
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
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Presenters != null)
                    hashCode = hashCode * 59 + this.Presenters.GetHashCode();
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
