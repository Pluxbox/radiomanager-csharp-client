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
    /// ProgramRelationsItemsParams
    /// </summary>
    [DataContract]
    public partial class ProgramRelationsItemsParams :  IEquatable<ProgramRelationsItemsParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramRelationsItemsParams" /> class.
        /// </summary>
        /// <param name="ProgramId">ProgramId.</param>
        public ProgramRelationsItemsParams(int? ProgramId = default(int?))
        {
            this.ProgramId = ProgramId;
        }
        
        /// <summary>
        /// Gets or Sets ProgramId
        /// </summary>
        [DataMember(Name="program_id", EmitDefaultValue=false)]
        public int? ProgramId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProgramRelationsItemsParams {\n");
            sb.Append("  ProgramId: ").Append(ProgramId).Append("\n");
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
            return this.Equals(obj as ProgramRelationsItemsParams);
        }

        /// <summary>
        /// Returns true if ProgramRelationsItemsParams instances are equal
        /// </summary>
        /// <param name="other">Instance of ProgramRelationsItemsParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProgramRelationsItemsParams other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ProgramId == other.ProgramId ||
                    this.ProgramId != null &&
                    this.ProgramId.Equals(other.ProgramId)
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
                if (this.ProgramId != null)
                    hash = hash * 59 + this.ProgramId.GetHashCode();
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
