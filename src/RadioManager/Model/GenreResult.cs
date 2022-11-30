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
    /// GenreResult
    /// </summary>
    [DataContract]
        public partial class GenreResult : Genre,  IEquatable<GenreResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenreResult" /> class.
        /// </summary>
        /// <param name="broadcasts">broadcasts.</param>
        /// <param name="programs">programs.</param>
        /// <param name="externalStationId">externalStationId.</param>
        public GenreResult(GenreRelationsBroadcasts broadcasts = default(GenreRelationsBroadcasts), GenreRelationsPrograms programs = default(GenreRelationsPrograms), long? externalStationId = default(long?), GenreRelationsBroadcasts broadcasts = default(GenreRelationsBroadcasts), GenreRelationsPrograms programs = default(GenreRelationsPrograms), long? externalStationId = default(long?), long? id = default(long?), string urn = default(string), long? parentId = default(long?), string name = default(string)) : base(id, urn, parentId, name)
        {
            this.Broadcasts = broadcasts;
            this.Programs = programs;
            this.ExternalStationId = externalStationId;
        }
        
        /// <summary>
        /// Gets or Sets Broadcasts
        /// </summary>
        [DataMember(Name="broadcasts", EmitDefaultValue=false)]
        public GenreRelationsBroadcasts Broadcasts { get; set; }

        /// <summary>
        /// Gets or Sets Programs
        /// </summary>
        [DataMember(Name="programs", EmitDefaultValue=false)]
        public GenreRelationsPrograms Programs { get; set; }

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
            sb.Append("class GenreResult {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Broadcasts: ").Append(Broadcasts).Append("\n");
            sb.Append("  Programs: ").Append(Programs).Append("\n");
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
            return this.Equals(input as GenreResult);
        }

        /// <summary>
        /// Returns true if GenreResult instances are equal
        /// </summary>
        /// <param name="input">Instance of GenreResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenreResult input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Broadcasts == input.Broadcasts ||
                    (this.Broadcasts != null &&
                    this.Broadcasts.Equals(input.Broadcasts))
                ) && base.Equals(input) && 
                (
                    this.Programs == input.Programs ||
                    (this.Programs != null &&
                    this.Programs.Equals(input.Programs))
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
                if (this.Broadcasts != null)
                    hashCode = hashCode * 59 + this.Broadcasts.GetHashCode();
                if (this.Programs != null)
                    hashCode = hashCode * 59 + this.Programs.GetHashCode();
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
