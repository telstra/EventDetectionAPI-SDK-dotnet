# com.telstra.eventdetection.Api.LongPollApi

All URIs are relative to *https://tapi.telstra.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Longpoll**](LongPollApi.md#longpoll) | **POST** /v1/eventdetection/events/{eventType} | Poll events


<a name="longpoll"></a>
# **Longpoll**
> GetEventResponse Longpoll (string eventType, PollingObj body)

Poll events

Poll events for a given set of MSISDNs

### Example
```csharp
using System;
using System.Diagnostics;
using com.telstra.eventdetection.Api;
using com.telstra.eventdetection.Client;
using com.telstra.eventdetection.Model;

namespace Example
{
    public class LongpollExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LongPollApi();
            var eventType = eventType_example;  // string | Event Type
            var body = new PollingObj(); // PollingObj | List of MSISDNs to pull the events

            try
            {
                // Poll events
                GetEventResponse result = apiInstance.Longpoll(eventType, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LongPollApi.Longpoll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventType** | **string**| Event Type | 
 **body** | [**PollingObj**](PollingObj.md)| List of MSISDNs to pull the events | 

### Return type

[**GetEventResponse**](GetEventResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

