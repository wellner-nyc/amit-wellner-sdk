/* 
 * The One Api
 *
 * API for the-one-api.dev
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TheOneSDK.Model
{
    /// <summary>
    /// Model for Movie
    /// </summary>
    [DataContract]
    public partial class Movie :  IEquatable<Movie>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Movie" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Movie() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Movie" /> class.
        /// </summary>
        /// <param name="Docs">Docs (required).</param>
        /// <param name="Limit">Limit.</param>
        /// <param name="Offset">Offset.</param>
        /// <param name="Page">Page.</param>
        /// <param name="Pages">Pages.</param>
        /// <param name="Total">Total.</param>
        public Movie(List<Docs> Docs = null, int? Limit = null, int? Offset = null, int? Page = null, int? Pages = null, int? Total = null)
        {
            // to ensure "Docs" is required (not null)
            if (Docs == null)
            {
                throw new InvalidDataException("Docs is a required property for Movie and cannot be null");
            }
            else
            {
                this.Docs = Docs;
            }
            this.Limit = Limit;
            this.Offset = Offset;
            this.Page = Page;
            this.Pages = Pages;
            this.Total = Total;
        }
        
        /// <summary>
        /// Gets or Sets Docs
        /// </summary>
        [DataMember(Name="docs", EmitDefaultValue=false)]
        public List<Docs> Docs { get; set; }
        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }
        /// <summary>
        /// Gets or Sets Offset
        /// </summary>
        [DataMember(Name="offset", EmitDefaultValue=false)]
        public int? Offset { get; set; }
        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public int? Page { get; set; }
        /// <summary>
        /// Gets or Sets Pages
        /// </summary>
        [DataMember(Name="pages", EmitDefaultValue=false)]
        public int? Pages { get; set; }
        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Movie {\n");
            sb.Append("  Docs: ").Append(Docs).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Pages: ").Append(Pages).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(obj as Movie);
        }

        /// <summary>
        /// Returns true if Movie instances are equal
        /// </summary>
        /// <param name="other">Instance of Movie to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Movie other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Docs == other.Docs ||
                    this.Docs != null &&
                    this.Docs.SequenceEqual(other.Docs)
                ) && 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
                ) && 
                (
                    this.Offset == other.Offset ||
                    this.Offset != null &&
                    this.Offset.Equals(other.Offset)
                ) && 
                (
                    this.Page == other.Page ||
                    this.Page != null &&
                    this.Page.Equals(other.Page)
                ) && 
                (
                    this.Pages == other.Pages ||
                    this.Pages != null &&
                    this.Pages.Equals(other.Pages)
                ) && 
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
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
                if (this.Docs != null)
                    hash = hash * 59 + this.Docs.GetHashCode();
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                if (this.Offset != null)
                    hash = hash * 59 + this.Offset.GetHashCode();
                if (this.Page != null)
                    hash = hash * 59 + this.Page.GetHashCode();
                if (this.Pages != null)
                    hash = hash * 59 + this.Pages.GetHashCode();
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                return hash;
            }
        }
    }

}
