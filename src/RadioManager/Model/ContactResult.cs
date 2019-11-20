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
    /// ContactResult
    /// </summary>
    [DataContract]
    public partial class ContactResult :  IEquatable<ContactResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactResult" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="UpdatedAt">UpdatedAt.</param>
        /// <param name="DeletedAt">DeletedAt.</param>
        /// <param name="ExternalStationId">ExternalStationId.</param>
        /// <param name="ModelTypeId">ModelTypeId (required).</param>
        /// <param name="FieldValues">FieldValues.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Firstname">Firstname (required).</param>
        /// <param name="Lastname">Lastname (required).</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="Tags">Tags (required).</param>
        /// <param name="Items">Items.</param>
        /// <param name="ModelType">ModelType.</param>
        public ContactResult(long? Id = default(long?), DateTime? CreatedAt = default(DateTime?), DateTime? UpdatedAt = default(DateTime?), DateTime? DeletedAt = default(DateTime?), long? ExternalStationId = default(long?), long? ModelTypeId = default(long?), Object FieldValues = default(Object), string Email = default(string), string Firstname = default(string), string Lastname = default(string), string Phone = default(string), ContactRelationsTags Tags = default(ContactRelationsTags), ContactRelationsItems Items = default(ContactRelationsItems), BroadcastRelationsModelType ModelType = default(BroadcastRelationsModelType))
        {
            // to ensure "ModelTypeId" is required (not null)
            if (ModelTypeId == null)
            {
                throw new InvalidDataException("ModelTypeId is a required property for ContactResult and cannot be null");
            }
            else
            {
                this.ModelTypeId = ModelTypeId;
            }
            // to ensure "Firstname" is required (not null)
            if (Firstname == null)
            {
                throw new InvalidDataException("Firstname is a required property for ContactResult and cannot be null");
            }
            else
            {
                this.Firstname = Firstname;
            }
            // to ensure "Lastname" is required (not null)
            if (Lastname == null)
            {
                throw new InvalidDataException("Lastname is a required property for ContactResult and cannot be null");
            }
            else
            {
                this.Lastname = Lastname;
            }
            // to ensure "Tags" is required (not null)
            if (Tags == null)
            {
                throw new InvalidDataException("Tags is a required property for ContactResult and cannot be null");
            }
            else
            {
                this.Tags = Tags;
            }
            this.Id = Id;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
            this.DeletedAt = DeletedAt;
            this.ExternalStationId = ExternalStationId;
            this.FieldValues = FieldValues;
            this.Email = Email;
            this.Phone = Phone;
            this.Items = Items;
            this.ModelType = ModelType;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets DeletedAt
        /// </summary>
        [DataMember(Name="deleted_at", EmitDefaultValue=false)]
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Gets or Sets ExternalStationId
        /// </summary>
        [DataMember(Name="_external_station_id", EmitDefaultValue=false)]
        public long? ExternalStationId { get; set; }

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
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
            sb.Append("  ExternalStationId: ").Append(ExternalStationId).Append("\n");
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

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.DeletedAt == input.DeletedAt ||
                    (this.DeletedAt != null &&
                    this.DeletedAt.Equals(input.DeletedAt))
                ) && 
                (
                    this.ExternalStationId == input.ExternalStationId ||
                    (this.ExternalStationId != null &&
                    this.ExternalStationId.Equals(input.ExternalStationId))
                ) && 
                (
                    this.ModelTypeId == input.ModelTypeId ||
                    (this.ModelTypeId != null &&
                    this.ModelTypeId.Equals(input.ModelTypeId))
                ) && 
                (
                    this.FieldValues == input.FieldValues ||
                    (this.FieldValues != null &&
                    this.FieldValues.Equals(input.FieldValues))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Firstname == input.Firstname ||
                    (this.Firstname != null &&
                    this.Firstname.Equals(input.Firstname))
                ) && 
                (
                    this.Lastname == input.Lastname ||
                    (this.Lastname != null &&
                    this.Lastname.Equals(input.Lastname))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.Items == input.Items ||
                    (this.Items != null &&
                    this.Items.Equals(input.Items))
                ) && 
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
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.DeletedAt != null)
                    hashCode = hashCode * 59 + this.DeletedAt.GetHashCode();
                if (this.ExternalStationId != null)
                    hashCode = hashCode * 59 + this.ExternalStationId.GetHashCode();
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
