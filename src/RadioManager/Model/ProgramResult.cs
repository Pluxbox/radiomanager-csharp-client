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
    /// ProgramResult
    /// </summary>
    [DataContract]
        public partial class ProgramResult : ProgramOutputOnly,  IEquatable<ProgramResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramResult" /> class.
        /// </summary>
        /// <param name="modelTypeId">modelTypeId (required).</param>
        /// <param name="fieldValues">fieldValues.</param>
        /// <param name="title">title (required).</param>
        /// <param name="disabled">disabled.</param>
        /// <param name="genreId">genreId.</param>
        /// <param name="description">description.</param>
        /// <param name="shortName">shortName.</param>
        /// <param name="mediumName">mediumName.</param>
        /// <param name="website">website.</param>
        /// <param name="email">email.</param>
        /// <param name="recommended">recommended.</param>
        /// <param name="language">language.</param>
        /// <param name="ptyCodeId">ptyCodeId.</param>
        /// <param name="genre">genre.</param>
        /// <param name="items">items.</param>
        /// <param name="blocks">blocks.</param>
        /// <param name="broadcasts">broadcasts.</param>
        /// <param name="presenters">presenters.</param>
        /// <param name="tags">tags.</param>
        /// <param name="modelType">modelType.</param>
        public ProgramResult(long? modelTypeId = default(long?), Object fieldValues = default(Object), string title = default(string), bool? disabled = default(bool?), long? genreId = default(long?), string description = default(string), string shortName = default(string), string mediumName = default(string), string website = default(string), string email = default(string), bool? recommended = default(bool?), string language = default(string), long? ptyCodeId = default(long?), Object genre = default(Object), Object items = default(Object), Object blocks = default(Object), Object broadcasts = default(Object), Object presenters = default(Object), Object tags = default(Object), Object modelType = default(Object), long? modelTypeId = default(long?), Object fieldValues = default(Object), string title = default(string), Object modelType = default(Object), long? id = default(long?), DateTime? updatedAt = default(DateTime?), DateTime? createdAt = default(DateTime?), DateTime? deletedAt = default(DateTime?), long? externalStationId = default(long?)) : base(id, updatedAt, createdAt, deletedAt, externalStationId)
        {
            // to ensure "modelTypeId" is required (not null)
            if (modelTypeId == null)
            {
                throw new InvalidDataException("modelTypeId is a required property for ProgramResult and cannot be null");
            }
            else
            {
                this.ModelTypeId = modelTypeId;
            }
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for ProgramResult and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            this.FieldValues = fieldValues;
            this.Disabled = disabled;
            this.GenreId = genreId;
            this.Description = description;
            this.ShortName = shortName;
            this.MediumName = mediumName;
            this.Website = website;
            this.Email = email;
            this.Recommended = recommended;
            this.Language = language;
            this.PtyCodeId = ptyCodeId;
            this.Genre = genre;
            this.Items = items;
            this.Blocks = blocks;
            this.Broadcasts = broadcasts;
            this.Presenters = presenters;
            this.Tags = tags;
            this.ModelType = modelType;
        }
        
        /// <summary>
        /// Gets or Sets ModelTypeId
        /// </summary>
        [DataMember(Name="model_type_id", EmitDefaultValue=false)]
        public long? ModelTypeId { get; set; }

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
        /// Gets or Sets Disabled
        /// </summary>
        [DataMember(Name="disabled", EmitDefaultValue=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Gets or Sets GenreId
        /// </summary>
        [DataMember(Name="genre_id", EmitDefaultValue=false)]
        public long? GenreId { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

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
        /// Gets or Sets Recommended
        /// </summary>
        [DataMember(Name="recommended", EmitDefaultValue=false)]
        public bool? Recommended { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets PtyCodeId
        /// </summary>
        [DataMember(Name="pty_code_id", EmitDefaultValue=false)]
        public long? PtyCodeId { get; set; }

        /// <summary>
        /// Gets or Sets Genre
        /// </summary>
        [DataMember(Name="genre", EmitDefaultValue=false)]
        public Object Genre { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public Object Items { get; set; }

        /// <summary>
        /// Gets or Sets Blocks
        /// </summary>
        [DataMember(Name="blocks", EmitDefaultValue=false)]
        public Object Blocks { get; set; }

        /// <summary>
        /// Gets or Sets Broadcasts
        /// </summary>
        [DataMember(Name="broadcasts", EmitDefaultValue=false)]
        public Object Broadcasts { get; set; }

        /// <summary>
        /// Gets or Sets Presenters
        /// </summary>
        [DataMember(Name="presenters", EmitDefaultValue=false)]
        public Object Presenters { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public Object Tags { get; set; }

        /// <summary>
        /// Gets or Sets ModelType
        /// </summary>
        [DataMember(Name="model_type", EmitDefaultValue=false)]
        public Object ModelType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProgramResult {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ModelTypeId: ").Append(ModelTypeId).Append("\n");
            sb.Append("  FieldValues: ").Append(FieldValues).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  GenreId: ").Append(GenreId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  MediumName: ").Append(MediumName).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Recommended: ").Append(Recommended).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  PtyCodeId: ").Append(PtyCodeId).Append("\n");
            sb.Append("  Genre: ").Append(Genre).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Blocks: ").Append(Blocks).Append("\n");
            sb.Append("  Broadcasts: ").Append(Broadcasts).Append("\n");
            sb.Append("  Presenters: ").Append(Presenters).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  ModelType: ").Append(ModelType).Append("\n");
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
            return this.Equals(input as ProgramResult);
        }

        /// <summary>
        /// Returns true if ProgramResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ProgramResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProgramResult input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.ModelTypeId == input.ModelTypeId ||
                    (this.ModelTypeId != null &&
                    this.ModelTypeId.Equals(input.ModelTypeId))
                ) && base.Equals(input) && 
                (
                    this.FieldValues == input.FieldValues ||
                    (this.FieldValues != null &&
                    this.FieldValues.Equals(input.FieldValues))
                ) && base.Equals(input) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && base.Equals(input) && 
                (
                    this.Disabled == input.Disabled ||
                    (this.Disabled != null &&
                    this.Disabled.Equals(input.Disabled))
                ) && base.Equals(input) && 
                (
                    this.GenreId == input.GenreId ||
                    (this.GenreId != null &&
                    this.GenreId.Equals(input.GenreId))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.ShortName == input.ShortName ||
                    (this.ShortName != null &&
                    this.ShortName.Equals(input.ShortName))
                ) && base.Equals(input) && 
                (
                    this.MediumName == input.MediumName ||
                    (this.MediumName != null &&
                    this.MediumName.Equals(input.MediumName))
                ) && base.Equals(input) && 
                (
                    this.Website == input.Website ||
                    (this.Website != null &&
                    this.Website.Equals(input.Website))
                ) && base.Equals(input) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && base.Equals(input) && 
                (
                    this.Recommended == input.Recommended ||
                    (this.Recommended != null &&
                    this.Recommended.Equals(input.Recommended))
                ) && base.Equals(input) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && base.Equals(input) && 
                (
                    this.PtyCodeId == input.PtyCodeId ||
                    (this.PtyCodeId != null &&
                    this.PtyCodeId.Equals(input.PtyCodeId))
                ) && base.Equals(input) && 
                (
                    this.Genre == input.Genre ||
                    (this.Genre != null &&
                    this.Genre.Equals(input.Genre))
                ) && base.Equals(input) && 
                (
                    this.Items == input.Items ||
                    (this.Items != null &&
                    this.Items.Equals(input.Items))
                ) && base.Equals(input) && 
                (
                    this.Blocks == input.Blocks ||
                    (this.Blocks != null &&
                    this.Blocks.Equals(input.Blocks))
                ) && base.Equals(input) && 
                (
                    this.Broadcasts == input.Broadcasts ||
                    (this.Broadcasts != null &&
                    this.Broadcasts.Equals(input.Broadcasts))
                ) && base.Equals(input) && 
                (
                    this.Presenters == input.Presenters ||
                    (this.Presenters != null &&
                    this.Presenters.Equals(input.Presenters))
                ) && base.Equals(input) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && base.Equals(input) && 
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
                int hashCode = base.GetHashCode();
                if (this.ModelTypeId != null)
                    hashCode = hashCode * 59 + this.ModelTypeId.GetHashCode();
                if (this.FieldValues != null)
                    hashCode = hashCode * 59 + this.FieldValues.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Disabled != null)
                    hashCode = hashCode * 59 + this.Disabled.GetHashCode();
                if (this.GenreId != null)
                    hashCode = hashCode * 59 + this.GenreId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ShortName != null)
                    hashCode = hashCode * 59 + this.ShortName.GetHashCode();
                if (this.MediumName != null)
                    hashCode = hashCode * 59 + this.MediumName.GetHashCode();
                if (this.Website != null)
                    hashCode = hashCode * 59 + this.Website.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Recommended != null)
                    hashCode = hashCode * 59 + this.Recommended.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.PtyCodeId != null)
                    hashCode = hashCode * 59 + this.PtyCodeId.GetHashCode();
                if (this.Genre != null)
                    hashCode = hashCode * 59 + this.Genre.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.Blocks != null)
                    hashCode = hashCode * 59 + this.Blocks.GetHashCode();
                if (this.Broadcasts != null)
                    hashCode = hashCode * 59 + this.Broadcasts.GetHashCode();
                if (this.Presenters != null)
                    hashCode = hashCode * 59 + this.Presenters.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }
}
