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

namespace IO.Swagger.Model
{
    /// <summary>
    /// Single item for results array within response of successful transformation request for /business-data/duns/search
    /// </summary>
    [DataContract]
    public partial class BusinessDataDunsSearchResult :  IEquatable<BusinessDataDunsSearchResult>, IValidatableObject
    {
        /// <summary>
        /// One-letter code describing the company's branch: **B**: branch, **N**: not a branch, **H**: headquarter, **S**: single location 
        /// </summary>
        /// <value>One-letter code describing the company's branch: **B**: branch, **N**: not a branch, **H**: headquarter, **S**: single location </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BranchCodeEnum
        {
            
            /// <summary>
            /// Enum B for "B"
            /// </summary>
            [EnumMember(Value = "B")]
            B,
            
            /// <summary>
            /// Enum N for "N"
            /// </summary>
            [EnumMember(Value = "N")]
            N,
            
            /// <summary>
            /// Enum H for "H"
            /// </summary>
            [EnumMember(Value = "H")]
            H,
            
            /// <summary>
            /// Enum S for "S"
            /// </summary>
            [EnumMember(Value = "S")]
            S
        }

        /// <summary>
        /// Description of the company's branch
        /// </summary>
        /// <value>Description of the company's branch</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BranchDescriptionEnum
        {
            
            /// <summary>
            /// Enum Branch for "branch"
            /// </summary>
            [EnumMember(Value = "branch")]
            Branch,
            
            /// <summary>
            /// Enum Notabranch for "not a branch"
            /// </summary>
            [EnumMember(Value = "not a branch")]
            Notabranch,
            
            /// <summary>
            /// Enum Headquarter for "headquarter"
            /// </summary>
            [EnumMember(Value = "headquarter")]
            Headquarter,
            
            /// <summary>
            /// Enum Singlelocation for "single location"
            /// </summary>
            [EnumMember(Value = "single location")]
            Singlelocation
        }

        /// <summary>
        /// One-letter code describing the company's branch: **B**: branch, **N**: not a branch, **H**: headquarter, **S**: single location 
        /// </summary>
        /// <value>One-letter code describing the company's branch: **B**: branch, **N**: not a branch, **H**: headquarter, **S**: single location </value>
        [DataMember(Name="branch_code", EmitDefaultValue=false)]
        public BranchCodeEnum? BranchCode { get; set; }
        /// <summary>
        /// Description of the company's branch
        /// </summary>
        /// <value>Description of the company's branch</value>
        [DataMember(Name="branch_description", EmitDefaultValue=false)]
        public BranchDescriptionEnum? BranchDescription { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessDataDunsSearchResult" /> class.
        /// </summary>
        /// <param name="CompanyName">The official company name.</param>
        /// <param name="City">The city of the company&#39;s address.</param>
        /// <param name="Zip">The zip of the company&#39;s address.</param>
        /// <param name="Street">The street of the company&#39;s address.</param>
        /// <param name="HouseNumber">The house number of the company&#39;s address.</param>
        /// <param name="DunsNumber">The company&#39;s D-U-N-S number.</param>
        /// <param name="DunsNumberHq">Optional the D-U-N-S number of the company&#39;s headquarters if this isn&#39;t the headquarter.</param>
        /// <param name="PhoneNumber">The company&#39;s phone number.</param>
        /// <param name="BranchCode">One-letter code describing the company&#39;s branch: **B**: branch, **N**: not a branch, **H**: headquarter, **S**: single location .</param>
        /// <param name="BranchDescription">Description of the company&#39;s branch.</param>
        /// <param name="Score">Internal ranking for all results compared with each other. the value is normalized between **0** and **1** (**1** is the best matching result and **0** the least one).</param>
        public BusinessDataDunsSearchResult(string CompanyName = null, string City = null, string Zip = null, string Street = null, string HouseNumber = null, string DunsNumber = null, string DunsNumberHq = null, string PhoneNumber = null, BranchCodeEnum? BranchCode = null, BranchDescriptionEnum? BranchDescription = null, float? Score = null)
        {
            this.CompanyName = CompanyName;
            this.City = City;
            this.Zip = Zip;
            this.Street = Street;
            this.HouseNumber = HouseNumber;
            this.DunsNumber = DunsNumber;
            this.DunsNumberHq = DunsNumberHq;
            this.PhoneNumber = PhoneNumber;
            this.BranchCode = BranchCode;
            this.BranchDescription = BranchDescription;
            this.Score = Score;
        }
        
        /// <summary>
        /// The official company name
        /// </summary>
        /// <value>The official company name</value>
        [DataMember(Name="company_name", EmitDefaultValue=false)]
        public string CompanyName { get; set; }
        /// <summary>
        /// The city of the company&#39;s address
        /// </summary>
        /// <value>The city of the company&#39;s address</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
        /// <summary>
        /// The zip of the company&#39;s address
        /// </summary>
        /// <value>The zip of the company&#39;s address</value>
        [DataMember(Name="zip", EmitDefaultValue=false)]
        public string Zip { get; set; }
        /// <summary>
        /// The street of the company&#39;s address
        /// </summary>
        /// <value>The street of the company&#39;s address</value>
        [DataMember(Name="street", EmitDefaultValue=false)]
        public string Street { get; set; }
        /// <summary>
        /// The house number of the company&#39;s address
        /// </summary>
        /// <value>The house number of the company&#39;s address</value>
        [DataMember(Name="house_number", EmitDefaultValue=false)]
        public string HouseNumber { get; set; }
        /// <summary>
        /// The company&#39;s D-U-N-S number
        /// </summary>
        /// <value>The company&#39;s D-U-N-S number</value>
        [DataMember(Name="duns_number", EmitDefaultValue=false)]
        public string DunsNumber { get; set; }
        /// <summary>
        /// Optional the D-U-N-S number of the company&#39;s headquarters if this isn&#39;t the headquarter
        /// </summary>
        /// <value>Optional the D-U-N-S number of the company&#39;s headquarters if this isn&#39;t the headquarter</value>
        [DataMember(Name="duns_number_hq", EmitDefaultValue=false)]
        public string DunsNumberHq { get; set; }
        /// <summary>
        /// The company&#39;s phone number
        /// </summary>
        /// <value>The company&#39;s phone number</value>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Internal ranking for all results compared with each other. the value is normalized between **0** and **1** (**1** is the best matching result and **0** the least one)
        /// </summary>
        /// <value>Internal ranking for all results compared with each other. the value is normalized between **0** and **1** (**1** is the best matching result and **0** the least one)</value>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public float? Score { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessDataDunsSearchResult {\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  HouseNumber: ").Append(HouseNumber).Append("\n");
            sb.Append("  DunsNumber: ").Append(DunsNumber).Append("\n");
            sb.Append("  DunsNumberHq: ").Append(DunsNumberHq).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  BranchCode: ").Append(BranchCode).Append("\n");
            sb.Append("  BranchDescription: ").Append(BranchDescription).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
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
            return this.Equals(obj as BusinessDataDunsSearchResult);
        }

