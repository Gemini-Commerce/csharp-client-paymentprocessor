# paymentprocessor - the C# library for the Payment Processor Service

No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: v1
- SDK version: 1.0.0
- Generator version: 7.9.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

<a id="frameworks-supported"></a>
## Frameworks supported

<a id="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 112.0.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a id="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using paymentprocessor.Api;
using paymentprocessor.Client;
using paymentprocessor.Model;
```
<a id="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out paymentprocessor.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using paymentprocessor.Api;
using paymentprocessor.Client;
using paymentprocessor.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://payment-processor.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new PaymentprocessorApi(config);
            var body = new PaymentprocessorAuthorizePaymentRequest(); // PaymentprocessorAuthorizePaymentRequest | 

            try
            {
                // Authorize Payment
                PaymentprocessorAuthorizePaymentResponse result = apiInstance.AuthorizePayment(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentprocessorApi.AuthorizePayment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://payment-processor.api.gogemini.io*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*PaymentprocessorApi* | [**AuthorizePayment**](docs/PaymentprocessorApi.md#authorizepayment) | **POST** /paymentprocessor.Paymentprocessor/AuthorizePayment | Authorize Payment
*PaymentprocessorApi* | [**CreatePaymentMethod**](docs/PaymentprocessorApi.md#createpaymentmethod) | **POST** /paymentprocessor.Paymentprocessor/CreatePaymentMethod | Create Payment Method
*PaymentprocessorApi* | [**FinalizePayment**](docs/PaymentprocessorApi.md#finalizepayment) | **POST** /paymentprocessor.Paymentprocessor/FinalizePayment | Finalize Payment
*PaymentprocessorApi* | [**GetAvailablePaymentMethod**](docs/PaymentprocessorApi.md#getavailablepaymentmethod) | **POST** /paymentprocessor.Paymentprocessor/GetAvailablePaymentMethod | Get Available Payment Method
*PaymentprocessorApi* | [**GetPaymentMethod**](docs/PaymentprocessorApi.md#getpaymentmethod) | **POST** /paymentprocessor.Paymentprocessor/GetPaymentMethod | Get Payment Method
*PaymentprocessorApi* | [**GetPaymentMethodConfiguration**](docs/PaymentprocessorApi.md#getpaymentmethodconfiguration) | **POST** /paymentprocessor.Paymentprocessor/GetPaymentMethodConfiguration | Get Payment Method Configuration
*PaymentprocessorApi* | [**InitPayment**](docs/PaymentprocessorApi.md#initpayment) | **POST** /paymentprocessor.Paymentprocessor/InitPayment | Init Payment
*PaymentprocessorApi* | [**ListAvailablePaymentMethods**](docs/PaymentprocessorApi.md#listavailablepaymentmethods) | **POST** /paymentprocessor.Paymentprocessor/ListAvailablePaymentMethods | List Available Payment Methods
*PaymentprocessorApi* | [**ListPaymentMethods**](docs/PaymentprocessorApi.md#listpaymentmethods) | **POST** /paymentprocessor.Paymentprocessor/ListPaymentMethods | List Payment Methods
*PaymentprocessorApi* | [**PerformPayment**](docs/PaymentprocessorApi.md#performpayment) | **POST** /paymentprocessor.Paymentprocessor/PerformPayment | Perform Payment
*PaymentprocessorApi* | [**PerformRefund**](docs/PaymentprocessorApi.md#performrefund) | **POST** /paymentprocessor.Paymentprocessor/PerformRefund | Perform Refund
*PaymentprocessorApi* | [**UpdatePayment**](docs/PaymentprocessorApi.md#updatepayment) | **POST** /paymentprocessor.Paymentprocessor/UpdatePayment | Update Payment
*PaymentprocessorApi* | [**UpdatePaymentMethod**](docs/PaymentprocessorApi.md#updatepaymentmethod) | **POST** /paymentprocessor.Paymentprocessor/UpdatePaymentMethod | Update Payment Method
*PaymentprocessorApi* | [**VoidPayment**](docs/PaymentprocessorApi.md#voidpayment) | **POST** /paymentprocessor.Paymentprocessor/VoidPayment | Void Payment


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.AvailabilityContextCustomer](docs/AvailabilityContextCustomer.md)
 - [Model.ConditionAction](docs/ConditionAction.md)
 - [Model.PaymentContextOrderInfo](docs/PaymentContextOrderInfo.md)
 - [Model.PaymentMethodRestrictionConditionCondition](docs/PaymentMethodRestrictionConditionCondition.md)
 - [Model.PaymentprocessorAuthorizePaymentRequest](docs/PaymentprocessorAuthorizePaymentRequest.md)
 - [Model.PaymentprocessorAuthorizePaymentResponse](docs/PaymentprocessorAuthorizePaymentResponse.md)
 - [Model.PaymentprocessorAvailabilityContext](docs/PaymentprocessorAvailabilityContext.md)
 - [Model.PaymentprocessorAvailabilityContextPostalAddress](docs/PaymentprocessorAvailabilityContextPostalAddress.md)
 - [Model.PaymentprocessorCreatePaymentMethodRequest](docs/PaymentprocessorCreatePaymentMethodRequest.md)
 - [Model.PaymentprocessorCurrency](docs/PaymentprocessorCurrency.md)
 - [Model.PaymentprocessorFinalizePaymentRequest](docs/PaymentprocessorFinalizePaymentRequest.md)
 - [Model.PaymentprocessorFinalizePaymentResponse](docs/PaymentprocessorFinalizePaymentResponse.md)
 - [Model.PaymentprocessorGetAvailablePaymentMethodRequest](docs/PaymentprocessorGetAvailablePaymentMethodRequest.md)
 - [Model.PaymentprocessorGetPaymentMethodConfigurationRequest](docs/PaymentprocessorGetPaymentMethodConfigurationRequest.md)
 - [Model.PaymentprocessorGetPaymentMethodConfigurationResponse](docs/PaymentprocessorGetPaymentMethodConfigurationResponse.md)
 - [Model.PaymentprocessorGetPaymentMethodRequest](docs/PaymentprocessorGetPaymentMethodRequest.md)
 - [Model.PaymentprocessorInitPaymentRequest](docs/PaymentprocessorInitPaymentRequest.md)
 - [Model.PaymentprocessorInitPaymentResponse](docs/PaymentprocessorInitPaymentResponse.md)
 - [Model.PaymentprocessorItem](docs/PaymentprocessorItem.md)
 - [Model.PaymentprocessorListAvailablePaymentMethodsRequest](docs/PaymentprocessorListAvailablePaymentMethodsRequest.md)
 - [Model.PaymentprocessorListAvailablePaymentMethodsResponse](docs/PaymentprocessorListAvailablePaymentMethodsResponse.md)
 - [Model.PaymentprocessorListPaymentMethodsRequest](docs/PaymentprocessorListPaymentMethodsRequest.md)
 - [Model.PaymentprocessorListPaymentMethodsResponse](docs/PaymentprocessorListPaymentMethodsResponse.md)
 - [Model.PaymentprocessorLocalizedText](docs/PaymentprocessorLocalizedText.md)
 - [Model.PaymentprocessorMoney](docs/PaymentprocessorMoney.md)
 - [Model.PaymentprocessorPayment](docs/PaymentprocessorPayment.md)
 - [Model.PaymentprocessorPaymentContext](docs/PaymentprocessorPaymentContext.md)
 - [Model.PaymentprocessorPaymentMethod](docs/PaymentprocessorPaymentMethod.md)
 - [Model.PaymentprocessorPaymentMethodRestriction](docs/PaymentprocessorPaymentMethodRestriction.md)
 - [Model.PaymentprocessorPaymentMethodRestrictionCondition](docs/PaymentprocessorPaymentMethodRestrictionCondition.md)
 - [Model.PaymentprocessorPerformPaymentRequest](docs/PaymentprocessorPerformPaymentRequest.md)
 - [Model.PaymentprocessorPerformPaymentResponse](docs/PaymentprocessorPerformPaymentResponse.md)
 - [Model.PaymentprocessorPerformRefundRequest](docs/PaymentprocessorPerformRefundRequest.md)
 - [Model.PaymentprocessorPostalAddress](docs/PaymentprocessorPostalAddress.md)
 - [Model.PaymentprocessorTransaction](docs/PaymentprocessorTransaction.md)
 - [Model.PaymentprocessorTransactionType](docs/PaymentprocessorTransactionType.md)
 - [Model.PaymentprocessorUpdatePaymentMethodRequest](docs/PaymentprocessorUpdatePaymentMethodRequest.md)
 - [Model.PaymentprocessorUpdatePaymentRequest](docs/PaymentprocessorUpdatePaymentRequest.md)
 - [Model.PaymentprocessorVoidPaymentRequest](docs/PaymentprocessorVoidPaymentRequest.md)
 - [Model.PaymentprocessorVoidPaymentResponse](docs/PaymentprocessorVoidPaymentResponse.md)
 - [Model.ProtobufAny](docs/ProtobufAny.md)
 - [Model.ProtobufNullValue](docs/ProtobufNullValue.md)
 - [Model.RpcStatus](docs/RpcStatus.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="Authorization"></a>
### Authorization

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

<a id="standardAuthorization"></a>
### standardAuthorization

- **Type**: OAuth
- **Flow**: implicit
- **Authorization URL**: 
- **Scopes**: N/A

