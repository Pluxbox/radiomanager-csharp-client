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
    /// BroadcastRelations
    /// </summary>
    [DataContract]
    public partial class BroadcastRelations :  IEquatable<BroadcastRelations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcastRelations" /> class.
        /// </summary>
        /// <param name="Genre">Genre.</param>
        /// <param name="Items">Items.</param>
        /// <param name="Blocks">Blocks.</param>
        /// <param name="Program">Program.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="Presenters">Presenters.</param>
        /// <param name="ModelType">ModelType.</param>
        public BroadcastRelations(BroadcastRelationsGenre Genre = default(BroadcastRelationsGenre), BroadcastRelationsItems Items = default(BroadcastRelationsItems), BroadcastRelationsBlocks Blocks = default(BroadcastRelationsBlocks), BlockRelationsProgram Program = default(BlockRelationsProgram), BroadcastRelationsTags Tags = default(BroadcastRelationsTags), BroadcastRelationsPresenters Presenters = default(BroadcastRelationsPresenters), BroadcastRelationsModelType ModelType = default(BroadcastRelationsModelType))
        {
            this.Genre = Genre;
            this.Items = Items;
            this.Blocks = Blocks;
            this.Program = Program;
            this.Tags = Tags;
            this.Presenters = Presenters;
            this.ModelType = ModelType;
        }
        
        /// <summary>
        /// Gets or Sets Genre
        /// </summary>
        [DataMember(Name="genre", EmitDefaultValue=false)]
        public BroadcastRelationsGenre Genre { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public BroadcastRelationsItems Items { get; set; }

        /// <summary>
        /// Gets or Sets Blocks
        /// </summary>
        [DataMember(Name="blocks", EmitDefaultValue=false)]
        public BroadcastRelationsBlocks Blocks { get; set; }

        /// <summary>
        /// Gets or Sets Program
        /// </summary>
        [DataMember(Name="program", EmitDefaultValue=false)]
        public BlockRelationsProgram Program { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public BroadcastRelationsTags Tags { get; set; }

        /// <summary>
        /// Gets or Sets Presenters
        /// </summary>
        [DataMember(Name="presenters", EmitDefaultValue=false)]
        public BroadcastRelationsPresenters Presenters { get; set; }

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
            sb.Append("class BroadcastRelations {\n");
            sb.Append("  Genre: ").Append(Genre).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Blocks: ").Append(Blocks).Append("\n");
            sb.Append("  Program: ").Append(Program).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Presenters: ").Append(Presenters).Append("\n");
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
            return this.Equals(input as BroadcastRelations);
        }

        /// <summary>
        /// Returns true if BroadcastRelations instances are equal
        /// </summary>
        /// <param name="input">Instance of BroadcastRelations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BroadcastRelations input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Genre == input.Genre ||
                    (this.Genre != null &&
                    this.Genre.Equals(input.Genre))
                ) && 
                (
                    this.Items == input.Items ||
                    (this.Items != null &&
                    this.Items.Equals(input.Items))
                ) && 
                (
                    this.Blocks == input.Blocks ||
                    (this.Blocks != null &&
                    this.Blocks.Equals(input.Blocks))
                ) && 
                (
                    this.Program == input.Program ||
                    (this.Program != null &&
                    this.Program.Equals(input.Program))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.Presenters == input.Presenters ||
                    (this.Presenters != null &&
                    this.Presenters.Equals(input.Presenters))
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
                if (this.Genre != null)
                    hashCode = hashCode * 59 + this.Genre.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.Blocks != null)
                    hashCode = hashCode * 59 + this.Blocks.GetHashCode();
                if (this.Program != null)
                    hashCode = hashCode * 59 + this.Program.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Presenters != null)
                    hashCode = hashCode * 59 + this.Presenters.GetHashCode();
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
