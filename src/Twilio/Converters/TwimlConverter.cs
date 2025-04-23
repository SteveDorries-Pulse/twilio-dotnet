using System;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Twilio.Converters
{
    /// <summary>
    /// Convert between strings and a Twiml
    /// </summary>
    public class TwimlConverter : JsonConverter<object>
    {
        /// <summary>
        /// Write value to JsonWriter
        /// </summary>
        /// <param name="writer">Writer to write to</param>
        /// <param name="value">Value to write</param>
        /// <param name="options">unused</param>
        public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
        {
            var t = JsonNode.Parse(value.ToString());
            t.WriteTo(writer);
        }

        /// <summary>
        /// Convert a string to a Twiml
        /// </summary>
        /// <param name="reader">JsonReader to read from</param>
        /// <param name="objectType">unused</param>
        /// <param name="existingValue">unused</param>
        /// <param name="options">unused</param>
        /// <returns>Converted Twiml</returns>
        public override object Read(
            ref Utf8JsonReader reader,
            Type objectType,
            JsonSerializerOptions options
        )
        {
            return new Types.Twiml(reader.GetString());
        }

        /// <summary>
        /// Determines if an object converted to a Twiml
        /// </summary>
        /// <param name="objectType">Type of object</param>
        /// <returns>true if an object can be converted; false otherwise</returns>
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Enum);
        }
    }
}
