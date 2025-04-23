using System.Text.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Twilio.Exceptions
{
    /// <summary>
    /// Exception from Twilio API
    /// </summary>

    public class RestException : TwilioException
    {
        /// <summary>
        /// Twilio error code
        /// </summary>
        [JsonPropertyName("code")]
        public int Code { get; set; }

        /// <summary>
        /// HTTP status code
        /// </summary>
        [JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        public override string Message
        {
            get
            {
                return _message;
            }
            
        }

        [JsonPropertyName("message")]
        protected string _message
        {
            get; set;
        }

        /// <summary>
        /// More info if provided
        /// </summary>
        [JsonPropertyName("more_info")]
        public string MoreInfo { get; set; }

        /// <summary>
        /// Details if provided
        /// </summary>
        [JsonPropertyName("details")]
        public Dictionary<string, object> Details { get; set; }

        /// <summary>
        /// Create an empty RestException
        /// </summary>
        public RestException() { }
        private RestException(
            int status,
            string message,
            int code,
            string moreInfo,
            Dictionary<string, object> details
        )
        {
            Status = status;
            Code = code;
            _message = message;
            MoreInfo = moreInfo;
            Details = details;
        }

        /// <summary>
        /// Create a RestException from a JSON payload
        /// </summary>
        /// <param name="json">JSON string to parse</param>
        public static RestException FromJson(string json)
        {
            return JsonSerializer.Deserialize<RestException>(json);
        }
    }
}
