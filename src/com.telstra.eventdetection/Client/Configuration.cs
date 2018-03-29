/* 
 * Telstra Event Detection API
 *
 *  # Introduction Telstra's Event Detection API provides the ability to subscribe to and receive mobile network events for registered mobile numbers associated with Telstra's mobile network, such as; SIM swap, port-in, port-out, new MSIDN, new mobile service and cancelled mobile service, as well as carrier-detection. ## Features Event Detection API provides these features   | Feature              | Description |   |- --|- --|   |`SIM swap` | Returns timestamped event data when any of the following network events occurs in connection with a registered mobile number associated with Telstraâ€™s mobile network:  SIM swap, port-in, port-out, new MSISDN, new mobile service or cancelled mobile service |   |`Carrier Detection` | Find out what Australian carrier a mobile number is subscribed to |   |`International Roaming` | *Coming soon.* Will indicate if a mobile number is operaing in Australia or outside of Australia. |  ## Getting access to the API The Event Detection API is available on our Enterprise Plans only. Please submit your [sales enquiry](https://dev.telstra.com/content/sales-enquiry-contact-form) . Or contact your Telstra Account Executive. We're available Monday to Friday 9am - 5pm. ## Frequently asked questions **Q: What is the Telstra Event Detection (TED) API?** A: The Telstra Event Detection (TED) API is a subscription based service from Telstra that enables a customer to be alerted when a particular network event is detected in connection with a registered mobile number that may indicate that a fraudulent misuse of an end userâ€™s mobility service is about to occur.  **Q: What are the network events that the TED API can detect?** A: Currently the TED API is able to detect a bundle of events associated with Telstra SIM swaps.  **Q: Can TED API detect number porting between operators other than Telstra? E.g. Optus to Vodafone?** A: No, we donâ€™t report these type of events at present.  **Q: How quickly are the network events detected?** A: This will vary depending on the event being detected, but generally we detect the event within a couple of seconds of it occurring and notify subscribers within near real time via the API.  **Q: How long does Telstra store the event data for?** A: Event data is stored for 90 days from the occurrence of a network event and then securely purged.  **Q: Is there a limit to the number of registered mobile numbers I can have for the Telstra Event Detection API?** A: No. You may have as many Telstra Event Detection API registered mobile numbers as you require within practical limits.  **Q: Why is monitoring for SIM SWAP events important?** A: Criminals are becoming much more savvy and will often try to circumvent two factor authentication protocols by swapping the SIM card for a particular mobile number in order to gain fraudulent access to the end userâ€™s service. Monitoring for SIM swap events may provide early detection that this is occurring and help prevent criminals from being successful in their endeavours.  **Q: If an end user is currently a customer of a Telstra Reseller that still utilises the Telstra Network, am I able to detect their Network events?** A: No. Telstra resellers such as Aldi Mobile are Mobile Virtual Network Operators (MVNO) that operate as totally independent businesses to Telstra. The Telstra SIM swap API does not monitor MNVO network events at present.  **Q: How do I purchase Telstra Event Detection API?** A: At the moment, the Telstra Event Detection API is only available through your Telstra Account Manager. If you don't have a Telstra Account Manager, or are not sure who they are, please submit a [sales enquiry](https://dev.telstra.com/content/sales-enquiry-contact-form).  **Q: What support options are available for the Telstra Event Detection API?** A: We provide 24/7 telephone based technical support (for paid plans) along with email support and an online community forum.  **Q: Do you detect network events from another carrier?** A: The Telstra Event Detection API detects network events associated with the Telstra network and Telstra mobile services.  **Q: Which Telstra personnel have access to the event detection data?** A: Access to Telstra Event Detection data is restricted to only Telstra personnel that require access for the purposes of providing the service.  **Q: Why should I purchase the Telstra Event Detection API from Telstra?** A: As the network events are occurring on the Telstra network, Telstra is in a position to be able to provide fast notification of an event as it is occurring, helping subscribers to prevent fraudulent activity from occurring and to minimise the resulting financial losses.  **Q: If I require assistance setting up my Telstra Event Detection API, are there any Professional Services options available to me?** A: At the current time, the Telstra Event Detection API does not have any Professional Service options available.  **Q: What subscription options are available for Telstra Event Detection API?** A: There is a month-by-month Pay As You Go (PAYG) plan or 12 Month contract option available.  **Q: Do Early Termination Charges (ETCâ€™s) apply?** A: If you have subscribed to a 12 month contract and want to terminate the plan or downgrade to a lower plan before the expiry of your existing 12 month term, we may charge you ETCs.  **Q: What privacy requirements apply to my use of the Telstra Event Detection API?** A: Before registering an end users mobile number with Telstra Event Detection API, you must: 1.  prepare an 'End User Notifications'. for our approval, which sets out what end user information will be disclosed via the API, the purposes for which that information will be disclosed, and to which third parties that information will be disclosed; 2.  provide each of your end user with the End User Notification; and 3.  obtain express, informed consent from each end user to the use and disclosure of their event data via the API for the purposes set out in the notification.  **Q: What terms and conditions apply to my use of the Telstra Event Detection API?** A: Before using the Telstra Event Detection API, you must agree to the TED API ['Our Customer Terms'](https://www.telstra.com.au/customer-terms/business-government#cloud-services).   # Getting Started First step is to create an `App`. After you've created an `App`, follow these steps 1. Authenticate by getting an Oauth token 2. Use the Event Detection API ## Run in Postman To get started quickly and easily with all the features of the Event Detection API, download the Postman collection here  <a href=\"https://app.getpostman.com/run-collection/8ab2273e066e5c6fd653#?env%5BEvent%20Detection%20API%5D=W3sidHlwZSI6InRleHQiLCJlbmFibGVkIjp0cnVlLCJrZXkiOiJjbGllbnRfaWQiLCJ2YWx1ZSI6ImNsaWVudF9pZCJ9LHsidHlwZSI6InRleHQiLCJlbmFibGVkIjp0cnVlLCJrZXkiOiJjbGllbnRfc2VjcmV0IiwidmFsdWUiOiJjbGllbnRfc2VjcmV0In0seyJ0eXBlIjoidGV4dCIsImVuYWJsZWQiOnRydWUsImtleSI6ImFjY2Vzc190b2tlbiIsInZhbHVlIjoiaTZPdmtyelVuc3hvODhrcU9BMXg4RWtPVWxuSyJ9LHsidHlwZSI6InRleHQiLCJlbmFibGVkIjp0cnVlLCJrZXkiOiJob3N0IiwidmFsdWUiOiJ0YXBpLnRlbHN0cmEuY29tIn0seyJ0eXBlIjoidGV4dCIsImVuYWJsZWQiOnRydWUsImtleSI6Im9hdXRoLWhvc3QiLCJ2YWx1ZSI6InRhcGkudGVsc3RyYS5jb20ifV0=\"><img alt=\"Run in Postman\" src=\"https://run.pstmn.io/button.svg\" /></a> ## Authentication   To get an OAuth 2.0 Authentication token, pass through your Consumer Key and Consumer Secret that you received when you registered for the Event Detection API key. The `grant_type` should be left as `client_credentials` and the scope as v1_eventdetection_simswap. The token will expire in one hour. Get your keys by creating an `App`.    # Request   ` CONSUMER_KEY=\"your consumer key\"   CONSUMER_SECRET=\"your consumer secret\"   curl -X POST -H 'Content-Type: application/x-www-form-urlencoded' \\   -d 'grant_type=client_credentials&client_id=$CONSUMER_KEY&client_secret=$CONSUMER_SECRET&scope=v1_eventdetection_simswap' \\   'https://tapi.telstra.com/v2/oauth/token' `    # Response    `{       \"access_token\" : \"1234567890123456788901234567\",       \"token_type\" : \"Bearer\",       \"expires_in\" : \"3599\"   }`  ## Subscribe mobile numbers Subscribing end user mobile numbers informs the API to register that mobile number so that you can poll those numbers for particular events. You can subscribe and unsubscribe numbers (opt in and opt out) against this service. Only numbers that are opted in (i.e. subscribed) can be polled for events. You must have obtained your end customerâ€™s consent before you can opt them into the Event Detection service.  # Request  `curl -X POST -H 'content-type: application/json' \\ -H 'Authorization: Bearer $TOKEN' \\ -d '{ \"msisdns\": [     \"61467754783\" ], \"eventType\": \"simswap\", \"notificationUrl\": \"https://requestb.in/161r14g1\" }' \\ 'https://tapi.telstra.com/v1/eventdetection/events'` | Parameter              | Description |   |- --|- --|   |`msisdns` | list of mobile numbers that has to be registered for the event |   |`eventType` | event Type to be subscribed to |   |`notificationUrl` | URL where the event notifications has to be posted (Optional) |   # Response  `{     \"msisdns\": [       {         \"msisdn\": \"61467754783\",         \"description\": \"opt-in status updated for this MSISDN\",         \"carrierName\": \"Telstra\"     }   ] }` | Parameter              | Description |   |- --|- --|   |`msisdn` | msisdn |   |`description` | status description indicating if the msisdn was opted-in|   |`carrierName` | carrier name for the msisdn |  ## Unsubscribe mobile numbers Unsubscribe mobile numbers against a particular event  # Request  `curl -X DELETE -H 'content-type: application/json' \\   -H 'Authorization: Bearer $token' \\   -d '{\"msisdns\": [\"61467754783\"]}' \\   'https://tapi.telstra.com/v1/eventdetection/events/{event-type}'`  | Parameter              | Description |   |- --|- --|   |`msisdns` | list of mobile numbers that has to be unsubscribed from the event |   |`eventType` | event Type to be unsubscribed from |   |`notificationUrl` | notification URL that has to be removed (Optional) |  # Response     ` {     \"msisdns\": [       {         \"msisdn\": \"61467754783\",         \"description\": \"opt-out status updated for this MSISDN\",         \"carrierName\": \"Telstra\"       }     ]   } `  | Parameter              | Description |   |- --|- --|   |`msisdn` | msisdn |   |`description` | status description indicating if the msisdn was opted-out |   |`carrierName` | carrier name for the msisdn |  ## Get event subscriptions Get the list of events subscribed for  # Request  `curl -X POST -H 'content-type: application/json' \\   -H 'Authorization: Bearer $TOKEN' \\   -d '{ \"msisdns\": [ \"61467754783\" ] }' \\   'https://tapi.telstra.com/v1/eventdetection/events/subscriptions'`  | Parameter              | Description |   |- --|- --|   |`msisdns` | list of msisdns to get the subscription details |  # Response  ` {   \"notificationURL\": \"https://requestb.in/161r14g1\",   \"subscriptions\": [     {         \"msisdn\": \"61467754783\",         \"events\": [             \"SIM_SWAP\"         ],         \"carrierName\": \"Telstra\"     }   ] } ` | Parameter              | Description |   |- --|- --|   |`notificationURL` | notification URL configured while registering msisdns |   |`msisdn` | msisdn |   |`events` | list of subscribed events for that msisdn |   |`carrierName` | carrier name for the msisdn |  ## Poll events Poll events for a given set of msisdns  # Request `curl -X POST -H 'content-type: application/json' \\   -H 'Authorization: Bearer $token' \\   -d '{ \"msisdns\": [ \"61467754783\", \"61467984007\" ] }' \\   'https://tapi.telstra.com/v1/eventdetection/events/{event_type}'`   Parameter              | Description |   |- --|- --|   |`msisdns` | list of msisdns to be polled for events |   |`eventType` | event Type to be polled for |  # Response  ` {   \"eventType\": \"simswap\",   \"msisdns\": [     {         \"msisdn\": \"+61467754783\",         \"mobileServiceEvents\": [             {                 \"eventId\": \"NEW_SIM\",                 \"eventDate\": \"2018-01-19T14:40:34\"             }         ]     },     {         \"msisdn\": \"+61467984007\",         \"mobileServiceEvents\": [             {                 \"eventId\": \"PORTOUT_SVC\",                 \"eventDate\": \"2018-02-21T15:20:01\",                 \"carrierName\": \"Telstra\"             }         ]     } ] } ` | Parameter              | Description |   |- --|- --|   |`eventType` | event type requested |   |`msisdn` | msisdn |   |`mobileServiceEvents` | list of service events |   |`eventId` | Id of the event occured. Event Id can be any one of the following - NEW_MSISDN, PORTIN_SVC, PORTOUT_SVC, NEW_SIM, CREATE_SVC, DELETE_SVC |   |`eventDate` | timestamp indicating when the event occured |   |`carrierName` | carrier name for the msisdn. Carrier name will be returned only for port out events |  ## Push notifications Push event notifications to the URL are configured with the parameter `notificationUrl` while subscribing mobile numbers. # Event notification format ` {   \"eventId\": \"NEW_SIM\",   \"msisdn\" : \"61467754783\",   \"eventDate\" : \"2018-01-19T14:40:34\" } ` | Parameter              | Description |   |- --|- --|   |`eventId` | event Id indicating the event occured. Event Id can be any one of the following - NEW_MSISDN, PORTIN_SVC, PORTOUT_SVC, NEW_SIM, CREATE_SVC, DELETE_SVC  |   |`msisdn` | msisdn for which the event occured |   |`eventDate` | timestamp indicating when the event occured |  ## SIMswap sub-features The following is a list of the sub-features for SIM swap and the description for that sub-feature. These will appear in the 'eventId' parameter in the API response payload for SIMswap events. | SIM swap Sub-Feature              | Description |   |- --|- --|   |`NEW_MSISDN` | The MSISDN of a service changes. The SIM card is not changed. Results in two events being created: 1)  CREATE_SVC/PORT_IN_SVC for the new number, and 2)  a NEW_MSISDN for the old MSISDN |   |`PORTIN_SVC` | A MSISDN registered for event detection is created as a mobile service on the Telstra network (note: if the MSISDN was not already registered by at least one customer for at least one event type, this event would be interpreted as a CREATE_SVC) |   |`PORTOUT_SVC` | The MSISDN is ported out from Telstra to another domestic operator |   |`NEW_SIM` | An existing Telstra MSISDN is moved onto a new SIM |   |`CREATE_SVC` | A new mobile service is created on the Telstra network (a new SIM and a new MSISDN) |   |`DELETE_SVC` | A mobile service (MSISDN and SIM) on the Telstra network is cancelled outright (as opposed to ported out to another domestic network) |  ## SDK repos * [Event Detection API - Java SDK](https://github.com/telstra/EventDetectionAPI-SDK-java) * [Event Detection API - .Net2 SDK](https://github.com/telstra/EventDetectionAPI-SDK-dotnet) * [Event Detection API - NodeJS SDK](https://github.com/telstra/EventDetectionAPI-SDK-node) * [Event Detection API - PHP SDK](https://github.com/telstra/EventDetectionAPI-SDK-php) * [Event Detection API - Python SDK](https://github.com/telstra/EventDetectionAPI-SDK-python) * [Event Detection API - Ruby SDK](https://github.com/telstra/EventDetectionAPI-SDK-ruby)
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Reflection;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace com.telstra.eventdetection.Client
{
    /// <summary>
    /// Represents a set of configuration settings
    /// </summary>
    public class Configuration : IReadableConfiguration
    {
        #region Constants

        /// <summary>
        /// Version of the package.
        /// </summary>
        /// <value>Version of the package.</value>
        public const string Version = "1.0.0";

        /// <summary>
        /// Identifier for ISO 8601 DateTime Format
        /// </summary>
        /// <remarks>See https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8 for more information.</remarks>
        // ReSharper disable once InconsistentNaming
        public const string ISO8601_DATETIME_FORMAT = "o";

        #endregion Constants

        #region Static Members

        private static readonly object GlobalConfigSync = new { };
        private static Configuration _globalConfiguration;

        /// <summary>
        /// Default creation of exceptions for a given method name and response object
        /// </summary>
        public static readonly ExceptionFactory DefaultExceptionFactory = (methodName, response) =>
        {
            var status = (int)response.StatusCode;
            if (status >= 400)
            {
                return new ApiException(status,
                    string.Format("Error calling {0}: {1}", methodName, response.Content),
                    response.Content);
            }
            if (status == 0)
            {
                return new ApiException(status,
                    string.Format("Error calling {0}: {1}", methodName, response.ErrorMessage), response.ErrorMessage);
            }
            return null;
        };

        /// <summary>
        /// Gets or sets the default Configuration.
        /// </summary>
        /// <value>Configuration.</value>
        public static Configuration Default
        {
            get { return _globalConfiguration; }
            set
            {
                lock (GlobalConfigSync)
                {
                    _globalConfiguration = value;
                }
            }
        }

        #endregion Static Members

        #region Private Members

        /// <summary>
        /// Gets or sets the API key based on the authentication name.
        /// </summary>
        /// <value>The API key.</value>
        private IDictionary<string, string> _apiKey = null;

        /// <summary>
        /// Gets or sets the prefix (e.g. Token) of the API key based on the authentication name.
        /// </summary>
        /// <value>The prefix of the API key.</value>
        private IDictionary<string, string> _apiKeyPrefix = null;

        private string _dateTimeFormat = ISO8601_DATETIME_FORMAT;
        private string _tempFolderPath = Path.GetTempPath();

        #endregion Private Members

        #region Constructors

        static Configuration()
        {
            _globalConfiguration = new GlobalConfiguration();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration" /> class
        /// </summary>
        public Configuration()
        {
            UserAgent = "Swagger-Codegen/1.0.0/csharp";
            BasePath = "https://tapi.telstra.com";
            DefaultHeader = new ConcurrentDictionary<string, string>();
            ApiKey = new ConcurrentDictionary<string, string>();
            ApiKeyPrefix = new ConcurrentDictionary<string, string>();

            // Setting Timeout has side effects (forces ApiClient creation).
            Timeout = 100000;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration" /> class
        /// </summary>
        public Configuration(
            IDictionary<string, string> defaultHeader,
            IDictionary<string, string> apiKey,
            IDictionary<string, string> apiKeyPrefix,
            string basePath = "https://tapi.telstra.com") : this()
        {
            if (string.IsNullOrWhiteSpace(basePath))
                throw new ArgumentException("The provided basePath is invalid.", "basePath");
            if (defaultHeader == null)
                throw new ArgumentNullException("defaultHeader");
            if (apiKey == null)
                throw new ArgumentNullException("apiKey");
            if (apiKeyPrefix == null)
                throw new ArgumentNullException("apiKeyPrefix");

            BasePath = basePath;

            foreach (var keyValuePair in defaultHeader)
            {
                DefaultHeader.Add(keyValuePair);
            }

            foreach (var keyValuePair in apiKey)
            {
                ApiKey.Add(keyValuePair);
            }

            foreach (var keyValuePair in apiKeyPrefix)
            {
                ApiKeyPrefix.Add(keyValuePair);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration" /> class with different settings
        /// </summary>
        /// <param name="apiClient">Api client</param>
        /// <param name="defaultHeader">Dictionary of default HTTP header</param>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <param name="accessToken">accessToken</param>
        /// <param name="apiKey">Dictionary of API key</param>
        /// <param name="apiKeyPrefix">Dictionary of API key prefix</param>
        /// <param name="tempFolderPath">Temp folder path</param>
        /// <param name="dateTimeFormat">DateTime format string</param>
        /// <param name="timeout">HTTP connection timeout (in milliseconds)</param>
        /// <param name="userAgent">HTTP user agent</param>
        [Obsolete("Use explicit object construction and setting of properties.", true)]
        public Configuration(
            // ReSharper disable UnusedParameter.Local
            ApiClient apiClient = null,
            IDictionary<string, string> defaultHeader = null,
            string username = null,
            string password = null,
            string accessToken = null,
            IDictionary<string, string> apiKey = null,
            IDictionary<string, string> apiKeyPrefix = null,
            string tempFolderPath = null,
            string dateTimeFormat = null,
            int timeout = 100000,
            string userAgent = "Swagger-Codegen/1.0.0/csharp"
            // ReSharper restore UnusedParameter.Local
            )
        {

        }

        /// <summary>
        /// Initializes a new instance of the Configuration class.
        /// </summary>
        /// <param name="apiClient">Api client.</param>
        [Obsolete("This constructor caused unexpected sharing of static data. It is no longer supported.", true)]
        // ReSharper disable once UnusedParameter.Local
        public Configuration(ApiClient apiClient)
        {

        }

        #endregion Constructors


        #region Properties

        private ApiClient _apiClient = null;
        /// <summary>
        /// Gets an instance of an ApiClient for this configuration
        /// </summary>
        public virtual ApiClient ApiClient
        {
            get
            {
                if (_apiClient == null) _apiClient = CreateApiClient();
                return _apiClient;
            }
        }

        private String _basePath = null;
        /// <summary>
        /// Gets or sets the base path for API access.
        /// </summary>
        public virtual string BasePath {
            get { return _basePath; }
            set {
                _basePath = value;
                // pass-through to ApiClient if it's set.
                if(_apiClient != null) {
                    _apiClient.RestClient.BaseUrl = new Uri(_basePath);
                }
            }
        }

        /// <summary>
        /// Gets or sets the default header.
        /// </summary>
        public virtual IDictionary<string, string> DefaultHeader { get; set; }

        /// <summary>
        /// Gets or sets the HTTP timeout (milliseconds) of ApiClient. Default to 100000 milliseconds.
        /// </summary>
        public virtual int Timeout
        {
            
            get { return ApiClient.RestClient.Timeout; }
            set { ApiClient.RestClient.Timeout = value; }
        }

        /// <summary>
        /// Gets or sets the HTTP user agent.
        /// </summary>
        /// <value>Http user agent.</value>
        public virtual string UserAgent { get; set; }

        /// <summary>
        /// Gets or sets the username (HTTP basic authentication).
        /// </summary>
        /// <value>The username.</value>
        public virtual string Username { get; set; }

        /// <summary>
        /// Gets or sets the password (HTTP basic authentication).
        /// </summary>
        /// <value>The password.</value>
        public virtual string Password { get; set; }

        /// <summary>
        /// Gets the API key with prefix.
        /// </summary>
        /// <param name="apiKeyIdentifier">API key identifier (authentication scheme).</param>
        /// <returns>API key with prefix.</returns>
        public string GetApiKeyWithPrefix(string apiKeyIdentifier)
        {
            var apiKeyValue = "";
            ApiKey.TryGetValue (apiKeyIdentifier, out apiKeyValue);
            var apiKeyPrefix = "";
            if (ApiKeyPrefix.TryGetValue (apiKeyIdentifier, out apiKeyPrefix))
                return apiKeyPrefix + " " + apiKeyValue;
            else
                return apiKeyValue;
        }

        /// <summary>
        /// Gets or sets the access token for OAuth2 authentication.
        /// </summary>
        /// <value>The access token.</value>
        public virtual string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the temporary folder path to store the files downloaded from the server.
        /// </summary>
        /// <value>Folder path.</value>
        public virtual string TempFolderPath
        {
            get { return _tempFolderPath; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    // Possible breaking change since swagger-codegen 2.2.1, enforce a valid temporary path on set.
                    _tempFolderPath = Path.GetTempPath();
                    return;
                }

                // create the directory if it does not exist
                if (!Directory.Exists(value))
                {
                    Directory.CreateDirectory(value);
                }

                // check if the path contains directory separator at the end
                if (value[value.Length - 1] == Path.DirectorySeparatorChar)
                {
                    _tempFolderPath = value;
                }
                else
                {
                    _tempFolderPath = value + Path.DirectorySeparatorChar;
                }
            }
        }

        /// <summary>
        /// Gets or sets the the date time format used when serializing in the ApiClient
        /// By default, it's set to ISO 8601 - "o", for others see:
        /// https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx
        /// and https://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx
        /// No validation is done to ensure that the string you're providing is valid
        /// </summary>
        /// <value>The DateTimeFormat string</value>
        public virtual string DateTimeFormat
        {
            get { return _dateTimeFormat; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    // Never allow a blank or null string, go back to the default
                    _dateTimeFormat = ISO8601_DATETIME_FORMAT;
                    return;
                }

                // Caution, no validation when you choose date time format other than ISO 8601
                // Take a look at the above links
                _dateTimeFormat = value;
            }
        }

        /// <summary>
        /// Gets or sets the prefix (e.g. Token) of the API key based on the authentication name.
        /// </summary>
        /// <value>The prefix of the API key.</value>
        public virtual IDictionary<string, string> ApiKeyPrefix
        {
            get { return _apiKeyPrefix; }
            set
            {
                if (value == null)
                {
                    throw new InvalidOperationException("ApiKeyPrefix collection may not be null.");
                }
                _apiKeyPrefix = value;
            }
        }

        /// <summary>
        /// Gets or sets the API key based on the authentication name.
        /// </summary>
        /// <value>The API key.</value>
        public virtual IDictionary<string, string> ApiKey
        {
            get { return _apiKey; }
            set
            {
                if (value == null)
                {
                    throw new InvalidOperationException("ApiKey collection may not be null.");
                }
                _apiKey = value;
            }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        public void AddDefaultHeader(string key, string value)
        {
            DefaultHeader[key] = value;
        }

        /// <summary>
        /// Creates a new <see cref="ApiClient" /> based on this <see cref="Configuration" /> instance.
        /// </summary>
        /// <returns></returns>
        public ApiClient CreateApiClient()
        {
            return new ApiClient(BasePath) { Configuration = this };
        }


        /// <summary>
        /// Returns a string with essential information for debugging.
        /// </summary>
        public static String ToDebugReport()
        {
            String report = "C# SDK (com.telstra.eventdetection) Debug Report:\n";
            report += "    OS: " + System.Environment.OSVersion + "\n";
            report += "    .NET Framework Version: " + System.Environment.Version  + "\n";
            report += "    Version of the API: 1.0.0\n";
            report += "    SDK Package Version: 1.0.0\n";

            return report;
        }

        /// <summary>
        /// Add Api Key Header.
        /// </summary>
        /// <param name="key">Api Key name.</param>
        /// <param name="value">Api Key value.</param>
        /// <returns></returns>
        public void AddApiKey(string key, string value)
        {
            ApiKey[key] = value;
        }

        /// <summary>
        /// Sets the API key prefix.
        /// </summary>
        /// <param name="key">Api Key name.</param>
        /// <param name="value">Api Key value.</param>
        public void AddApiKeyPrefix(string key, string value)
        {
            ApiKeyPrefix[key] = value;
        }

        #endregion Methods
    }
}
