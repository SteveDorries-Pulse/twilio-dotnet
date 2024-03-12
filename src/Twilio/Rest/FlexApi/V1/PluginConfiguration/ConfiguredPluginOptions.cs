/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Flex
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




namespace Twilio.Rest.FlexApi.V1.PluginConfiguration
{
    /// <summary> fetch </summary>
    public class FetchConfiguredPluginOptions : IOptions<ConfiguredPluginResource>
    {
    
        ///<summary> The SID of the Flex Plugin Configuration the resource to belongs to. </summary> 
        public string PathConfigurationSid { get; }

        ///<summary> The unique string that we created to identify the Flex Plugin resource. </summary> 
        public string PathPluginSid { get; }

        ///<summary> The Flex-Metadata HTTP request header </summary> 
        public string FlexMetadata { get; set; }



        /// <summary> Construct a new FetchConfiguredPluginOptions </summary>
        /// <param name="pathConfigurationSid"> The SID of the Flex Plugin Configuration the resource to belongs to. </param>
        /// <param name="pathPluginSid"> The unique string that we created to identify the Flex Plugin resource. </param>
        public FetchConfiguredPluginOptions(string pathConfigurationSid, string pathPluginSid)
        {
            PathConfigurationSid = pathConfigurationSid;
            PathPluginSid = pathPluginSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        
    /// <summary> Generate the necessary header parameters </summary>
    public List<KeyValuePair<string, string>> GetHeaderParams()
    {
        var p = new List<KeyValuePair<string, string>>();
        if (FlexMetadata != null)
        {
            p.Add(new KeyValuePair<string, string>("Flex-Metadata", FlexMetadata));
        }
        return p;
    }

    }


    /// <summary> read </summary>
    public class ReadConfiguredPluginOptions : ReadOptions<ConfiguredPluginResource>
    {
    
        ///<summary> The SID of the Flex Plugin Configuration the resource to belongs to. </summary> 
        public string PathConfigurationSid { get; }

        ///<summary> The Flex-Metadata HTTP request header </summary> 
        public string FlexMetadata { get; set; }



        /// <summary> Construct a new ListConfiguredPluginOptions </summary>
        /// <param name="pathConfigurationSid"> The SID of the Flex Plugin Configuration the resource to belongs to. </param>
        public ReadConfiguredPluginOptions(string pathConfigurationSid)
        {
            PathConfigurationSid = pathConfigurationSid;
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

        
    /// <summary> Generate the necessary header parameters </summary>
    public List<KeyValuePair<string, string>> GetHeaderParams()
    {
        var p = new List<KeyValuePair<string, string>>();
        if (FlexMetadata != null)
        {
            p.Add(new KeyValuePair<string, string>("Flex-Metadata", FlexMetadata));
        }
        return p;
    }

    }

}

