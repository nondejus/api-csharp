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
    ///  Class for testing GenderApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class GenderApiTests
    {
        private GenderApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GenderApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GenderApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' GenderApi
            //Assert.IsInstanceOfType(typeof(GenderApi), instance, "instance is a GenderApi");
        }

        
        /// <summary>
        /// Test GetGender
        /// </summary>
        [Test]
        public void GetGenderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string firstname = null;
            //var response = instance.GetGender(firstname);
            //Assert.IsInstanceOf<GenderGetResponse> (response, "response is GenderGetResponse");
        }
        
        /// <summary>
        /// Test GetGenderExtended
        /// </summary>
        [Test]
        public void GetGenderExtendedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string firstname = null;
            //string countrycode = null;
            //var response = instance.GetGenderExtended(firstname, countrycode);
            //Assert.IsInstanceOf<GenderExtendedGetResponse> (response, "response is GenderExtendedGetResponse");
        }
        
    }

}
