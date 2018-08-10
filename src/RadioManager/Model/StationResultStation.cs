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
    /// StationResultStation
    /// </summary>
    [DataContract]
    public partial class StationResultStation :  IEquatable<StationResultStation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StationResultStation" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="UpdatedAt">UpdatedAt.</param>
        /// <param name="SystemName">SystemName.</param>
        /// <param name="ShortName">ShortName.</param>
        /// <param name="MediumName">MediumName.</param>
        /// <param name="Website">Website.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Keywords">Keywords.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Sms">Sms.</param>
        /// <param name="Telephone">Telephone.</param>
        /// <param name="GenreId">GenreId.</param>
        /// <param name="Language">Language.</param>
        /// <param name="Active">Active.</param>
        /// <param name="LogoRectangle">LogoRectangle.</param>
        /// <param name="Logo128x128">Logo128x128.</param>
        /// <param name="Logo320x320">Logo320x320.</param>
        /// <param name="Logo600x600">Logo600x600.</param>
        /// <param name="PayOff">PayOff.</param>
        /// <param name="PtyCode">PtyCode.</param>
        /// <param name="PtyType">PtyType.</param>
        /// <param name="StationKey">StationKey.</param>
        /// <param name="Timezone">Timezone.</param>
        /// <param name="StartDays">StartDays.</param>
        public StationResultStation(int? Id = default(int?), string Name = default(string), DateTime? CreatedAt = default(DateTime?), DateTime? UpdatedAt = default(DateTime?), string SystemName = default(string), string ShortName = default(string), string MediumName = default(string), string Website = default(string), string Email = default(string), List<string> Keywords = default(List<string>), string Description = default(string), string Sms = default(string), string Telephone = default(string), int? GenreId = default(int?), string Language = default(string), bool? Active = default(bool?), string LogoRectangle = default(string), string Logo128x128 = default(string), string Logo320x320 = default(string), string Logo600x600 = default(string), string PayOff = default(string), int? PtyCode = default(int?), string PtyType = default(string), string StationKey = default(string), string Timezone = default(string), StationResultStationStartDays StartDays = default(StationResultStationStartDays))
        {
            this.Id = Id;
            this.Name = Name;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
            this.SystemName = SystemName;
            this.ShortName = ShortName;
            this.MediumName = MediumName;
            this.Website = Website;
            this.Email = Email;
            this.Keywords = Keywords;
            this.Description = Description;
            this.Sms = Sms;
            this.Telephone = Telephone;
            this.GenreId = GenreId;
            this.Language = Language;
            this.Active = Active;
            this.LogoRectangle = LogoRectangle;
            this.Logo128x128 = Logo128x128;
            this.Logo320x320 = Logo320x320;
            this.Logo600x600 = Logo600x600;
            this.PayOff = PayOff;
            this.PtyCode = PtyCode;
            this.PtyType = PtyType;
            this.StationKey = StationKey;
            this.Timezone = Timezone;
            this.StartDays = StartDays;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets SystemName
        /// </summary>
        [DataMember(Name="system_name", EmitDefaultValue=false)]
        public string SystemName { get; set; }

        /// <summary>
        /// Gets or Sets ShortName
        /// </summary>
        [DataMember(Name="short_name", EmitDefaultValue=false)]
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or Sets MediumName
        /// </summary>
        [DataMember(Name="medium_name", EmitDefaultValue=false)]
        public string MediumName { get; set; }

        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name="website", EmitDefaultValue=false)]
        public string Website { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Keywords
        /// </summary>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Sms
        /// </summary>
        [DataMember(Name="sms", EmitDefaultValue=false)]
        public string Sms { get; set; }

        /// <summary>
        /// Gets or Sets Telephone
        /// </summary>
        [DataMember(Name="telephone", EmitDefaultValue=false)]
        public string Telephone { get; set; }

        /// <summary>
        /// Gets or Sets GenreId
        /// </summary>
        [DataMember(Name="genre_id", EmitDefaultValue=false)]
        public int? GenreId { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or Sets LogoRectangle
        /// </summary>
        [DataMember(Name="logo_rectangle", EmitDefaultValue=false)]
        public string LogoRectangle { get; set; }

        /// <summary>
        /// Gets or Sets Logo128x128
        /// </summary>
        [DataMember(Name="logo_128x128", EmitDefaultValue=false)]
        public string Logo128x128 { get; set; }

        /// <summary>
        /// Gets or Sets Logo320x320
        /// </summary>
        [DataMember(Name="logo_320x320", EmitDefaultValue=false)]
        public string Logo320x320 { get; set; }

        /// <summary>
        /// Gets or Sets Logo600x600
        /// </summary>
        [DataMember(Name="logo_600x600", EmitDefaultValue=false)]
        public string Logo600x600 { get; set; }

        /// <summary>
        /// Gets or Sets PayOff
        /// </summary>
        [DataMember(Name="pay_off", EmitDefaultValue=false)]
        public string PayOff { get; set; }

        /// <summary>
        /// Gets or Sets PtyCode
        /// </summary>
        [DataMember(Name="pty_code", EmitDefaultValue=false)]
        public int? PtyCode { get; set; }

        /// <summary>
        /// Gets or Sets PtyType
        /// </summary>
        [DataMember(Name="pty_type", EmitDefaultValue=false)]
        public string PtyType { get; set; }

        /// <summary>
        /// Gets or Sets StationKey
        /// </summary>
        [DataMember(Name="station_key", EmitDefaultValue=false)]
        public string StationKey { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or Sets StartDays
        /// </summary>
        [DataMember(Name="start_days", EmitDefaultValue=false)]
        public StationResultStationStartDays StartDays { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StationResultStation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  SystemName: ").Append(SystemName).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  MediumName: ").Append(MediumName).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Sms: ").Append(Sms).Append("\n");
            sb.Append("  Telephone: ").Append(Telephone).Append("\n");
            sb.Append("  GenreId: ").Append(GenreId).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  LogoRectangle: ").Append(LogoRectangle).Append("\n");
            sb.Append("  Logo128x128: ").Append(Logo128x128).Append("\n");
            sb.Append("  Logo320x320: ").Append(Logo320x320).Append("\n");
            sb.Append("  Logo600x600: ").Append(Logo600x600).Append("\n");
            sb.Append("  PayOff: ").Append(PayOff).Append("\n");
            sb.Append("  PtyCode: ").Append(PtyCode).Append("\n");
            sb.Append("  PtyType: ").Append(PtyType).Append("\n");
            sb.Append("  StationKey: ").Append(StationKey).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  StartDays: ").Append(StartDays).Append("\n");
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
            return this.Equals(obj as StationResultStation);
        }

        /// <summary>
        /// Returns true if StationResultStation instances are equal
        /// </summary>
        /// <param name="other">Instance of StationResultStation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StationResultStation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    this.SystemName == other.SystemName ||
                    this.SystemName != null &&
                    this.SystemName.Equals(other.SystemName)
                ) && 
                (
                    this.ShortName == other.ShortName ||
                    this.ShortName != null &&
                    this.ShortName.Equals(other.ShortName)
                ) && 
                (
                    this.MediumName == other.MediumName ||
                    this.MediumName != null &&
                    this.MediumName.Equals(other.MediumName)
                ) && 
                (
                    this.Website == other.Website ||
                    this.Website != null &&
                    this.Website.Equals(other.Website)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Keywords == other.Keywords ||
                    this.Keywords != null &&
                    this.Keywords.SequenceEqual(other.Keywords)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Sms == other.Sms ||
                    this.Sms != null &&
                    this.Sms.Equals(other.Sms)
                ) && 
                (
                    this.Telephone == other.Telephone ||
                    this.Telephone != null &&
                    this.Telephone.Equals(other.Telephone)
                ) && 
                (
                    this.GenreId == other.GenreId ||
                    this.GenreId != null &&
                    this.GenreId.Equals(other.GenreId)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) && 
                (
                    this.LogoRectangle == other.LogoRectangle ||
                    this.LogoRectangle != null &&
                    this.LogoRectangle.Equals(other.LogoRectangle)
                ) && 
                (
                    this.Logo128x128 == other.Logo128x128 ||
                    this.Logo128x128 != null &&
                    this.Logo128x128.Equals(other.Logo128x128)
                ) && 
                (
                    this.Logo320x320 == other.Logo320x320 ||
                    this.Logo320x320 != null &&
                    this.Logo320x320.Equals(other.Logo320x320)
                ) && 
                (
                    this.Logo600x600 == other.Logo600x600 ||
                    this.Logo600x600 != null &&
                    this.Logo600x600.Equals(other.Logo600x600)
                ) && 
                (
                    this.PayOff == other.PayOff ||
                    this.PayOff != null &&
                    this.PayOff.Equals(other.PayOff)
                ) && 
                (
                    this.PtyCode == other.PtyCode ||
                    this.PtyCode != null &&
                    this.PtyCode.Equals(other.PtyCode)
                ) && 
                (
                    this.PtyType == other.PtyType ||
                    this.PtyType != null &&
                    this.PtyType.Equals(other.PtyType)
                ) && 
                (
                    this.StationKey == other.StationKey ||
                    this.StationKey != null &&
                    this.StationKey.Equals(other.StationKey)
                ) && 
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
                ) && 
                (
                    this.StartDays == other.StartDays ||
                    this.StartDays != null &&
                    this.StartDays.Equals(other.StartDays)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                if (this.SystemName != null)
                    hash = hash * 59 + this.SystemName.GetHashCode();
                if (this.ShortName != null)
                    hash = hash * 59 + this.ShortName.GetHashCode();
                if (this.MediumName != null)
                    hash = hash * 59 + this.MediumName.GetHashCode();
                if (this.Website != null)
                    hash = hash * 59 + this.Website.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Keywords != null)
                    hash = hash * 59 + this.Keywords.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Sms != null)
                    hash = hash * 59 + this.Sms.GetHashCode();
                if (this.Telephone != null)
                    hash = hash * 59 + this.Telephone.GetHashCode();
                if (this.GenreId != null)
                    hash = hash * 59 + this.GenreId.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                if (this.LogoRectangle != null)
                    hash = hash * 59 + this.LogoRectangle.GetHashCode();
                if (this.Logo128x128 != null)
                    hash = hash * 59 + this.Logo128x128.GetHashCode();
                if (this.Logo320x320 != null)
                    hash = hash * 59 + this.Logo320x320.GetHashCode();
                if (this.Logo600x600 != null)
                    hash = hash * 59 + this.Logo600x600.GetHashCode();
                if (this.PayOff != null)
                    hash = hash * 59 + this.PayOff.GetHashCode();
                if (this.PtyCode != null)
                    hash = hash * 59 + this.PtyCode.GetHashCode();
                if (this.PtyType != null)
                    hash = hash * 59 + this.PtyType.GetHashCode();
                if (this.StationKey != null)
                    hash = hash * 59 + this.StationKey.GetHashCode();
                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();
                if (this.StartDays != null)
                    hash = hash * 59 + this.StartDays.GetHashCode();
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
