using System.Collections.Generic;
using System.Text.Json;

namespace Twilio.Types
{
    /// <summary>
    /// POCO to represent an outbound SMS price
    /// </summary>
    public class OutboundSmsPrice
    {
        /// <summary>
        /// SMS mcc
        /// </summary>
        [JsonPropertyName("mcc")]
        public string Mcc { get; }

        /// <summary>
        /// SMS mnc
        /// </summary>
        [JsonPropertyName("mnc")]
        public string Mnc { get; }

        /// <summary>
        /// Carrier name
        /// </summary>
        [JsonPropertyName("carrier")]
        public string Carrier { get; }

        /// <summary>
        /// List of prices
        /// </summary>
        [JsonPropertyName("prices")]
        public List<InboundSmsPrice> Prices { get; }

        /// <summary>
        /// Create a new OutboundSmsPrice
        /// </summary>
        /// <param name="mcc">SMS mcc</param>
        /// <param name="mnc">SMS mnc</param>
        /// <param name="carrier">Carrier name</param>
        /// <param name="prices">List of prices</param>
        public OutboundSmsPrice (
            string mcc,
            string mnc,
            string carrier,
            List<InboundSmsPrice> prices
        )
        {
            Mcc = mcc;
            Mnc = mnc;
            Carrier = carrier;
            Prices = prices;
        }
    }
}

