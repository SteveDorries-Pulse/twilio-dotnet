using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

using Twilio.Converters;
using Twilio.Types;

namespace Twilio.UnitTests.Converters
{

    public class StringEnumConverterTest : TwilioTest
    {
        class StatusClass
        {
            [JsonPropertyName("status")]
            [JsonConverter(typeof(StringEnumConverter))]
            public StatusEnum? Status { get; set; }

            [JsonPropertyName("status_list")]
            [JsonConverter(typeof(StringEnumConverter))]
            public List<StatusEnum>? StatusList { get; set; }
        }

        
        class StatusEnum : StringEnum
        {
            public StatusEnum(string value) : base(value) { }
            public StatusEnum() { }
            
            public static readonly StatusEnum Awe = new("awe");
            public static readonly StatusEnum Some = new("some");
        }

        [Fact]
        public void TestBasicDeserialize()
        {
            var input = "{\"status\":\"awe\",\"status_list\":[\"some\"]}";
            var result = JsonSerializer.Deserialize<StatusClass>(input);
            Assert.Equal(StatusEnum.Awe, result!.Status);
            Assert.Equal(new[] { StatusEnum.Some }, result.StatusList);
        }

        [Fact]
        public void TestNullDeserialize()
        {
            var input = "{\"status\":null,\"status_list\":null}";
            var result = JsonSerializer.Deserialize<StatusClass>(input);
            Assert.Null(result!.Status);
            Assert.Null(result.StatusList);
        }
    }
}
