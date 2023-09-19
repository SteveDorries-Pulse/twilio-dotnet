/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Microvisor
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




namespace Twilio.Rest.Microvisor.V1
{
    /// <summary> Fetch a specific Device. </summary>
    public class FetchDeviceOptions : IOptions<DeviceResource>
    {
    
        ///<summary> A 34-character string that uniquely identifies this Device. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchDeviceOptions </summary>
        /// <param name="pathSid"> A 34-character string that uniquely identifies this Device. </param>
        public FetchDeviceOptions(string pathSid)
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


    /// <summary> Retrieve a list of all Devices registered with the Account. </summary>
    public class ReadDeviceOptions : ReadOptions<DeviceResource>
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

    /// <summary> Update a specific Device. </summary>
    public class UpdateDeviceOptions : IOptions<DeviceResource>
    {
    
        ///<summary> A 34-character string that uniquely identifies this Device. </summary> 
        public string PathSid { get; }

        ///<summary> A unique and addressable name to be assigned to this Device by the developer. It may be used in place of the Device SID. </summary> 
        public string UniqueName { get; set; }

        ///<summary> The SID or unique name of the App to be targeted to the Device. </summary> 
        public string TargetApp { get; set; }

        ///<summary> A Boolean flag specifying whether to enable application logging. Logs will be enabled or extended for 24 hours. </summary> 
        public bool? LoggingEnabled { get; set; }

        ///<summary> Set to true to restart the App running on the Device. </summary> 
        public bool? RestartApp { get; set; }



        /// <summary> Construct a new UpdateDeviceOptions </summary>
        /// <param name="pathSid"> A 34-character string that uniquely identifies this Device. </param>
        public UpdateDeviceOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            if (TargetApp != null)
            {
                p.Add(new KeyValuePair<string, string>("TargetApp", TargetApp));
            }
            if (LoggingEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("LoggingEnabled", LoggingEnabled.Value.ToString().ToLower()));
            }
            if (RestartApp != null)
            {
                p.Add(new KeyValuePair<string, string>("RestartApp", RestartApp.Value.ToString().ToLower()));
            }
            return p;
        }
        

    }


}

