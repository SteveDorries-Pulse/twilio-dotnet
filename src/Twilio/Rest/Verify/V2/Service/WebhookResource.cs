/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Verify
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


namespace Twilio.Rest.Verify.V2.Service
{
    public class WebhookResource : Resource
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
            public static readonly StatusEnum Enabled = new StatusEnum("enabled");
            public static readonly StatusEnum Disabled = new StatusEnum("disabled");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class VersionEnum : StringEnum
        {
            private VersionEnum(string value) : base(value) {}
            public VersionEnum() {}
            public static implicit operator VersionEnum(string value)
            {
                return new VersionEnum(value);
            }
            public static readonly VersionEnum V1 = new VersionEnum("v1");
            public static readonly VersionEnum V2 = new VersionEnum("v2");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class MethodsEnum : StringEnum
        {
            private MethodsEnum(string value) : base(value) {}
            public MethodsEnum() {}
            public static implicit operator MethodsEnum(string value)
            {
                return new MethodsEnum(value);
            }
            public static readonly MethodsEnum Get = new MethodsEnum("GET");
            public static readonly MethodsEnum Post = new MethodsEnum("POST");

        }

        
        private static Request BuildCreateRequest(CreateWebhookOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Services/{ServiceSid}/Webhooks";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Verify,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new Webhook for the Service </summary>
        /// <param name="options"> Create Webhook parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Webhook </returns>
        public static WebhookResource Create(CreateWebhookOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a new Webhook for the Service </summary>
        /// <param name="options"> Create Webhook parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<WebhookResource> CreateAsync(CreateWebhookOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a new Webhook for the Service </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>
        /// <param name="friendlyName"> The string that you assigned to describe the webhook. **This value should not contain PII.** </param>
        /// <param name="eventTypes"> The array of events that this Webhook is subscribed to. Possible event types: `*, factor.deleted, factor.created, factor.verified, challenge.approved, challenge.denied` </param>
        /// <param name="webhookUrl"> The URL associated with this Webhook. </param>
        /// <param name="status">  </param>
        /// <param name="version">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Webhook </returns>
        public static WebhookResource Create(
                                          string pathServiceSid,
                                          string friendlyName,
                                          List<string> eventTypes,
                                          string webhookUrl,
                                          WebhookResource.StatusEnum status = null,
                                          WebhookResource.VersionEnum version = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateWebhookOptions(pathServiceSid, friendlyName, eventTypes, webhookUrl){  Status = status, Version = version };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a new Webhook for the Service </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>
        /// <param name="friendlyName"> The string that you assigned to describe the webhook. **This value should not contain PII.** </param>
        /// <param name="eventTypes"> The array of events that this Webhook is subscribed to. Possible event types: `*, factor.deleted, factor.created, factor.verified, challenge.approved, challenge.denied` </param>
        /// <param name="webhookUrl"> The URL associated with this Webhook. </param>
        /// <param name="status">  </param>
        /// <param name="version">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<WebhookResource> CreateAsync(
                                                                                  string pathServiceSid,
                                                                                  string friendlyName,
                                                                                  List<string> eventTypes,
                                                                                  string webhookUrl,
                                                                                  WebhookResource.StatusEnum status = null,
                                                                                  WebhookResource.VersionEnum version = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateWebhookOptions(pathServiceSid, friendlyName, eventTypes, webhookUrl){  Status = status, Version = version };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> Delete a specific Webhook. </summary>
        /// <param name="options"> Delete Webhook parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Webhook </returns>
        private static Request BuildDeleteRequest(DeleteWebhookOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Services/{ServiceSid}/Webhooks/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Verify,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Delete a specific Webhook. </summary>
        /// <param name="options"> Delete Webhook parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Webhook </returns>
        public static bool Delete(DeleteWebhookOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Delete a specific Webhook. </summary>
        /// <param name="options"> Delete Webhook parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteWebhookOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Delete a specific Webhook. </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Webhook resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Webhook </returns>
        public static bool Delete(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteWebhookOptions(pathServiceSid, pathSid)        ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Delete a specific Webhook. </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Webhook resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteWebhookOptions(pathServiceSid, pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchWebhookOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Services/{ServiceSid}/Webhooks/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Verify,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch a specific Webhook. </summary>
        /// <param name="options"> Fetch Webhook parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Webhook </returns>
        public static WebhookResource Fetch(FetchWebhookOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a specific Webhook. </summary>
        /// <param name="options"> Fetch Webhook parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<WebhookResource> FetchAsync(FetchWebhookOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a specific Webhook. </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Webhook resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Webhook </returns>
        public static WebhookResource Fetch(
                                         string pathServiceSid, 
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchWebhookOptions(pathServiceSid, pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a specific Webhook. </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Webhook resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<WebhookResource> FetchAsync(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchWebhookOptions(pathServiceSid, pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadWebhookOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Services/{ServiceSid}/Webhooks";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Verify,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all Webhooks for a Service. </summary>
        /// <param name="options"> Read Webhook parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Webhook </returns>
        public static ResourceSet<WebhookResource> Read(ReadWebhookOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<WebhookResource>.FromJson("webhooks", response.Content);
            return new ResourceSet<WebhookResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Webhooks for a Service. </summary>
        /// <param name="options"> Read Webhook parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<WebhookResource>> ReadAsync(ReadWebhookOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<WebhookResource>.FromJson("webhooks", response.Content);
            return new ResourceSet<WebhookResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of all Webhooks for a Service. </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Webhook </returns>
        public static ResourceSet<WebhookResource> Read(
                                                     string pathServiceSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadWebhookOptions(pathServiceSid){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Webhooks for a Service. </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<WebhookResource>> ReadAsync(
                                                                                             string pathServiceSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadWebhookOptions(pathServiceSid){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<WebhookResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<WebhookResource>.FromJson("webhooks", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<WebhookResource> NextPage(Page<WebhookResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<WebhookResource>.FromJson("webhooks", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<WebhookResource> PreviousPage(Page<WebhookResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<WebhookResource>.FromJson("webhooks", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateWebhookOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Services/{ServiceSid}/Webhooks/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Verify,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Webhook parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Webhook </returns>
        public static WebhookResource Update(UpdateWebhookOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Webhook parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<WebhookResource> UpdateAsync(UpdateWebhookOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> update </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Webhook resource to update. </param>
        /// <param name="friendlyName"> The string that you assigned to describe the webhook. **This value should not contain PII.** </param>
        /// <param name="eventTypes"> The array of events that this Webhook is subscribed to. Possible event types: `*, factor.deleted, factor.created, factor.verified, challenge.approved, challenge.denied` </param>
        /// <param name="webhookUrl"> The URL associated with this Webhook. </param>
        /// <param name="status">  </param>
        /// <param name="version">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Webhook </returns>
        public static WebhookResource Update(
                                          string pathServiceSid,
                                          string pathSid,
                                          string friendlyName = null,
                                          List<string> eventTypes = null,
                                          string webhookUrl = null,
                                          WebhookResource.StatusEnum status = null,
                                          WebhookResource.VersionEnum version = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateWebhookOptions(pathServiceSid, pathSid){ FriendlyName = friendlyName, EventTypes = eventTypes, WebhookUrl = webhookUrl, Status = status, Version = version };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> update </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Webhook resource to update. </param>
        /// <param name="friendlyName"> The string that you assigned to describe the webhook. **This value should not contain PII.** </param>
        /// <param name="eventTypes"> The array of events that this Webhook is subscribed to. Possible event types: `*, factor.deleted, factor.created, factor.verified, challenge.approved, challenge.denied` </param>
        /// <param name="webhookUrl"> The URL associated with this Webhook. </param>
        /// <param name="status">  </param>
        /// <param name="version">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<WebhookResource> UpdateAsync(
                                                                              string pathServiceSid,
                                                                              string pathSid,
                                                                              string friendlyName = null,
                                                                              List<string> eventTypes = null,
                                                                              string webhookUrl = null,
                                                                              WebhookResource.StatusEnum status = null,
                                                                              WebhookResource.VersionEnum version = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateWebhookOptions(pathServiceSid, pathSid){ FriendlyName = friendlyName, EventTypes = eventTypes, WebhookUrl = webhookUrl, Status = status, Version = version };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a WebhookResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> WebhookResource object represented by the provided JSON </returns>
        public static WebhookResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<WebhookResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The unique string that we created to identify the Webhook resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The unique SID identifier of the Service. </summary> 
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Service resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The string that you assigned to describe the webhook. **This value should not contain PII.** </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The array of events that this Webhook is subscribed to. Possible event types: `*, factor.deleted, factor.created, factor.verified, challenge.approved, challenge.denied` </summary> 
        [JsonProperty("event_types")]
        public List<string> EventTypes { get; private set; }

        
        [JsonProperty("status")]
        public WebhookResource.StatusEnum Status { get; private set; }

        
        [JsonProperty("version")]
        public WebhookResource.VersionEnum Version { get; private set; }

        ///<summary> The URL associated with this Webhook. </summary> 
        [JsonProperty("webhook_url")]
        public Uri WebhookUrl { get; private set; }

        
        [JsonProperty("webhook_method")]
        public WebhookResource.MethodsEnum WebhookMethod { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The absolute URL of the Webhook resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private WebhookResource() {

        }
    }
}

