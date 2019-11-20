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
    /// BroadcastRelationsItemsParams
    /// </summary>
    [DataContract]
    public partial class BroadcastRelationsItemsParams :  IEquatable<BroadcastRelationsItemsParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcastRelationsItemsParams" /> class.
        /// </summary>
        /// <param name="BroadcastId">BroadcastId.</param>
        public BroadcastRelationsItemsParams(int? BroadcastId = default(int?))
        {
            this.BroadcastId = BroadcastId;
        }
        
        /// <summary>
        /// Gets or Sets BroadcastId
        /// </summary>
        [DataMember(Name="broadcast_id", EmitDefaultValue=false)]
        public int? BroadcastId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BroadcastRelationsItemsParams {\n");
            sb.Append("  BroadcastId: ").Append(BroadcastId).Append("\n");
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
            return this.Equals(input as BroadcastRelationsItemsParams);
        }

        /// <summary>
        /// Returns true if BroadcastRelationsItemsParams instances are equal
        /// </summary>
        /// <param name="input">Instance of BroadcastRelationsItemsParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BroadcastRelationsItemsParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BroadcastId == input.BroadcastId ||
                    (this.BroadcastId != null &&
                    this.BroadcastId.Equals(input.BroadcastId))
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
                if (this.BroadcastId != null)
                    hashCode = hashCode * 59 + this.BroadcastId.GetHashCode();
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
