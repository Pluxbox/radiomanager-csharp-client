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
    /// PresenterEPGResult
    /// </summary>
    [DataContract]
        public partial class PresenterEPGResult : Presenter,  IEquatable<PresenterEPGResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PresenterEPGResult" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="deletedAt">deletedAt (required).</param>
        /// <param name="externalStationId">externalStationId.</param>
        public PresenterEPGResult(long? id = default(long?), DateTime? updatedAt = default(DateTime?), DateTime? createdAt = default(DateTime?), DateTime? deletedAt = default(DateTime?), long? externalStationId = default(long?), long? id = default(long?), DateTime? updatedAt = default(DateTime?), DateTime? createdAt = default(DateTime?), long? externalStationId = default(long?), long? modelTypeId = default(long?), Object fieldValues = default(Object), string firstname = default(string), string lastname = default(string), bool? active = default(bool?), string name = default(string)) : base(modelTypeId, fieldValues, firstname, lastname, active, name)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for PresenterEPGResult and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "updatedAt" is required (not null)
            if (updatedAt == null)
            {
                throw new InvalidDataException("updatedAt is a required property for PresenterEPGResult and cannot be null");
            }
            else
            {
                this.UpdatedAt = updatedAt;
            }
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for PresenterEPGResult and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            // to ensure "deletedAt" is required (not null)
            if (deletedAt == null)
            {
                throw new InvalidDataException("deletedAt is a required property for PresenterEPGResult and cannot be null");
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
            sb.Append("class PresenterEPGResult {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
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
            return this.Equals(input as PresenterEPGResult);
        }

        /// <summary>
        /// Returns true if PresenterEPGResult instances are equal
        /// </summary>
        /// <param name="input">Instance of PresenterEPGResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PresenterEPGResult input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && base.Equals(input) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && base.Equals(input) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && base.Equals(input) && 
                (
                    this.DeletedAt == input.DeletedAt ||
                    (this.DeletedAt != null &&
                    this.DeletedAt.Equals(input.DeletedAt))
                ) && base.Equals(input) && 
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
                int hashCode = base.GetHashCode();
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
