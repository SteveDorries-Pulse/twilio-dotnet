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




namespace Twilio.Rest.Messaging.V1.Service
{

    /// <summary> create </summary>
    public class CreateShortCodeOptions : IOptions<ShortCodeResource>
    {
        
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to create the resource under. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the ShortCode resource being added to the Service. </summary> 
        public string ShortCodeSid { get; }


        /// <summary> Construct a new CreateShortCodeOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to create the resource under. </param>
        /// <param name="shortCodeSid"> The SID of the ShortCode resource being added to the Service. </param>
        public CreateShortCodeOptions(string pathServiceSid, string shortCodeSid)
        {
            PathServiceSid = pathServiceSid;
            ShortCodeSid = shortCodeSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (ShortCodeSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ShortCodeSid", ShortCodeSid));
            }
            return p;
        }

        

    }
    /// <summary> delete </summary>
    public class DeleteShortCodeOptions : IOptions<ShortCodeResource>
    {
        
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to delete the resource from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the ShortCode resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteShortCodeOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to delete the resource from. </param>
        /// <param name="pathSid"> The SID of the ShortCode resource to delete. </param>
        public DeleteShortCodeOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

    

    }


    /// <summary> fetch </summary>
    public class FetchShortCodeOptions : IOptions<ShortCodeResource>
    {
    
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to fetch the resource from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the ShortCode resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchShortCodeOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to fetch the resource from. </param>
        /// <param name="pathSid"> The SID of the ShortCode resource to fetch. </param>
        public FetchShortCodeOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

    

    }


    /// <summary> read </summary>
    public class ReadShortCodeOptions : ReadOptions<ShortCodeResource>
    {
    
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to read the resources from. </summary> 
        public string PathServiceSid { get; }



        /// <summary> Construct a new ListShortCodeOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to read the resources from. </param>
        public ReadShortCodeOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }

    

    }

}

