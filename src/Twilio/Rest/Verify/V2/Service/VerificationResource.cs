/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// VerificationResource
/// </summary>

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

    public class VerificationResource : Resource
    {
        public sealed class ChannelEnum : StringEnum
        {
            private ChannelEnum(string value) : base(value) {}
            public ChannelEnum() {}
            public static implicit operator ChannelEnum(string value)
            {
                return new ChannelEnum(value);
            }

            public static readonly ChannelEnum Sms = new ChannelEnum("sms");
            public static readonly ChannelEnum Call = new ChannelEnum("call");
            public static readonly ChannelEnum Email = new ChannelEnum("email");
            public static readonly ChannelEnum Whatsapp = new ChannelEnum("whatsapp");
            public static readonly ChannelEnum Sna = new ChannelEnum("sna");
        }

        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }

            public static readonly StatusEnum Canceled = new StatusEnum("canceled");
            public static readonly StatusEnum Approved = new StatusEnum("approved");
        }

        private static Request BuildCreateRequest(CreateVerificationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Verify,
                "/v2/Services/" + options.PathServiceSid + "/Verifications",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Create a new Verification using a Service
        /// </summary>
        /// <param name="options"> Create Verification parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Verification </returns>
        public static VerificationResource Create(CreateVerificationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Create a new Verification using a Service
        /// </summary>
        /// <param name="options"> Create Verification parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Verification </returns>
        public static async System.Threading.Tasks.Task<VerificationResource> CreateAsync(CreateVerificationOptions options,
                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Create a new Verification using a Service
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the verification Service to create the resource under </param>
        /// <param name="to"> The phone number or email to verify </param>
        /// <param name="channel"> The verification method to use </param>
        /// <param name="customFriendlyName"> A custom user defined friendly name </param>
        /// <param name="customMessage"> The text of a custom message to use for the verification </param>
        /// <param name="sendDigits"> The digits to send after a phone call is answered </param>
        /// <param name="locale"> The locale to use for the verification SMS, WhatsApp or call </param>
        /// <param name="customCode"> A pre-generated code </param>
        /// <param name="amount"> The amount of the associated PSD2 compliant transaction. </param>
        /// <param name="payee"> The payee of the associated PSD2 compliant transaction </param>
        /// <param name="rateLimits"> The custom key-value pairs of Programmable Rate Limits. </param>
        /// <param name="channelConfiguration"> Channel specific configuration in json format. </param>
        /// <param name="appHash"> Your App Hash to be appended at the end of an SMS. </param>
        /// <param name="templateSid"> The verification template SMS messages. </param>
        /// <param name="templateCustomSubstitutions"> The values of the special variables declared on the message template.
        ///                                   </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Verification </returns>
        public static VerificationResource Create(string pathServiceSid,
                                                  string to,
                                                  string channel,
                                                  string customFriendlyName = null,
                                                  string customMessage = null,
                                                  string sendDigits = null,
                                                  string locale = null,
                                                  string customCode = null,
                                                  string amount = null,
                                                  string payee = null,
                                                  object rateLimits = null,
                                                  object channelConfiguration = null,
                                                  string appHash = null,
                                                  string templateSid = null,
                                                  string templateCustomSubstitutions = null,
                                                  ITwilioRestClient client = null)
        {
            var options = new CreateVerificationOptions(pathServiceSid, to, channel){CustomFriendlyName = customFriendlyName, CustomMessage = customMessage, SendDigits = sendDigits, Locale = locale, CustomCode = customCode, Amount = amount, Payee = payee, RateLimits = rateLimits, ChannelConfiguration = channelConfiguration, AppHash = appHash, TemplateSid = templateSid, TemplateCustomSubstitutions = templateCustomSubstitutions};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Create a new Verification using a Service
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the verification Service to create the resource under </param>
        /// <param name="to"> The phone number or email to verify </param>
        /// <param name="channel"> The verification method to use </param>
        /// <param name="customFriendlyName"> A custom user defined friendly name </param>
        /// <param name="customMessage"> The text of a custom message to use for the verification </param>
        /// <param name="sendDigits"> The digits to send after a phone call is answered </param>
        /// <param name="locale"> The locale to use for the verification SMS, WhatsApp or call </param>
        /// <param name="customCode"> A pre-generated code </param>
        /// <param name="amount"> The amount of the associated PSD2 compliant transaction. </param>
        /// <param name="payee"> The payee of the associated PSD2 compliant transaction </param>
        /// <param name="rateLimits"> The custom key-value pairs of Programmable Rate Limits. </param>
        /// <param name="channelConfiguration"> Channel specific configuration in json format. </param>
        /// <param name="appHash"> Your App Hash to be appended at the end of an SMS. </param>
        /// <param name="templateSid"> The verification template SMS messages. </param>
        /// <param name="templateCustomSubstitutions"> The values of the special variables declared on the message template.
        ///                                   </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Verification </returns>
        public static async System.Threading.Tasks.Task<VerificationResource> CreateAsync(string pathServiceSid,
                                                                                          string to,
                                                                                          string channel,
                                                                                          string customFriendlyName = null,
                                                                                          string customMessage = null,
                                                                                          string sendDigits = null,
                                                                                          string locale = null,
                                                                                          string customCode = null,
                                                                                          string amount = null,
                                                                                          string payee = null,
                                                                                          object rateLimits = null,
                                                                                          object channelConfiguration = null,
                                                                                          string appHash = null,
                                                                                          string templateSid = null,
                                                                                          string templateCustomSubstitutions = null,
                                                                                          ITwilioRestClient client = null)
        {
            var options = new CreateVerificationOptions(pathServiceSid, to, channel){CustomFriendlyName = customFriendlyName, CustomMessage = customMessage, SendDigits = sendDigits, Locale = locale, CustomCode = customCode, Amount = amount, Payee = payee, RateLimits = rateLimits, ChannelConfiguration = channelConfiguration, AppHash = appHash, TemplateSid = templateSid, TemplateCustomSubstitutions = templateCustomSubstitutions};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateVerificationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Verify,
                "/v2/Services/" + options.PathServiceSid + "/Verifications/" + options.PathSid + "",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Update a Verification status
        /// </summary>
        /// <param name="options"> Update Verification parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Verification </returns>
        public static VerificationResource Update(UpdateVerificationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Update a Verification status
        /// </summary>
        /// <param name="options"> Update Verification parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Verification </returns>
        public static async System.Threading.Tasks.Task<VerificationResource> UpdateAsync(UpdateVerificationOptions options,
                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Update a Verification status
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the verification Service to update the resource from </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="status"> The new status of the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Verification </returns>
        public static VerificationResource Update(string pathServiceSid,
                                                  string pathSid,
                                                  VerificationResource.StatusEnum status,
                                                  ITwilioRestClient client = null)
        {
            var options = new UpdateVerificationOptions(pathServiceSid, pathSid, status);
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// Update a Verification status
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the verification Service to update the resource from </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="status"> The new status of the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Verification </returns>
        public static async System.Threading.Tasks.Task<VerificationResource> UpdateAsync(string pathServiceSid,
                                                                                          string pathSid,
                                                                                          VerificationResource.StatusEnum status,
                                                                                          ITwilioRestClient client = null)
        {
            var options = new UpdateVerificationOptions(pathServiceSid, pathSid, status);
            return await UpdateAsync(options, client);
        }
        #endif

        private static Request BuildFetchRequest(FetchVerificationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Verify,
                "/v2/Services/" + options.PathServiceSid + "/Verifications/" + options.PathSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Fetch a specific Verification
        /// </summary>
        /// <param name="options"> Fetch Verification parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Verification </returns>
        public static VerificationResource Fetch(FetchVerificationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific Verification
        /// </summary>
        /// <param name="options"> Fetch Verification parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Verification </returns>
        public static async System.Threading.Tasks.Task<VerificationResource> FetchAsync(FetchVerificationOptions options,
                                                                                         ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch a specific Verification
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the verification Service to fetch the resource from </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Verification </returns>
        public static VerificationResource Fetch(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchVerificationOptions(pathServiceSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific Verification
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the verification Service to fetch the resource from </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Verification </returns>
        public static async System.Threading.Tasks.Task<VerificationResource> FetchAsync(string pathServiceSid,
                                                                                         string pathSid,
                                                                                         ITwilioRestClient client = null)
        {
            var options = new FetchVerificationOptions(pathServiceSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a VerificationResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> VerificationResource object represented by the provided JSON </returns>
        public static VerificationResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<VerificationResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The SID of the Service that the resource is associated with
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The phone number or email being verified
        /// </summary>
        [JsonProperty("to")]
        public string To { get; private set; }
        /// <summary>
        /// The verification method used.
        /// </summary>
        [JsonProperty("channel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public VerificationResource.ChannelEnum Channel { get; private set; }
        /// <summary>
        /// The status of the verification resource
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; private set; }
        /// <summary>
        /// Whether the verification was successful
        /// </summary>
        [JsonProperty("valid")]
        public bool? Valid { get; private set; }
        /// <summary>
        /// Information about the phone number being verified
        /// </summary>
        [JsonProperty("lookup")]
        public object Lookup { get; private set; }
        /// <summary>
        /// The amount of the associated PSD2 compliant transaction.
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; private set; }
        /// <summary>
        /// The payee of the associated PSD2 compliant transaction
        /// </summary>
        [JsonProperty("payee")]
        public string Payee { get; private set; }
        /// <summary>
        /// An array of verification attempt objects.
        /// </summary>
        [JsonProperty("send_code_attempts")]
        public List<object> SendCodeAttempts { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT when the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT when the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The set of fields used for a silent network auth (`sna`) verification
        /// </summary>
        [JsonProperty("sna")]
        public object Sna { get; private set; }
        /// <summary>
        /// The absolute URL of the Verification resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private VerificationResource()
        {

        }
    }

}