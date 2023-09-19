/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Pricing
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


namespace Twilio.Rest.Pricing.V2
{
    public class CountryResource : Resource
    {
    

    

        
        private static Request BuildFetchRequest(FetchCountryOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Trunking/Countries/{IsoCountry}";

            string PathIsoCountry = options.PathIsoCountry.ToString();
            path = path.Replace("{"+"IsoCountry"+"}", PathIsoCountry);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Pricing,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch a specific Country. </summary>
        /// <param name="options"> Fetch Country parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Country </returns>
        public static CountryResource Fetch(FetchCountryOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a specific Country. </summary>
        /// <param name="options"> Fetch Country parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Country </returns>
        public static async System.Threading.Tasks.Task<CountryResource> FetchAsync(FetchCountryOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a specific Country. </summary>
        /// <param name="pathIsoCountry"> The [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) of the origin-based voice pricing information to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Country </returns>
        public static CountryResource Fetch(
                                         string pathIsoCountry, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchCountryOptions(pathIsoCountry){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a specific Country. </summary>
        /// <param name="pathIsoCountry"> The [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) of the origin-based voice pricing information to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Country </returns>
        public static async System.Threading.Tasks.Task<CountryResource> FetchAsync(string pathIsoCountry, ITwilioRestClient client = null)
        {
            var options = new FetchCountryOptions(pathIsoCountry){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadCountryOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Trunking/Countries";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Pricing,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read Country parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Country </returns>
        public static ResourceSet<CountryResource> Read(ReadCountryOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<CountryResource>.FromJson("countries", response.Content);
            return new ResourceSet<CountryResource>(page, options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read Country parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Country </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CountryResource>> ReadAsync(ReadCountryOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<CountryResource>.FromJson("countries", response.Content);
            return new ResourceSet<CountryResource>(page, options, client);
        }
        #endif
        /// <summary> read </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Country </returns>
        public static ResourceSet<CountryResource> Read(
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadCountryOptions(){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Country </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CountryResource>> ReadAsync(
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadCountryOptions(){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<CountryResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<CountryResource>.FromJson("countries", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<CountryResource> NextPage(Page<CountryResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<CountryResource>.FromJson("countries", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<CountryResource> PreviousPage(Page<CountryResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<CountryResource>.FromJson("countries", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a CountryResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> CountryResource object represented by the provided JSON </returns>
        public static CountryResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<CountryResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The name of the country. </summary> 
        [JsonProperty("country")]
        public string Country { get; private set; }

        ///<summary> The [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2). </summary> 
        [JsonProperty("iso_country")]
        public string IsoCountry { get; private set; }

        ///<summary> The list of [TerminatingPrefixPrice](https://www.twilio.com/docs/voice/pricing#outbound-prefix-price-with-origin) records. </summary> 
        [JsonProperty("terminating_prefix_prices")]
        public List<OutboundPrefixPriceWithOrigin> TerminatingPrefixPrices { get; private set; }

        ///<summary> The list of [OriginatingCallPrice](https://www.twilio.com/docs/voice/pricing#inbound-call-price) records. </summary> 
        [JsonProperty("originating_call_prices")]
        public List<InboundCallPrice> OriginatingCallPrices { get; private set; }

        ///<summary> The currency in which prices are measured, specified in [ISO 4127](https://www.iso.org/iso/home/standards/currency_codes.htm) format (e.g. `usd`, `eur`, `jpy`). </summary> 
        [JsonProperty("price_unit")]
        public string PriceUnit { get; private set; }

        ///<summary> The absolute URL of the resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private CountryResource() {

        }
    }
}

