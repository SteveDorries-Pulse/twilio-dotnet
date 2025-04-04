/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Messaging
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



namespace Twilio.Rest.Messaging.V1
{
    public class DomainCertsResource : Resource
    {
    

    

        
        /// <summary> delete </summary>
        /// <param name="options"> Delete DomainCerts parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of DomainCerts </returns>
        private static Request BuildDeleteRequest(DeleteDomainCertsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/LinkShortening/Domains/{DomainSid}/Certificate";

            string PathDomainSid = options.PathDomainSid;
            path = path.Replace("{"+"DomainSid"+"}", PathDomainSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Messaging,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> delete </summary>
        /// <param name="options"> Delete DomainCerts parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of DomainCerts </returns>
        public static bool Delete(DeleteDomainCertsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete DomainCerts parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of DomainCerts </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteDomainCertsOptions options,
                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> delete </summary>
        /// <param name="pathDomainSid"> Unique string used to identify the domain that this certificate should be associated with. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of DomainCerts </returns>
        public static bool Delete(string pathDomainSid, ITwilioRestClient client = null)
        {
            var options = new DeleteDomainCertsOptions(pathDomainSid)     ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="pathDomainSid"> Unique string used to identify the domain that this certificate should be associated with. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of DomainCerts </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathDomainSid, ITwilioRestClient client = null)
        {
            var options = new DeleteDomainCertsOptions(pathDomainSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchDomainCertsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/LinkShortening/Domains/{DomainSid}/Certificate";

            string PathDomainSid = options.PathDomainSid;
            path = path.Replace("{"+"DomainSid"+"}", PathDomainSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Messaging,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch DomainCerts parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of DomainCerts </returns>
        public static DomainCertsResource Fetch(FetchDomainCertsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch DomainCerts parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of DomainCerts </returns>
        public static async System.Threading.Tasks.Task<DomainCertsResource> FetchAsync(FetchDomainCertsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="pathDomainSid"> Unique string used to identify the domain that this certificate should be associated with. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of DomainCerts </returns>
        public static DomainCertsResource Fetch(
                                         string pathDomainSid, 
                                        ITwilioRestClient client = null)
        {
            var options = new FetchDomainCertsOptions(pathDomainSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathDomainSid"> Unique string used to identify the domain that this certificate should be associated with. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of DomainCerts </returns>
        public static async System.Threading.Tasks.Task<DomainCertsResource> FetchAsync(string pathDomainSid, ITwilioRestClient client = null)
        {
            var options = new FetchDomainCertsOptions(pathDomainSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildUpdateRequest(UpdateDomainCertsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/LinkShortening/Domains/{DomainSid}/Certificate";

            string PathDomainSid = options.PathDomainSid;
            path = path.Replace("{"+"DomainSid"+"}", PathDomainSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Messaging,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> update </summary>
        /// <param name="options"> Update DomainCerts parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of DomainCerts </returns>
        public static DomainCertsResource Update(UpdateDomainCertsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
        /// <param name="options"> Update DomainCerts parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of DomainCerts </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<DomainCertsResource> UpdateAsync(UpdateDomainCertsOptions options,
                                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> update </summary>
        /// <param name="pathDomainSid"> Unique string used to identify the domain that this certificate should be associated with. </param>
        /// <param name="tlsCert"> Contains the full TLS certificate and private for this domain in PEM format: https://en.wikipedia.org/wiki/Privacy-Enhanced_Mail. Twilio uses this information to process HTTPS traffic sent to your domain. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of DomainCerts </returns>
        public static DomainCertsResource Update(
                                          string pathDomainSid,
                                          string tlsCert,
                                            ITwilioRestClient client = null)
        {
            var options = new UpdateDomainCertsOptions(pathDomainSid, tlsCert){  };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> update </summary>
        /// <param name="pathDomainSid"> Unique string used to identify the domain that this certificate should be associated with. </param>
        /// <param name="tlsCert"> Contains the full TLS certificate and private for this domain in PEM format: https://en.wikipedia.org/wiki/Privacy-Enhanced_Mail. Twilio uses this information to process HTTPS traffic sent to your domain. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of DomainCerts </returns>
        public static async System.Threading.Tasks.Task<DomainCertsResource> UpdateAsync(
                                                                              string pathDomainSid,
                                                                              string tlsCert,
                                                                                ITwilioRestClient client = null)
        {
            var options = new UpdateDomainCertsOptions(pathDomainSid, tlsCert){  };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a DomainCertsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> DomainCertsResource object represented by the provided JSON </returns>
        public static DomainCertsResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<DomainCertsResource>(json);
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

    
        ///<summary> The unique string that we created to identify the Domain resource. </summary> 
        [JsonProperty("domain_sid")]
        public string DomainSid { get; private set; }

        ///<summary> Date that this Domain was last updated. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> Date that the private certificate associated with this domain expires. You will need to update the certificate before that date to ensure your shortened links will continue to work. </summary> 
        [JsonProperty("date_expires")]
        public DateTime? DateExpires { get; private set; }

        ///<summary> Date that this Domain was registered to the Twilio platform to create a new Domain object. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> Full url path for this domain. </summary> 
        [JsonProperty("domain_name")]
        public Uri DomainName { get; private set; }

        ///<summary> The unique string that we created to identify this Certificate resource. </summary> 
        [JsonProperty("certificate_sid")]
        public string CertificateSid { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> Optional JSON field describing the status and upload date of a new certificate in the process of validation </summary> 
        [JsonProperty("cert_in_validation")]
        public object CertInValidation { get; private set; }



        private DomainCertsResource() {

        }
    }
}

