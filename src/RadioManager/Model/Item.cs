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
    /// Item
    /// </summary>
    [DataContract]
    public partial class Item :  IEquatable<Item>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Scheduled for "scheduled"
            /// </summary>
            [EnumMember(Value = "scheduled")]
            Scheduled,
            
            /// <summary>
            /// Enum Playing for "playing"
            /// </summary>
            [EnumMember(Value = "playing")]
            Playing,
            
            /// <summary>
            /// Enum Played for "played"
            /// </summary>
            [EnumMember(Value = "played")]
            Played
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Item" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Item() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Item" /> class.
        /// </summary>
        /// <param name="ModelTypeId">ModelTypeId (required).</param>
        /// <param name="BlockId">BlockId.</param>
        /// <param name="ExternalId">ExternalId.</param>
        /// <param name="FieldValues">FieldValues.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Duration">Duration.</param>
        /// <param name="Start">Start.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Import">Import.</param>
        /// <param name="CampaignId">CampaignId.</param>
        /// <param name="Recommended">Recommended.</param>
        /// <param name="StationDraftId">StationDraftId.</param>
        /// <param name="ProgramDraftId">ProgramDraftId.</param>
        /// <param name="UserDraftId">UserDraftId.</param>
        /// <param name="StaticStart">StaticStart.</param>
        /// <param name="Details">Details.</param>
        public Item(long? ModelTypeId = default(long?), long? BlockId = default(long?), string ExternalId = default(string), ImportItemFieldValues FieldValues = default(ImportItemFieldValues), string Title = default(string), long? Duration = default(long?), DateTime? Start = default(DateTime?), StatusEnum? Status = default(StatusEnum?), long? Import = default(long?), long? CampaignId = default(long?), bool? Recommended = default(bool?), long? StationDraftId = default(long?), long? ProgramDraftId = default(long?), long? UserDraftId = default(long?), bool? StaticStart = default(bool?), string Details = default(string))
        {
            // to ensure "ModelTypeId" is required (not null)
            if (ModelTypeId == null)
            {
                throw new InvalidDataException("ModelTypeId is a required property for Item and cannot be null");
            }
            else
            {
                this.ModelTypeId = ModelTypeId;
            }
            this.BlockId = BlockId;
            this.ExternalId = ExternalId;
            this.FieldValues = FieldValues;
            this.Title = Title;
            this.Duration = Duration;
            this.Start = Start;
            this.Status = Status;
            this.Import = Import;
            this.CampaignId = CampaignId;
            this.Recommended = Recommended;
            this.StationDraftId = StationDraftId;
            this.ProgramDraftId = ProgramDraftId;
            this.UserDraftId = UserDraftId;
            this.StaticStart = StaticStart;
            this.Details = Details;
        }
        
        /// <summary>
        /// Gets or Sets ModelTypeId
        /// </summary>
        [DataMember(Name="model_type_id", EmitDefaultValue=false)]
        public long? ModelTypeId { get; set; }

        /// <summary>
        /// Gets or Sets BlockId
        /// </summary>
        [DataMember(Name="block_id", EmitDefaultValue=false)]
        public long? BlockId { get; set; }

        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name="external_id", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets FieldValues
        /// </summary>
        [DataMember(Name="field_values", EmitDefaultValue=false)]
        public ImportItemFieldValues FieldValues { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public DateTime? Start { get; set; }


        /// <summary>
        /// Gets or Sets Import
        /// </summary>
        [DataMember(Name="import", EmitDefaultValue=false)]
        public long? Import { get; set; }

        /// <summary>
        /// Gets or Sets CampaignId
        /// </summary>
        [DataMember(Name="campaign_id", EmitDefaultValue=false)]
        public long? CampaignId { get; set; }

        /// <summary>
        /// Gets or Sets Recommended
        /// </summary>
        [DataMember(Name="recommended", EmitDefaultValue=false)]
        public bool? Recommended { get; set; }

        /// <summary>
        /// Gets or Sets StationDraftId
        /// </summary>
        [DataMember(Name="station_draft_id", EmitDefaultValue=false)]
        public long? StationDraftId { get; set; }

        /// <summary>
        /// Gets or Sets ProgramDraftId
        /// </summary>
        [DataMember(Name="program_draft_id", EmitDefaultValue=false)]
        public long? ProgramDraftId { get; set; }

        /// <summary>
        /// Gets or Sets UserDraftId
        /// </summary>
        [DataMember(Name="user_draft_id", EmitDefaultValue=false)]
        public long? UserDraftId { get; set; }

        /// <summary>
        /// Gets or Sets StaticStart
        /// </summary>
        [DataMember(Name="static_start", EmitDefaultValue=false)]
        public bool? StaticStart { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public string Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Item {\n");
            sb.Append("  ModelTypeId: ").Append(ModelTypeId).Append("\n");
            sb.Append("  BlockId: ").Append(BlockId).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  FieldValues: ").Append(FieldValues).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Import: ").Append(Import).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  Recommended: ").Append(Recommended).Append("\n");
            sb.Append("  StationDraftId: ").Append(StationDraftId).Append("\n");
            sb.Append("  ProgramDraftId: ").Append(ProgramDraftId).Append("\n");
            sb.Append("  UserDraftId: ").Append(UserDraftId).Append("\n");
            sb.Append("  StaticStart: ").Append(StaticStart).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(obj as Item);
        }

        /// <summary>
        /// Returns true if Item instances are equal
        /// </summary>
        /// <param name="other">Instance of Item to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Item other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ModelTypeId == other.ModelTypeId ||
                    this.ModelTypeId != null &&
                    this.ModelTypeId.Equals(other.ModelTypeId)
                ) && 
                (
                    this.BlockId == other.BlockId ||
                    this.BlockId != null &&
                    this.BlockId.Equals(other.BlockId)
                ) && 
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
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
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
                ) && 
                (
                    this.Start == other.Start ||
                    this.Start != null &&
                    this.Start.Equals(other.Start)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Import == other.Import ||
                    this.Import != null &&
                    this.Import.Equals(other.Import)
                ) && 
                (
                    this.CampaignId == other.CampaignId ||
                    this.CampaignId != null &&
                    this.CampaignId.Equals(other.CampaignId)
                ) && 
                (
                    this.Recommended == other.Recommended ||
                    this.Recommended != null &&
                    this.Recommended.Equals(other.Recommended)
                ) && 
                (
                    this.StationDraftId == other.StationDraftId ||
                    this.StationDraftId != null &&
                    this.StationDraftId.Equals(other.StationDraftId)
                ) && 
                (
                    this.ProgramDraftId == other.ProgramDraftId ||
                    this.ProgramDraftId != null &&
                    this.ProgramDraftId.Equals(other.ProgramDraftId)
                ) && 
                (
                    this.UserDraftId == other.UserDraftId ||
                    this.UserDraftId != null &&
                    this.UserDraftId.Equals(other.UserDraftId)
                ) && 
                (
                    this.StaticStart == other.StaticStart ||
                    this.StaticStart != null &&
                    this.StaticStart.Equals(other.StaticStart)
                ) && 
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.Equals(other.Details)
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
                if (this.ModelTypeId != null)
                    hash = hash * 59 + this.ModelTypeId.GetHashCode();
                if (this.BlockId != null)
                    hash = hash * 59 + this.BlockId.GetHashCode();
                if (this.ExternalId != null)
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                if (this.FieldValues != null)
                    hash = hash * 59 + this.FieldValues.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Duration != null)
                    hash = hash * 59 + this.Duration.GetHashCode();
                if (this.Start != null)
                    hash = hash * 59 + this.Start.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Import != null)
                    hash = hash * 59 + this.Import.GetHashCode();
                if (this.CampaignId != null)
                    hash = hash * 59 + this.CampaignId.GetHashCode();
                if (this.Recommended != null)
                    hash = hash * 59 + this.Recommended.GetHashCode();
                if (this.StationDraftId != null)
                    hash = hash * 59 + this.StationDraftId.GetHashCode();
                if (this.ProgramDraftId != null)
                    hash = hash * 59 + this.ProgramDraftId.GetHashCode();
                if (this.UserDraftId != null)
                    hash = hash * 59 + this.UserDraftId.GetHashCode();
                if (this.StaticStart != null)
                    hash = hash * 59 + this.StaticStart.GetHashCode();
                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();
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
