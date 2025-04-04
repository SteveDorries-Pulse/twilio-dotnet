/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Verify
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




namespace Twilio.Rest.Verify.V2.Service
{

    /// <summary> challenge a specific Verification Check. </summary>
    public class CreateVerificationCheckOptions : IOptions<VerificationCheckResource>
    {
        
        ///<summary> The SID of the verification [Service](https://www.twilio.com/docs/verify/api/service) to create the resource under. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The 4-10 character string being verified. </summary> 
        public string Code { get; set; }

        ///<summary> The phone number or [email](https://www.twilio.com/docs/verify/email) to verify. Either this parameter or the `verification_sid` must be specified. Phone numbers must be in [E.164 format](https://www.twilio.com/docs/glossary/what-e164). </summary> 
        public string To { get; set; }

        ///<summary> A SID that uniquely identifies the Verification Check. Either this parameter or the `to` phone number/[email](https://www.twilio.com/docs/verify/email) must be specified. </summary> 
        public string VerificationSid { get; set; }

        ///<summary> The amount of the associated PSD2 compliant transaction. Requires the PSD2 Service flag enabled. </summary> 
        public string Amount { get; set; }

        ///<summary> The payee of the associated PSD2 compliant transaction. Requires the PSD2 Service flag enabled. </summary> 
        public string Payee { get; set; }

        ///<summary> A sna client token received in sna url invocation response needs to be passed in Verification Check request and should match to get successful response. </summary> 
        public string SnaClientToken { get; set; }


        /// <summary> Construct a new CreateVerificationCheckOptions </summary>
        /// <param name="pathServiceSid"> The SID of the verification [Service](https://www.twilio.com/docs/verify/api/service) to create the resource under. </param>
        public CreateVerificationCheckOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Code != null)
            {
                p.Add(new KeyValuePair<string, string>("Code", Code));
            }
            if (To != null)
            {
                p.Add(new KeyValuePair<string, string>("To", To));
            }
            if (VerificationSid != null)
            {
                p.Add(new KeyValuePair<string, string>("VerificationSid", VerificationSid));
            }
            if (Amount != null)
            {
                p.Add(new KeyValuePair<string, string>("Amount", Amount));
            }
            if (Payee != null)
            {
                p.Add(new KeyValuePair<string, string>("Payee", Payee));
            }
            if (SnaClientToken != null)
            {
                p.Add(new KeyValuePair<string, string>("SnaClientToken", SnaClientToken));
            }
            return p;
        }

        

    }
}

