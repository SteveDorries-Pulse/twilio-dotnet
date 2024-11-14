/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Assistants
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




namespace Twilio.Rest.Assistants.V1.Assistant
{

    /// <summary> Attach Tool to Assistant </summary>
    public class CreateAssistantsToolOptions : IOptions<AssistantsToolResource>
    {
        
        ///<summary> The assistant ID. </summary> 
        public string PathAssistantId { get; }

        ///<summary> The tool ID. </summary> 
        public string PathId { get; }


        /// <summary> Construct a new CreateAssistantToolAttachmentOptions </summary>
        /// <param name="pathAssistantId"> The assistant ID. </param>
        /// <param name="pathId"> The tool ID. </param>
        public CreateAssistantsToolOptions(string pathAssistantId, string pathId)
        {
            PathAssistantId = pathAssistantId;
            PathId = pathId;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        

    }
    /// <summary> Detach Tool to Assistant </summary>
    public class DeleteAssistantsToolOptions : IOptions<AssistantsToolResource>
    {
        
        ///<summary> The assistant ID. </summary> 
        public string PathAssistantId { get; }

        ///<summary> The tool ID. </summary> 
        public string PathId { get; }



        /// <summary> Construct a new DeleteAssistantToolAttachmentOptions </summary>
        /// <param name="pathAssistantId"> The assistant ID. </param>
        /// <param name="pathId"> The tool ID. </param>
        public DeleteAssistantsToolOptions(string pathAssistantId, string pathId)
        {
            PathAssistantId = pathAssistantId;
            PathId = pathId;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

    

    }


    /// <summary> List tools for an Assistant </summary>
    public class ReadAssistantsToolOptions : ReadOptions<AssistantsToolResource>
    {
    
        ///<summary> The assistant ID. </summary> 
        public string PathAssistantId { get; }



        /// <summary> Construct a new ListToolsByAssistantOptions </summary>
        /// <param name="pathAssistantId"> The assistant ID. </param>
        public ReadAssistantsToolOptions(string pathAssistantId)
        {
            PathAssistantId = pathAssistantId;
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
