using System.Collections.Generic;
using System.Text.Json;

namespace Twilio.Types
{
    /// <summary>
    /// POCO for outbound prefix prices with origins
    /// </summary>
    public class OutboundPrefixPriceWithOrigin
    {
        /// <summary>
        /// Destination Prefix list
        /// </summary>
        [JsonPropertyName("destination_prefixes")]
        public List<string> DestinationPrefixes { get; }

        /// <summary>
        /// Destination Prefix list
        /// </summary>
        [JsonPropertyName("origination_prefixes")]
        public List<string> OriginationPrefixes { get; }

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
        /// <param name="destinationPrefixes">List of destination prefixes</param>
        /// <param name="originationPrefixes">List of origination prefixes</param>
        /// <param name="friendlyName">Prefix friendly name</param>
        /// <param name="basePrice">Base price of prefix</param>
        /// <param name="currentPrice">Current price of prefix</param>
        public OutboundPrefixPriceWithOrigin (
            List<string> destinationPrefixes,
            List<string> originationPrefixes,
            string friendlyName,
            double basePrice,
            double currentPrice
        )
        {
            DestinationPrefixes = destinationPrefixes;
            OriginationPrefixes = originationPrefixes;
            FriendlyName = friendlyName;
            BasePrice = basePrice;
            CurrentPrice = currentPrice;
        }
    }
}

