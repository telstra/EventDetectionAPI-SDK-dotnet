# com.telstra.eventdetection.Api.GetSubscriptionApi

All URIs are relative to *https://tapi.telstra.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSubscription**](GetSubscriptionApi.md#getsubscription) | **POST** /v1/eventdetection/events/subscriptions | Get Event Subscriptions


<a name="getsubscription"></a>
# **GetSubscription**
> GetSubscriptionResponse GetSubscription (PhoneNumberList body)

Get Event Subscriptions

Get the list of events subscribed for

### Example
```csharp
using System;
using System.Diagnostics;
using com.telstra.eventdetection.Api;
using com.telstra.eventdetection.Client;
using com.telstra.eventdetection.Model;

namespace Example
{
    public class GetSubscriptionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GetSubscriptionApi();
            var body = new PhoneNumberList(); // PhoneNumberList | List of subscribed phone numbers

            try
            {
                // Get Event Subscriptions
                GetSubscriptionResponse result = apiInstance.GetSubscription(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GetSubscriptionApi.GetSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PhoneNumberList**](PhoneNumberList.md)| List of subscribed phone numbers | 

### Return type

[**GetSubscriptionResponse**](GetSubscriptionResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

