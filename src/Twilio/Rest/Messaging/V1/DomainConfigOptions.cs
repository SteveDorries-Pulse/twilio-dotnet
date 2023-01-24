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


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;
using System.Linq;



namespace Twilio.Rest.Messaging.V1
{
    /// <summary> fetch </summary>
    public class FetchDomainConfigOptions : IOptions<DomainConfigResource>
    {
    
        ///<summary> Unique string used to identify the domain that this config should be associated with. </summary> 
        public string PathDomainSid { get; }



        /// <summary> Construct a new FetchDomainConfigOptions </summary>
        /// <param name="pathDomainSid"> Unique string used to identify the domain that this config should be associated with. </param>
        public FetchDomainConfigOptions(string pathDomainSid)
        {
            PathDomainSid = pathDomainSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> update </summary>
    public class UpdateDomainConfigOptions : IOptions<DomainConfigResource>
    {
    
        ///<summary> Unique string used to identify the domain that this config should be associated with. </summary> 
        public string PathDomainSid { get; }

        ///<summary> A list of messagingServiceSids (with prefix MG) </summary> 
        public List<string> MessagingServiceSids { get; }

        ///<summary> Any requests we receive to this domain that do not match an existing shortened message will be redirected to the fallback url. These will likely be either expired messages, random misdirected traffic, or intentional scraping. </summary> 
        public Uri FallbackUrl { get; set; }

        ///<summary> URL to receive click events to your webhook whenever the recipients click on the shortened links </summary> 
        public Uri CallbackUrl { get; set; }

        ///<summary> An action type for messaging_service_sids operation (ADD, DELETE, REPLACE) </summary> 
        public string MessagingServiceSidsAction { get; set; }



        /// <summary> Construct a new UpdateDomainConfigOptions </summary>
        /// <param name="pathDomainSid"> Unique string used to identify the domain that this config should be associated with. </param>
        /// <param name="messagingServiceSids"> A list of messagingServiceSids (with prefix MG) </param>
        public UpdateDomainConfigOptions(string pathDomainSid, List<string> messagingServiceSids)
        {
            PathDomainSid = pathDomainSid;
            MessagingServiceSids = messagingServiceSids;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (MessagingServiceSids != null)
            {
                p.AddRange(MessagingServiceSids.Select(MessagingServiceSids => new KeyValuePair<string, string>("MessagingServiceSids", MessagingServiceSids)));
            }
            if (FallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("FallbackUrl", Serializers.Url(FallbackUrl)));
            }
            if (CallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackUrl", Serializers.Url(CallbackUrl)));
            }
            if (MessagingServiceSidsAction != null)
            {
                p.Add(new KeyValuePair<string, string>("MessagingServiceSidsAction", MessagingServiceSidsAction));
            }
            return p;
        }
        

    }


}
