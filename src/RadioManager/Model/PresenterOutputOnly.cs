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
    /// PresenterOutputOnly
    /// </summary>
    [DataContract]
    public partial class PresenterOutputOnly :  IEquatable<PresenterOutputOnly>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PresenterOutputOnly" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PresenterOutputOnly() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PresenterOutputOnly" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="UpdatedAt">UpdatedAt (required).</param>
        /// <param name="CreatedAt">CreatedAt (required).</param>
        /// <param name="DeletedAt">DeletedAt (required).</param>
        /// <param name="ExternalStationId">ExternalStationId.</param>
        public PresenterOutputOnly(long? Id = default(long?), DateTime? UpdatedAt = default(DateTime?), DateTime? CreatedAt = default(DateTime?), DateTime? DeletedAt = default(DateTime?), long? ExternalStationId = default(long?))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for PresenterOutputOnly and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "UpdatedAt" is required (not null)
            if (UpdatedAt == null)
            {
                throw new InvalidDataException("UpdatedAt is a required property for PresenterOutputOnly and cannot be null");
            }
            else
            {
                this.UpdatedAt = UpdatedAt;
            }
            // to ensure "CreatedAt" is required (not null)
            if (CreatedAt == null)
            {
                throw new InvalidDataException("CreatedAt is a required property for PresenterOutputOnly and cannot be null");
            }
            else
            {
                this.CreatedAt = CreatedAt;
            }
            // to ensure "DeletedAt" is required (not null)
            if (DeletedAt == null)
            {
                throw new InvalidDataException("DeletedAt is a required property for PresenterOutputOnly and cannot be null");
            }
            else
            {
                this.DeletedAt = DeletedAt;
            }
            this.ExternalStationId = ExternalStationId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PresenterOutputOnly {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
            sb.Append("  ExternalStationId: ").Append(ExternalStationId).Append("\n");
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
            return this.Equals(obj as PresenterOutputOnly);
        }

        /// <summary>
        /// Returns true if PresenterOutputOnly instances are equal
        /// </summary>
        /// <param name="other">Instance of PresenterOutputOnly to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PresenterOutputOnly other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.DeletedAt == other.DeletedAt ||
                    this.DeletedAt != null &&
                    this.DeletedAt.Equals(other.DeletedAt)
                ) && 
                (
                    this.ExternalStationId == other.ExternalStationId ||
                    this.ExternalStationId != null &&
                    this.ExternalStationId.Equals(other.ExternalStationId)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.DeletedAt != null)
                    hash = hash * 59 + this.DeletedAt.GetHashCode();
                if (this.ExternalStationId != null)
                    hash = hash * 59 + this.ExternalStationId.GetHashCode();
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
