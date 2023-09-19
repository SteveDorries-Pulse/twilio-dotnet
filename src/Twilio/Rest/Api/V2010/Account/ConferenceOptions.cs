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


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;




namespace Twilio.Rest.Api.V2010.Account
{
    /// <summary> Fetch an instance of a conference </summary>
    public class FetchConferenceOptions : IOptions<ConferenceResource>
    {
    
        ///<summary> The Twilio-provided string that uniquely identifies the Conference resource to fetch </summary> 
        public string PathSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Conference resource(s) to fetch. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new FetchConferenceOptions </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Conference resource to fetch </param>
        public FetchConferenceOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve a list of conferences belonging to the account used to make the request </summary>
    public class ReadConferenceOptions : ReadOptions<ConferenceResource>
    {
    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Conference resource(s) to read. </summary> 
        public string PathAccountSid { get; set; }

        ///<summary> The `date_created` value, specified as `YYYY-MM-DD`, of the resources to read. To read conferences that started on or before midnight on a date, use `<=YYYY-MM-DD`, and to specify  conferences that started on or after midnight on a date, use `>=YYYY-MM-DD`. </summary> 
        public DateTime? DateCreated { get; set; }

        ///<summary> The `date_created` value, specified as `YYYY-MM-DD`, of the resources to read. To read conferences that started on or before midnight on a date, use `<=YYYY-MM-DD`, and to specify  conferences that started on or after midnight on a date, use `>=YYYY-MM-DD`. </summary> 
        public DateTime? DateCreatedBefore { get; set; }

        ///<summary> The `date_created` value, specified as `YYYY-MM-DD`, of the resources to read. To read conferences that started on or before midnight on a date, use `<=YYYY-MM-DD`, and to specify  conferences that started on or after midnight on a date, use `>=YYYY-MM-DD`. </summary> 
        public DateTime? DateCreatedAfter { get; set; }

        ///<summary> The `date_updated` value, specified as `YYYY-MM-DD`, of the resources to read. To read conferences that were last updated on or before midnight on a date, use `<=YYYY-MM-DD`, and to specify conferences that were last updated on or after midnight on a given date, use  `>=YYYY-MM-DD`. </summary> 
        public DateTime? DateUpdated { get; set; }

        ///<summary> The `date_updated` value, specified as `YYYY-MM-DD`, of the resources to read. To read conferences that were last updated on or before midnight on a date, use `<=YYYY-MM-DD`, and to specify conferences that were last updated on or after midnight on a given date, use  `>=YYYY-MM-DD`. </summary> 
        public DateTime? DateUpdatedBefore { get; set; }

        ///<summary> The `date_updated` value, specified as `YYYY-MM-DD`, of the resources to read. To read conferences that were last updated on or before midnight on a date, use `<=YYYY-MM-DD`, and to specify conferences that were last updated on or after midnight on a given date, use  `>=YYYY-MM-DD`. </summary> 
        public DateTime? DateUpdatedAfter { get; set; }

        ///<summary> The string that identifies the Conference resources to read. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> The status of the resources to read. Can be: `init`, `in-progress`, or `completed`. </summary> 
        public ConferenceResource.StatusEnum Status { get; set; }




        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", DateCreated.Value.ToString("yyyy-MM-dd")));
            }
            else
            {
                if (DateCreatedBefore != null)
                {
                    p.Add(new KeyValuePair<string, string>("DateCreated<", DateCreatedBefore.Value.ToString("yyyy-MM-dd")));
                }
                if (DateCreatedAfter != null)
                {
                    p.Add(new KeyValuePair<string, string>("DateCreated>", DateCreatedAfter.Value.ToString("yyyy-MM-dd")));
                }
            }
            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", DateUpdated.Value.ToString("yyyy-MM-dd")));
            }
            else
            {
                if (DateUpdatedBefore != null)
                {
                    p.Add(new KeyValuePair<string, string>("DateUpdated<", DateUpdatedBefore.Value.ToString("yyyy-MM-dd")));
                }
                if (DateUpdatedAfter != null)
                {
                    p.Add(new KeyValuePair<string, string>("DateUpdated>", DateUpdatedAfter.Value.ToString("yyyy-MM-dd")));
                }
            }
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

    /// <summary> update </summary>
    public class UpdateConferenceOptions : IOptions<ConferenceResource>
    {
    
        ///<summary> The Twilio-provided string that uniquely identifies the Conference resource to update </summary> 
        public string PathSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Conference resource(s) to update. </summary> 
        public string PathAccountSid { get; set; }

        
        public ConferenceResource.UpdateStatusEnum Status { get; set; }

        ///<summary> The URL we should call to announce something into the conference. The URL may return an MP3 file, a WAV file, or a TwiML document that contains `<Play>`, `<Say>`, `<Pause>`, or `<Redirect>` verbs. </summary> 
        public Uri AnnounceUrl { get; set; }

        ///<summary> The HTTP method used to call `announce_url`. Can be: `GET` or `POST` and the default is `POST` </summary> 
        public Twilio.Http.HttpMethod AnnounceMethod { get; set; }



        /// <summary> Construct a new UpdateConferenceOptions </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Conference resource to update </param>
        public UpdateConferenceOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            if (AnnounceUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("AnnounceUrl", Serializers.Url(AnnounceUrl)));
            }
            if (AnnounceMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("AnnounceMethod", AnnounceMethod.ToString()));
            }
            return p;
        }
        

    }


}