        /// <summary>
        /// Returns true if BusinessDataDunsSearchResult instances are equal
        /// </summary>
        /// <param name="other">Instance of BusinessDataDunsSearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessDataDunsSearchResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CompanyName == other.CompanyName ||
                    this.CompanyName != null &&
                    this.CompanyName.Equals(other.CompanyName)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.Zip == other.Zip ||
                    this.Zip != null &&
                    this.Zip.Equals(other.Zip)
                ) && 
                (
                    this.Street == other.Street ||
                    this.Street != null &&
                    this.Street.Equals(other.Street)
                ) && 
                (
                    this.HouseNumber == other.HouseNumber ||
                    this.HouseNumber != null &&
                    this.HouseNumber.Equals(other.HouseNumber)
                ) && 
                (
                    this.DunsNumber == other.DunsNumber ||
                    this.DunsNumber != null &&
                    this.DunsNumber.Equals(other.DunsNumber)
                ) && 
                (
                    this.DunsNumberHq == other.DunsNumberHq ||
                    this.DunsNumberHq != null &&
                    this.DunsNumberHq.Equals(other.DunsNumberHq)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.BranchCode == other.BranchCode ||
                    this.BranchCode != null &&
                    this.BranchCode.Equals(other.BranchCode)
                ) && 
                (
                    this.BranchDescription == other.BranchDescription ||
                    this.BranchDescription != null &&
                    this.BranchDescription.Equals(other.BranchDescription)
                ) && 
                (
                    this.Score == other.Score ||
                    this.Score != null &&
                    this.Score.Equals(other.Score)
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
                if (this.CompanyName != null)
                    hash = hash * 59 + this.CompanyName.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.Zip != null)
                    hash = hash * 59 + this.Zip.GetHashCode();
                if (this.Street != null)
                    hash = hash * 59 + this.Street.GetHashCode();
                if (this.HouseNumber != null)
                    hash = hash * 59 + this.HouseNumber.GetHashCode();
                if (this.DunsNumber != null)
                    hash = hash * 59 + this.DunsNumber.GetHashCode();
                if (this.DunsNumberHq != null)
                    hash = hash * 59 + this.DunsNumberHq.GetHashCode();
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                if (this.BranchCode != null)
                    hash = hash * 59 + this.BranchCode.GetHashCode();
                if (this.BranchDescription != null)
                    hash = hash * 59 + this.BranchDescription.GetHashCode();
                if (this.Score != null)
                    hash = hash * 59 + this.Score.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}