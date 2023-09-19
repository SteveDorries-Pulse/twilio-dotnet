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
using Twilio.Types;


namespace Twilio.Rest.Api.V2010.Account
{
    public class AuthorizedConnectAppResource : Resource
    {
    

    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class PermissionEnum : StringEnum
        {
            private PermissionEnum(string value) : base(value) {}
            public PermissionEnum() {}
            public static implicit operator PermissionEnum(string value)
            {
                return new PermissionEnum(value);
            }

            public static readonly PermissionEnum GetAll = new PermissionEnum("get-all");
            public static readonly PermissionEnum PostAll = new PermissionEnum("post-all");
        }

        
        private static Request BuildFetchRequest(FetchAuthorizedConnectAppOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/AuthorizedConnectApps/{ConnectAppSid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);
            string PathConnectAppSid = options.PathConnectAppSid;
            path = path.Replace("{"+"ConnectAppSid"+"}", PathConnectAppSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch an instance of an authorized-connect-app </summary>
        /// <param name="options"> Fetch AuthorizedConnectApp parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthorizedConnectApp </returns>
        public static AuthorizedConnectAppResource Fetch(FetchAuthorizedConnectAppOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch an instance of an authorized-connect-app </summary>
        /// <param name="options"> Fetch AuthorizedConnectApp parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthorizedConnectApp </returns>
        public static async System.Threading.Tasks.Task<AuthorizedConnectAppResource> FetchAsync(FetchAuthorizedConnectAppOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch an instance of an authorized-connect-app </summary>
        /// <param name="pathConnectAppSid"> The SID of the Connect App to fetch. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the AuthorizedConnectApp resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthorizedConnectApp </returns>
        public static AuthorizedConnectAppResource Fetch(
                                         string pathConnectAppSid, 
                                         string pathAccountSid = null, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchAuthorizedConnectAppOptions(pathConnectAppSid){ PathAccountSid = pathAccountSid };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch an instance of an authorized-connect-app </summary>
        /// <param name="pathConnectAppSid"> The SID of the Connect App to fetch. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the AuthorizedConnectApp resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthorizedConnectApp </returns>
        public static async System.Threading.Tasks.Task<AuthorizedConnectAppResource> FetchAsync(string pathConnectAppSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchAuthorizedConnectAppOptions(pathConnectAppSid){ PathAccountSid = pathAccountSid };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadAuthorizedConnectAppOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/AuthorizedConnectApps.json";

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
        /// <summary> Retrieve a list of authorized-connect-apps belonging to the account used to make the request </summary>
        /// <param name="options"> Read AuthorizedConnectApp parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthorizedConnectApp </returns>
        public static ResourceSet<AuthorizedConnectAppResource> Read(ReadAuthorizedConnectAppOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<AuthorizedConnectAppResource>.FromJson("authorized_connect_apps", response.Content);
            return new ResourceSet<AuthorizedConnectAppResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of authorized-connect-apps belonging to the account used to make the request </summary>
        /// <param name="options"> Read AuthorizedConnectApp parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthorizedConnectApp </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AuthorizedConnectAppResource>> ReadAsync(ReadAuthorizedConnectAppOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<AuthorizedConnectAppResource>.FromJson("authorized_connect_apps", response.Content);
            return new ResourceSet<AuthorizedConnectAppResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of authorized-connect-apps belonging to the account used to make the request </summary>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the AuthorizedConnectApp resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthorizedConnectApp </returns>
        public static ResourceSet<AuthorizedConnectAppResource> Read(
                                                     string pathAccountSid = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadAuthorizedConnectAppOptions(){ PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of authorized-connect-apps belonging to the account used to make the request </summary>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the AuthorizedConnectApp resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthorizedConnectApp </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AuthorizedConnectAppResource>> ReadAsync(
                                                                                             string pathAccountSid = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadAuthorizedConnectAppOptions(){ PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<AuthorizedConnectAppResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<AuthorizedConnectAppResource>.FromJson("authorized_connect_apps", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<AuthorizedConnectAppResource> NextPage(Page<AuthorizedConnectAppResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AuthorizedConnectAppResource>.FromJson("authorized_connect_apps", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<AuthorizedConnectAppResource> PreviousPage(Page<AuthorizedConnectAppResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AuthorizedConnectAppResource>.FromJson("authorized_connect_apps", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a AuthorizedConnectAppResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AuthorizedConnectAppResource object represented by the provided JSON </returns>
        public static AuthorizedConnectAppResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<AuthorizedConnectAppResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the AuthorizedConnectApp resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The company name set for the Connect App. </summary> 
        [JsonProperty("connect_app_company_name")]
        public string ConnectAppCompanyName { get; private set; }

        ///<summary> A detailed description of the Connect App. </summary> 
        [JsonProperty("connect_app_description")]
        public string ConnectAppDescription { get; private set; }

        ///<summary> The name of the Connect App. </summary> 
        [JsonProperty("connect_app_friendly_name")]
        public string ConnectAppFriendlyName { get; private set; }

        ///<summary> The public URL for the Connect App. </summary> 
        [JsonProperty("connect_app_homepage_url")]
        public Uri ConnectAppHomepageUrl { get; private set; }

        ///<summary> The SID that we assigned to the Connect App. </summary> 
        [JsonProperty("connect_app_sid")]
        public string ConnectAppSid { get; private set; }

        ///<summary> The date and time in GMT that the resource was created specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT that the resource was last updated specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The set of permissions that you authorized for the Connect App.  Can be: `get-all` or `post-all`. </summary> 
        [JsonProperty("permissions")]
        public List<AuthorizedConnectAppResource.PermissionEnum> Permissions { get; private set; }

        ///<summary> The URI of the resource, relative to `https://api.twilio.com`. </summary> 
        [JsonProperty("uri")]
        public string Uri { get; private set; }



        private AuthorizedConnectAppResource() {

        }
    }
}

