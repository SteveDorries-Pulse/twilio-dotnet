using System.Collections.Generic;
using System.Text.Json;
using Twilio.Converters;

/// <summary>
/// Recording Rule - A single Recording Rule for a Room
/// </summary>
namespace Twilio.Types
{
    public class RecordingRule
    {

        public sealed class TypeEnum : StringEnum
        {
            private TypeEnum(string value) : base(value) {}

            public TypeEnum() {}
            public static readonly TypeEnum Include = new TypeEnum("include");
            public static readonly TypeEnum Exclude = new TypeEnum("exclude");
        }

        public sealed class KindEnum : StringEnum
        {
            private KindEnum(string value) : base(value) {}

            public KindEnum() {}

            public static readonly KindEnum Audio = new KindEnum("audio");
            public static readonly KindEnum Data = new KindEnum("data");
            public static readonly KindEnum Video = new KindEnum("video");
        }

        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TypeEnum Type { get; private set; }

        [JsonPropertyName("all")]
        public bool? All { get; private set; }

        [JsonPropertyName("publisher")]
        public string Publisher { get; private set; }

        [JsonPropertyName("track")]
        public string Track { get; private set; }

        [JsonPropertyName("kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public KindEnum Kind { get; private set; }

        public RecordingRule (
                TypeEnum type,
                bool? all,
                string publisher,
                string track,
                KindEnum kind
                )
        {
            Type = type;
            All = all;
            Publisher = publisher;
            Track = track;
            Kind = kind;
        }
    }
}
