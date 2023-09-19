/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Taskrouter
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




namespace Twilio.Rest.Taskrouter.V1.Workspace.Worker
{
    /// <summary> fetch </summary>
    public class FetchWorkersRealTimeStatisticsOptions : IOptions<WorkersRealTimeStatisticsResource>
    {
    
        ///<summary> The SID of the Workspace with the resource to fetch. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> Only calculate real-time statistics on this TaskChannel. Can be the TaskChannel's SID or its `unique_name`, such as `voice`, `sms`, or `default`. </summary> 
        public string TaskChannel { get; set; }



        /// <summary> Construct a new FetchWorkersRealTimeStatisticsOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the resource to fetch. </param>
        public FetchWorkersRealTimeStatisticsOptions(string pathWorkspaceSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (TaskChannel != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskChannel", TaskChannel));
            }
            return p;
        }
        

    }


}

