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
    /// CampaignRelationsItemsParams
    /// </summary>
    [DataContract]
    public partial class CampaignRelationsItemsParams :  IEquatable<CampaignRelationsItemsParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignRelationsItemsParams" /> class.
        /// </summary>
        /// <param name="CampaignId">CampaignId.</param>
        public CampaignRelationsItemsParams(int? CampaignId = default(int?))
        {
            this.CampaignId = CampaignId;
        }
        
        /// <summary>
        /// Gets or Sets CampaignId
        /// </summary>
        [DataMember(Name="campaign_id", EmitDefaultValue=false)]
        public int? CampaignId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignRelationsItemsParams {\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
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
            return this.Equals(input as CampaignRelationsItemsParams);
        }

        /// <summary>
        /// Returns true if CampaignRelationsItemsParams instances are equal
        /// </summary>
        /// <param name="input">Instance of CampaignRelationsItemsParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignRelationsItemsParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
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
                if (this.CampaignId != null)
                    hashCode = hashCode * 59 + this.CampaignId.GetHashCode();
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
