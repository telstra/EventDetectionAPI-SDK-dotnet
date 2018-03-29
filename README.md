# com.telstra.eventdetection - the C# library for the Telstra Event Detection API



- API version: 1.0.0
- SDK version: 1.0.0

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using com.telstra.eventdetection.Api;
using com.telstra.eventdetection.Client;
using com.telstra.eventdetection.Model;
```
<a name="packaging"></a>
## Packaging


This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out com.telstra.eventdetection.csproj
```


<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using com.telstra.eventdetection.Api;
using com.telstra.eventdetection.Client;
using com.telstra.eventdetection.Model;

namespace Example
{
    public class Example
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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://tapi.telstra.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthenticationApi* | [**AuthToken**](docs/AuthenticationApi.md#authtoken) | **POST** /v2/oauth/token | Generate authentication token
*GetSubscriptionApi* | [**GetSubscription**](docs/GetSubscriptionApi.md#getsubscription) | **POST** /v1/eventdetection/events/subscriptions | Get Event Subscriptions
*LongPollApi* | [**Longpoll**](docs/LongPollApi.md#longpoll) | **POST** /v1/eventdetection/events/{eventType} | Poll events
*PushNotificationsApi* | [**PushNotifications**](docs/PushNotificationsApi.md#pushnotifications) | **POST** /v1/eventdetection/events/notifications | Push event notifications
*RegistrationApi* | [**Register**](docs/RegistrationApi.md#register) | **POST** /v1/eventdetection/events | Register
*RegistrationApi* | [**Unregister**](docs/RegistrationApi.md#unregister) | **DELETE** /v1/eventdetection/events/{eventType} | Unregister


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Eventsattr](docs/Eventsattr.md)
 - [Model.GetEventResponse](docs/GetEventResponse.md)
 - [Model.GetSubscriptionResponse](docs/GetSubscriptionResponse.md)
 - [Model.NotificationPayload](docs/NotificationPayload.md)
 - [Model.OAuthResponse](docs/OAuthResponse.md)
 - [Model.PhoneNumberList](docs/PhoneNumberList.md)
 - [Model.PollingObj](docs/PollingObj.md)
 - [Model.PushNotificationObj](docs/PushNotificationObj.md)
 - [Model.ResisterPhoneNumberList](docs/ResisterPhoneNumberList.md)
 - [Model.ServiceEventsAttr](docs/ServiceEventsAttr.md)
 - [Model.SubscriptionObj](docs/SubscriptionObj.md)
 - [Model.Subscriptionattr](docs/Subscriptionattr.md)
 - [Model.Test](docs/Test.md)
 - [Model.UnregisterRequestObj](docs/UnregisterRequestObj.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorisation

<a name="auth"></a>
### auth

- **Type**: OAuth
- **Flow**: application
- **Authorisation URL**: 
- **Scopes**: 
  - v1_eventdetection_simswap: v1_eventdetection_simswap

