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




namespace Twilio.Rest.Api.V2010.Account.Sip.Domain.AuthTypes.AuthTypeCalls
{

    /// <summary> Create a new IP Access Control List mapping </summary>
    public class CreateAuthCallsIpAccessControlListMappingOptions : IOptions<AuthCallsIpAccessControlListMappingResource>
    {
        
        ///<summary> The SID of the SIP domain that will contain the new resource. </summary> 
        public string PathDomainSid { get; }

        ///<summary> The SID of the IpAccessControlList resource to map to the SIP domain. </summary> 
        public string IpAccessControlListSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that will create the resource. </summary> 
        public string PathAccountSid { get; set; }


        /// <summary> Construct a new CreateSipAuthCallsIpAccessControlListMappingOptions </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that will contain the new resource. </param>
        /// <param name="ipAccessControlListSid"> The SID of the IpAccessControlList resource to map to the SIP domain. </param>
        public CreateAuthCallsIpAccessControlListMappingOptions(string pathDomainSid, string ipAccessControlListSid)
        {
            PathDomainSid = pathDomainSid;
            IpAccessControlListSid = ipAccessControlListSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (IpAccessControlListSid != null)
            {
                p.Add(new KeyValuePair<string, string>("IpAccessControlListSid", IpAccessControlListSid));
            }
            return p;
        }
        

    }
    /// <summary> Delete an IP Access Control List mapping from the requested domain </summary>
    public class DeleteAuthCallsIpAccessControlListMappingOptions : IOptions<AuthCallsIpAccessControlListMappingResource>
    {
        
        ///<summary> The SID of the SIP domain that contains the resources to delete. </summary> 
        public string PathDomainSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the IpAccessControlListMapping resource to delete. </summary> 
        public string PathSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the IpAccessControlListMapping resources to delete. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new DeleteSipAuthCallsIpAccessControlListMappingOptions </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that contains the resources to delete. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the IpAccessControlListMapping resource to delete. </param>
        public DeleteAuthCallsIpAccessControlListMappingOptions(string pathDomainSid, string pathSid)
        {
            PathDomainSid = pathDomainSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Fetch a specific instance of an IP Access Control List mapping </summary>
    public class FetchAuthCallsIpAccessControlListMappingOptions : IOptions<AuthCallsIpAccessControlListMappingResource>
    {
    
        ///<summary> The SID of the SIP domain that contains the resource to fetch. </summary> 
        public string PathDomainSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the IpAccessControlListMapping resource to fetch. </summary> 
        public string PathSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the IpAccessControlListMapping resource to fetch. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new FetchSipAuthCallsIpAccessControlListMappingOptions </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that contains the resource to fetch. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the IpAccessControlListMapping resource to fetch. </param>
        public FetchAuthCallsIpAccessControlListMappingOptions(string pathDomainSid, string pathSid)
        {
            PathDomainSid = pathDomainSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve a list of IP Access Control List mappings belonging to the domain used in the request </summary>
    public class ReadAuthCallsIpAccessControlListMappingOptions : ReadOptions<AuthCallsIpAccessControlListMappingResource>
    {
    
        ///<summary> The SID of the SIP domain that contains the resources to read. </summary> 
        public string PathDomainSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the IpAccessControlListMapping resources to read. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new ListSipAuthCallsIpAccessControlListMappingOptions </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that contains the resources to read. </param>
        public ReadAuthCallsIpAccessControlListMappingOptions(string pathDomainSid)
        {
            PathDomainSid = pathDomainSid;
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

