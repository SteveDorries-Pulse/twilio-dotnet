/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Accounts
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



namespace Twilio.Rest.Accounts.V1
{
    public class BulkConsentsResource : Resource
    {
    

    

        
        private static Request BuildCreateRequest(CreateBulkConsentsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Consents/Bulk";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Accounts,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create BulkConsents parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BulkConsents </returns>
        public static BulkConsentsResource Create(CreateBulkConsentsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create BulkConsents parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BulkConsents </returns>
        public static async System.Threading.Tasks.Task<BulkConsentsResource> CreateAsync(CreateBulkConsentsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> create </summary>
        /// <param name="items"> This is a list of objects that describes a contact's opt-in status. Each object contains the following fields: `contact_id`, which must be a string representing phone number in [E.164 format](https://www.twilio.com/docs/glossary/what-e164); `correlation_id`, a unique 32-character UUID used to uniquely map the request item with the response item; `sender_id`, which can be either a valid messaging service SID or a from phone number; `status`, a string representing the consent status. Can be one of [`opt-in`, `opt-out`]; and `source`, a string indicating the medium through which the consent was collected. Can be one of [`website`, `offline`, `opt-in-message`, `opt-out-message`, `others`]. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BulkConsents </returns>
        public static BulkConsentsResource Create(
                                          List<object> items,
                                            ITwilioRestClient client = null)
        {
            var options = new CreateBulkConsentsOptions(items){  };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="items"> This is a list of objects that describes a contact's opt-in status. Each object contains the following fields: `contact_id`, which must be a string representing phone number in [E.164 format](https://www.twilio.com/docs/glossary/what-e164); `correlation_id`, a unique 32-character UUID used to uniquely map the request item with the response item; `sender_id`, which can be either a valid messaging service SID or a from phone number; `status`, a string representing the consent status. Can be one of [`opt-in`, `opt-out`]; and `source`, a string indicating the medium through which the consent was collected. Can be one of [`website`, `offline`, `opt-in-message`, `opt-out-message`, `others`]. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BulkConsents </returns>
        public static async System.Threading.Tasks.Task<BulkConsentsResource> CreateAsync(
                                                                                  List<object> items,
                                                                                    ITwilioRestClient client = null)
        {
        var options = new CreateBulkConsentsOptions(items){  };
            return await CreateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a BulkConsentsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> BulkConsentsResource object represented by the provided JSON </returns>
        public static BulkConsentsResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<BulkConsentsResource>(json);
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

    
        ///<summary> A list of objects where each object represents the result of processing a `correlation_id`. Each object contains the following fields: `correlation_id`, a unique 32-character UUID that maps the response to the original request; `error_code`, an integer where 0 indicates success and any non-zero value represents an error; and `error_messages`, an array of strings describing specific validation errors encountered. If the request is successful, the error_messages array will be empty. </summary> 
        [JsonProperty("items")]
        public object Items { get; private set; }



        private BulkConsentsResource() {

        }
    }
}
