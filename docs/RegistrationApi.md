# com.telstra.eventdetection.Api.RegistrationApi

All URIs are relative to *https://tapi.telstra.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Register**](RegistrationApi.md#register) | **POST** /v1/eventdetection/events | Register
[**Unregister**](RegistrationApi.md#unregister) | **DELETE** /v1/eventdetection/events/{eventType} | Unregister


<a name="register"></a>
# **Register**
> ResisterPhoneNumberList Register (SubscriptionObj body)

Register

Register for an event

### Example
```csharp
using System;
using System.Diagnostics;
using com.telstra.eventdetection.Api;
using com.telstra.eventdetection.Client;
using com.telstra.eventdetection.Model;

namespace Example
{
    public class RegisterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationApi();
            var body = new SubscriptionObj(); // SubscriptionObj | Subscribe with a list of phone numbers, push notification URL (optional) and the event type.

            try
            {
                // Register
                ResisterPhoneNumberList result = apiInstance.Register(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.Register: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubscriptionObj**](SubscriptionObj.md)| Subscribe with a list of phone numbers, push notification URL (optional) and the event type. | 

### Return type

[**ResisterPhoneNumberList**](ResisterPhoneNumberList.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unregister"></a>
# **Unregister**
> ResisterPhoneNumberList Unregister (string eventType, UnregisterRequestObj body)

Unregister

Unregister from an event

### Example
```csharp
using System;
using System.Diagnostics;
using com.telstra.eventdetection.Api;
using com.telstra.eventdetection.Client;
using com.telstra.eventdetection.Model;

namespace Example
{
    public class UnregisterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationApi();
            var eventType = eventType_example;  // string | Event Type
            var body = new UnregisterRequestObj(); // UnregisterRequestObj | List of subscribed phone numbers and notification URL (optional)

            try
            {
                // Unregister
                ResisterPhoneNumberList result = apiInstance.Unregister(eventType, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.Unregister: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventType** | **string**| Event Type | 
 **body** | [**UnregisterRequestObj**](UnregisterRequestObj.md)| List of subscribed phone numbers and notification URL (optional) | 

### Return type

[**ResisterPhoneNumberList**](ResisterPhoneNumberList.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

