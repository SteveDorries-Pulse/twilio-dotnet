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




namespace Twilio.Rest.Messaging.V1
{

    /// <summary> create </summary>
    public class CreateBrandRegistrationOptions : IOptions<BrandRegistrationResource>
    {
        
        ///<summary> Customer Profile Bundle Sid. </summary> 
        public string CustomerProfileBundleSid { get; }

        ///<summary> A2P Messaging Profile Bundle Sid. </summary> 
        public string A2PProfileBundleSid { get; }

        ///<summary> Type of brand being created. One of: \\\"STANDARD\\\", \\\"SOLE_PROPRIETOR\\\". SOLE_PROPRIETOR is for low volume, SOLE_PROPRIETOR use cases. STANDARD is for all other use cases. </summary> 
        public string BrandType { get; set; }

        ///<summary> A boolean that specifies whether brand should be a mock or not. If true, brand will be registered as a mock brand. Defaults to false if no value is provided. </summary> 
        public bool? Mock { get; set; }

        ///<summary> A flag to disable automatic secondary vetting for brands which it would otherwise be done. </summary> 
        public bool? SkipAutomaticSecVet { get; set; }


        /// <summary> Construct a new CreateBrandRegistrationsOptions </summary>
        /// <param name="customerProfileBundleSid"> Customer Profile Bundle Sid. </param>
        /// <param name="a2PProfileBundleSid"> A2P Messaging Profile Bundle Sid. </param>
        public CreateBrandRegistrationOptions(string customerProfileBundleSid, string a2PProfileBundleSid)
        {
            CustomerProfileBundleSid = customerProfileBundleSid;
            A2PProfileBundleSid = a2PProfileBundleSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (CustomerProfileBundleSid != null)
            {
                p.Add(new KeyValuePair<string, string>("CustomerProfileBundleSid", CustomerProfileBundleSid));
            }
            if (A2PProfileBundleSid != null)
            {
                p.Add(new KeyValuePair<string, string>("A2PProfileBundleSid", A2PProfileBundleSid));
            }
            if (BrandType != null)
            {
                p.Add(new KeyValuePair<string, string>("BrandType", BrandType));
            }
            if (Mock != null)
            {
                p.Add(new KeyValuePair<string, string>("Mock", Mock.Value.ToString().ToLower()));
            }
            if (SkipAutomaticSecVet != null)
            {
                p.Add(new KeyValuePair<string, string>("SkipAutomaticSecVet", SkipAutomaticSecVet.Value.ToString().ToLower()));
            }
            return p;
        }

        

    }
    /// <summary> fetch </summary>
    public class FetchBrandRegistrationOptions : IOptions<BrandRegistrationResource>
    {
    
        ///<summary> The SID of the Brand Registration resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchBrandRegistrationsOptions </summary>
        /// <param name="pathSid"> The SID of the Brand Registration resource to fetch. </param>
        public FetchBrandRegistrationOptions(string pathSid)
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


    /// <summary> read </summary>
    public class ReadBrandRegistrationOptions : ReadOptions<BrandRegistrationResource>
    {
    



        
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

    /// <summary> update </summary>
    public class UpdateBrandRegistrationOptions : IOptions<BrandRegistrationResource>
    {
    
        ///<summary> The SID of the Brand Registration resource to update. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new UpdateBrandRegistrationsOptions </summary>
        /// <param name="pathSid"> The SID of the Brand Registration resource to update. </param>
        public UpdateBrandRegistrationOptions(string pathSid)
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


}

