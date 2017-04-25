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
    /// Google Plus information for /social-media/activities/get
    /// </summary>
    [DataContract]
    public partial class SocialMediaActivitiesGetGooglePlus :  IEquatable<SocialMediaActivitiesGetGooglePlus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SocialMediaActivitiesGetGooglePlus" /> class.
        /// </summary>
        /// <param name="Url">The fully qualified url to the person&#39;s profile.</param>
        /// <param name="Followers">The number of followers on Google Plus.</param>
        public SocialMediaActivitiesGetGooglePlus(string Url = null, long? Followers = null)
        {
            this.Url = Url;
            this.Followers = Followers;
        }
        
        /// <summary>
        /// The fully qualified url to the person&#39;s profile
        /// </summary>
        /// <value>The fully qualified url to the person&#39;s profile</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        /// <summary>
        /// The number of followers on Google Plus
        /// </summary>
        /// <value>The number of followers on Google Plus</value>
        [DataMember(Name="followers", EmitDefaultValue=false)]
        public long? Followers { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SocialMediaActivitiesGetGooglePlus {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Followers: ").Append(Followers).Append("\n");
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
            return this.Equals(obj as SocialMediaActivitiesGetGooglePlus);
        }

        /// <summary>
        /// Returns true if SocialMediaActivitiesGetGooglePlus instances are equal
        /// </summary>
        /// <param name="other">Instance of SocialMediaActivitiesGetGooglePlus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SocialMediaActivitiesGetGooglePlus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.Followers == other.Followers ||
                    this.Followers != null &&
                    this.Followers.Equals(other.Followers)
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
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                if (this.Followers != null)
                    hash = hash * 59 + this.Followers.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
