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
    /// ContactRelations
    /// </summary>
    [DataContract]
    public partial class ContactRelations :  IEquatable<ContactRelations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactRelations" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactRelations() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactRelations" /> class.
        /// </summary>
        /// <param name="Tags">Tags (required).</param>
        /// <param name="Items">Items.</param>
        /// <param name="ModelType">ModelType.</param>
        public ContactRelations(ContactRelationsTags Tags = default(ContactRelationsTags), ContactRelationsItems Items = default(ContactRelationsItems), BroadcastRelationsModelType ModelType = default(BroadcastRelationsModelType))
        {
            // to ensure "Tags" is required (not null)
            if (Tags == null)
            {
                throw new InvalidDataException("Tags is a required property for ContactRelations and cannot be null");
            }
            else
            {
                this.Tags = Tags;
            }
            this.Items = Items;
            this.ModelType = ModelType;
        }
        
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public ContactRelationsTags Tags { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public ContactRelationsItems Items { get; set; }

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
            sb.Append("class ContactRelations {\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as ContactRelations);
        }

        /// <summary>
        /// Returns true if ContactRelations instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactRelations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactRelations input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.Items == input.Items ||
                    (this.Items != null &&
                    this.Items.Equals(input.Items))
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
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
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
