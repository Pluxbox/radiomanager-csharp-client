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
    /// ProgramRelationsBlocks
    /// </summary>
    [DataContract]
    public partial class ProgramRelationsBlocks :  IEquatable<ProgramRelationsBlocks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramRelationsBlocks" /> class.
        /// </summary>
        /// <param name="Href">Href.</param>
        /// <param name="Model">Model.</param>
        /// <param name="Operation">Operation.</param>
        /// <param name="_Params">_Params.</param>
        public ProgramRelationsBlocks(string Href = default(string), string Model = default(string), string Operation = default(string), ProgramRelationsItemsParams _Params = default(ProgramRelationsItemsParams))
        {
            this.Href = Href;
            this.Model = Model;
            this.Operation = Operation;
            this._Params = _Params;
        }
        
        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public string Model { get; set; }

        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [DataMember(Name="operation", EmitDefaultValue=false)]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or Sets _Params
        /// </summary>
        [DataMember(Name="params", EmitDefaultValue=false)]
        public ProgramRelationsItemsParams _Params { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProgramRelationsBlocks {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  _Params: ").Append(_Params).Append("\n");
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
            return this.Equals(obj as ProgramRelationsBlocks);
        }

        /// <summary>
        /// Returns true if ProgramRelationsBlocks instances are equal
        /// </summary>
        /// <param name="other">Instance of ProgramRelationsBlocks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProgramRelationsBlocks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Href == other.Href ||
                    this.Href != null &&
                    this.Href.Equals(other.Href)
                ) && 
                (
                    this.Model == other.Model ||
                    this.Model != null &&
                    this.Model.Equals(other.Model)
                ) && 
                (
                    this.Operation == other.Operation ||
                    this.Operation != null &&
                    this.Operation.Equals(other.Operation)
                ) && 
                (
                    this._Params == other._Params ||
                    this._Params != null &&
                    this._Params.Equals(other._Params)
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
                if (this.Href != null)
                    hash = hash * 59 + this.Href.GetHashCode();
                if (this.Model != null)
                    hash = hash * 59 + this.Model.GetHashCode();
                if (this.Operation != null)
                    hash = hash * 59 + this.Operation.GetHashCode();
                if (this._Params != null)
                    hash = hash * 59 + this._Params.GetHashCode();
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
