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


namespace Twilio.Rest.Numbers.V1
{
    public class PortingBulkPortabilityResource : Resource
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
            public static readonly StatusEnum InProgress = new StatusEnum("in-progress");
            public static readonly StatusEnum Completed = new StatusEnum("completed");
            public static readonly StatusEnum Expired = new StatusEnum("expired");

        }

        
        private static Request BuildCreateRequest(CreatePortingBulkPortabilityOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Porting/Portability";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Numbers,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Allows to check if a list of phone numbers can be ported to Twilio or not. This is done asynchronous for each phone number. </summary>
        /// <param name="options"> Create PortingBulkPortability parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PortingBulkPortability </returns>
        public static PortingBulkPortabilityResource Create(CreatePortingBulkPortabilityOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Allows to check if a list of phone numbers can be ported to Twilio or not. This is done asynchronous for each phone number. </summary>
        /// <param name="options"> Create PortingBulkPortability parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PortingBulkPortability </returns>
        public static async System.Threading.Tasks.Task<PortingBulkPortabilityResource> CreateAsync(CreatePortingBulkPortabilityOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Allows to check if a list of phone numbers can be ported to Twilio or not. This is done asynchronous for each phone number. </summary>
        /// <param name="phoneNumbers"> The phone numbers which portability is to be checked. This should be a list of strings. Phone numbers are in E.164 format (e.g. +16175551212). . </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PortingBulkPortability </returns>
        public static PortingBulkPortabilityResource Create(
                                          List<string> phoneNumbers,
                                          ITwilioRestClient client = null)
        {
            var options = new CreatePortingBulkPortabilityOptions(phoneNumbers){  };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Allows to check if a list of phone numbers can be ported to Twilio or not. This is done asynchronous for each phone number. </summary>
        /// <param name="phoneNumbers"> The phone numbers which portability is to be checked. This should be a list of strings. Phone numbers are in E.164 format (e.g. +16175551212). . </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PortingBulkPortability </returns>
        public static async System.Threading.Tasks.Task<PortingBulkPortabilityResource> CreateAsync(
                                                                                  List<string> phoneNumbers,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreatePortingBulkPortabilityOptions(phoneNumbers){  };
            return await CreateAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchPortingBulkPortabilityOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Porting/Portability/{Sid}";

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

        /// <summary> Fetch a previous portability check. This should return the current status of the validation and the result for all the numbers provided, given that they have been validated (as this process is performed asynchronously). </summary>
        /// <param name="options"> Fetch PortingBulkPortability parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PortingBulkPortability </returns>
        public static PortingBulkPortabilityResource Fetch(FetchPortingBulkPortabilityOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a previous portability check. This should return the current status of the validation and the result for all the numbers provided, given that they have been validated (as this process is performed asynchronously). </summary>
        /// <param name="options"> Fetch PortingBulkPortability parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PortingBulkPortability </returns>
        public static async System.Threading.Tasks.Task<PortingBulkPortabilityResource> FetchAsync(FetchPortingBulkPortabilityOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a previous portability check. This should return the current status of the validation and the result for all the numbers provided, given that they have been validated (as this process is performed asynchronously). </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies the Portability check. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PortingBulkPortability </returns>
        public static PortingBulkPortabilityResource Fetch(
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchPortingBulkPortabilityOptions(pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a previous portability check. This should return the current status of the validation and the result for all the numbers provided, given that they have been validated (as this process is performed asynchronously). </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies the Portability check. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PortingBulkPortability </returns>
        public static async System.Threading.Tasks.Task<PortingBulkPortabilityResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchPortingBulkPortabilityOptions(pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a PortingBulkPortabilityResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> PortingBulkPortabilityResource object represented by the provided JSON </returns>
        public static PortingBulkPortabilityResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<PortingBulkPortabilityResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> A 34 character string that uniquely identifies this Portability check. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        
        [JsonProperty("status")]
        public PortingBulkPortabilityResource.StatusEnum Status { get; private set; }

        ///<summary> The date that the Portability check was created, given in ISO 8601 format. </summary> 
        [JsonProperty("datetime_created")]
        public DateTime? DatetimeCreated { get; private set; }

        ///<summary> Contains a list with all the information of the requested phone numbers. Each phone number contains the following properties: `phone_number`: The phone number which portability is to be checked. `portable`: Boolean flag specifying if phone number is portable or not. `not_portable_reason`: Reason why the phone number cannot be ported into Twilio, `null` otherwise. `not_portable_reason_code`: The Portability Reason Code for the phone number if it cannot be ported in Twilio, `null` otherwise. `pin_and_account_number_required`: Boolean flag specifying if PIN and account number is required for the phone number. `number_type`: The type of the requested phone number. `country` Country the phone number belongs to. `messaging_carrier` Current messaging carrier of the phone number. `voice_carrier` Current voice carrier of the phone number. </summary> 
        [JsonProperty("phone_numbers")]
        public List<object> PhoneNumbers { get; private set; }

        ///<summary> This is the url of the request that you're trying to reach out to locate the resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private PortingBulkPortabilityResource() {

        }
    }
}

