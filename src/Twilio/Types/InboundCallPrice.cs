using System.Text.Json;
using Twilio.Converters;

namespace Twilio.Types
{
    /// <summary>
    /// POCO to represent an inbound call price
    /// </summary>
    public class InboundCallPrice
    {
        /// <summary>
        /// Types of inbound numbers
        /// </summary>
        public sealed class TypeEnum : StringEnum
        {
            private TypeEnum(string value) : base(value) { }

            /// <summary>
            /// Generic constructor
            /// </summary>
            public TypeEnum() { }

            /// <summary>
            /// Local number type
            /// </summary>
            public static readonly TypeEnum Local = new TypeEnum("local");

            /// <summary>
            /// Mobile number type
            /// </summary>
            public static readonly TypeEnum Mobile = new TypeEnum("mobile");

            /// <summary>
            /// National number type
            /// </summary>
            public static readonly TypeEnum National = new TypeEnum("national");

            /// <summary>
            /// Toll Free number type
            /// </summary>
            public static readonly TypeEnum TollFree = new TypeEnum("toll free");
        }

        /// <summary>
        /// Base price of calls
        /// </summary>
        [JsonPropertyName("base_price")]
        public double? BasePrice { get; private set; }

        /// <summary>
        /// Current price of calls
        /// </summary>
        [JsonPropertyName("current_price")]
        public double? CurrentPrice { get; private set; }

        /// <summary>
        /// Type of number
        /// </summary>
        [JsonPropertyName("number_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TypeEnum NumberType { get; private set; }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public InboundCallPrice() { }

        private InboundCallPrice(
            double? basePrice,
            double? currentPrice,
            TypeEnum numberType
        )
        {
            BasePrice = basePrice;
            CurrentPrice = currentPrice;
            NumberType = numberType;
        }
    }
}

