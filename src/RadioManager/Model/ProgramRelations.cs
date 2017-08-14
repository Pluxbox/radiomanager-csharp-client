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
    /// ProgramRelations
    /// </summary>
    [DataContract]
    public partial class ProgramRelations :  IEquatable<ProgramRelations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramRelations" /> class.
        /// </summary>
        /// <param name="Items">Items.</param>
        /// <param name="Blocks">Blocks.</param>
        /// <param name="Broadcasts">Broadcasts.</param>
        /// <param name="Presenters">Presenters.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="ModelType">ModelType.</param>
        public ProgramRelations(ProgramRelationsItems Items = default(ProgramRelationsItems), ProgramRelationsBlocks Blocks = default(ProgramRelationsBlocks), ProgramRelationsBroadcasts Broadcasts = default(ProgramRelationsBroadcasts), ProgramRelationsPresenters Presenters = default(ProgramRelationsPresenters), ProgramRelationsTags Tags = default(ProgramRelationsTags), BroadcastRelationsModelType ModelType = default(BroadcastRelationsModelType))
        {
            this.Items = Items;
            this.Blocks = Blocks;
            this.Broadcasts = Broadcasts;
            this.Presenters = Presenters;
            this.Tags = Tags;
            this.ModelType = ModelType;
        }
        
        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public ProgramRelationsItems Items { get; set; }

        /// <summary>
        /// Gets or Sets Blocks
        /// </summary>
        [DataMember(Name="blocks", EmitDefaultValue=false)]
        public ProgramRelationsBlocks Blocks { get; set; }

        /// <summary>
        /// Gets or Sets Broadcasts
        /// </summary>
        [DataMember(Name="broadcasts", EmitDefaultValue=false)]
        public ProgramRelationsBroadcasts Broadcasts { get; set; }

        /// <summary>
        /// Gets or Sets Presenters
        /// </summary>
        [DataMember(Name="presenters", EmitDefaultValue=false)]
        public ProgramRelationsPresenters Presenters { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public ProgramRelationsTags Tags { get; set; }

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
            sb.Append("class ProgramRelations {\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Blocks: ").Append(Blocks).Append("\n");
            sb.Append("  Broadcasts: ").Append(Broadcasts).Append("\n");
            sb.Append("  Presenters: ").Append(Presenters).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ProgramRelations);
        }

        /// <summary>
        /// Returns true if ProgramRelations instances are equal
        /// </summary>
        /// <param name="other">Instance of ProgramRelations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProgramRelations other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.Equals(other.Items)
                ) && 
                (
                    this.Blocks == other.Blocks ||
                    this.Blocks != null &&
                    this.Blocks.Equals(other.Blocks)
                ) && 
                (
                    this.Broadcasts == other.Broadcasts ||
                    this.Broadcasts != null &&
                    this.Broadcasts.Equals(other.Broadcasts)
                ) && 
                (
                    this.Presenters == other.Presenters ||
                    this.Presenters != null &&
                    this.Presenters.Equals(other.Presenters)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.Equals(other.Tags)
                ) && 
                (
                    this.ModelType == other.ModelType ||
                    this.ModelType != null &&
                    this.ModelType.Equals(other.ModelType)
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
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();
                if (this.Blocks != null)
                    hash = hash * 59 + this.Blocks.GetHashCode();
                if (this.Broadcasts != null)
                    hash = hash * 59 + this.Broadcasts.GetHashCode();
                if (this.Presenters != null)
                    hash = hash * 59 + this.Presenters.GetHashCode();
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                if (this.ModelType != null)
                    hash = hash * 59 + this.ModelType.GetHashCode();
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
