using System.Collections.Generic;
using System.Text.Json;

namespace Twilio.Types
{
    /// <summary>
    /// POCO for outbound prefix prices
    /// </summary>
    public class OutboundPrefixPrice
    {
        /// <summary>
        /// Prefix list
        /// </summary>
        [JsonPropertyName("prefixes")]
        public List<string> Prefixes { get; }

        /// <summary>
        /// Prefix friendly name
        /// </summary>
        [JsonPropertyName("friendly_name")]
        public string FriendlyName { get; }

        /// <summary>
        /// Base price for prefix
        /// </summary>
        [JsonPropertyName("base_price")]
        public double? BasePrice { get; }

        /// <summary>
        /// Current price of prefix
        /// </summary>
        [JsonPropertyName("current_price")]
        public double? CurrentPrice { get; }

        /// <summary>
        /// Create a new OutboundPrefixPrice
        /// </summary>
        /// <param name="prefixes">List of prefixes</param>
        /// <param name="friendlyName">Prefix friendly name</param>
        /// <param name="basePrice">Base price of prefix</param>
        /// <param name="currentPrice">Current price of prefix</param>
        public OutboundPrefixPrice (
            List<string> prefixes,
            string friendlyName,
            double basePrice,
            double currentPrice
        )
        {
            Prefixes = prefixes;
            FriendlyName = friendlyName;
            BasePrice = basePrice;
            CurrentPrice = currentPrice;
        }
    }
}

