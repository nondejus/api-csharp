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
    /// Response of successful transformation request for /url/check
    /// </summary>
    [DataContract]
    public partial class UrlCheckResponse :  IEquatable<UrlCheckResponse>, IValidatableObject
    {
        /// <summary>
        /// Flag if the root resource (website) is valid or not [0, 1]
        /// </summary>
        /// <value>Flag if the root resource (website) is valid or not [0, 1]</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValidEnum
        {
            
            /// <summary>
            /// Enum NUMBER_0 for 0
            /// </summary>
            [EnumMember(Value = "0")]
            NUMBER_0 = 0,
            
            /// <summary>
            /// Enum NUMBER_1 for 1
            /// </summary>
            [EnumMember(Value = "1")]
            NUMBER_1 = 1
        }

        /// <summary>
        /// Flag if the root resource (website) is valid or not [0, 1]
        /// </summary>
        /// <value>Flag if the root resource (website) is valid or not [0, 1]</value>
        [DataMember(Name="valid", EmitDefaultValue=false)]
        public ValidEnum? Valid { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UrlCheckResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UrlCheckResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UrlCheckResponse" /> class.
        /// </summary>
        /// <param name="Valid">Flag if the root resource (website) is valid or not [0, 1] (required).</param>
        /// <param name="Url">The final url of the resource (required).</param>
        /// <param name="HttpCode">The HTTP status code according to https://en.wikipedia.org/wiki/List_of_HTTP_status_codes (required).</param>
        /// <param name="TotalTime">Total time of the request in seconds (required).</param>
        /// <param name="NamelookupTime">Time until host name resolved in seconds (required).</param>
        /// <param name="ConnectTime">Time until connection established in seconds (required).</param>
        /// <param name="PretransferTime">Time until file transfer began in seconds (required).</param>
        /// <param name="StarttransferTime">Time to first byte in seconds (required).</param>
        /// <param name="PrimaryIp">IP address of the most recent connection (required).</param>
        /// <param name="PrimaryPort">Destination port of the connection (required).</param>
        /// <param name="DownloadContentLength">Number of bytes to download from the resource (-1 means no information available; will be removed in future versions / deprecated) (required).</param>
        /// <param name="ContentType">Content type of the requested resource (required).</param>
        /// <param name="Redirects">Array collection of all urls including redirects (required).</param>
        /// <param name="Parameters">Array collection of all url parameters (required).</param>
        public UrlCheckResponse(ValidEnum? Valid = null, string Url = null, long? HttpCode = null, float? TotalTime = null, float? NamelookupTime = null, float? ConnectTime = null, float? PretransferTime = null, float? StarttransferTime = null, string PrimaryIp = null, long? PrimaryPort = null, long? DownloadContentLength = null, string ContentType = null, List<Object> Redirects = null, List<Object> Parameters = null)
        {
            // to ensure "Valid" is required (not null)
            if (Valid == null)
            {
                throw new InvalidDataException("Valid is a required property for UrlCheckResponse and cannot be null");
            }
            else
            {
                this.Valid = Valid;
            }
            // to ensure "Url" is required (not null)
            if (Url == null)
            {
                throw new InvalidDataException("Url is a required property for UrlCheckResponse and cannot be null");
            }
            else
            {
                this.Url = Url;
            }
            // to ensure "HttpCode" is required (not null)
            if (HttpCode == null)
            {
                throw new InvalidDataException("HttpCode is a required property for UrlCheckResponse and cannot be null");
            }
            else
            {
                this.HttpCode = HttpCode;
            }
            // to ensure "TotalTime" is required (not null)
            if (TotalTime == null)
            {
                throw new InvalidDataException("TotalTime is a required property for UrlCheckResponse and cannot be null");
            }
            else
            {
                this.TotalTime = TotalTime;
            }
            // to ensure "NamelookupTime" is required (not null)
            if (NamelookupTime == null)
            {
                throw new InvalidDataException("NamelookupTime is a required property for UrlCheckResponse and cannot be null");
            }
            else
            {
                this.NamelookupTime = NamelookupTime;
            }
            // to ensure "ConnectTime" is required (not null)
            if (ConnectTime == null)
            {
                throw new InvalidDataException("ConnectTime is a required property for UrlCheckResponse and cannot be null");
            }
            else
            {
                this.ConnectTime = ConnectTime;
            }
            // to ensure "PretransferTime" is required (not null)
            if (PretransferTime == null)
            {
                throw new InvalidDataException("PretransferTime is a required property for UrlCheckResponse and cannot be null");
            }
            else
            {
                this.PretransferTime = PretransferTime;
            }
            // to ensure "StarttransferTime" is required (not null)
            if (StarttransferTime == null)
            {
                throw new InvalidDataException("StarttransferTime is a required property for UrlCheckResponse and cannot be null");
            }
            else
            {
                this.StarttransferTime = StarttransferTime;
            }
            // to ensure "PrimaryIp" is required (not null)
            if (PrimaryIp == null)
            {
                throw new InvalidDataException("PrimaryIp is a required property for UrlCheckResponse and cannot be null");
            }
            else
            {
                this.PrimaryIp = PrimaryIp;
            }
            // to ensure "PrimaryPort" is required (not null)
            if (PrimaryPort == null)
            {
                throw new InvalidDataException("PrimaryPort is a required property for UrlCheckResponse and cannot be null");
            }
            else
            {
                this.PrimaryPort = PrimaryPort;
            }
            // to ensure "DownloadContentLength" is required (not null)
            if (DownloadContentLength == null)
            {
                throw new InvalidDataException("DownloadContentLength is a required property for UrlCheckResponse and cannot be null");
            }
            else
            {
                this.DownloadContentLength = DownloadContentLength;
            }
            // to ensure "ContentType" is required (not null)
            if (ContentType == null)
            {
                throw new InvalidDataException("ContentType is a required property for UrlCheckResponse and cannot be null");
            }
            else
            {
                this.ContentType = ContentType;
            }
            // to ensure "Redirects" is required (not null)
            if (Redirects == null)
            {
                throw new InvalidDataException("Redirects is a required property for UrlCheckResponse and cannot be null");
            }
            else
            {
                this.Redirects = Redirects;
            }
            // to ensure "Parameters" is required (not null)
            if (Parameters == null)
            {
                throw new InvalidDataException("Parameters is a required property for UrlCheckResponse and cannot be null");
            }
            else
            {
                this.Parameters = Parameters;
            }
        }
        
        /// <summary>
        /// The final url of the resource
        /// </summary>
        /// <value>The final url of the resource</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        /// <summary>
        /// The HTTP status code according to https://en.wikipedia.org/wiki/List_of_HTTP_status_codes
        /// </summary>
        /// <value>The HTTP status code according to https://en.wikipedia.org/wiki/List_of_HTTP_status_codes</value>
        [DataMember(Name="http_code", EmitDefaultValue=false)]
        public long? HttpCode { get; set; }
        /// <summary>
        /// Total time of the request in seconds
        /// </summary>
        /// <value>Total time of the request in seconds</value>
        [DataMember(Name="total_time", EmitDefaultValue=false)]
        public float? TotalTime { get; set; }
        /// <summary>
        /// Time until host name resolved in seconds
        /// </summary>
        /// <value>Time until host name resolved in seconds</value>
        [DataMember(Name="namelookup_time", EmitDefaultValue=false)]
        public float? NamelookupTime { get; set; }
        /// <summary>
        /// Time until connection established in seconds
        /// </summary>
        /// <value>Time until connection established in seconds</value>
        [DataMember(Name="connect_time", EmitDefaultValue=false)]
        public float? ConnectTime { get; set; }
        /// <summary>
        /// Time until file transfer began in seconds
        /// </summary>
        /// <value>Time until file transfer began in seconds</value>
        [DataMember(Name="pretransfer_time", EmitDefaultValue=false)]
        public float? PretransferTime { get; set; }
        /// <summary>
        /// Time to first byte in seconds
        /// </summary>
        /// <value>Time to first byte in seconds</value>
        [DataMember(Name="starttransfer_time", EmitDefaultValue=false)]
        public float? StarttransferTime { get; set; }
        /// <summary>
        /// IP address of the most recent connection
        /// </summary>
        /// <value>IP address of the most recent connection</value>
        [DataMember(Name="primary_ip", EmitDefaultValue=false)]
        public string PrimaryIp { get; set; }
        /// <summary>
        /// Destination port of the connection
        /// </summary>
        /// <value>Destination port of the connection</value>
        [DataMember(Name="primary_port", EmitDefaultValue=false)]
        public long? PrimaryPort { get; set; }
        /// <summary>
        /// Number of bytes to download from the resource (-1 means no information available; will be removed in future versions / deprecated)
        /// </summary>
        /// <value>Number of bytes to download from the resource (-1 means no information available; will be removed in future versions / deprecated)</value>
        [DataMember(Name="download_content_length", EmitDefaultValue=false)]
        public long? DownloadContentLength { get; set; }
        /// <summary>
        /// Content type of the requested resource
        /// </summary>
        /// <value>Content type of the requested resource</value>
        [DataMember(Name="content_type", EmitDefaultValue=false)]
        public string ContentType { get; set; }
        /// <summary>
        /// Array collection of all urls including redirects
        /// </summary>
        /// <value>Array collection of all urls including redirects</value>
        [DataMember(Name="redirects", EmitDefaultValue=false)]
        public List<Object> Redirects { get; set; }
        /// <summary>
        /// Array collection of all url parameters
        /// </summary>
        /// <value>Array collection of all url parameters</value>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public List<Object> Parameters { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UrlCheckResponse {\n");
            sb.Append("  Valid: ").Append(Valid).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  HttpCode: ").Append(HttpCode).Append("\n");
            sb.Append("  TotalTime: ").Append(TotalTime).Append("\n");
            sb.Append("  NamelookupTime: ").Append(NamelookupTime).Append("\n");
            sb.Append("  ConnectTime: ").Append(ConnectTime).Append("\n");
            sb.Append("  PretransferTime: ").Append(PretransferTime).Append("\n");
            sb.Append("  StarttransferTime: ").Append(StarttransferTime).Append("\n");
            sb.Append("  PrimaryIp: ").Append(PrimaryIp).Append("\n");
            sb.Append("  PrimaryPort: ").Append(PrimaryPort).Append("\n");
            sb.Append("  DownloadContentLength: ").Append(DownloadContentLength).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Redirects: ").Append(Redirects).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
            return this.Equals(obj as UrlCheckResponse);
        }

        /// <summary>
        /// Returns true if UrlCheckResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of UrlCheckResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UrlCheckResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Valid == other.Valid ||
                    this.Valid != null &&
                    this.Valid.Equals(other.Valid)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.HttpCode == other.HttpCode ||
                    this.HttpCode != null &&
                    this.HttpCode.Equals(other.HttpCode)
                ) && 
                (
                    this.TotalTime == other.TotalTime ||
                    this.TotalTime != null &&
                    this.TotalTime.Equals(other.TotalTime)
                ) && 
                (
                    this.NamelookupTime == other.NamelookupTime ||
                    this.NamelookupTime != null &&
                    this.NamelookupTime.Equals(other.NamelookupTime)
                ) && 
                (
                    this.ConnectTime == other.ConnectTime ||
                    this.ConnectTime != null &&
                    this.ConnectTime.Equals(other.ConnectTime)
                ) && 
                (
                    this.PretransferTime == other.PretransferTime ||
                    this.PretransferTime != null &&
                    this.PretransferTime.Equals(other.PretransferTime)
                ) && 
                (
                    this.StarttransferTime == other.StarttransferTime ||
                    this.StarttransferTime != null &&
                    this.StarttransferTime.Equals(other.StarttransferTime)
                ) && 
                (
                    this.PrimaryIp == other.PrimaryIp ||
                    this.PrimaryIp != null &&
                    this.PrimaryIp.Equals(other.PrimaryIp)
                ) && 
                (
                    this.PrimaryPort == other.PrimaryPort ||
                    this.PrimaryPort != null &&
                    this.PrimaryPort.Equals(other.PrimaryPort)
                ) && 
                (
                    this.DownloadContentLength == other.DownloadContentLength ||
                    this.DownloadContentLength != null &&
                    this.DownloadContentLength.Equals(other.DownloadContentLength)
                ) && 
                (
                    this.ContentType == other.ContentType ||
                    this.ContentType != null &&
                    this.ContentType.Equals(other.ContentType)
                ) && 
                (
                    this.Redirects == other.Redirects ||
                    this.Redirects != null &&
                    this.Redirects.SequenceEqual(other.Redirects)
                ) && 
                (
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(other.Parameters)
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
                if (this.Valid != null)
                    hash = hash * 59 + this.Valid.GetHashCode();
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                if (this.HttpCode != null)
                    hash = hash * 59 + this.HttpCode.GetHashCode();
                if (this.TotalTime != null)
                    hash = hash * 59 + this.TotalTime.GetHashCode();
                if (this.NamelookupTime != null)
                    hash = hash * 59 + this.NamelookupTime.GetHashCode();
                if (this.ConnectTime != null)
                    hash = hash * 59 + this.ConnectTime.GetHashCode();
                if (this.PretransferTime != null)
                    hash = hash * 59 + this.PretransferTime.GetHashCode();
                if (this.StarttransferTime != null)
                    hash = hash * 59 + this.StarttransferTime.GetHashCode();
                if (this.PrimaryIp != null)
                    hash = hash * 59 + this.PrimaryIp.GetHashCode();
                if (this.PrimaryPort != null)
                    hash = hash * 59 + this.PrimaryPort.GetHashCode();
                if (this.DownloadContentLength != null)
                    hash = hash * 59 + this.DownloadContentLength.GetHashCode();
                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();
                if (this.Redirects != null)
                    hash = hash * 59 + this.Redirects.GetHashCode();
                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
