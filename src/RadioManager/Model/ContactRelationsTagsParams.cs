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
    /// ContactRelationsTagsParams
    /// </summary>
    [DataContract]
        public partial class ContactRelationsTagsParams :  IEquatable<ContactRelationsTagsParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactRelationsTagsParams" /> class.
        /// </summary>
        /// <param name="contactId">contactId.</param>
        public ContactRelationsTagsParams(int? contactId = default(int?))
        {
            this.ContactId = contactId;
        }
        
        /// <summary>
        /// Gets or Sets ContactId
        /// </summary>
        [DataMember(Name="contact_id", EmitDefaultValue=false)]
        public int? ContactId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactRelationsTagsParams {\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
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
            return this.Equals(input as ContactRelationsTagsParams);
        }

        /// <summary>
        /// Returns true if ContactRelationsTagsParams instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactRelationsTagsParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactRelationsTagsParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContactId == input.ContactId ||
                    (this.ContactId != null &&
                    this.ContactId.Equals(input.ContactId))
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
                if (this.ContactId != null)
                    hashCode = hashCode * 59 + this.ContactId.GetHashCode();
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
