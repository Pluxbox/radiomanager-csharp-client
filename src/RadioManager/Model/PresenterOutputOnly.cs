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
        /// <param name="id">id (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="deletedAt">deletedAt (required).</param>
        /// <param name="externalStationId">externalStationId.</param>
        public PresenterOutputOnly(long? id = default(long?), DateTime? updatedAt = default(DateTime?), DateTime? createdAt = default(DateTime?), DateTime? deletedAt = default(DateTime?), long? externalStationId = default(long?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for PresenterOutputOnly and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "updatedAt" is required (not null)
            if (updatedAt == null)
            {
                throw new InvalidDataException("updatedAt is a required property for PresenterOutputOnly and cannot be null");
            }
            else
            {
                this.UpdatedAt = updatedAt;
            }
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for PresenterOutputOnly and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            // to ensure "deletedAt" is required (not null)
            if (deletedAt == null)
            {
                throw new InvalidDataException("deletedAt is a required property for PresenterOutputOnly and cannot be null");
            }
            else
            {
                this.DeletedAt = deletedAt;
            }
            this.ExternalStationId = externalStationId;
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
            return this.Equals(input as PresenterOutputOnly);
        }

        /// <summary>
        /// Returns true if PresenterOutputOnly instances are equal
        /// </summary>
        /// <param name="input">Instance of PresenterOutputOnly to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PresenterOutputOnly input)
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
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.DeletedAt != null)
                    hashCode = hashCode * 59 + this.DeletedAt.GetHashCode();
                if (this.ExternalStationId != null)
                    hashCode = hashCode * 59 + this.ExternalStationId.GetHashCode();
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
