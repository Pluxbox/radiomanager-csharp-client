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
    /// ProgramDataInput
    /// </summary>
    [DataContract]
        public partial class ProgramDataInput : Program,  IEquatable<ProgramDataInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramDataInput" /> class.
        /// </summary>
        public ProgramDataInput(long? modelTypeId = default(long?), Object fieldValues = default(Object), string title = default(string), bool? disabled = default(bool?), long? genreId = default(long?), string description = default(string), string shortName = default(string), string mediumName = default(string), string website = default(string), string email = default(string), bool? recommended = default(bool?), string language = default(string), long? ptyCodeId = default(long?)) : base(modelTypeId, fieldValues, title, disabled, genreId, description, shortName, mediumName, website, email, recommended, language, ptyCodeId)
        {
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProgramDataInput {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
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
            return this.Equals(input as ProgramDataInput);
        }

        /// <summary>
        /// Returns true if ProgramDataInput instances are equal
        /// </summary>
        /// <param name="input">Instance of ProgramDataInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProgramDataInput input)
        {
            if (input == null)
                return false;

            return base.Equals(input);
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
