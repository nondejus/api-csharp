/* 
 * /data.mill for applications
 *
 * **&#47;data.mill for applications** is the most versatile and powerful API for all aspects of data quality in your business application.  Use **&#47;data.mill** to check, correct and enrich personal data and business information. The internationally applicable functions can be integrated easily into existing applications, whether desktop, online or mobile and thus enable you to professionally improve your customer or supplier database, directly in your system. Due to **&#47;data.mill**'s pay-per-use credit model there are no setup fees or fixed monthly subscription fees.  **&#47;data.mill** is constantly evolving and upgraded with the latest technology and data services available on the market.  GitHub for SDKs: https://github.com/datamill-solutions 
 *
 * OpenAPI spec version: 1.6.5
 * Contact: info@datamill.solutions
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
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DataMill.Model
{
    /// <summary>
    /// Response of successful transformation request for /gender/get
    /// </summary>
    [DataContract]
    public partial class GenderGetResponse :  IEquatable<GenderGetResponse>, IValidatableObject
    {
        /// <summary>
        /// The gender of the first name where the following codes apply 'M' for male 'F' for female '?' for unknown gender 
        /// </summary>
        /// <value>The gender of the first name where the following codes apply 'M' for male 'F' for female '?' for unknown gender </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GenderEnum
        {
            
            /// <summary>
            /// Enum M for "M"
            /// </summary>
            [EnumMember(Value = "M")]
            M,
            
            /// <summary>
            /// Enum F for "F"
            /// </summary>
            [EnumMember(Value = "F")]
            F,
            
            /// <summary>
            /// Enum QuestionMark for "?"
            /// </summary>
            [EnumMember(Value = "?")]
            QuestionMark
        }

        /// <summary>
        /// The gender of the first name where the following codes apply 'M' for male 'F' for female '?' for unknown gender 
        /// </summary>
        /// <value>The gender of the first name where the following codes apply 'M' for male 'F' for female '?' for unknown gender </value>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        public GenderEnum? Gender { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenderGetResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GenderGetResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenderGetResponse" /> class.
        /// </summary>
        /// <param name="Gender">The gender of the first name where the following codes apply &#39;M&#39; for male &#39;F&#39; for female &#39;?&#39; for unknown gender  (required).</param>
        public GenderGetResponse(GenderEnum? Gender = null)
        {
            // to ensure "Gender" is required (not null)
            if (Gender == null)
            {
                throw new InvalidDataException("Gender is a required property for GenderGetResponse and cannot be null");
            }
            else
            {
                this.Gender = Gender;
            }
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenderGetResponse {\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
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
            return this.Equals(obj as GenderGetResponse);
        }

        /// <summary>
        /// Returns true if GenderGetResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GenderGetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenderGetResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Gender == other.Gender ||
                    this.Gender != null &&
                    this.Gender.Equals(other.Gender)
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
                if (this.Gender != null)
                    hash = hash * 59 + this.Gender.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
