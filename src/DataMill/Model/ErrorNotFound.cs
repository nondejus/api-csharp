/* 
 * /data.mill for applications
 *
 * **&#47;data.mill for applications** is the most versatile and powerful API for all aspects of data quality in your business application.  Use **&#47;data.mill** to check, correct and enrich personal data and business information. The internationally applicable functions can be integrated easily into existing applications, whether desktop, online or mobile and thus enable you to professionally improve your customer or supplier database, directly in your system. Due to **&#47;data.mill**'s pay-per-use credit model there are no setup fees or fixed monthly subscription fees.  **&#47;data.mill** is constantly evolving and upgraded with the latest technology and data services available on the market. 
 *
 * OpenAPI spec version: 1.6.4
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
    /// Action, transformation or route not found
    /// </summary>
    [DataContract]
    public partial class ErrorNotFound :  IEquatable<ErrorNotFound>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorNotFound" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ErrorNotFound() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorNotFound" /> class.
        /// </summary>
        /// <param name="Errorcode">Unique error code for this error (required).</param>
        /// <param name="Errormessage">Description for this error (required).</param>
        public ErrorNotFound(long? Errorcode = null, string Errormessage = null)
        {
            // to ensure "Errorcode" is required (not null)
            if (Errorcode == null)
            {
                throw new InvalidDataException("Errorcode is a required property for ErrorNotFound and cannot be null");
            }
            else
            {
                this.Errorcode = Errorcode;
            }
            // to ensure "Errormessage" is required (not null)
            if (Errormessage == null)
            {
                throw new InvalidDataException("Errormessage is a required property for ErrorNotFound and cannot be null");
            }
            else
            {
                this.Errormessage = Errormessage;
            }
        }
        
        /// <summary>
        /// Unique error code for this error
        /// </summary>
        /// <value>Unique error code for this error</value>
        [DataMember(Name="errorcode", EmitDefaultValue=false)]
        public long? Errorcode { get; set; }
        /// <summary>
        /// Description for this error
        /// </summary>
        /// <value>Description for this error</value>
        [DataMember(Name="errormessage", EmitDefaultValue=false)]
        public string Errormessage { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorNotFound {\n");
            sb.Append("  Errorcode: ").Append(Errorcode).Append("\n");
            sb.Append("  Errormessage: ").Append(Errormessage).Append("\n");
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
            return this.Equals(obj as ErrorNotFound);
        }

        /// <summary>
        /// Returns true if ErrorNotFound instances are equal
        /// </summary>
        /// <param name="other">Instance of ErrorNotFound to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorNotFound other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Errorcode == other.Errorcode ||
                    this.Errorcode != null &&
                    this.Errorcode.Equals(other.Errorcode)
                ) && 
                (
                    this.Errormessage == other.Errormessage ||
                    this.Errormessage != null &&
                    this.Errormessage.Equals(other.Errormessage)
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
                if (this.Errorcode != null)
                    hash = hash * 59 + this.Errorcode.GetHashCode();
                if (this.Errormessage != null)
                    hash = hash * 59 + this.Errormessage.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
