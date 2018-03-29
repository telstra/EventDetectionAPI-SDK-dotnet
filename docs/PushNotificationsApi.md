# com.telstra.eventdetection.Api.PushNotificationsApi

All URIs are relative to *https://tapi.telstra.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PushNotifications**](PushNotificationsApi.md#pushnotifications) | **POST** /v1/eventdetection/events/notifications | Push event notifications


<a name="pushnotifications"></a>
# **PushNotifications**
> PushNotificationObj PushNotifications (string contentType, NotificationPayload body)

Push event notifications

Push event notifications to the notification URL configured during the MSISDN registration process

### Example
```csharp
using System;
using System.Diagnostics;
using com.telstra.eventdetection.Api;
using com.telstra.eventdetection.Client;
using com.telstra.eventdetection.Model;

namespace Example
{
    public class PushNotificationsExample
    {
        public void main()
        {
            var apiInstance = new PushNotificationsApi();
            var contentType = contentType_example;  // string | application/json
            var body = new NotificationPayload(); // NotificationPayload | Application Id, MSISDN, Event Id and Event Date

            try
            {
                // Push event notifications
                PushNotificationObj result = apiInstance.PushNotifications(contentType, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PushNotificationsApi.PushNotifications: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**| application/json | 
 **body** | [**NotificationPayload**](NotificationPayload.md)| Application Id, MSISDN, Event Id and Event Date | 

### Return type

[**PushNotificationObj**](PushNotificationObj.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

