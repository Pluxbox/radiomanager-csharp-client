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
    /// RelationsPlaceholder
    /// </summary>
    [DataContract]
    public partial class RelationsPlaceholder :  IEquatable<RelationsPlaceholder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelationsPlaceholder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RelationsPlaceholder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RelationsPlaceholder" /> class.
        /// </summary>
        /// <param name="Href">HREF (required).</param>
        /// <param name="Model">MODEL (required).</param>
        /// <param name="Operation">OPERATION (required).</param>
        /// <param name="_Params">PARAMS (required).</param>
        public RelationsPlaceholder(string Href = default(string), string Model = default(string), string Operation = default(string), Object _Params = default(Object))
        {
            // to ensure "Href" is required (not null)
            if (Href == null)
            {
                throw new InvalidDataException("Href is a required property for RelationsPlaceholder and cannot be null");
            }
            else
            {
                this.Href = Href;
            }
            // to ensure "Model" is required (not null)
            if (Model == null)
            {
                throw new InvalidDataException("Model is a required property for RelationsPlaceholder and cannot be null");
            }
            else
            {
                this.Model = Model;
            }
            // to ensure "Operation" is required (not null)
            if (Operation == null)
            {
                throw new InvalidDataException("Operation is a required property for RelationsPlaceholder and cannot be null");
            }
            else
            {
                this.Operation = Operation;
            }
            // to ensure "_Params" is required (not null)
            if (_Params == null)
            {
                throw new InvalidDataException("_Params is a required property for RelationsPlaceholder and cannot be null");
            }
            else
            {
                this._Params = _Params;
            }
        }
        
        /// <summary>
        /// HREF
        /// </summary>
        /// <value>HREF</value>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// MODEL
        /// </summary>
        /// <value>MODEL</value>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public string Model { get; set; }

        /// <summary>
        /// OPERATION
        /// </summary>
        /// <value>OPERATION</value>
        [DataMember(Name="operation", EmitDefaultValue=false)]
        public string Operation { get; set; }

        /// <summary>
        /// PARAMS
        /// </summary>
        /// <value>PARAMS</value>
        [DataMember(Name="params", EmitDefaultValue=false)]
        public Object _Params { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelationsPlaceholder {\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RelationsPlaceholder);
        }

        /// <summary>
        /// Returns true if RelationsPlaceholder instances are equal
        /// </summary>
        /// <param name="input">Instance of RelationsPlaceholder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelationsPlaceholder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
                ) && 
                (
                    this._Params == input._Params ||
                    (this._Params != null &&
                    this._Params.Equals(input._Params))
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
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.Operation != null)
                    hashCode = hashCode * 59 + this.Operation.GetHashCode();
                if (this._Params != null)
                    hashCode = hashCode * 59 + this._Params.GetHashCode();
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
