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
    /// TagResult
    /// </summary>
    [DataContract]
        public partial class TagResult : TagOutputOnly,  IEquatable<TagResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagResult" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="broadcasts">broadcasts.</param>
        /// <param name="programs">programs.</param>
        /// <param name="contacts">contacts.</param>
        /// <param name="items">items.</param>
        public TagResult(string name = default(string), Object broadcasts = default(Object), Object programs = default(Object), Object contacts = default(Object), Object items = default(Object), string name = default(string), Object broadcasts = default(Object), Object programs = default(Object), Object items = default(Object), long? id = default(long?), DateTime? createdAt = default(DateTime?), DateTime? updatedAt = default(DateTime?), DateTime? deletedAt = default(DateTime?), long? externalStationId = default(long?)) : base(id, createdAt, updatedAt, deletedAt, externalStationId)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for TagResult and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.Broadcasts = broadcasts;
            this.Programs = programs;
            this.Contacts = contacts;
            this.Items = items;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Broadcasts
        /// </summary>
        [DataMember(Name="broadcasts", EmitDefaultValue=false)]
        public Object Broadcasts { get; set; }

        /// <summary>
        /// Gets or Sets Programs
        /// </summary>
        [DataMember(Name="programs", EmitDefaultValue=false)]
        public Object Programs { get; set; }

        /// <summary>
        /// Gets or Sets Contacts
        /// </summary>
        [DataMember(Name="contacts", EmitDefaultValue=false)]
        public Object Contacts { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public Object Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TagResult {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as TagResult);
        }

        /// <summary>
        /// Returns true if TagResult instances are equal
        /// </summary>
        /// <param name="input">Instance of TagResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TagResult input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
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
                    this.Contacts == input.Contacts ||
                    (this.Contacts != null &&
                    this.Contacts.Equals(input.Contacts))
                ) && base.Equals(input) && 
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
                int hashCode = base.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }
}
