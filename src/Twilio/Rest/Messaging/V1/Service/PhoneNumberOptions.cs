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
    public class CreatePhoneNumberOptions : IOptions<PhoneNumberResource>
    {
        
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to create the resource under. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the Phone Number being added to the Service. </summary> 
        public string PhoneNumberSid { get; }


        /// <summary> Construct a new CreatePhoneNumberOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to create the resource under. </param>
        /// <param name="phoneNumberSid"> The SID of the Phone Number being added to the Service. </param>
        public CreatePhoneNumberOptions(string pathServiceSid, string phoneNumberSid)
        {
            PathServiceSid = pathServiceSid;
            PhoneNumberSid = phoneNumberSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PhoneNumberSid != null)
            {
                p.Add(new KeyValuePair<string, string>("PhoneNumberSid", PhoneNumberSid));
            }
            return p;
        }

        

    }
    /// <summary> delete </summary>
    public class DeletePhoneNumberOptions : IOptions<PhoneNumberResource>
    {
        
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to delete the resource from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the PhoneNumber resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeletePhoneNumberOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to delete the resource from. </param>
        /// <param name="pathSid"> The SID of the PhoneNumber resource to delete. </param>
        public DeletePhoneNumberOptions(string pathServiceSid, string pathSid)
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
    public class FetchPhoneNumberOptions : IOptions<PhoneNumberResource>
    {
    
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to fetch the resource from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the PhoneNumber resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchPhoneNumberOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to fetch the resource from. </param>
        /// <param name="pathSid"> The SID of the PhoneNumber resource to fetch. </param>
        public FetchPhoneNumberOptions(string pathServiceSid, string pathSid)
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
    public class ReadPhoneNumberOptions : ReadOptions<PhoneNumberResource>
    {
    
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to read the resources from. </summary> 
        public string PathServiceSid { get; }



        /// <summary> Construct a new ListPhoneNumberOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to read the resources from. </param>
        public ReadPhoneNumberOptions(string pathServiceSid)
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

