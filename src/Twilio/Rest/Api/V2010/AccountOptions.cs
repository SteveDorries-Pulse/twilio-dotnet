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




namespace Twilio.Rest.Api.V2010
{

    /// <summary> Create a new Twilio Subaccount from the account making the request </summary>
    public class CreateAccountOptions : IOptions<AccountResource>
    {
        
        ///<summary> A human readable description of the account to create, defaults to `SubAccount Created at {YYYY-MM-DD HH:MM meridian}` </summary> 
        public string FriendlyName { get; set; }



        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            return p;
        }
        

    }
    /// <summary> Fetch the account specified by the provided Account Sid </summary>
    public class FetchAccountOptions : IOptions<AccountResource>
    {
    
        ///<summary> The Account Sid that uniquely identifies the account to fetch </summary> 
        public string PathSid { get; set; }




        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieves a collection of Accounts belonging to the account used to make the request </summary>
    public class ReadAccountOptions : ReadOptions<AccountResource>
    {
    
        ///<summary> Only return the Account resources with friendly names that exactly match this name. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> Only return Account resources with the given status. Can be `closed`, `suspended` or `active`. </summary> 
        public AccountResource.StatusEnum Status { get; set; }




        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

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

    /// <summary> Modify the properties of a given Account </summary>
    public class UpdateAccountOptions : IOptions<AccountResource>
    {
    
        ///<summary> The Account Sid that uniquely identifies the account to update </summary> 
        public string PathSid { get; set; }

        ///<summary> Update the human-readable description of this Account </summary> 
        public string FriendlyName { get; set; }

        
        public AccountResource.StatusEnum Status { get; set; }




        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            return p;
        }
        

    }


}

