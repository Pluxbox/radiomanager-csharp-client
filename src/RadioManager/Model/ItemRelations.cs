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
    /// ItemRelations
    /// </summary>
    [DataContract]
    public partial class ItemRelations :  IEquatable<ItemRelations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemRelations" /> class.
        /// </summary>
        /// <param name="Block">Block.</param>
        /// <param name="Broadcast">Broadcast.</param>
        /// <param name="Program">Program.</param>
        /// <param name="Contacts">Contacts.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="Campaign">Campaign.</param>
        /// <param name="ModelType">ModelType.</param>
        public ItemRelations(ItemRelationsBlock Block = default(ItemRelationsBlock), BlockRelationsBroadcast Broadcast = default(BlockRelationsBroadcast), ItemRelationsProgram Program = default(ItemRelationsProgram), ItemRelationsContacts Contacts = default(ItemRelationsContacts), ItemRelationsTags Tags = default(ItemRelationsTags), ItemRelationsCampaign Campaign = default(ItemRelationsCampaign), BroadcastRelationsModelType ModelType = default(BroadcastRelationsModelType))
        {
            this.Block = Block;
            this.Broadcast = Broadcast;
            this.Program = Program;
            this.Contacts = Contacts;
            this.Tags = Tags;
            this.Campaign = Campaign;
            this.ModelType = ModelType;
        }
        
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
            sb.Append("class ItemRelations {\n");
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
            return this.Equals(input as ItemRelations);
        }

        /// <summary>
        /// Returns true if ItemRelations instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemRelations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemRelations input)
        {
            if (input == null)
                return false;

            return 
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
