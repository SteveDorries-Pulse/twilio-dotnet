using System.Text.Json;

namespace Twilio.Types
{
    /// <summary>
    /// Capabilities of a phone number
    /// </summary>
    public class PhoneNumberCapabilities
    {
        /// <summary>
        /// MMS capable
        /// </summary>
        [JsonPropertyName("mms")]
        public bool Mms { get; }

        /// <summary>
        /// SMS capable
        /// </summary>
        [JsonPropertyName("sms")]
        public bool Sms { get; }

        /// <summary>
        /// Voice capable
        /// </summary>
        [JsonPropertyName("voice")]
        public bool Voice { get; }

        /// <summary>
        /// Fax capable
        /// </summary>
        [JsonPropertyName("fax")]
        public bool Fax { get; }

        /// <summary>
        /// Create a new PhoneNumberCapability
        /// </summary>
        /// <param name="mms">MMS capable</param>
        /// <param name="sms">SMS capable</param>
        /// <param name="voice">Voice capable</param>
        /// <param name="fax">Fax capable</param>
        public PhoneNumberCapabilities (bool mms, bool sms, bool voice, bool fax)
        {
            Mms = mms;
            Sms = sms;
            Voice = voice;
            Fax = fax;
        }
    }
}

