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
    /// ItemResult
    /// </summary>
    [DataContract]
    public partial class ItemResult :  IEquatable<ItemResult>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="ItemResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemResult" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="UpdatedAt">UpdatedAt.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="DeletedAt">DeletedAt.</param>
        /// <param name="DataModified">DataModified.</param>
        /// <param name="Order">Order.</param>
        /// <param name="TemplateblockId">TemplateblockId.</param>
        /// <param name="TemplateitemId">TemplateitemId.</param>
        /// <param name="ExternalStationId">ExternalStationId.</param>
        /// <param name="ModelTypeId">ModelTypeId (required).</param>
        /// <param name="BlockId">BlockId.</param>
        /// <param name="ExternalId">ExternalId (required).</param>
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
        /// <param name="Block">Block.</param>
        /// <param name="Broadcast">Broadcast.</param>
        /// <param name="Program">Program.</param>
        /// <param name="Contacts">Contacts.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="Campaign">Campaign.</param>
        /// <param name="ModelType">ModelType.</param>
        public ItemResult(long? Id = default(long?), DateTime? UpdatedAt = default(DateTime?), DateTime? CreatedAt = default(DateTime?), DateTime? DeletedAt = default(DateTime?), long? DataModified = default(long?), long? Order = default(long?), long? TemplateblockId = default(long?), long? TemplateitemId = default(long?), long? ExternalStationId = default(long?), long? ModelTypeId = default(long?), long? BlockId = default(long?), long? ExternalId = default(long?), ImportItemFieldValues FieldValues = default(ImportItemFieldValues), string Title = default(string), long? Duration = default(long?), DateTime? Start = default(DateTime?), StatusEnum? Status = default(StatusEnum?), long? Import = default(long?), long? CampaignId = default(long?), bool? Recommended = default(bool?), long? StationDraftId = default(long?), long? ProgramDraftId = default(long?), long? UserDraftId = default(long?), bool? StaticStart = default(bool?), string Details = default(string), ItemRelationsBlock Block = default(ItemRelationsBlock), BlockRelationsBroadcast Broadcast = default(BlockRelationsBroadcast), ItemRelationsProgram Program = default(ItemRelationsProgram), ItemRelationsContacts Contacts = default(ItemRelationsContacts), ItemRelationsTags Tags = default(ItemRelationsTags), ItemRelationsCampaign Campaign = default(ItemRelationsCampaign), BroadcastRelationsModelType ModelType = default(BroadcastRelationsModelType))
        {
            // to ensure "ModelTypeId" is required (not null)
            if (ModelTypeId == null)
            {
                throw new InvalidDataException("ModelTypeId is a required property for ItemResult and cannot be null");
            }
            else
            {
                this.ModelTypeId = ModelTypeId;
            }
            // to ensure "ExternalId" is required (not null)
            if (ExternalId == null)
            {
                throw new InvalidDataException("ExternalId is a required property for ItemResult and cannot be null");
            }
            else
            {
                this.ExternalId = ExternalId;
            }
            this.Id = Id;
            this.UpdatedAt = UpdatedAt;
            this.CreatedAt = CreatedAt;
            this.DeletedAt = DeletedAt;
            this.DataModified = DataModified;
            this.Order = Order;
            this.TemplateblockId = TemplateblockId;
            this.TemplateitemId = TemplateitemId;
            this.ExternalStationId = ExternalStationId;
            this.BlockId = BlockId;
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
            this.Block = Block;
            this.Broadcast = Broadcast;
            this.Program = Program;
            this.Contacts = Contacts;
            this.Tags = Tags;
            this.Campaign = Campaign;
            this.ModelType = ModelType;
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
        /// Gets or Sets DataModified
        /// </summary>
        [DataMember(Name="data_modified", EmitDefaultValue=false)]
        public long? DataModified { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public long? Order { get; set; }

        /// <summary>
        /// Gets or Sets TemplateblockId
        /// </summary>
        [DataMember(Name="templateblock_id", EmitDefaultValue=false)]
        public long? TemplateblockId { get; set; }

        /// <summary>
        /// Gets or Sets TemplateitemId
        /// </summary>
        [DataMember(Name="templateitem_id", EmitDefaultValue=false)]
        public long? TemplateitemId { get; set; }

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
        /// Gets or Sets BlockId
        /// </summary>
        [DataMember(Name="block_id", EmitDefaultValue=false)]
        public long? BlockId { get; set; }

        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name="external_id", EmitDefaultValue=false)]
        public long? ExternalId { get; set; }

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
        /// Gets or Sets Block
        /// </summary>
        [DataMember(Name="block", EmitDefaultValue=false)]
        public ItemRelationsBlock Block { get; set; }

        /// <summary>
        /// Gets or Sets Broadcast
        /// </summary>
        [DataMember(Name="broadcast", EmitDefaultValue=false)]
        public BlockRelationsBroadcast Broadcast { get; set; }

        /// <summary>
        /// Gets or Sets Program
        /// </summary>
        [DataMember(Name="program", EmitDefaultValue=false)]
        public ItemRelationsProgram Program { get; set; }

        /// <summary>
        /// Gets or Sets Contacts
        /// </summary>
        [DataMember(Name="contacts", EmitDefaultValue=false)]
        public ItemRelationsContacts Contacts { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public ItemRelationsTags Tags { get; set; }

        /// <summary>
        /// Gets or Sets Campaign
        /// </summary>
        [DataMember(Name="campaign", EmitDefaultValue=false)]
        public ItemRelationsCampaign Campaign { get; set; }

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
            sb.Append("class ItemResult {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
            sb.Append("  DataModified: ").Append(DataModified).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  TemplateblockId: ").Append(TemplateblockId).Append("\n");
            sb.Append("  TemplateitemId: ").Append(TemplateitemId).Append("\n");
            sb.Append("  ExternalStationId: ").Append(ExternalStationId).Append("\n");
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
            sb.Append("  Block: ").Append(Block).Append("\n");
            sb.Append("  Broadcast: ").Append(Broadcast).Append("\n");
            sb.Append("  Program: ").Append(Program).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Campaign: ").Append(Campaign).Append("\n");
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
            return this.Equals(input as ItemResult);
        }

        /// <summary>
        /// Returns true if ItemResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemResult input)
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
                    this.DataModified == input.DataModified ||
                    (this.DataModified != null &&
                    this.DataModified.Equals(input.DataModified))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.TemplateblockId == input.TemplateblockId ||
                    (this.TemplateblockId != null &&
                    this.TemplateblockId.Equals(input.TemplateblockId))
                ) && 
                (
                    this.TemplateitemId == input.TemplateitemId ||
                    (this.TemplateitemId != null &&
                    this.TemplateitemId.Equals(input.TemplateitemId))
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
                    this.BlockId == input.BlockId ||
                    (this.BlockId != null &&
                    this.BlockId.Equals(input.BlockId))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.FieldValues == input.FieldValues ||
                    (this.FieldValues != null &&
                    this.FieldValues.Equals(input.FieldValues))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Import == input.Import ||
                    (this.Import != null &&
                    this.Import.Equals(input.Import))
                ) && 
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
                ) && 
                (
                    this.Recommended == input.Recommended ||
                    (this.Recommended != null &&
                    this.Recommended.Equals(input.Recommended))
                ) && 
                (
                    this.StationDraftId == input.StationDraftId ||
                    (this.StationDraftId != null &&
                    this.StationDraftId.Equals(input.StationDraftId))
                ) && 
                (
                    this.ProgramDraftId == input.ProgramDraftId ||
                    (this.ProgramDraftId != null &&
                    this.ProgramDraftId.Equals(input.ProgramDraftId))
                ) && 
                (
                    this.UserDraftId == input.UserDraftId ||
                    (this.UserDraftId != null &&
                    this.UserDraftId.Equals(input.UserDraftId))
                ) && 
                (
                    this.StaticStart == input.StaticStart ||
                    (this.StaticStart != null &&
                    this.StaticStart.Equals(input.StaticStart))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.Block == input.Block ||
                    (this.Block != null &&
                    this.Block.Equals(input.Block))
                ) && 
                (
                    this.Broadcast == input.Broadcast ||
                    (this.Broadcast != null &&
                    this.Broadcast.Equals(input.Broadcast))
                ) && 
                (
                    this.Program == input.Program ||
                    (this.Program != null &&
                    this.Program.Equals(input.Program))
                ) && 
                (
                    this.Contacts == input.Contacts ||
                    (this.Contacts != null &&
                    this.Contacts.Equals(input.Contacts))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.Campaign == input.Campaign ||
                    (this.Campaign != null &&
                    this.Campaign.Equals(input.Campaign))
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
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.DeletedAt != null)
                    hashCode = hashCode * 59 + this.DeletedAt.GetHashCode();
                if (this.DataModified != null)
                    hashCode = hashCode * 59 + this.DataModified.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.TemplateblockId != null)
                    hashCode = hashCode * 59 + this.TemplateblockId.GetHashCode();
                if (this.TemplateitemId != null)
                    hashCode = hashCode * 59 + this.TemplateitemId.GetHashCode();
                if (this.ExternalStationId != null)
                    hashCode = hashCode * 59 + this.ExternalStationId.GetHashCode();
                if (this.ModelTypeId != null)
                    hashCode = hashCode * 59 + this.ModelTypeId.GetHashCode();
                if (this.BlockId != null)
                    hashCode = hashCode * 59 + this.BlockId.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.FieldValues != null)
                    hashCode = hashCode * 59 + this.FieldValues.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Import != null)
                    hashCode = hashCode * 59 + this.Import.GetHashCode();
                if (this.CampaignId != null)
                    hashCode = hashCode * 59 + this.CampaignId.GetHashCode();
                if (this.Recommended != null)
                    hashCode = hashCode * 59 + this.Recommended.GetHashCode();
                if (this.StationDraftId != null)
                    hashCode = hashCode * 59 + this.StationDraftId.GetHashCode();
                if (this.ProgramDraftId != null)
                    hashCode = hashCode * 59 + this.ProgramDraftId.GetHashCode();
                if (this.UserDraftId != null)
                    hashCode = hashCode * 59 + this.UserDraftId.GetHashCode();
                if (this.StaticStart != null)
                    hashCode = hashCode * 59 + this.StaticStart.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Block != null)
                    hashCode = hashCode * 59 + this.Block.GetHashCode();
                if (this.Broadcast != null)
                    hashCode = hashCode * 59 + this.Broadcast.GetHashCode();
                if (this.Program != null)
                    hashCode = hashCode * 59 + this.Program.GetHashCode();
                if (this.Contacts != null)
                    hashCode = hashCode * 59 + this.Contacts.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Campaign != null)
                    hashCode = hashCode * 59 + this.Campaign.GetHashCode();
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
