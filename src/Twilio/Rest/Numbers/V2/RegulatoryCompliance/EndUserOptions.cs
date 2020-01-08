/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Numbers.V2.RegulatoryCompliance
{

    /// <summary>
    /// Create a new End User.
    /// </summary>
    public class CreateEndUserOptions : IOptions<EndUserResource>
    {
        /// <summary>
        /// The string that you assigned to describe the resource
        /// </summary>
        public string FriendlyName { get; }
        /// <summary>
        /// The type of end user of the Bundle resource
        /// </summary>
        public EndUserResource.TypeEnum Type { get; }
        /// <summary>
        /// The set of parameters that compose the End User resource
        /// </summary>
        public object Attributes { get; set; }

        /// <summary>
        /// Construct a new CreateEndUserOptions
        /// </summary>
        /// <param name="friendlyName"> The string that you assigned to describe the resource </param>
        /// <param name="type"> The type of end user of the Bundle resource </param>
        public CreateEndUserOptions(string friendlyName, EndUserResource.TypeEnum type)
        {
            FriendlyName = friendlyName;
            Type = type;
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

            if (Type != null)
            {
                p.Add(new KeyValuePair<string, string>("Type", Type.ToString()));
            }

            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Serializers.JsonObject(Attributes)));
            }

            return p;
        }
    }

    /// <summary>
    /// Retrieve a list of all End User for an account.
    /// </summary>
    public class ReadEndUserOptions : ReadOptions<EndUserResource>
    {
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Fetch specific End User Instance.
    /// </summary>
    public class FetchEndUserOptions : IOptions<EndUserResource>
    {
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchEndUserOptions
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public FetchEndUserOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// Update an existing End User.
    /// </summary>
    public class UpdateEndUserOptions : IOptions<EndUserResource>
    {
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The string that you assigned to describe the resource
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The set of parameters that compose the End User resource
        /// </summary>
        public object Attributes { get; set; }

        /// <summary>
        /// Construct a new UpdateEndUserOptions
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public UpdateEndUserOptions(string pathSid)
        {
            PathSid = pathSid;
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

            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Serializers.JsonObject(Attributes)));
            }

            return p;
        }
    }

}