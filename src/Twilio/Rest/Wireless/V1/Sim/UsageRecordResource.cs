/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Wireless
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


namespace Twilio.Rest.Wireless.V1.Sim
{
    public class UsageRecordResource : Resource
    {
    

    
        public sealed class GranularityEnum : StringEnum
        {
            private GranularityEnum(string value) : base(value) {}
            public GranularityEnum() {}
            public static implicit operator GranularityEnum(string value)
            {
                return new GranularityEnum(value);
            }
            public static readonly GranularityEnum Hourly = new GranularityEnum("hourly");
            public static readonly GranularityEnum Daily = new GranularityEnum("daily");
            public static readonly GranularityEnum All = new GranularityEnum("all");

        }

        
        private static Request BuildReadRequest(ReadUsageRecordOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Sims/{SimSid}/UsageRecords";

            string PathSimSid = options.PathSimSid;
            path = path.Replace("{"+"SimSid"+"}", PathSimSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Wireless,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read UsageRecord parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UsageRecord </returns>
        public static ResourceSet<UsageRecordResource> Read(ReadUsageRecordOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<UsageRecordResource>.FromJson("usage_records", response.Content);
            return new ResourceSet<UsageRecordResource>(page, options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read UsageRecord parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UsageRecord </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<UsageRecordResource>> ReadAsync(ReadUsageRecordOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<UsageRecordResource>.FromJson("usage_records", response.Content);
            return new ResourceSet<UsageRecordResource>(page, options, client);
        }
        #endif
        /// <summary> read </summary>
        /// <param name="pathSimSid"> The SID of the [Sim resource](https://www.twilio.com/docs/iot/wireless/api/sim-resource)  to read the usage from. </param>
        /// <param name="end"> Only include usage that occurred on or before this date, specified in [ISO 8601](https://www.iso.org/iso-8601-date-and-time-format.html). The default is the current time. </param>
        /// <param name="start"> Only include usage that has occurred on or after this date, specified in [ISO 8601](https://www.iso.org/iso-8601-date-and-time-format.html). The default is one month before the `end` parameter value. </param>
        /// <param name="granularity"> How to summarize the usage by time. Can be: `daily`, `hourly`, or `all`. The default is `all`. A value of `all` returns one Usage Record that describes the usage for the entire period. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UsageRecord </returns>
        public static ResourceSet<UsageRecordResource> Read(
                                                     string pathSimSid,
                                                     DateTime? end = null,
                                                     DateTime? start = null,
                                                     UsageRecordResource.GranularityEnum granularity = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadUsageRecordOptions(pathSimSid){ End = end, Start = start, Granularity = granularity, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="pathSimSid"> The SID of the [Sim resource](https://www.twilio.com/docs/iot/wireless/api/sim-resource)  to read the usage from. </param>
        /// <param name="end"> Only include usage that occurred on or before this date, specified in [ISO 8601](https://www.iso.org/iso-8601-date-and-time-format.html). The default is the current time. </param>
        /// <param name="start"> Only include usage that has occurred on or after this date, specified in [ISO 8601](https://www.iso.org/iso-8601-date-and-time-format.html). The default is one month before the `end` parameter value. </param>
        /// <param name="granularity"> How to summarize the usage by time. Can be: `daily`, `hourly`, or `all`. The default is `all`. A value of `all` returns one Usage Record that describes the usage for the entire period. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UsageRecord </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<UsageRecordResource>> ReadAsync(
                                                                                             string pathSimSid,
                                                                                             DateTime? end = null,
                                                                                             DateTime? start = null,
                                                                                             UsageRecordResource.GranularityEnum granularity = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadUsageRecordOptions(pathSimSid){ End = end, Start = start, Granularity = granularity, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<UsageRecordResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<UsageRecordResource>.FromJson("usage_records", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<UsageRecordResource> NextPage(Page<UsageRecordResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<UsageRecordResource>.FromJson("usage_records", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<UsageRecordResource> PreviousPage(Page<UsageRecordResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<UsageRecordResource>.FromJson("usage_records", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a UsageRecordResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> UsageRecordResource object represented by the provided JSON </returns>
        public static UsageRecordResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<UsageRecordResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The SID of the [Sim resource](https://www.twilio.com/docs/iot/wireless/api/sim-resource) that this Usage Record is for. </summary> 
        [JsonProperty("sim_sid")]
        public string SimSid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the UsageRecord resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The time period for which the usage is reported. Contains `start` and `end` datetime values given as GMT in [ISO 8601](https://www.iso.org/iso-8601-date-and-time-format.html) format. </summary> 
        [JsonProperty("period")]
        public object Period { get; private set; }

        ///<summary> An object that describes the SIM's usage of Commands during the specified period. See [Commands Usage Object](https://www.twilio.com/docs/iot/wireless/api/sim-usagerecord-resource#commands-usage-object). </summary> 
        [JsonProperty("commands")]
        public object Commands { get; private set; }

        ///<summary> An object that describes the SIM's data usage during the specified period. See [Data Usage Object](https://www.twilio.com/docs/iot/wireless/api/sim-usagerecord-resource#data-usage-object). </summary> 
        [JsonProperty("data")]
        public object Data { get; private set; }



        private UsageRecordResource() {

        }
    }
}

