# DataMill - the C# library for the /data.mill for applications

**&#47;data.mill for applications** is the most versatile and powerful API for all aspects of data quality in your business application.  Use **&#47;data.mill** to check, correct and enrich personal data and business information. The internationally applicable functions can be integrated easily into existing applications, whether desktop, online or mobile and thus enable you to professionally improve your customer or supplier database, directly in your system. Due to **&#47;data.mill**'s pay-per-use credit model there are no setup fees or fixed monthly subscription fees.  **&#47;data.mill** is constantly evolving and upgraded with the latest technology and data services available on the market.  GitHub for SDKs: https://github.com/datamill-solutions 

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.6.5
- SDK version: 0.0.2
- Build package: class io.swagger.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://datamill.solutions/en#contact-form](https://datamill.solutions/en#contact-form)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommned using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            
            var apiInstance = new AddressApi();
            var license = license_example;  // string | The license key is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var guid = guid_example;  // string | The guid is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var street = street_example;  // string | Free-form text containing the street name and optional the house number including additional house number information. The key is required if housenumber is empty or unset. (optional) 
            var housenumber = housenumber_example;  // string | Free-form text containing the house number including additional house number information and optional the street name. The key is required if street is empty or unset. (optional) 

            try
            {
                // Try to extract house number from street information
                AddressHouseNumberExtractResponse result = apiInstance.ExtractHouseNumber(license, guid, street, housenumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressApi.ExtractHouseNumber: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.methis.at*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AddressApi* | [**ExtractHouseNumber**](docs/AddressApi.md#extracthousenumber) | **POST** /address/housenumber/extract | Try to extract house number from street information
*AddressApi* | [**LocateAddress**](docs/AddressApi.md#locateaddress) | **POST** /address/locate | Reverse address lookup
*AddressApi* | [**SearchAddress**](docs/AddressApi.md#searchaddress) | **POST** /address/search | Lookup physical postal address
*AddressApi* | [**SearchAddressMultiple**](docs/AddressApi.md#searchaddressmultiple) | **POST** /address/search/multiple | Address lookup with multiple possible results
*BICApi* | [**CheckBIC**](docs/BICApi.md#checkbic) | **POST** /bic/check | Check BIC for spelling
*ConvertApi* | [**ConvertCapitalFirst**](docs/ConvertApi.md#convertcapitalfirst) | **POST** /convert/capitalfirst | Convert any string to capitalize words
*ConvertApi* | [**ConvertLowerCase**](docs/ConvertApi.md#convertlowercase) | **POST** /convert/lowercase | Convert any string to lower case
*ConvertApi* | [**ConvertUpperCase**](docs/ConvertApi.md#convertuppercase) | **POST** /convert/uppercase | Convert any string to upper case
*ConvertApi* | [**ConvertWrap**](docs/ConvertApi.md#convertwrap) | **POST** /convert/wrap | Wrap text
*DUNSApi* | [**GetDUNSRating**](docs/DUNSApi.md#getdunsrating) | **POST** /business-data/duns/rating | Get marketing information by DUNS number
*DUNSApi* | [**ResolveDUNS**](docs/DUNSApi.md#resolveduns) | **POST** /business-data/duns/resolve | Resolve company information by DUNS number
*DUNSApi* | [**SearchDUNS**](docs/DUNSApi.md#searchduns) | **POST** /business-data/duns/search | Find DUNS number and company information by name
*DeliveryInformationApi* | [**SearchUndeliverableContact**](docs/DeliveryInformationApi.md#searchundeliverablecontact) | **POST** /business-data/undeliverable-contacts/search | Find moved and deceased contacts
*EmailApi* | [**CheckEmailDomain**](docs/EmailApi.md#checkemaildomain) | **POST** /email/domain/check | Check email syntax and mail server domain
*EmailApi* | [**CheckEmailMailbox**](docs/EmailApi.md#checkemailmailbox) | **POST** /email/extended/check | Check email syntax, mail server domain and mailbox itself
*EmailApi* | [**CheckEmailSyntax**](docs/EmailApi.md#checkemailsyntax) | **POST** /email/syntax/check | Check email syntax
*FirstNameApi* | [**GetFirstNames**](docs/FirstNameApi.md#getfirstnames) | **POST** /firstname/get | Recognize and extract first names
*GenderApi* | [**GetGender**](docs/GenderApi.md#getgender) | **POST** /gender/get | Recognize gender by first name
*GenderApi* | [**GetGenderExtended**](docs/GenderApi.md#getgenderextended) | **POST** /gender/extended/get | Recognize gender by first name (advanced)
*IBANApi* | [**CheckIBAN**](docs/IBANApi.md#checkiban) | **POST** /iban/check | Check IBAN for spelling
*PhoneNumberApi* | [**CheckMobilePhone**](docs/PhoneNumberApi.md#checkmobilephone) | **POST** /phone/mobile/check | Verify mobile phone number
*PhoneNumberApi* | [**FormatPhoneNumber**](docs/PhoneNumberApi.md#formatphonenumber) | **POST** /phone/format | Parse, format and validate phone numbers
*PhoneNumberApi* | [**GetPhoneCountryCode**](docs/PhoneNumberApi.md#getphonecountrycode) | **POST** /phone/countrycode/get | International and national dial prefix
*SocialMediaApi* | [**GetSocialMediaActivities**](docs/SocialMediaApi.md#getsocialmediaactivities) | **POST** /social-media/activities/get | Retrieve social media data by email address
*URLApi* | [**CheckUrl**](docs/URLApi.md#checkurl) | **POST** /url/check | Information about web resources
*VATApi* | [**CheckVAT**](docs/VATApi.md#checkvat) | **POST** /vat/check | Check vat number for correctness
*VATApi* | [**ResolveVAT**](docs/VATApi.md#resolvevat) | **POST** /vat/resolve | Try to resolve VAT number to company information
*VATApi* | [**SearchVAT**](docs/VATApi.md#searchvat) | **POST** /vat/search | Find VAT number and company information by name


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AddressHouseNumberExtractResponse](docs/AddressHouseNumberExtractResponse.md)
 - [Model.AddressSearchMultipleResponse](docs/AddressSearchMultipleResponse.md)
 - [Model.AddressSearchResponse](docs/AddressSearchResponse.md)
 - [Model.BicCheckResponse](docs/BicCheckResponse.md)
 - [Model.BusinessDataDunsRatingResponse](docs/BusinessDataDunsRatingResponse.md)
 - [Model.BusinessDataDunsResolveResponse](docs/BusinessDataDunsResolveResponse.md)
 - [Model.BusinessDataDunsSearchResponse](docs/BusinessDataDunsSearchResponse.md)
 - [Model.BusinessDataDunsSearchResult](docs/BusinessDataDunsSearchResult.md)
 - [Model.BusinessDataUndeliverableContactsResponse](docs/BusinessDataUndeliverableContactsResponse.md)
 - [Model.BusinessDataUndeliverableContactsSearchContact](docs/BusinessDataUndeliverableContactsSearchContact.md)
 - [Model.ConvertCapitalFirstResponse](docs/ConvertCapitalFirstResponse.md)
 - [Model.ConvertLowerCaseResponse](docs/ConvertLowerCaseResponse.md)
 - [Model.ConvertUpperCaseResponse](docs/ConvertUpperCaseResponse.md)
 - [Model.ConvertWrapResponse](docs/ConvertWrapResponse.md)
 - [Model.EmailDomainCheckResponse](docs/EmailDomainCheckResponse.md)
 - [Model.EmailExtendedCheckResponse](docs/EmailExtendedCheckResponse.md)
 - [Model.EmailSyntaxCheckResponse](docs/EmailSyntaxCheckResponse.md)
 - [Model.ErrorForbidden](docs/ErrorForbidden.md)
 - [Model.ErrorIncorrectParameters](docs/ErrorIncorrectParameters.md)
 - [Model.ErrorInternalError](docs/ErrorInternalError.md)
 - [Model.ErrorMissingParameters](docs/ErrorMissingParameters.md)
 - [Model.ErrorNotAllowed](docs/ErrorNotAllowed.md)
 - [Model.ErrorNotFound](docs/ErrorNotFound.md)
 - [Model.ErrorQuotaExceeded](docs/ErrorQuotaExceeded.md)
 - [Model.ErrorServiceUnavailable](docs/ErrorServiceUnavailable.md)
 - [Model.ErrorUnauthorized](docs/ErrorUnauthorized.md)
 - [Model.FirstNameGetResponse](docs/FirstNameGetResponse.md)
 - [Model.GenderExtendedGetResponse](docs/GenderExtendedGetResponse.md)
 - [Model.GenderGetResponse](docs/GenderGetResponse.md)
 - [Model.IbanCheckResponse](docs/IbanCheckResponse.md)
 - [Model.PhoneCountryCodeGetResponse](docs/PhoneCountryCodeGetResponse.md)
 - [Model.PhoneFormatResponse](docs/PhoneFormatResponse.md)
 - [Model.PhoneMobileCheckResponse](docs/PhoneMobileCheckResponse.md)
 - [Model.SocialMediaActivitiesGetEducation](docs/SocialMediaActivitiesGetEducation.md)
 - [Model.SocialMediaActivitiesGetEmployment](docs/SocialMediaActivitiesGetEmployment.md)
 - [Model.SocialMediaActivitiesGetFacebook](docs/SocialMediaActivitiesGetFacebook.md)
 - [Model.SocialMediaActivitiesGetGooglePlus](docs/SocialMediaActivitiesGetGooglePlus.md)
 - [Model.SocialMediaActivitiesGetInstagram](docs/SocialMediaActivitiesGetInstagram.md)
 - [Model.SocialMediaActivitiesGetKlout](docs/SocialMediaActivitiesGetKlout.md)
 - [Model.SocialMediaActivitiesGetLinkedIn](docs/SocialMediaActivitiesGetLinkedIn.md)
 - [Model.SocialMediaActivitiesGetLocation](docs/SocialMediaActivitiesGetLocation.md)
 - [Model.SocialMediaActivitiesGetPinterest](docs/SocialMediaActivitiesGetPinterest.md)
 - [Model.SocialMediaActivitiesGetResponse](docs/SocialMediaActivitiesGetResponse.md)
 - [Model.SocialMediaActivitiesGetTwitter](docs/SocialMediaActivitiesGetTwitter.md)
 - [Model.SocialMediaActivitiesGetXing](docs/SocialMediaActivitiesGetXing.md)
 - [Model.SocialMediaActivitiesGetYouTube](docs/SocialMediaActivitiesGetYouTube.md)
 - [Model.UrlCheckResponse](docs/UrlCheckResponse.md)
 - [Model.VatCheckResponse](docs/VatCheckResponse.md)
 - [Model.VatResolveResponse](docs/VatResolveResponse.md)
 - [Model.VatSearchResponse](docs/VatSearchResponse.md)
 - [Model.VatSearchResultRecord](docs/VatSearchResultRecord.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.
