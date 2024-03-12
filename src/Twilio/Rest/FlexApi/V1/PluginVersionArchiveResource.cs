/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Flex
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



namespace Twilio.Rest.FlexApi.V1
{
    public class PluginVersionArchiveResource : Resource
    {
    

    

        
        private static Request BuildUpdateRequest(UpdatePluginVersionArchiveOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/PluginService/Plugins/{PluginSid}/Versions/{Sid}/Archive";

            string PathPluginSid = options.PathPluginSid;
            path = path.Replace("{"+"PluginSid"+"}", PathPluginSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.FlexApi,
                path,
                postParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> update </summary>
        /// <param name="options"> Update PluginVersionArchive parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PluginVersionArchive </returns>
        public static PluginVersionArchiveResource Update(UpdatePluginVersionArchiveOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
        /// <param name="options"> Update PluginVersionArchive parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PluginVersionArchive </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<PluginVersionArchiveResource> UpdateAsync(UpdatePluginVersionArchiveOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> update </summary>
        /// <param name="pathPluginSid"> The SID of the Flex Plugin the resource to belongs to. </param>
        /// <param name="pathSid"> The SID of the Flex Plugin Version resource to archive. </param>
        /// <param name="flexMetadata"> The Flex-Metadata HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PluginVersionArchive </returns>
        public static PluginVersionArchiveResource Update(
                                          string pathPluginSid,
                                          string pathSid,
                                          string flexMetadata = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdatePluginVersionArchiveOptions(pathPluginSid, pathSid){ FlexMetadata = flexMetadata };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> update </summary>
        /// <param name="pathPluginSid"> The SID of the Flex Plugin the resource to belongs to. </param>
        /// <param name="pathSid"> The SID of the Flex Plugin Version resource to archive. </param>
        /// <param name="flexMetadata"> The Flex-Metadata HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PluginVersionArchive </returns>
        public static async System.Threading.Tasks.Task<PluginVersionArchiveResource> UpdateAsync(
                                                                              string pathPluginSid,
                                                                              string pathSid,
                                                                              string flexMetadata = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdatePluginVersionArchiveOptions(pathPluginSid, pathSid){ FlexMetadata = flexMetadata };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a PluginVersionArchiveResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> PluginVersionArchiveResource object represented by the provided JSON </returns>
        public static PluginVersionArchiveResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<PluginVersionArchiveResource>(json);
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

    
        ///<summary> The unique string that we created to identify the Flex Plugin Version resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the Flex Plugin resource this Flex Plugin Version belongs to. </summary> 
        [JsonProperty("plugin_sid")]
        public string PluginSid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Flex Plugin Version resource and owns this resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The unique version of this Flex Plugin Version. </summary> 
        [JsonProperty("version")]
        public string Version { get; private set; }

        ///<summary> The URL of where the Flex Plugin Version JavaScript bundle is hosted on. </summary> 
        [JsonProperty("plugin_url")]
        public Uri PluginUrl { get; private set; }

        ///<summary> A changelog that describes the changes this Flex Plugin Version brings. </summary> 
        [JsonProperty("changelog")]
        public string Changelog { get; private set; }

        ///<summary> Whether to inject credentials while accessing this Plugin Version. The default value is false. </summary> 
        [JsonProperty("private")]
        public bool? Private { get; private set; }

        ///<summary> Whether the Flex Plugin Version is archived. The default value is false. </summary> 
        [JsonProperty("archived")]
        public bool? Archived { get; private set; }

        ///<summary> The date and time in GMT when the Flex Plugin Version was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The absolute URL of the Flex Plugin Version resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private PluginVersionArchiveResource() {

        }
    }
}

