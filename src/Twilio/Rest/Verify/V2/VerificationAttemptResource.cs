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
using Twilio.Constant;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;


namespace Twilio.Rest.Verify.V2
{
    public class VerificationAttemptResource : Resource
    {
    

    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class ChannelsEnum : StringEnum
        {
            private ChannelsEnum(string value) : base(value) {}
            public ChannelsEnum() {}
            public static implicit operator ChannelsEnum(string value)
            {
                return new ChannelsEnum(value);
            }
            public static readonly ChannelsEnum Sms = new ChannelsEnum("sms");
            public static readonly ChannelsEnum Call = new ChannelsEnum("call");
            public static readonly ChannelsEnum Email = new ChannelsEnum("email");
            public static readonly ChannelsEnum Whatsapp = new ChannelsEnum("whatsapp");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class ConversionStatusEnum : StringEnum
        {
            private ConversionStatusEnum(string value) : base(value) {}
            public ConversionStatusEnum() {}
            public static implicit operator ConversionStatusEnum(string value)
            {
                return new ConversionStatusEnum(value);
            }
            public static readonly ConversionStatusEnum Converted = new ConversionStatusEnum("converted");
            public static readonly ConversionStatusEnum Unconverted = new ConversionStatusEnum("unconverted");

        }

        
        private static Request BuildFetchRequest(FetchVerificationAttemptOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Attempts/{Sid}";

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

        /// <summary> Fetch a specific verification attempt. </summary>
        /// <param name="options"> Fetch VerificationAttempt parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of VerificationAttempt </returns>
        public static VerificationAttemptResource Fetch(FetchVerificationAttemptOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a specific verification attempt. </summary>
        /// <param name="options"> Fetch VerificationAttempt parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of VerificationAttempt </returns>
        public static async System.Threading.Tasks.Task<VerificationAttemptResource> FetchAsync(FetchVerificationAttemptOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a specific verification attempt. </summary>
        /// <param name="pathSid"> The unique SID identifier of a Verification Attempt </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of VerificationAttempt </returns>
        public static VerificationAttemptResource Fetch(
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchVerificationAttemptOptions(pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a specific verification attempt. </summary>
        /// <param name="pathSid"> The unique SID identifier of a Verification Attempt </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of VerificationAttempt </returns>
        public static async System.Threading.Tasks.Task<VerificationAttemptResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchVerificationAttemptOptions(pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadVerificationAttemptOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Attempts";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Verify,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> List all the verification attempts for a given Account. </summary>
        /// <param name="options"> Read VerificationAttempt parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of VerificationAttempt </returns>
        public static ResourceSet<VerificationAttemptResource> Read(ReadVerificationAttemptOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<VerificationAttemptResource>.FromJson("attempts", response.Content);
            return new ResourceSet<VerificationAttemptResource>(page, options, client);
        }

        #if !NET35
        /// <summary> List all the verification attempts for a given Account. </summary>
        /// <param name="options"> Read VerificationAttempt parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of VerificationAttempt </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<VerificationAttemptResource>> ReadAsync(ReadVerificationAttemptOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<VerificationAttemptResource>.FromJson("attempts", response.Content);
            return new ResourceSet<VerificationAttemptResource>(page, options, client);
        }
        #endif
        /// <summary> List all the verification attempts for a given Account. </summary>
        /// <param name="dateCreatedAfter"> Datetime filter used to consider only Verification Attempts created after this datetime on the summary aggregation. Given as GMT in ISO 8601 formatted datetime string: yyyy-MM-dd'T'HH:mm:ss'Z. </param>
        /// <param name="dateCreatedBefore"> Datetime filter used to consider only Verification Attempts created before this datetime on the summary aggregation. Given as GMT in ISO 8601 formatted datetime string: yyyy-MM-dd'T'HH:mm:ss'Z. </param>
        /// <param name="channelDataTo"> Destination of a verification. It is phone number in E.164 format. </param>
        /// <param name="country"> Filter used to query Verification Attempts sent to the specified destination country. </param>
        /// <param name="channel"> Filter used to query Verification Attempts by communication channel. Valid values are `SMS` and `CALL` </param>
        /// <param name="verifyServiceSid"> Filter used to query Verification Attempts by verify service. Only attempts of the provided SID will be returned. </param>
        /// <param name="verificationSid"> Filter used to return all the Verification Attempts of a single verification. Only attempts of the provided verification SID will be returned. </param>
        /// <param name="status"> Filter used to query Verification Attempts by conversion status. Valid values are `UNCONVERTED`, for attempts that were not converted, and `CONVERTED`, for attempts that were confirmed. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of VerificationAttempt </returns>
        public static ResourceSet<VerificationAttemptResource> Read(
                                                     DateTime? dateCreatedAfter = null,
                                                     DateTime? dateCreatedBefore = null,
                                                     string channelDataTo = null,
                                                     string country = null,
                                                     VerificationAttemptResource.ChannelsEnum channel = null,
                                                     string verifyServiceSid = null,
                                                     string verificationSid = null,
                                                     VerificationAttemptResource.ConversionStatusEnum status = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadVerificationAttemptOptions(){ DateCreatedAfter = dateCreatedAfter, DateCreatedBefore = dateCreatedBefore, ChannelDataTo = channelDataTo, Country = country, Channel = channel, VerifyServiceSid = verifyServiceSid, VerificationSid = verificationSid, Status = status, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> List all the verification attempts for a given Account. </summary>
        /// <param name="dateCreatedAfter"> Datetime filter used to consider only Verification Attempts created after this datetime on the summary aggregation. Given as GMT in ISO 8601 formatted datetime string: yyyy-MM-dd'T'HH:mm:ss'Z. </param>
        /// <param name="dateCreatedBefore"> Datetime filter used to consider only Verification Attempts created before this datetime on the summary aggregation. Given as GMT in ISO 8601 formatted datetime string: yyyy-MM-dd'T'HH:mm:ss'Z. </param>
        /// <param name="channelDataTo"> Destination of a verification. It is phone number in E.164 format. </param>
        /// <param name="country"> Filter used to query Verification Attempts sent to the specified destination country. </param>
        /// <param name="channel"> Filter used to query Verification Attempts by communication channel. Valid values are `SMS` and `CALL` </param>
        /// <param name="verifyServiceSid"> Filter used to query Verification Attempts by verify service. Only attempts of the provided SID will be returned. </param>
        /// <param name="verificationSid"> Filter used to return all the Verification Attempts of a single verification. Only attempts of the provided verification SID will be returned. </param>
        /// <param name="status"> Filter used to query Verification Attempts by conversion status. Valid values are `UNCONVERTED`, for attempts that were not converted, and `CONVERTED`, for attempts that were confirmed. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of VerificationAttempt </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<VerificationAttemptResource>> ReadAsync(
                                                                                             DateTime? dateCreatedAfter = null,
                                                                                             DateTime? dateCreatedBefore = null,
                                                                                             string channelDataTo = null,
                                                                                             string country = null,
                                                                                             VerificationAttemptResource.ChannelsEnum channel = null,
                                                                                             string verifyServiceSid = null,
                                                                                             string verificationSid = null,
                                                                                             VerificationAttemptResource.ConversionStatusEnum status = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadVerificationAttemptOptions(){ DateCreatedAfter = dateCreatedAfter, DateCreatedBefore = dateCreatedBefore, ChannelDataTo = channelDataTo, Country = country, Channel = channel, VerifyServiceSid = verifyServiceSid, VerificationSid = verificationSid, Status = status, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<VerificationAttemptResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<VerificationAttemptResource>.FromJson("attempts", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<VerificationAttemptResource> NextPage(Page<VerificationAttemptResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<VerificationAttemptResource>.FromJson("attempts", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<VerificationAttemptResource> PreviousPage(Page<VerificationAttemptResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<VerificationAttemptResource>.FromJson("attempts", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a VerificationAttemptResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> VerificationAttemptResource object represented by the provided JSON </returns>
        public static VerificationAttemptResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<VerificationAttemptResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
        /// <summary>
    /// Converts an object into a json string
    /// </summary>
    /// <param name="model"> C# model </param>
    /// <returns> JSON string </returns>
    public static string ToJson(object model)
    {
        try
        {
            return JsonConvert.SerializeObject(model);
        }
        catch (JsonException e)
        {
            throw new ApiException(e.Message, e);
        }
    }

    
        ///<summary> The SID that uniquely identifies the verification attempt resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Verification resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) used to generate the attempt. </summary> 
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }

        ///<summary> The SID of the [Verification](https://www.twilio.com/docs/verify/api/verification) that generated the attempt. </summary> 
        [JsonProperty("verification_sid")]
        public string VerificationSid { get; private set; }

        ///<summary> The date that this Attempt was created, given in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date that this Attempt was updated, given in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        
        [JsonProperty("conversion_status")]
        public VerificationAttemptResource.ConversionStatusEnum ConversionStatus { get; private set; }

        
        [JsonProperty("channel")]
        public VerificationAttemptResource.ChannelsEnum Channel { get; private set; }

        ///<summary> An object containing the charge for this verification attempt related to the channel costs and the currency used. The costs related to the succeeded verifications are not included. May not be immediately available. More information on pricing is available [here](https://www.twilio.com/en-us/verify/pricing). </summary> 
        [JsonProperty("price")]
        public object Price { get; private set; }

        ///<summary> An object containing the channel specific information for an attempt. </summary> 
        [JsonProperty("channel_data")]
        public object ChannelData { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private VerificationAttemptResource() {

        }
    }
}

