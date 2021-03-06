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
    /// CampaignTemplateItem
    /// </summary>
    [DataContract]
    public partial class CampaignTemplateItem :  IEquatable<CampaignTemplateItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignTemplateItem" /> class.
        /// </summary>
        /// <param name="ModelTypeId">ModelTypeId.</param>
        /// <param name="ExternalId">ExternalId.</param>
        /// <param name="FieldValues">FieldValues.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Duration">Duration.</param>
        /// <param name="Recommended">Recommended.</param>
        /// <param name="StaticStart">StaticStart.</param>
        /// <param name="Deltas">Deltas.</param>
        public CampaignTemplateItem(long? ModelTypeId = default(long?), string ExternalId = default(string), Object FieldValues = default(Object), string Title = default(string), long? Duration = default(long?), bool? Recommended = default(bool?), bool? StaticStart = default(bool?), Object Deltas = default(Object))
        {
            this.ModelTypeId = ModelTypeId;
            this.ExternalId = ExternalId;
            this.FieldValues = FieldValues;
            this.Title = Title;
            this.Duration = Duration;
            this.Recommended = Recommended;
            this.StaticStart = StaticStart;
            this.Deltas = Deltas;
        }
        
        /// <summary>
        /// Gets or Sets ModelTypeId
        /// </summary>
        [DataMember(Name="model_type_id", EmitDefaultValue=false)]
        public long? ModelTypeId { get; set; }

        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name="external_id", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets FieldValues
        /// </summary>
        [DataMember(Name="field_values", EmitDefaultValue=false)]
        public Object FieldValues { get; set; }

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
        /// Gets or Sets Recommended
        /// </summary>
        [DataMember(Name="recommended", EmitDefaultValue=false)]
        public bool? Recommended { get; set; }

        /// <summary>
        /// Gets or Sets StaticStart
        /// </summary>
        [DataMember(Name="static_start", EmitDefaultValue=false)]
        public bool? StaticStart { get; set; }

        /// <summary>
        /// Gets or Sets Deltas
        /// </summary>
        [DataMember(Name="_deltas", EmitDefaultValue=false)]
        public Object Deltas { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignTemplateItem {\n");
            sb.Append("  ModelTypeId: ").Append(ModelTypeId).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  FieldValues: ").Append(FieldValues).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Recommended: ").Append(Recommended).Append("\n");
            sb.Append("  StaticStart: ").Append(StaticStart).Append("\n");
            sb.Append("  Deltas: ").Append(Deltas).Append("\n");
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
            return this.Equals(input as CampaignTemplateItem);
        }

        /// <summary>
        /// Returns true if CampaignTemplateItem instances are equal
        /// </summary>
        /// <param name="input">Instance of CampaignTemplateItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignTemplateItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ModelTypeId == input.ModelTypeId ||
                    (this.ModelTypeId != null &&
                    this.ModelTypeId.Equals(input.ModelTypeId))
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
                    this.Recommended == input.Recommended ||
                    (this.Recommended != null &&
                    this.Recommended.Equals(input.Recommended))
                ) && 
                (
                    this.StaticStart == input.StaticStart ||
                    (this.StaticStart != null &&
                    this.StaticStart.Equals(input.StaticStart))
                ) && 
                (
                    this.Deltas == input.Deltas ||
                    (this.Deltas != null &&
                    this.Deltas.Equals(input.Deltas))
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
                if (this.ModelTypeId != null)
                    hashCode = hashCode * 59 + this.ModelTypeId.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.FieldValues != null)
                    hashCode = hashCode * 59 + this.FieldValues.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.Recommended != null)
                    hashCode = hashCode * 59 + this.Recommended.GetHashCode();
                if (this.StaticStart != null)
                    hashCode = hashCode * 59 + this.StaticStart.GetHashCode();
                if (this.Deltas != null)
                    hashCode = hashCode * 59 + this.Deltas.GetHashCode();
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
