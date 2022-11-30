/* 
 * RadioManager
 *
 * This OpenAPI 3 Document describes the functionality of the API v2 of RadioManager. Note that no rights can be derived from this Document and the true functionality of the API might differ.
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
    /// ItemInputOnly
    /// </summary>
    [DataContract]
        public partial class ItemInputOnly :  IEquatable<ItemInputOnly>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemInputOnly" /> class.
        /// </summary>
        /// <param name="previousId">previousId.</param>
        /// <param name="beforeId">beforeId.</param>
        /// <param name="contacts">contacts.</param>
        /// <param name="tags">tags.</param>
        public ItemInputOnly(long? previousId = default(long?), long? beforeId = default(long?), List<int?> contacts = default(List<int?>), List<int?> tags = default(List<int?>))
        {
            this.PreviousId = previousId;
            this.BeforeId = beforeId;
            this.Contacts = contacts;
            this.Tags = tags;
        }
        
        /// <summary>
        /// Gets or Sets PreviousId
        /// </summary>
        [DataMember(Name="_previous_id", EmitDefaultValue=false)]
        public long? PreviousId { get; set; }

        /// <summary>
        /// Gets or Sets BeforeId
        /// </summary>
        [DataMember(Name="_before_id", EmitDefaultValue=false)]
        public long? BeforeId { get; set; }

        /// <summary>
        /// Gets or Sets Contacts
        /// </summary>
        [DataMember(Name="contacts", EmitDefaultValue=false)]
        public List<int?> Contacts { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<int?> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemInputOnly {\n");
            sb.Append("  PreviousId: ").Append(PreviousId).Append("\n");
            sb.Append("  BeforeId: ").Append(BeforeId).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(input as ItemInputOnly);
        }

        /// <summary>
        /// Returns true if ItemInputOnly instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemInputOnly to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemInputOnly input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PreviousId == input.PreviousId ||
                    (this.PreviousId != null &&
                    this.PreviousId.Equals(input.PreviousId))
                ) && 
                (
                    this.BeforeId == input.BeforeId ||
                    (this.BeforeId != null &&
                    this.BeforeId.Equals(input.BeforeId))
                ) && 
                (
                    this.Contacts == input.Contacts ||
                    this.Contacts != null &&
                    input.Contacts != null &&
                    this.Contacts.SequenceEqual(input.Contacts)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.PreviousId != null)
                    hashCode = hashCode * 59 + this.PreviousId.GetHashCode();
                if (this.BeforeId != null)
                    hashCode = hashCode * 59 + this.BeforeId.GetHashCode();
                if (this.Contacts != null)
                    hashCode = hashCode * 59 + this.Contacts.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
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
