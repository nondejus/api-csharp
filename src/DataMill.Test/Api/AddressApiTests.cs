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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using DataMill.Client;
using DataMill.Api;
using DataMill.Model;

namespace DataMill.Test
{
    /// <summary>
    ///  Class for testing AddressApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AddressApiTests
    {
        private AddressApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AddressApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AddressApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AddressApi
            //Assert.IsInstanceOfType(typeof(AddressApi), instance, "instance is a AddressApi");
        }

        
        /// <summary>
        /// Test ExtractHouseNumber
        /// </summary>
        [Test]
        public void ExtractHouseNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string street = null;
            //string housenumber = null;
            //var response = instance.ExtractHouseNumber(street, housenumber);
            //Assert.IsInstanceOf<AddressHouseNumberExtractResponse> (response, "response is AddressHouseNumberExtractResponse");
        }
        
        /// <summary>
        /// Test LocateAddress
        /// </summary>
        [Test]
        public void LocateAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string latitude = null;
            //string longitude = null;
            //string locale = null;
            //var response = instance.LocateAddress(latitude, longitude, locale);
            //Assert.IsInstanceOf<AddressSearchResponse> (response, "response is AddressSearchResponse");
        }
        
        /// <summary>
        /// Test SearchAddress
        /// </summary>
        [Test]
        public void SearchAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string country = null;
            //string state = null;
            //string county = null;
            //string city = null;
            //string zip = null;
            //string district = null;
            //string street = null;
            //string housenumber = null;
            //string locale = null;
            //var response = instance.SearchAddress(address, country, state, county, city, zip, district, street, housenumber, locale);
            //Assert.IsInstanceOf<AddressSearchResponse> (response, "response is AddressSearchResponse");
        }
        
        /// <summary>
        /// Test SearchAddressMultiple
        /// </summary>
        [Test]
        public void SearchAddressMultipleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string locale = null;
            //var response = instance.SearchAddressMultiple(address, locale);
            //Assert.IsInstanceOf<AddressSearchMultipleResponse> (response, "response is AddressSearchMultipleResponse");
        }
        
    }

}
