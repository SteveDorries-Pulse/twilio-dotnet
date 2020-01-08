/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Studio.V2
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// UpdateFlowValidateOptions
    /// </summary>
    public class UpdateFlowValidateOptions : IOptions<FlowValidateResource>
    {
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; }
        /// <summary>
        /// The status
        /// </summary>
        public FlowValidateResource.StatusEnum Status { get; }
        /// <summary>
        /// The definition
        /// </summary>
        public string Definition { get; }
        /// <summary>
        /// The commit_message
        /// </summary>
        public string CommitMessage { get; set; }

        /// <summary>
        /// Construct a new UpdateFlowValidateOptions
        /// </summary>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="status"> The status </param>
        /// <param name="definition"> The definition </param>
        public UpdateFlowValidateOptions(string friendlyName, FlowValidateResource.StatusEnum status, string definition)
        {
            FriendlyName = friendlyName;
            Status = status;
            Definition = definition;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
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

            if (Definition != null)
            {
                p.Add(new KeyValuePair<string, string>("Definition", Definition));
            }

            if (CommitMessage != null)
            {
                p.Add(new KeyValuePair<string, string>("CommitMessage", CommitMessage));
            }

            return p;
        }
    }

}