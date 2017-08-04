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
    /// TagRelationsBroadcastsParams
    /// </summary>
    [DataContract]
    public partial class TagRelationsBroadcastsParams :  IEquatable<TagRelationsBroadcastsParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagRelationsBroadcastsParams" /> class.
        /// </summary>
        /// <param name="TagId">TagId.</param>
        public TagRelationsBroadcastsParams(int? TagId = default(int?))
        {
            this.TagId = TagId;
        }
        
        /// <summary>
        /// Gets or Sets TagId
        /// </summary>
        [DataMember(Name="tag_id", EmitDefaultValue=false)]
        public int? TagId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TagRelationsBroadcastsParams {\n");
            sb.Append("  TagId: ").Append(TagId).Append("\n");
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
            return this.Equals(input as TagRelationsBroadcastsParams);
        }

        /// <summary>
        /// Returns true if TagRelationsBroadcastsParams instances are equal
        /// </summary>
        /// <param name="input">Instance of TagRelationsBroadcastsParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TagRelationsBroadcastsParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TagId == input.TagId ||
                    (this.TagId != null &&
                    this.TagId.Equals(input.TagId))
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
                if (this.TagId != null)
                    hashCode = hashCode * 59 + this.TagId.GetHashCode();
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
