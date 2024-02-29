# paymentprocessor.Api.PaymentprocessorApi

All URIs are relative to *https://payment-processor.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AuthorizePayment**](PaymentprocessorApi.md#authorizepayment) | **POST** /paymentprocessor.Paymentprocessor/AuthorizePayment | Authorize Payment |
| [**CreatePaymentMethod**](PaymentprocessorApi.md#createpaymentmethod) | **POST** /paymentprocessor.Paymentprocessor/CreatePaymentMethod | Create Payment Method |
| [**FinalizePayment**](PaymentprocessorApi.md#finalizepayment) | **POST** /paymentprocessor.Paymentprocessor/FinalizePayment | Finalize Payment |
| [**GetAvailablePaymentMethod**](PaymentprocessorApi.md#getavailablepaymentmethod) | **POST** /paymentprocessor.Paymentprocessor/GetAvailablePaymentMethod | Get Available Payment Method |
| [**GetPaymentMethod**](PaymentprocessorApi.md#getpaymentmethod) | **POST** /paymentprocessor.Paymentprocessor/GetPaymentMethod | Get Payment Method |
| [**GetPaymentMethodConfiguration**](PaymentprocessorApi.md#getpaymentmethodconfiguration) | **POST** /paymentprocessor.Paymentprocessor/GetPaymentMethodConfiguration | Get Payment Method Configuration |
| [**InitPayment**](PaymentprocessorApi.md#initpayment) | **POST** /paymentprocessor.Paymentprocessor/InitPayment | Init Payment |
| [**ListAvailablePaymentMethods**](PaymentprocessorApi.md#listavailablepaymentmethods) | **POST** /paymentprocessor.Paymentprocessor/ListAvailablePaymentMethods | List Available Payment Methods |
| [**ListPaymentMethods**](PaymentprocessorApi.md#listpaymentmethods) | **POST** /paymentprocessor.Paymentprocessor/ListPaymentMethods | List Payment Methods |
| [**PerformPayment**](PaymentprocessorApi.md#performpayment) | **POST** /paymentprocessor.Paymentprocessor/PerformPayment | Perform Payment |
| [**PerformRefund**](PaymentprocessorApi.md#performrefund) | **POST** /paymentprocessor.Paymentprocessor/PerformRefund | Perform Refund |
| [**UpdatePayment**](PaymentprocessorApi.md#updatepayment) | **POST** /paymentprocessor.Paymentprocessor/UpdatePayment | Update Payment |
| [**UpdatePaymentMethod**](PaymentprocessorApi.md#updatepaymentmethod) | **POST** /paymentprocessor.Paymentprocessor/UpdatePaymentMethod | Update Payment Method |
| [**VoidPayment**](PaymentprocessorApi.md#voidpayment) | **POST** /paymentprocessor.Paymentprocessor/VoidPayment | Void Payment |

<a id="authorizepayment"></a>
# **AuthorizePayment**
> PaymentprocessorAuthorizePaymentResponse AuthorizePayment (PaymentprocessorAuthorizePaymentRequest body)

Authorize Payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using paymentprocessor.Api;
using paymentprocessor.Client;
using paymentprocessor.Model;

namespace Example
{
    public class AuthorizePaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://payment-processor.api.gogemini.io";

            var apiInstance = new PaymentprocessorApi(config);
            var body = new PaymentprocessorAuthorizePaymentRequest(); // PaymentprocessorAuthorizePaymentRequest | 

            try
            {
                // Authorize Payment
                PaymentprocessorAuthorizePaymentResponse result = apiInstance.AuthorizePayment(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentprocessorApi.AuthorizePayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthorizePaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Authorize Payment
    ApiResponse<PaymentprocessorAuthorizePaymentResponse> response = apiInstance.AuthorizePaymentWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentprocessorApi.AuthorizePaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PaymentprocessorAuthorizePaymentRequest**](PaymentprocessorAuthorizePaymentRequest.md) |  |  |

### Return type

[**PaymentprocessorAuthorizePaymentResponse**](PaymentprocessorAuthorizePaymentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createpaymentmethod"></a>
# **CreatePaymentMethod**
> PaymentprocessorPaymentMethod CreatePaymentMethod (PaymentprocessorCreatePaymentMethodRequest body)

Create Payment Method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using paymentprocessor.Api;
using paymentprocessor.Client;
using paymentprocessor.Model;

namespace Example
{
    public class CreatePaymentMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://payment-processor.api.gogemini.io";

            var apiInstance = new PaymentprocessorApi(config);
            var body = new PaymentprocessorCreatePaymentMethodRequest(); // PaymentprocessorCreatePaymentMethodRequest | 

            try
            {
                // Create Payment Method
                PaymentprocessorPaymentMethod result = apiInstance.CreatePaymentMethod(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentprocessorApi.CreatePaymentMethod: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePaymentMethodWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Payment Method
    ApiResponse<PaymentprocessorPaymentMethod> response = apiInstance.CreatePaymentMethodWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentprocessorApi.CreatePaymentMethodWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PaymentprocessorCreatePaymentMethodRequest**](PaymentprocessorCreatePaymentMethodRequest.md) |  |  |

### Return type

[**PaymentprocessorPaymentMethod**](PaymentprocessorPaymentMethod.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="finalizepayment"></a>
# **FinalizePayment**
> PaymentprocessorFinalizePaymentResponse FinalizePayment (PaymentprocessorFinalizePaymentRequest body)

Finalize Payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using paymentprocessor.Api;
using paymentprocessor.Client;
using paymentprocessor.Model;

namespace Example
{
    public class FinalizePaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://payment-processor.api.gogemini.io";

            var apiInstance = new PaymentprocessorApi(config);
            var body = new PaymentprocessorFinalizePaymentRequest(); // PaymentprocessorFinalizePaymentRequest | 

            try
            {
                // Finalize Payment
                PaymentprocessorFinalizePaymentResponse result = apiInstance.FinalizePayment(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentprocessorApi.FinalizePayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FinalizePaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Finalize Payment
    ApiResponse<PaymentprocessorFinalizePaymentResponse> response = apiInstance.FinalizePaymentWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentprocessorApi.FinalizePaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PaymentprocessorFinalizePaymentRequest**](PaymentprocessorFinalizePaymentRequest.md) |  |  |

### Return type

[**PaymentprocessorFinalizePaymentResponse**](PaymentprocessorFinalizePaymentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getavailablepaymentmethod"></a>
# **GetAvailablePaymentMethod**
> PaymentprocessorPaymentMethod GetAvailablePaymentMethod (PaymentprocessorGetAvailablePaymentMethodRequest body)

Get Available Payment Method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using paymentprocessor.Api;
using paymentprocessor.Client;
using paymentprocessor.Model;

namespace Example
{
    public class GetAvailablePaymentMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://payment-processor.api.gogemini.io";

            var apiInstance = new PaymentprocessorApi(config);
            var body = new PaymentprocessorGetAvailablePaymentMethodRequest(); // PaymentprocessorGetAvailablePaymentMethodRequest | 

            try
            {
                // Get Available Payment Method
                PaymentprocessorPaymentMethod result = apiInstance.GetAvailablePaymentMethod(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentprocessorApi.GetAvailablePaymentMethod: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAvailablePaymentMethodWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Available Payment Method
    ApiResponse<PaymentprocessorPaymentMethod> response = apiInstance.GetAvailablePaymentMethodWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentprocessorApi.GetAvailablePaymentMethodWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PaymentprocessorGetAvailablePaymentMethodRequest**](PaymentprocessorGetAvailablePaymentMethodRequest.md) |  |  |

### Return type

[**PaymentprocessorPaymentMethod**](PaymentprocessorPaymentMethod.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpaymentmethod"></a>
# **GetPaymentMethod**
> PaymentprocessorPaymentMethod GetPaymentMethod (PaymentprocessorGetPaymentMethodRequest body)

Get Payment Method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using paymentprocessor.Api;
using paymentprocessor.Client;
using paymentprocessor.Model;

namespace Example
{
    public class GetPaymentMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://payment-processor.api.gogemini.io";

            var apiInstance = new PaymentprocessorApi(config);
            var body = new PaymentprocessorGetPaymentMethodRequest(); // PaymentprocessorGetPaymentMethodRequest | 

            try
            {
                // Get Payment Method
                PaymentprocessorPaymentMethod result = apiInstance.GetPaymentMethod(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentprocessorApi.GetPaymentMethod: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPaymentMethodWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Payment Method
    ApiResponse<PaymentprocessorPaymentMethod> response = apiInstance.GetPaymentMethodWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentprocessorApi.GetPaymentMethodWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PaymentprocessorGetPaymentMethodRequest**](PaymentprocessorGetPaymentMethodRequest.md) |  |  |

### Return type

[**PaymentprocessorPaymentMethod**](PaymentprocessorPaymentMethod.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpaymentmethodconfiguration"></a>
# **GetPaymentMethodConfiguration**
> PaymentprocessorGetPaymentMethodConfigurationResponse GetPaymentMethodConfiguration (PaymentprocessorGetPaymentMethodConfigurationRequest body)

Get Payment Method Configuration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using paymentprocessor.Api;
using paymentprocessor.Client;
using paymentprocessor.Model;

namespace Example
{
    public class GetPaymentMethodConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://payment-processor.api.gogemini.io";

            var apiInstance = new PaymentprocessorApi(config);
            var body = new PaymentprocessorGetPaymentMethodConfigurationRequest(); // PaymentprocessorGetPaymentMethodConfigurationRequest | 

            try
            {
                // Get Payment Method Configuration
                PaymentprocessorGetPaymentMethodConfigurationResponse result = apiInstance.GetPaymentMethodConfiguration(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentprocessorApi.GetPaymentMethodConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPaymentMethodConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Payment Method Configuration
    ApiResponse<PaymentprocessorGetPaymentMethodConfigurationResponse> response = apiInstance.GetPaymentMethodConfigurationWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentprocessorApi.GetPaymentMethodConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PaymentprocessorGetPaymentMethodConfigurationRequest**](PaymentprocessorGetPaymentMethodConfigurationRequest.md) |  |  |

### Return type

[**PaymentprocessorGetPaymentMethodConfigurationResponse**](PaymentprocessorGetPaymentMethodConfigurationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="initpayment"></a>
# **InitPayment**
> PaymentprocessorInitPaymentResponse InitPayment (PaymentprocessorInitPaymentRequest body)

Init Payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using paymentprocessor.Api;
using paymentprocessor.Client;
using paymentprocessor.Model;

namespace Example
{
    public class InitPaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://payment-processor.api.gogemini.io";

            var apiInstance = new PaymentprocessorApi(config);
            var body = new PaymentprocessorInitPaymentRequest(); // PaymentprocessorInitPaymentRequest | 

            try
            {
                // Init Payment
                PaymentprocessorInitPaymentResponse result = apiInstance.InitPayment(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentprocessorApi.InitPayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InitPaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Init Payment
    ApiResponse<PaymentprocessorInitPaymentResponse> response = apiInstance.InitPaymentWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentprocessorApi.InitPaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PaymentprocessorInitPaymentRequest**](PaymentprocessorInitPaymentRequest.md) |  |  |

### Return type

[**PaymentprocessorInitPaymentResponse**](PaymentprocessorInitPaymentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listavailablepaymentmethods"></a>
# **ListAvailablePaymentMethods**
> PaymentprocessorListAvailablePaymentMethodsResponse ListAvailablePaymentMethods (PaymentprocessorListAvailablePaymentMethodsRequest body)

List Available Payment Methods

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using paymentprocessor.Api;
using paymentprocessor.Client;
using paymentprocessor.Model;

namespace Example
{
    public class ListAvailablePaymentMethodsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://payment-processor.api.gogemini.io";

            var apiInstance = new PaymentprocessorApi(config);
            var body = new PaymentprocessorListAvailablePaymentMethodsRequest(); // PaymentprocessorListAvailablePaymentMethodsRequest | 

            try
            {
                // List Available Payment Methods
                PaymentprocessorListAvailablePaymentMethodsResponse result = apiInstance.ListAvailablePaymentMethods(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentprocessorApi.ListAvailablePaymentMethods: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAvailablePaymentMethodsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Available Payment Methods
    ApiResponse<PaymentprocessorListAvailablePaymentMethodsResponse> response = apiInstance.ListAvailablePaymentMethodsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentprocessorApi.ListAvailablePaymentMethodsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PaymentprocessorListAvailablePaymentMethodsRequest**](PaymentprocessorListAvailablePaymentMethodsRequest.md) |  |  |

### Return type

[**PaymentprocessorListAvailablePaymentMethodsResponse**](PaymentprocessorListAvailablePaymentMethodsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listpaymentmethods"></a>
# **ListPaymentMethods**
> PaymentprocessorListPaymentMethodsResponse ListPaymentMethods (PaymentprocessorListPaymentMethodsRequest body)

List Payment Methods

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using paymentprocessor.Api;
using paymentprocessor.Client;
using paymentprocessor.Model;

namespace Example
{
    public class ListPaymentMethodsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://payment-processor.api.gogemini.io";

            var apiInstance = new PaymentprocessorApi(config);
            var body = new PaymentprocessorListPaymentMethodsRequest(); // PaymentprocessorListPaymentMethodsRequest | 

            try
            {
                // List Payment Methods
                PaymentprocessorListPaymentMethodsResponse result = apiInstance.ListPaymentMethods(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentprocessorApi.ListPaymentMethods: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPaymentMethodsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Payment Methods
    ApiResponse<PaymentprocessorListPaymentMethodsResponse> response = apiInstance.ListPaymentMethodsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentprocessorApi.ListPaymentMethodsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PaymentprocessorListPaymentMethodsRequest**](PaymentprocessorListPaymentMethodsRequest.md) |  |  |

### Return type

[**PaymentprocessorListPaymentMethodsResponse**](PaymentprocessorListPaymentMethodsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="performpayment"></a>
# **PerformPayment**
> PaymentprocessorPerformPaymentResponse PerformPayment (PaymentprocessorPerformPaymentRequest body)

Perform Payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using paymentprocessor.Api;
using paymentprocessor.Client;
using paymentprocessor.Model;

namespace Example
{
    public class PerformPaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://payment-processor.api.gogemini.io";

            var apiInstance = new PaymentprocessorApi(config);
            var body = new PaymentprocessorPerformPaymentRequest(); // PaymentprocessorPerformPaymentRequest | 

            try
            {
                // Perform Payment
                PaymentprocessorPerformPaymentResponse result = apiInstance.PerformPayment(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentprocessorApi.PerformPayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PerformPaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Perform Payment
    ApiResponse<PaymentprocessorPerformPaymentResponse> response = apiInstance.PerformPaymentWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentprocessorApi.PerformPaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PaymentprocessorPerformPaymentRequest**](PaymentprocessorPerformPaymentRequest.md) |  |  |

### Return type

[**PaymentprocessorPerformPaymentResponse**](PaymentprocessorPerformPaymentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="performrefund"></a>
# **PerformRefund**
> Object PerformRefund (PaymentprocessorPerformRefundRequest body)

Perform Refund

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using paymentprocessor.Api;
using paymentprocessor.Client;
using paymentprocessor.Model;

namespace Example
{
    public class PerformRefundExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://payment-processor.api.gogemini.io";

            var apiInstance = new PaymentprocessorApi(config);
            var body = new PaymentprocessorPerformRefundRequest(); // PaymentprocessorPerformRefundRequest | 

            try
            {
                // Perform Refund
                Object result = apiInstance.PerformRefund(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentprocessorApi.PerformRefund: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PerformRefundWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Perform Refund
    ApiResponse<Object> response = apiInstance.PerformRefundWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentprocessorApi.PerformRefundWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PaymentprocessorPerformRefundRequest**](PaymentprocessorPerformRefundRequest.md) |  |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatepayment"></a>
# **UpdatePayment**
> Object UpdatePayment (PaymentprocessorUpdatePaymentRequest body)

Update Payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using paymentprocessor.Api;
using paymentprocessor.Client;
using paymentprocessor.Model;

namespace Example
{
    public class UpdatePaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://payment-processor.api.gogemini.io";

            var apiInstance = new PaymentprocessorApi(config);
            var body = new PaymentprocessorUpdatePaymentRequest(); // PaymentprocessorUpdatePaymentRequest | 

            try
            {
                // Update Payment
                Object result = apiInstance.UpdatePayment(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentprocessorApi.UpdatePayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Payment
    ApiResponse<Object> response = apiInstance.UpdatePaymentWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentprocessorApi.UpdatePaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PaymentprocessorUpdatePaymentRequest**](PaymentprocessorUpdatePaymentRequest.md) |  |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatepaymentmethod"></a>
# **UpdatePaymentMethod**
> PaymentprocessorPaymentMethod UpdatePaymentMethod (PaymentprocessorUpdatePaymentMethodRequest body)

Update Payment Method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using paymentprocessor.Api;
using paymentprocessor.Client;
using paymentprocessor.Model;

namespace Example
{
    public class UpdatePaymentMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://payment-processor.api.gogemini.io";

            var apiInstance = new PaymentprocessorApi(config);
            var body = new PaymentprocessorUpdatePaymentMethodRequest(); // PaymentprocessorUpdatePaymentMethodRequest | 

            try
            {
                // Update Payment Method
                PaymentprocessorPaymentMethod result = apiInstance.UpdatePaymentMethod(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentprocessorApi.UpdatePaymentMethod: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePaymentMethodWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Payment Method
    ApiResponse<PaymentprocessorPaymentMethod> response = apiInstance.UpdatePaymentMethodWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentprocessorApi.UpdatePaymentMethodWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PaymentprocessorUpdatePaymentMethodRequest**](PaymentprocessorUpdatePaymentMethodRequest.md) |  |  |

### Return type

[**PaymentprocessorPaymentMethod**](PaymentprocessorPaymentMethod.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="voidpayment"></a>
# **VoidPayment**
> PaymentprocessorVoidPaymentResponse VoidPayment (PaymentprocessorVoidPaymentRequest body)

Void Payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using paymentprocessor.Api;
using paymentprocessor.Client;
using paymentprocessor.Model;

namespace Example
{
    public class VoidPaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://payment-processor.api.gogemini.io";

            var apiInstance = new PaymentprocessorApi(config);
            var body = new PaymentprocessorVoidPaymentRequest(); // PaymentprocessorVoidPaymentRequest | 

            try
            {
                // Void Payment
                PaymentprocessorVoidPaymentResponse result = apiInstance.VoidPayment(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentprocessorApi.VoidPayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VoidPaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Void Payment
    ApiResponse<PaymentprocessorVoidPaymentResponse> response = apiInstance.VoidPaymentWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentprocessorApi.VoidPaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PaymentprocessorVoidPaymentRequest**](PaymentprocessorVoidPaymentRequest.md) |  |  |

### Return type

[**PaymentprocessorVoidPaymentResponse**](PaymentprocessorVoidPaymentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

