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
    /// TagRelations
    /// </summary>
    [DataContract]
    public partial class TagRelations :  IEquatable<TagRelations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagRelations" /> class.
        /// </summary>
        /// <param name="Broadcasts">Broadcasts.</param>
        /// <param name="Programs">Programs.</param>
        /// <param name="Contacts">Contacts.</param>
        /// <param name="Items">Items.</param>
        public TagRelations(TagRelationsBroadcasts Broadcasts = default(TagRelationsBroadcasts), TagRelationsPrograms Programs = default(TagRelationsPrograms), TagRelationsContacts Contacts = default(TagRelationsContacts), TagRelationsItems Items = default(TagRelationsItems))
        {
            this.Broadcasts = Broadcasts;
            this.Programs = Programs;
            this.Contacts = Contacts;
            this.Items = Items;
        }
        
        /// <summary>
        /// Gets or Sets Broadcasts
        /// </summary>
        [DataMember(Name="broadcasts", EmitDefaultValue=false)]
        public TagRelationsBroadcasts Broadcasts { get; set; }

        /// <summary>
        /// Gets or Sets Programs
        /// </summary>
        [DataMember(Name="programs", EmitDefaultValue=false)]
        public TagRelationsPrograms Programs { get; set; }

        /// <summary>
        /// Gets or Sets Contacts
        /// </summary>
        [DataMember(Name="contacts", EmitDefaultValue=false)]
        public TagRelationsContacts Contacts { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public TagRelationsItems Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TagRelations {\n");
            sb.Append("  Broadcasts: ").Append(Broadcasts).Append("\n");
            sb.Append("  Programs: ").Append(Programs).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as TagRelations);
        }

        /// <summary>
        /// Returns true if TagRelations instances are equal
        /// </summary>
        /// <param name="input">Instance of TagRelations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TagRelations input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Broadcasts == input.Broadcasts ||
                    (this.Broadcasts != null &&
                    this.Broadcasts.Equals(input.Broadcasts))
                ) && 
                (
                    this.Programs == input.Programs ||
                    (this.Programs != null &&
                    this.Programs.Equals(input.Programs))
                ) && 
                (
                    this.Contacts == input.Contacts ||
                    (this.Contacts != null &&
                    this.Contacts.Equals(input.Contacts))
                ) && 
                (
                    this.Items == input.Items ||
                    (this.Items != null &&
                    this.Items.Equals(input.Items))
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
                if (this.Broadcasts != null)
                    hashCode = hashCode * 59 + this.Broadcasts.GetHashCode();
                if (this.Programs != null)
                    hashCode = hashCode * 59 + this.Programs.GetHashCode();
                if (this.Contacts != null)
                    hashCode = hashCode * 59 + this.Contacts.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
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
