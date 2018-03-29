# com.telstra.eventdetection.Api.AuthenticationApi

All URIs are relative to *https://tapi.telstra.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthToken**](AuthenticationApi.md#authtoken) | **POST** /v2/oauth/token | Generate authentication token


<a name="authtoken"></a>
# **AuthToken**
> OAuthResponse AuthToken (string clientId, string clientSecret, string grantType)

Generate authentication token

Generate authentication token

### Example
```csharp
using System;
using System.Diagnostics;
using com.telstra.eventdetection.Api;
using com.telstra.eventdetection.Client;
using com.telstra.eventdetection.Model;

namespace Example
{
    public class AuthTokenExample
    {
        public void main()
        {
            var apiInstance = new AuthenticationApi();
            var clientId = clientId_example;  // string | 
            var clientSecret = clientSecret_example;  // string | 
            var grantType = grantType_example;  // string |  (default to client_credentials)

            try
            {
                // Generate authentication token
                OAuthResponse result = apiInstance.AuthToken(clientId, clientSecret, grantType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**|  | 
 **clientSecret** | **string**|  | 
 **grantType** | **string**|  | [default to client_credentials]

### Return type

[**OAuthResponse**](OAuthResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

