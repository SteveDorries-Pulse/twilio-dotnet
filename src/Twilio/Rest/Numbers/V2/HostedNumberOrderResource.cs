/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Numbers
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;


namespace Twilio.Rest.Numbers.V2
{
    public class HostedNumberOrderResource : Resource
    {
    

    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }
            public static readonly StatusEnum Received = new StatusEnum("received");
            public static readonly StatusEnum Verified = new StatusEnum("verified");
            public static readonly StatusEnum PendingLoa = new StatusEnum("pending-loa");
            public static readonly StatusEnum CarrierProcessing = new StatusEnum("carrier-processing");
            public static readonly StatusEnum Completed = new StatusEnum("completed");
            public static readonly StatusEnum Failed = new StatusEnum("failed");
            public static readonly StatusEnum ActionRequired = new StatusEnum("action-required");

        }

        
        private static Request BuildCreateRequest(CreateHostedNumberOrderOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/HostedNumber/Orders";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Numbers,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Host a phone number's capability on Twilio's platform. </summary>
        /// <param name="options"> Create HostedNumberOrder parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of HostedNumberOrder </returns>
        public static HostedNumberOrderResource Create(CreateHostedNumberOrderOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Host a phone number's capability on Twilio's platform. </summary>
        /// <param name="options"> Create HostedNumberOrder parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of HostedNumberOrder </returns>
        public static async System.Threading.Tasks.Task<HostedNumberOrderResource> CreateAsync(CreateHostedNumberOrderOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Host a phone number's capability on Twilio's platform. </summary>
        /// <param name="phoneNumber"> The number to host in [+E.164](https://en.wikipedia.org/wiki/E.164) format </param>
        /// <param name="contactPhoneNumber"> The contact phone number of the person authorized to sign the Authorization Document. </param>
        /// <param name="addressSid"> Optional. A 34 character string that uniquely identifies the Address resource that represents the address of the owner of this phone number. </param>
        /// <param name="email"> Optional. Email of the owner of this phone number that is being hosted. </param>
        /// <param name="accountSid"> This defaults to the AccountSid of the authorization the user is using. This can be provided to specify a subaccount to add the HostedNumberOrder to. </param>
        /// <param name="friendlyName"> A 128 character string that is a human readable text that describes this resource. </param>
        /// <param name="ccEmails"> Optional. A list of emails that the LOA document for this HostedNumberOrder will be carbon copied to. </param>
        /// <param name="smsUrl"> The URL that Twilio should request when somebody sends an SMS to the phone number. This will be copied onto the IncomingPhoneNumber resource. </param>
        /// <param name="smsMethod"> The HTTP method that should be used to request the SmsUrl. Must be either `GET` or `POST`.  This will be copied onto the IncomingPhoneNumber resource. </param>
        /// <param name="smsFallbackUrl"> A URL that Twilio will request if an error occurs requesting or executing the TwiML defined by SmsUrl. This will be copied onto the IncomingPhoneNumber resource. </param>
        /// <param name="smsCapability"> Used to specify that the SMS capability will be hosted on Twilio's platform. </param>
        /// <param name="smsFallbackMethod"> The HTTP method that should be used to request the SmsFallbackUrl. Must be either `GET` or `POST`. This will be copied onto the IncomingPhoneNumber resource. </param>
        /// <param name="statusCallbackUrl"> Optional. The Status Callback URL attached to the IncomingPhoneNumber resource. </param>
        /// <param name="statusCallbackMethod"> Optional. The Status Callback Method attached to the IncomingPhoneNumber resource. </param>
        /// <param name="smsApplicationSid"> Optional. The 34 character sid of the application Twilio should use to handle SMS messages sent to this number. If a `SmsApplicationSid` is present, Twilio will ignore all of the SMS urls above and use those set on the application. </param>
        /// <param name="contactTitle"> The title of the person authorized to sign the Authorization Document for this phone number. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of HostedNumberOrder </returns>
        public static HostedNumberOrderResource Create(
                                          Types.PhoneNumber phoneNumber,
                                          Types.PhoneNumber contactPhoneNumber,
                                          string addressSid,
                                          string email,
                                          string accountSid = null,
                                          string friendlyName = null,
                                          List<string> ccEmails = null,
                                          Uri smsUrl = null,
                                          Twilio.Http.HttpMethod smsMethod = null,
                                          Uri smsFallbackUrl = null,
                                          bool? smsCapability = null,
                                          Twilio.Http.HttpMethod smsFallbackMethod = null,
                                          Uri statusCallbackUrl = null,
                                          Twilio.Http.HttpMethod statusCallbackMethod = null,
                                          string smsApplicationSid = null,
                                          string contactTitle = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateHostedNumberOrderOptions(phoneNumber, contactPhoneNumber, addressSid, email){  AccountSid = accountSid, FriendlyName = friendlyName, CcEmails = ccEmails, SmsUrl = smsUrl, SmsMethod = smsMethod, SmsFallbackUrl = smsFallbackUrl, SmsCapability = smsCapability, SmsFallbackMethod = smsFallbackMethod, StatusCallbackUrl = statusCallbackUrl, StatusCallbackMethod = statusCallbackMethod, SmsApplicationSid = smsApplicationSid, ContactTitle = contactTitle };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Host a phone number's capability on Twilio's platform. </summary>
        /// <param name="phoneNumber"> The number to host in [+E.164](https://en.wikipedia.org/wiki/E.164) format </param>
        /// <param name="contactPhoneNumber"> The contact phone number of the person authorized to sign the Authorization Document. </param>
        /// <param name="addressSid"> Optional. A 34 character string that uniquely identifies the Address resource that represents the address of the owner of this phone number. </param>
        /// <param name="email"> Optional. Email of the owner of this phone number that is being hosted. </param>
        /// <param name="accountSid"> This defaults to the AccountSid of the authorization the user is using. This can be provided to specify a subaccount to add the HostedNumberOrder to. </param>
        /// <param name="friendlyName"> A 128 character string that is a human readable text that describes this resource. </param>
        /// <param name="ccEmails"> Optional. A list of emails that the LOA document for this HostedNumberOrder will be carbon copied to. </param>
        /// <param name="smsUrl"> The URL that Twilio should request when somebody sends an SMS to the phone number. This will be copied onto the IncomingPhoneNumber resource. </param>
        /// <param name="smsMethod"> The HTTP method that should be used to request the SmsUrl. Must be either `GET` or `POST`.  This will be copied onto the IncomingPhoneNumber resource. </param>
        /// <param name="smsFallbackUrl"> A URL that Twilio will request if an error occurs requesting or executing the TwiML defined by SmsUrl. This will be copied onto the IncomingPhoneNumber resource. </param>
        /// <param name="smsCapability"> Used to specify that the SMS capability will be hosted on Twilio's platform. </param>
        /// <param name="smsFallbackMethod"> The HTTP method that should be used to request the SmsFallbackUrl. Must be either `GET` or `POST`. This will be copied onto the IncomingPhoneNumber resource. </param>
        /// <param name="statusCallbackUrl"> Optional. The Status Callback URL attached to the IncomingPhoneNumber resource. </param>
        /// <param name="statusCallbackMethod"> Optional. The Status Callback Method attached to the IncomingPhoneNumber resource. </param>
        /// <param name="smsApplicationSid"> Optional. The 34 character sid of the application Twilio should use to handle SMS messages sent to this number. If a `SmsApplicationSid` is present, Twilio will ignore all of the SMS urls above and use those set on the application. </param>
        /// <param name="contactTitle"> The title of the person authorized to sign the Authorization Document for this phone number. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of HostedNumberOrder </returns>
        public static async System.Threading.Tasks.Task<HostedNumberOrderResource> CreateAsync(
                                                                                  Types.PhoneNumber phoneNumber,
                                                                                  Types.PhoneNumber contactPhoneNumber,
                                                                                  string addressSid,
                                                                                  string email,
                                                                                  string accountSid = null,
                                                                                  string friendlyName = null,
                                                                                  List<string> ccEmails = null,
                                                                                  Uri smsUrl = null,
                                                                                  Twilio.Http.HttpMethod smsMethod = null,
                                                                                  Uri smsFallbackUrl = null,
                                                                                  bool? smsCapability = null,
                                                                                  Twilio.Http.HttpMethod smsFallbackMethod = null,
                                                                                  Uri statusCallbackUrl = null,
                                                                                  Twilio.Http.HttpMethod statusCallbackMethod = null,
                                                                                  string smsApplicationSid = null,
                                                                                  string contactTitle = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateHostedNumberOrderOptions(phoneNumber, contactPhoneNumber, addressSid, email){  AccountSid = accountSid, FriendlyName = friendlyName, CcEmails = ccEmails, SmsUrl = smsUrl, SmsMethod = smsMethod, SmsFallbackUrl = smsFallbackUrl, SmsCapability = smsCapability, SmsFallbackMethod = smsFallbackMethod, StatusCallbackUrl = statusCallbackUrl, StatusCallbackMethod = statusCallbackMethod, SmsApplicationSid = smsApplicationSid, ContactTitle = contactTitle };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> Cancel the HostedNumberOrder (only available when the status is in `received`). </summary>
        /// <param name="options"> Delete HostedNumberOrder parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of HostedNumberOrder </returns>
        private static Request BuildDeleteRequest(DeleteHostedNumberOrderOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/HostedNumber/Orders/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Numbers,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Cancel the HostedNumberOrder (only available when the status is in `received`). </summary>
        /// <param name="options"> Delete HostedNumberOrder parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of HostedNumberOrder </returns>
        public static bool Delete(DeleteHostedNumberOrderOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Cancel the HostedNumberOrder (only available when the status is in `received`). </summary>
        /// <param name="options"> Delete HostedNumberOrder parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of HostedNumberOrder </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteHostedNumberOrderOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Cancel the HostedNumberOrder (only available when the status is in `received`). </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this HostedNumberOrder. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of HostedNumberOrder </returns>
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteHostedNumberOrderOptions(pathSid)     ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Cancel the HostedNumberOrder (only available when the status is in `received`). </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this HostedNumberOrder. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of HostedNumberOrder </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteHostedNumberOrderOptions(pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchHostedNumberOrderOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/HostedNumber/Orders/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Numbers,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch a specific HostedNumberOrder. </summary>
        /// <param name="options"> Fetch HostedNumberOrder parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of HostedNumberOrder </returns>
        public static HostedNumberOrderResource Fetch(FetchHostedNumberOrderOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a specific HostedNumberOrder. </summary>
        /// <param name="options"> Fetch HostedNumberOrder parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of HostedNumberOrder </returns>
        public static async System.Threading.Tasks.Task<HostedNumberOrderResource> FetchAsync(FetchHostedNumberOrderOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a specific HostedNumberOrder. </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this HostedNumberOrder. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of HostedNumberOrder </returns>
        public static HostedNumberOrderResource Fetch(
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchHostedNumberOrderOptions(pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a specific HostedNumberOrder. </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this HostedNumberOrder. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of HostedNumberOrder </returns>
        public static async System.Threading.Tasks.Task<HostedNumberOrderResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchHostedNumberOrderOptions(pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadHostedNumberOrderOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/HostedNumber/Orders";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Numbers,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of HostedNumberOrders belonging to the account initiating the request. </summary>
        /// <param name="options"> Read HostedNumberOrder parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of HostedNumberOrder </returns>
        public static ResourceSet<HostedNumberOrderResource> Read(ReadHostedNumberOrderOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<HostedNumberOrderResource>.FromJson("items", response.Content);
            return new ResourceSet<HostedNumberOrderResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of HostedNumberOrders belonging to the account initiating the request. </summary>
        /// <param name="options"> Read HostedNumberOrder parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of HostedNumberOrder </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<HostedNumberOrderResource>> ReadAsync(ReadHostedNumberOrderOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<HostedNumberOrderResource>.FromJson("items", response.Content);
            return new ResourceSet<HostedNumberOrderResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of HostedNumberOrders belonging to the account initiating the request. </summary>
        /// <param name="status"> The Status of this HostedNumberOrder. One of `received`, `pending-verification`, `verified`, `pending-loa`, `carrier-processing`, `testing`, `completed`, `failed`, or `action-required`. </param>
        /// <param name="smsCapability"> Whether the SMS capability will be hosted on our platform. Can be `true` of `false`. </param>
        /// <param name="phoneNumber"> An E164 formatted phone number hosted by this HostedNumberOrder. </param>
        /// <param name="incomingPhoneNumberSid"> A 34 character string that uniquely identifies the IncomingPhoneNumber resource created by this HostedNumberOrder. </param>
        /// <param name="friendlyName"> A human readable description of this resource, up to 128 characters. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of HostedNumberOrder </returns>
        public static ResourceSet<HostedNumberOrderResource> Read(
                                                     HostedNumberOrderResource.StatusEnum status = null,
                                                     bool? smsCapability = null,
                                                     Types.PhoneNumber phoneNumber = null,
                                                     string incomingPhoneNumberSid = null,
                                                     string friendlyName = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadHostedNumberOrderOptions(){ Status = status, SmsCapability = smsCapability, PhoneNumber = phoneNumber, IncomingPhoneNumberSid = incomingPhoneNumberSid, FriendlyName = friendlyName, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of HostedNumberOrders belonging to the account initiating the request. </summary>
        /// <param name="status"> The Status of this HostedNumberOrder. One of `received`, `pending-verification`, `verified`, `pending-loa`, `carrier-processing`, `testing`, `completed`, `failed`, or `action-required`. </param>
        /// <param name="smsCapability"> Whether the SMS capability will be hosted on our platform. Can be `true` of `false`. </param>
        /// <param name="phoneNumber"> An E164 formatted phone number hosted by this HostedNumberOrder. </param>
        /// <param name="incomingPhoneNumberSid"> A 34 character string that uniquely identifies the IncomingPhoneNumber resource created by this HostedNumberOrder. </param>
        /// <param name="friendlyName"> A human readable description of this resource, up to 128 characters. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of HostedNumberOrder </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<HostedNumberOrderResource>> ReadAsync(
                                                                                             HostedNumberOrderResource.StatusEnum status = null,
                                                                                             bool? smsCapability = null,
                                                                                             Types.PhoneNumber phoneNumber = null,
                                                                                             string incomingPhoneNumberSid = null,
                                                                                             string friendlyName = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadHostedNumberOrderOptions(){ Status = status, SmsCapability = smsCapability, PhoneNumber = phoneNumber, IncomingPhoneNumberSid = incomingPhoneNumberSid, FriendlyName = friendlyName, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<HostedNumberOrderResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<HostedNumberOrderResource>.FromJson("items", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<HostedNumberOrderResource> NextPage(Page<HostedNumberOrderResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<HostedNumberOrderResource>.FromJson("items", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<HostedNumberOrderResource> PreviousPage(Page<HostedNumberOrderResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<HostedNumberOrderResource>.FromJson("items", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a HostedNumberOrderResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> HostedNumberOrderResource object represented by the provided JSON </returns>
        public static HostedNumberOrderResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<HostedNumberOrderResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> A 34 character string that uniquely identifies this HostedNumberOrder. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> A 34 character string that uniquely identifies the account. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> A 34 character string that uniquely identifies the [IncomingPhoneNumber](https://www.twilio.com/docs/api/rest/incoming-phone-numbers) resource that represents the phone number being hosted. </summary> 
        [JsonProperty("incoming_phone_number_sid")]
        public string IncomingPhoneNumberSid { get; private set; }

        ///<summary> A 34 character string that uniquely identifies the Address resource that represents the address of the owner of this phone number. </summary> 
        [JsonProperty("address_sid")]
        public string AddressSid { get; private set; }

        ///<summary> A 34 character string that uniquely identifies the [Authorization Document](https://www.twilio.com/docs/api/phone-numbers/hosted-number-authorization-documents) the user needs to sign. </summary> 
        [JsonProperty("signing_document_sid")]
        public string SigningDocumentSid { get; private set; }

        ///<summary> Phone number to be hosted. This must be in [E.164](https://en.wikipedia.org/wiki/E.164) format, e.g., +16175551212 </summary> 
        [JsonProperty("phone_number")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber PhoneNumber { get; private set; }

        ///<summary> The capabilities </summary> 
        [JsonProperty("capabilities")]
        public PhoneNumberCapabilities Capabilities { get; private set; }

        ///<summary> A 128 character string that is a human-readable text that describes this resource. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        
        [JsonProperty("status")]
        public HostedNumberOrderResource.StatusEnum Status { get; private set; }

        ///<summary> A message that explains why a hosted_number_order went to status \"action-required\" </summary> 
        [JsonProperty("failure_reason")]
        public string FailureReason { get; private set; }

        ///<summary> The date this resource was created, given as [GMT RFC 2822](http://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date that this resource was updated, given as [GMT RFC 2822](http://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> Email of the owner of this phone number that is being hosted. </summary> 
        [JsonProperty("email")]
        public string Email { get; private set; }

        ///<summary> A list of emails that LOA document for this HostedNumberOrder will be carbon copied to. </summary> 
        [JsonProperty("cc_emails")]
        public List<string> CcEmails { get; private set; }

        ///<summary> The URL of this HostedNumberOrder. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The title of the person authorized to sign the Authorization Document for this phone number. </summary> 
        [JsonProperty("contact_title")]
        public string ContactTitle { get; private set; }

        ///<summary> The contact phone number of the person authorized to sign the Authorization Document. </summary> 
        [JsonProperty("contact_phone_number")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber ContactPhoneNumber { get; private set; }

        ///<summary> A 34 character string that uniquely identifies the bulk hosting request associated with this HostedNumberOrder. </summary> 
        [JsonProperty("bulk_hosting_request_sid")]
        public string BulkHostingRequestSid { get; private set; }

        ///<summary> The next step you need to take to complete the hosted number order and request it successfully. </summary> 
        [JsonProperty("next_step")]
        public string NextStep { get; private set; }



        private HostedNumberOrderResource() {

        }
    }
}

