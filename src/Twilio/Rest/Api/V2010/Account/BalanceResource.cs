/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Api
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



namespace Twilio.Rest.Api.V2010.Account
{
    public class BalanceResource : Resource
    {
    

    

        
        private static Request BuildFetchRequest(FetchBalanceOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/Balance.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch the balance for an Account based on Account Sid. Balance changes may not be reflected immediately. Child accounts do not contain balance information </summary>
        /// <param name="options"> Fetch Balance parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Balance </returns>
        public static BalanceResource Fetch(FetchBalanceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch the balance for an Account based on Account Sid. Balance changes may not be reflected immediately. Child accounts do not contain balance information </summary>
        /// <param name="options"> Fetch Balance parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Balance </returns>
        public static async System.Threading.Tasks.Task<BalanceResource> FetchAsync(FetchBalanceOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch the balance for an Account based on Account Sid. Balance changes may not be reflected immediately. Child accounts do not contain balance information </summary>
        /// <param name="pathAccountSid"> The unique SID identifier of the Account. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Balance </returns>
        public static BalanceResource Fetch(
                                         string pathAccountSid = null, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchBalanceOptions(){ PathAccountSid = pathAccountSid };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch the balance for an Account based on Account Sid. Balance changes may not be reflected immediately. Child accounts do not contain balance information </summary>
        /// <param name="pathAccountSid"> The unique SID identifier of the Account. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Balance </returns>
        public static async System.Threading.Tasks.Task<BalanceResource> FetchAsync(string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchBalanceOptions(){ PathAccountSid = pathAccountSid };
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a BalanceResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> BalanceResource object represented by the provided JSON </returns>
        public static BalanceResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<BalanceResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The unique SID identifier of the Account. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The balance of the Account, in units specified by the unit parameter. Balance changes may not be reflected immediately. Child accounts do not contain balance information </summary> 
        [JsonProperty("balance")]
        public string Balance { get; private set; }

        ///<summary> The units of currency for the account balance </summary> 
        [JsonProperty("currency")]
        public string Currency { get; private set; }



        private BalanceResource() {

        }
    }
}

