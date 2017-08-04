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
    /// Broadcast
    /// </summary>
    [DataContract]
    public partial class Broadcast :  IEquatable<Broadcast>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets RepetitionType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RepetitionTypeEnum
        {
            
            /// <summary>
            /// Enum _1week for "1 week"
            /// </summary>
            [EnumMember(Value = "1 week")]
            _1week,
            
            /// <summary>
            /// Enum _2weeks for "2 weeks"
            /// </summary>
            [EnumMember(Value = "2 weeks")]
            _2weeks,
            
            /// <summary>
            /// Enum _4weeks for "4 weeks"
            /// </summary>
            [EnumMember(Value = "4 weeks")]
            _4weeks,
            
            /// <summary>
            /// Enum _1month for "1 month"
            /// </summary>
            [EnumMember(Value = "1 month")]
            _1month
        }

        /// <summary>
        /// Gets or Sets RepetitionType
        /// </summary>
        [DataMember(Name="repetition_type", EmitDefaultValue=false)]
        public RepetitionTypeEnum? RepetitionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Broadcast" /> class.
        /// </summary>
        /// <param name="ProgramId">ProgramId.</param>
        /// <param name="ModelTypeId">ModelTypeId.</param>
        /// <param name="StationId">StationId.</param>
        /// <param name="FieldValues">FieldValues.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Start">Start.</param>
        /// <param name="Stop">Stop.</param>
        /// <param name="GenreId">GenreId.</param>
        /// <param name="Description">Description.</param>
        /// <param name="ShortName">ShortName.</param>
        /// <param name="MediumName">MediumName.</param>
        /// <param name="Website">Website.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Recommended">Recommended.</param>
        /// <param name="Language">Language.</param>
        /// <param name="Published">Published.</param>
        /// <param name="RepetitionUid">RepetitionUid.</param>
        /// <param name="RepetitionType">RepetitionType.</param>
        /// <param name="RepetitionEnd">RepetitionEnd.</param>
        /// <param name="RepetitionStart">RepetitionStart.</param>
        /// <param name="RepetitionDays">RepetitionDays.</param>
        /// <param name="PtyCodeId">PtyCodeId.</param>
        public Broadcast(long? ProgramId = default(long?), long? ModelTypeId = default(long?), long? StationId = default(long?), BroadcastFieldValues FieldValues = default(BroadcastFieldValues), string Title = default(string), DateTime? Start = default(DateTime?), DateTime? Stop = default(DateTime?), long? GenreId = default(long?), string Description = default(string), string ShortName = default(string), string MediumName = default(string), string Website = default(string), string Email = default(string), bool? Recommended = default(bool?), string Language = default(string), bool? Published = default(bool?), string RepetitionUid = default(string), RepetitionTypeEnum? RepetitionType = default(RepetitionTypeEnum?), DateTime? RepetitionEnd = default(DateTime?), DateTime? RepetitionStart = default(DateTime?), string RepetitionDays = default(string), long? PtyCodeId = default(long?))
        {
            this.ProgramId = ProgramId;
            this.ModelTypeId = ModelTypeId;
            this.StationId = StationId;
            this.FieldValues = FieldValues;
            this.Title = Title;
            this.Start = Start;
            this.Stop = Stop;
            this.GenreId = GenreId;
            this.Description = Description;
            this.ShortName = ShortName;
            this.MediumName = MediumName;
            this.Website = Website;
            this.Email = Email;
            this.Recommended = Recommended;
            this.Language = Language;
            this.Published = Published;
            this.RepetitionUid = RepetitionUid;
            this.RepetitionType = RepetitionType;
            this.RepetitionEnd = RepetitionEnd;
            this.RepetitionStart = RepetitionStart;
            this.RepetitionDays = RepetitionDays;
            this.PtyCodeId = PtyCodeId;
        }
        
        /// <summary>
        /// Gets or Sets ProgramId
        /// </summary>
        [DataMember(Name="program_id", EmitDefaultValue=false)]
        public long? ProgramId { get; set; }

        /// <summary>
        /// Gets or Sets ModelTypeId
        /// </summary>
        [DataMember(Name="model_type_id", EmitDefaultValue=false)]
        public long? ModelTypeId { get; set; }

        /// <summary>
        /// Gets or Sets StationId
        /// </summary>
        [DataMember(Name="station_id", EmitDefaultValue=false)]
        public long? StationId { get; set; }

        /// <summary>
        /// Gets or Sets FieldValues
        /// </summary>
        [DataMember(Name="field_values", EmitDefaultValue=false)]
        public BroadcastFieldValues FieldValues { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public DateTime? Start { get; set; }

        /// <summary>
        /// Gets or Sets Stop
        /// </summary>
        [DataMember(Name="stop", EmitDefaultValue=false)]
        public DateTime? Stop { get; set; }

        /// <summary>
        /// Gets or Sets GenreId
        /// </summary>
        [DataMember(Name="genre_id", EmitDefaultValue=false)]
        public long? GenreId { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ShortName
        /// </summary>
        [DataMember(Name="short_name", EmitDefaultValue=false)]
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or Sets MediumName
        /// </summary>
        [DataMember(Name="medium_name", EmitDefaultValue=false)]
        public string MediumName { get; set; }

        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name="website", EmitDefaultValue=false)]
        public string Website { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Recommended
        /// </summary>
        [DataMember(Name="recommended", EmitDefaultValue=false)]
        public bool? Recommended { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets Published
        /// </summary>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public bool? Published { get; set; }

        /// <summary>
        /// Gets or Sets RepetitionUid
        /// </summary>
        [DataMember(Name="repetition_uid", EmitDefaultValue=false)]
        public string RepetitionUid { get; set; }


        /// <summary>
        /// Gets or Sets RepetitionEnd
        /// </summary>
        [DataMember(Name="repetition_end", EmitDefaultValue=false)]
        public DateTime? RepetitionEnd { get; set; }

        /// <summary>
        /// Gets or Sets RepetitionStart
        /// </summary>
        [DataMember(Name="repetition_start", EmitDefaultValue=false)]
        public DateTime? RepetitionStart { get; set; }

        /// <summary>
        /// Gets or Sets RepetitionDays
        /// </summary>
        [DataMember(Name="repetition_days", EmitDefaultValue=false)]
        public string RepetitionDays { get; set; }

        /// <summary>
        /// Gets or Sets PtyCodeId
        /// </summary>
        [DataMember(Name="pty_code_id", EmitDefaultValue=false)]
        public long? PtyCodeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Broadcast {\n");
            sb.Append("  ProgramId: ").Append(ProgramId).Append("\n");
            sb.Append("  ModelTypeId: ").Append(ModelTypeId).Append("\n");
            sb.Append("  StationId: ").Append(StationId).Append("\n");
            sb.Append("  FieldValues: ").Append(FieldValues).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  Stop: ").Append(Stop).Append("\n");
            sb.Append("  GenreId: ").Append(GenreId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  MediumName: ").Append(MediumName).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Recommended: ").Append(Recommended).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  RepetitionUid: ").Append(RepetitionUid).Append("\n");
            sb.Append("  RepetitionType: ").Append(RepetitionType).Append("\n");
            sb.Append("  RepetitionEnd: ").Append(RepetitionEnd).Append("\n");
            sb.Append("  RepetitionStart: ").Append(RepetitionStart).Append("\n");
            sb.Append("  RepetitionDays: ").Append(RepetitionDays).Append("\n");
            sb.Append("  PtyCodeId: ").Append(PtyCodeId).Append("\n");
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
            return this.Equals(obj as Broadcast);
        }

        /// <summary>
        /// Returns true if Broadcast instances are equal
        /// </summary>
        /// <param name="other">Instance of Broadcast to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Broadcast other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ProgramId == other.ProgramId ||
                    this.ProgramId != null &&
                    this.ProgramId.Equals(other.ProgramId)
                ) && 
                (
                    this.ModelTypeId == other.ModelTypeId ||
                    this.ModelTypeId != null &&
                    this.ModelTypeId.Equals(other.ModelTypeId)
                ) && 
                (
                    this.StationId == other.StationId ||
                    this.StationId != null &&
                    this.StationId.Equals(other.StationId)
                ) && 
                (
                    this.FieldValues == other.FieldValues ||
                    this.FieldValues != null &&
                    this.FieldValues.Equals(other.FieldValues)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Start == other.Start ||
                    this.Start != null &&
                    this.Start.Equals(other.Start)
                ) && 
                (
                    this.Stop == other.Stop ||
                    this.Stop != null &&
                    this.Stop.Equals(other.Stop)
                ) && 
                (
                    this.GenreId == other.GenreId ||
                    this.GenreId != null &&
                    this.GenreId.Equals(other.GenreId)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.ShortName == other.ShortName ||
                    this.ShortName != null &&
                    this.ShortName.Equals(other.ShortName)
                ) && 
                (
                    this.MediumName == other.MediumName ||
                    this.MediumName != null &&
                    this.MediumName.Equals(other.MediumName)
                ) && 
                (
                    this.Website == other.Website ||
                    this.Website != null &&
                    this.Website.Equals(other.Website)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Recommended == other.Recommended ||
                    this.Recommended != null &&
                    this.Recommended.Equals(other.Recommended)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.Published == other.Published ||
                    this.Published != null &&
                    this.Published.Equals(other.Published)
                ) && 
                (
                    this.RepetitionUid == other.RepetitionUid ||
                    this.RepetitionUid != null &&
                    this.RepetitionUid.Equals(other.RepetitionUid)
                ) && 
                (
                    this.RepetitionType == other.RepetitionType ||
                    this.RepetitionType != null &&
                    this.RepetitionType.Equals(other.RepetitionType)
                ) && 
                (
                    this.RepetitionEnd == other.RepetitionEnd ||
                    this.RepetitionEnd != null &&
                    this.RepetitionEnd.Equals(other.RepetitionEnd)
                ) && 
                (
                    this.RepetitionStart == other.RepetitionStart ||
                    this.RepetitionStart != null &&
                    this.RepetitionStart.Equals(other.RepetitionStart)
                ) && 
                (
                    this.RepetitionDays == other.RepetitionDays ||
                    this.RepetitionDays != null &&
                    this.RepetitionDays.Equals(other.RepetitionDays)
                ) && 
                (
                    this.PtyCodeId == other.PtyCodeId ||
                    this.PtyCodeId != null &&
                    this.PtyCodeId.Equals(other.PtyCodeId)
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
                if (this.ModelTypeId != null)
                    hash = hash * 59 + this.ModelTypeId.GetHashCode();
                if (this.StationId != null)
                    hash = hash * 59 + this.StationId.GetHashCode();
                if (this.FieldValues != null)
                    hash = hash * 59 + this.FieldValues.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Start != null)
                    hash = hash * 59 + this.Start.GetHashCode();
                if (this.Stop != null)
                    hash = hash * 59 + this.Stop.GetHashCode();
                if (this.GenreId != null)
                    hash = hash * 59 + this.GenreId.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.ShortName != null)
                    hash = hash * 59 + this.ShortName.GetHashCode();
                if (this.MediumName != null)
                    hash = hash * 59 + this.MediumName.GetHashCode();
                if (this.Website != null)
                    hash = hash * 59 + this.Website.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Recommended != null)
                    hash = hash * 59 + this.Recommended.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.Published != null)
                    hash = hash * 59 + this.Published.GetHashCode();
                if (this.RepetitionUid != null)
                    hash = hash * 59 + this.RepetitionUid.GetHashCode();
                if (this.RepetitionType != null)
                    hash = hash * 59 + this.RepetitionType.GetHashCode();
                if (this.RepetitionEnd != null)
                    hash = hash * 59 + this.RepetitionEnd.GetHashCode();
                if (this.RepetitionStart != null)
                    hash = hash * 59 + this.RepetitionStart.GetHashCode();
                if (this.RepetitionDays != null)
                    hash = hash * 59 + this.RepetitionDays.GetHashCode();
                if (this.PtyCodeId != null)
                    hash = hash * 59 + this.PtyCodeId.GetHashCode();
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
            // PtyCodeId (long?) minimum
            if(this.PtyCodeId < (long?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PtyCodeId, must be a value greater than or equal to 1.", new [] { "PtyCodeId" });
            }

            yield break;
        }
    }

}
