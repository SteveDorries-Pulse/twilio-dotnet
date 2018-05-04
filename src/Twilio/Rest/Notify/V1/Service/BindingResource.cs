/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
/// 
/// BindingResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Notify.V1.Service 
{

    public class BindingResource : Resource 
    {
        public sealed class BindingTypeEnum : StringEnum 
        {
            private BindingTypeEnum(string value) : base(value) {}
            public BindingTypeEnum() {}
            public static implicit operator BindingTypeEnum(string value)
            {
                return new BindingTypeEnum(value);
            }

            public static readonly BindingTypeEnum Apn = new BindingTypeEnum("apn");
            public static readonly BindingTypeEnum Gcm = new BindingTypeEnum("gcm");
            public static readonly BindingTypeEnum Sms = new BindingTypeEnum("sms");
            public static readonly BindingTypeEnum Fcm = new BindingTypeEnum("fcm");
            public static readonly BindingTypeEnum FacebookMessenger = new BindingTypeEnum("facebook-messenger");
            public static readonly BindingTypeEnum Alexa = new BindingTypeEnum("alexa");
        }

        private static Request BuildFetchRequest(FetchBindingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Notify,
                "/v1/Services/" + options.PathServiceSid + "/Bindings/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns> 
        public static BindingResource Fetch(FetchBindingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns> 
        public static async System.Threading.Tasks.Task<BindingResource> FetchAsync(FetchBindingOptions options, 
                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns> 
        public static BindingResource Fetch(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchBindingOptions(pathServiceSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns> 
        public static async System.Threading.Tasks.Task<BindingResource> FetchAsync(string pathServiceSid, 
                                                                                    string pathSid, 
                                                                                    ITwilioRestClient client = null)
        {
            var options = new FetchBindingOptions(pathServiceSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteBindingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Notify,
                "/v1/Services/" + options.PathServiceSid + "/Bindings/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns> 
        public static bool Delete(DeleteBindingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteBindingOptions options, 
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns> 
        public static bool Delete(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteBindingOptions(pathServiceSid, pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid, 
                                                                          string pathSid, 
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteBindingOptions(pathServiceSid, pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateBindingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Notify,
                "/v1/Services/" + options.PathServiceSid + "/Bindings",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns> 
        public static BindingResource Create(CreateBindingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns> 
        public static async System.Threading.Tasks.Task<BindingResource> CreateAsync(CreateBindingOptions options, 
                                                                                     ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="identity"> The Identity to which this Binding belongs to. </param>
        /// <param name="bindingType"> The type of the Binding. </param>
        /// <param name="address"> The address specific to the channel. </param>
        /// <param name="tag"> The list of tags associated with this Binding. </param>
        /// <param name="notificationProtocolVersion"> The version of the protocol used to send the notification. </param>
        /// <param name="credentialSid"> The unique identifier of the Credential resource to be used to send notifications to
        ///                     this Binding. </param>
        /// <param name="endpoint"> DEPRECATED* </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns> 
        public static BindingResource Create(string pathServiceSid, 
                                             string identity, 
                                             BindingResource.BindingTypeEnum bindingType, 
                                             string address, 
                                             List<string> tag = null, 
                                             string notificationProtocolVersion = null, 
                                             string credentialSid = null, 
                                             string endpoint = null, 
                                             ITwilioRestClient client = null)
        {
            var options = new CreateBindingOptions(pathServiceSid, identity, bindingType, address){Tag = tag, NotificationProtocolVersion = notificationProtocolVersion, CredentialSid = credentialSid, Endpoint = endpoint};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="identity"> The Identity to which this Binding belongs to. </param>
        /// <param name="bindingType"> The type of the Binding. </param>
        /// <param name="address"> The address specific to the channel. </param>
        /// <param name="tag"> The list of tags associated with this Binding. </param>
        /// <param name="notificationProtocolVersion"> The version of the protocol used to send the notification. </param>
        /// <param name="credentialSid"> The unique identifier of the Credential resource to be used to send notifications to
        ///                     this Binding. </param>
        /// <param name="endpoint"> DEPRECATED* </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns> 
        public static async System.Threading.Tasks.Task<BindingResource> CreateAsync(string pathServiceSid, 
                                                                                     string identity, 
                                                                                     BindingResource.BindingTypeEnum bindingType, 
                                                                                     string address, 
                                                                                     List<string> tag = null, 
                                                                                     string notificationProtocolVersion = null, 
                                                                                     string credentialSid = null, 
                                                                                     string endpoint = null, 
                                                                                     ITwilioRestClient client = null)
        {
            var options = new CreateBindingOptions(pathServiceSid, identity, bindingType, address){Tag = tag, NotificationProtocolVersion = notificationProtocolVersion, CredentialSid = credentialSid, Endpoint = endpoint};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadBindingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Notify,
                "/v1/Services/" + options.PathServiceSid + "/Bindings",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns> 
        public static ResourceSet<BindingResource> Read(ReadBindingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<BindingResource>.FromJson("bindings", response.Content);
            return new ResourceSet<BindingResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<BindingResource>> ReadAsync(ReadBindingOptions options, 
                                                                                                ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<BindingResource>.FromJson("bindings", response.Content);
            return new ResourceSet<BindingResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="startDate"> Only list Bindings created on or after the given date. </param>
        /// <param name="endDate"> Only list Bindings created on or before the given date. </param>
        /// <param name="identity"> Only list Bindings that have any of the specified Identities. </param>
        /// <param name="tag"> Only list Bindings that have all of the specified Tags. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns> 
        public static ResourceSet<BindingResource> Read(string pathServiceSid, 
                                                        DateTime? startDate = null, 
                                                        DateTime? endDate = null, 
                                                        List<string> identity = null, 
                                                        List<string> tag = null, 
                                                        int? pageSize = null, 
                                                        long? limit = null, 
                                                        ITwilioRestClient client = null)
        {
            var options = new ReadBindingOptions(pathServiceSid){StartDate = startDate, EndDate = endDate, Identity = identity, Tag = tag, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="startDate"> Only list Bindings created on or after the given date. </param>
        /// <param name="endDate"> Only list Bindings created on or before the given date. </param>
        /// <param name="identity"> Only list Bindings that have any of the specified Identities. </param>
        /// <param name="tag"> Only list Bindings that have all of the specified Tags. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<BindingResource>> ReadAsync(string pathServiceSid, 
                                                                                                DateTime? startDate = null, 
                                                                                                DateTime? endDate = null, 
                                                                                                List<string> identity = null, 
                                                                                                List<string> tag = null, 
                                                                                                int? pageSize = null, 
                                                                                                long? limit = null, 
                                                                                                ITwilioRestClient client = null)
        {
            var options = new ReadBindingOptions(pathServiceSid){StartDate = startDate, EndDate = endDate, Identity = identity, Tag = tag, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<BindingResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<BindingResource>.FromJson("bindings", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<BindingResource> NextPage(Page<BindingResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Notify,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<BindingResource>.FromJson("bindings", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<BindingResource> PreviousPage(Page<BindingResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Notify,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<BindingResource>.FromJson("bindings", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a BindingResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> BindingResource object represented by the provided JSON </returns> 
        public static BindingResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<BindingResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The service_sid
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// The unique identifier of the Credential resource to be used to send notifications to this Binding.
        /// </summary>
        [JsonProperty("credential_sid")]
        public string CredentialSid { get; private set; }
        /// <summary>
        /// The date_created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date_updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The version of the protocol used to send the notification.
        /// </summary>
        [JsonProperty("notification_protocol_version")]
        public string NotificationProtocolVersion { get; private set; }
        /// <summary>
        /// DEPRECATED*
        /// </summary>
        [JsonProperty("endpoint")]
        public string Endpoint { get; private set; }
        /// <summary>
        /// The Identity to which this Binding belongs to.
        /// </summary>
        [JsonProperty("identity")]
        public string Identity { get; private set; }
        /// <summary>
        /// The type of the Binding.
        /// </summary>
        [JsonProperty("binding_type")]
        public string BindingType { get; private set; }
        /// <summary>
        /// The address specific to the channel.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; private set; }
        /// <summary>
        /// The list of tags associated with this Binding.
        /// </summary>
        [JsonProperty("tags")]
        public List<string> Tags { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The links
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private BindingResource()
        {

        }
    }

}