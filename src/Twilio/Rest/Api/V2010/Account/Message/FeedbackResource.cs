using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Api.V2010.Account.Message 
{

    /// <summary>
    /// FeedbackResource
    /// </summary>
    public class FeedbackResource : Resource 
    {
        public sealed class OutcomeEnum : StringEnum 
        {
            private OutcomeEnum(string value) : base(value) {}
            public OutcomeEnum() {}

            public static readonly OutcomeEnum Confirmed = new OutcomeEnum("confirmed");
            public static readonly OutcomeEnum Umconfirmed = new OutcomeEnum("umconfirmed");
        }

        private static Request BuildCreateRequest(CreateFeedbackOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Messages/" + options.PathMessageSid + "/Feedback.json",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create Feedback parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Feedback </returns> 
        public static FeedbackResource Create(CreateFeedbackOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create Feedback parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Feedback </returns> 
        public static async System.Threading.Tasks.Task<FeedbackResource> CreateAsync(CreateFeedbackOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="pathMessageSid"> The message_sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="outcome"> The outcome </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Feedback </returns> 
        public static FeedbackResource Create(string pathMessageSid, string pathAccountSid = null, FeedbackResource.OutcomeEnum outcome = null, ITwilioRestClient client = null)
        {
            var options = new CreateFeedbackOptions(pathMessageSid){PathAccountSid = pathAccountSid, Outcome = outcome};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="pathMessageSid"> The message_sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="outcome"> The outcome </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Feedback </returns> 
        public static async System.Threading.Tasks.Task<FeedbackResource> CreateAsync(string pathMessageSid, string pathAccountSid = null, FeedbackResource.OutcomeEnum outcome = null, ITwilioRestClient client = null)
        {
            var options = new CreateFeedbackOptions(pathMessageSid){PathAccountSid = pathAccountSid, Outcome = outcome};
            return await CreateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a FeedbackResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> FeedbackResource object represented by the provided JSON </returns> 
        public static FeedbackResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<FeedbackResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The message_sid
        /// </summary>
        [JsonProperty("message_sid")]
        public string MessageSid { get; private set; }
        /// <summary>
        /// The outcome
        /// </summary>
        [JsonProperty("outcome")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FeedbackResource.OutcomeEnum Outcome { get; private set; }
        /// <summary>
        /// The date_created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date_updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The uri
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }

        private FeedbackResource()
        {

        }
    }

}