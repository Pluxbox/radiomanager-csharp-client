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
    /// ContactResult
    /// </summary>
    [DataContract]
        public partial class ContactResult : ContactOutputOnly,  IEquatable<ContactResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactResult" /> class.
        /// </summary>
        /// <param name="modelTypeId">modelTypeId (required).</param>
        /// <param name="fieldValues">fieldValues.</param>
        /// <param name="email">email.</param>
        /// <param name="firstname">firstname (required).</param>
        /// <param name="lastname">lastname (required).</param>
        /// <param name="phone">phone.</param>
        /// <param name="tags">tags (required).</param>
        /// <param name="items">items.</param>
        /// <param name="modelType">modelType.</param>
        public ContactResult(long? modelTypeId = default(long?), Object fieldValues = default(Object), string email = default(string), string firstname = default(string), string lastname = default(string), string phone = default(string), ContactRelationsTags tags = default(ContactRelationsTags), ContactRelationsItems items = default(ContactRelationsItems), BroadcastRelationsModelType modelType = default(BroadcastRelationsModelType), long? modelTypeId = default(long?), Object fieldValues = default(Object), string email = default(string), BroadcastRelationsModelType modelType = default(BroadcastRelationsModelType), long? id = default(long?), DateTime? createdAt = default(DateTime?), DateTime? updatedAt = default(DateTime?), DateTime? deletedAt = default(DateTime?), long? externalStationId = default(long?)) : base(id, createdAt, updatedAt, deletedAt, externalStationId)
        {
            // to ensure "modelTypeId" is required (not null)
            if (modelTypeId == null)
            {
                throw new InvalidDataException("modelTypeId is a required property for ContactResult and cannot be null");
            }
            else
            {
                this.ModelTypeId = modelTypeId;
            }
            // to ensure "firstname" is required (not null)
            if (firstname == null)
            {
                throw new InvalidDataException("firstname is a required property for ContactResult and cannot be null");
            }
            else
            {
                this.Firstname = firstname;
            }
            // to ensure "lastname" is required (not null)
            if (lastname == null)
            {
                throw new InvalidDataException("lastname is a required property for ContactResult and cannot be null");
            }
            else
            {
                this.Lastname = lastname;
            }
            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new InvalidDataException("tags is a required property for ContactResult and cannot be null");
            }
            else
            {
                this.Tags = tags;
            }
            this.FieldValues = fieldValues;
            this.Email = email;
            this.Phone = phone;
            this.Items = items;
            this.ModelType = modelType;
        }
        
        /// <summary>
        /// Gets or Sets ModelTypeId
        /// </summary>
        [DataMember(Name="model_type_id", EmitDefaultValue=false)]
        public long? ModelTypeId { get; set; }

        /// <summary>
        /// Gets or Sets FieldValues
        /// </summary>
        [DataMember(Name="field_values", EmitDefaultValue=false)]
        public Object FieldValues { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Firstname
        /// </summary>
        [DataMember(Name="firstname", EmitDefaultValue=false)]
        public string Firstname { get; set; }

        /// <summary>
        /// Gets or Sets Lastname
        /// </summary>
        [DataMember(Name="lastname", EmitDefaultValue=false)]
        public string Lastname { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public ContactRelationsTags Tags { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public ContactRelationsItems Items { get; set; }

        /// <summary>
        /// Gets or Sets ModelType
        /// </summary>
        [DataMember(Name="model_type", EmitDefaultValue=false)]
        public BroadcastRelationsModelType ModelType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactResult {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ModelTypeId: ").Append(ModelTypeId).Append("\n");
            sb.Append("  FieldValues: ").Append(FieldValues).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  Lastname: ").Append(Lastname).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  ModelType: ").Append(ModelType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as ContactResult);
        }

        /// <summary>
        /// Returns true if ContactResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactResult input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.ModelTypeId == input.ModelTypeId ||
                    (this.ModelTypeId != null &&
                    this.ModelTypeId.Equals(input.ModelTypeId))
                ) && base.Equals(input) && 
                (
                    this.FieldValues == input.FieldValues ||
                    (this.FieldValues != null &&
                    this.FieldValues.Equals(input.FieldValues))
                ) && base.Equals(input) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && base.Equals(input) && 
                (
                    this.Firstname == input.Firstname ||
                    (this.Firstname != null &&
                    this.Firstname.Equals(input.Firstname))
                ) && base.Equals(input) && 
                (
                    this.Lastname == input.Lastname ||
                    (this.Lastname != null &&
                    this.Lastname.Equals(input.Lastname))
                ) && base.Equals(input) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && base.Equals(input) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && base.Equals(input) && 
                (
                    this.Items == input.Items ||
                    (this.Items != null &&
                    this.Items.Equals(input.Items))
                ) && base.Equals(input) && 
                (
                    this.ModelType == input.ModelType ||
                    (this.ModelType != null &&
                    this.ModelType.Equals(input.ModelType))
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
                int hashCode = base.GetHashCode();
                if (this.ModelTypeId != null)
                    hashCode = hashCode * 59 + this.ModelTypeId.GetHashCode();
                if (this.FieldValues != null)
                    hashCode = hashCode * 59 + this.FieldValues.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Firstname != null)
                    hashCode = hashCode * 59 + this.Firstname.GetHashCode();
                if (this.Lastname != null)
                    hashCode = hashCode * 59 + this.Lastname.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.ModelType != null)
                    hashCode = hashCode * 59 + this.ModelType.GetHashCode();
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
