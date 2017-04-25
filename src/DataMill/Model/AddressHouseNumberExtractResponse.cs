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
    /// Response of successful transformation request for /address/housenumber/extract
    /// </summary>
    [DataContract]
    public partial class AddressHouseNumberExtractResponse :  IEquatable<AddressHouseNumberExtractResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressHouseNumberExtractResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddressHouseNumberExtractResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressHouseNumberExtractResponse" /> class.
        /// </summary>
        /// <param name="Street">The extracted street name (required).</param>
        /// <param name="Housenumber">House number including additional house number information (required).</param>
        /// <param name="HousenumberOnly">House number excluding additional house number information (required).</param>
        /// <param name="HousenumberAddition">Additional house number information (required).</param>
        public AddressHouseNumberExtractResponse(string Street = null, string Housenumber = null, string HousenumberOnly = null, string HousenumberAddition = null)
        {
            // to ensure "Street" is required (not null)
            if (Street == null)
            {
                throw new InvalidDataException("Street is a required property for AddressHouseNumberExtractResponse and cannot be null");
            }
            else
            {
                this.Street = Street;
            }
            // to ensure "Housenumber" is required (not null)
            if (Housenumber == null)
            {
                throw new InvalidDataException("Housenumber is a required property for AddressHouseNumberExtractResponse and cannot be null");
            }
            else
            {
                this.Housenumber = Housenumber;
            }
            // to ensure "HousenumberOnly" is required (not null)
            if (HousenumberOnly == null)
            {
                throw new InvalidDataException("HousenumberOnly is a required property for AddressHouseNumberExtractResponse and cannot be null");
            }
            else
            {
                this.HousenumberOnly = HousenumberOnly;
            }
            // to ensure "HousenumberAddition" is required (not null)
            if (HousenumberAddition == null)
            {
                throw new InvalidDataException("HousenumberAddition is a required property for AddressHouseNumberExtractResponse and cannot be null");
            }
            else
            {
                this.HousenumberAddition = HousenumberAddition;
            }
        }
        
        /// <summary>
        /// The extracted street name
        /// </summary>
        /// <value>The extracted street name</value>
        [DataMember(Name="street", EmitDefaultValue=false)]
        public string Street { get; set; }
        /// <summary>
        /// House number including additional house number information
        /// </summary>
        /// <value>House number including additional house number information</value>
        [DataMember(Name="housenumber", EmitDefaultValue=false)]
        public string Housenumber { get; set; }
        /// <summary>
        /// House number excluding additional house number information
        /// </summary>
        /// <value>House number excluding additional house number information</value>
        [DataMember(Name="housenumber_only", EmitDefaultValue=false)]
        public string HousenumberOnly { get; set; }
        /// <summary>
        /// Additional house number information
        /// </summary>
        /// <value>Additional house number information</value>
        [DataMember(Name="housenumber_addition", EmitDefaultValue=false)]
        public string HousenumberAddition { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressHouseNumberExtractResponse {\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  Housenumber: ").Append(Housenumber).Append("\n");
            sb.Append("  HousenumberOnly: ").Append(HousenumberOnly).Append("\n");
            sb.Append("  HousenumberAddition: ").Append(HousenumberAddition).Append("\n");
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
            return this.Equals(obj as AddressHouseNumberExtractResponse);
        }

        /// <summary>
        /// Returns true if AddressHouseNumberExtractResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AddressHouseNumberExtractResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressHouseNumberExtractResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Street == other.Street ||
                    this.Street != null &&
                    this.Street.Equals(other.Street)
                ) && 
                (
                    this.Housenumber == other.Housenumber ||
                    this.Housenumber != null &&
                    this.Housenumber.Equals(other.Housenumber)
                ) && 
                (
                    this.HousenumberOnly == other.HousenumberOnly ||
                    this.HousenumberOnly != null &&
                    this.HousenumberOnly.Equals(other.HousenumberOnly)
                ) && 
                (
                    this.HousenumberAddition == other.HousenumberAddition ||
                    this.HousenumberAddition != null &&
                    this.HousenumberAddition.Equals(other.HousenumberAddition)
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
                if (this.Street != null)
                    hash = hash * 59 + this.Street.GetHashCode();
                if (this.Housenumber != null)
                    hash = hash * 59 + this.Housenumber.GetHashCode();
                if (this.HousenumberOnly != null)
                    hash = hash * 59 + this.HousenumberOnly.GetHashCode();
                if (this.HousenumberAddition != null)
                    hash = hash * 59 + this.HousenumberAddition.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
