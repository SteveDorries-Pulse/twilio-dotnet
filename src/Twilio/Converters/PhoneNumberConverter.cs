using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Twilio.Types;


namespace Twilio.Converters
{
    /// <summary>
    /// Convert between strings and a PhoneNumber
    /// </summary>
    public class PhoneNumberConverter : JsonConverter<PhoneNumber>
    {
        /// <summary>
        /// Write value to JsonWriter
        /// </summary>
        /// <param name="writer">Writer to write to</param>
        /// <param name="value">Value to write</param>
        /// <param name="options">unsued</param>
        public override void Write(Utf8JsonWriter writer, PhoneNumber value, JsonSerializerOptions options)
        {
            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(value.ToString());
            }
        }

        /// <summary>
        /// Convert a string to a PhoneNumber
        /// </summary>
        /// <param name="reader">JsonReader to read from</param>
        /// <param name="objectType">unused</param>
        /// <param name="existingValue">unused</param>
        /// <param name="serializer">unsued</param>
        /// <returns>Converted PhoneNumber</returns>
        public override PhoneNumber Read(
            ref Utf8JsonReader reader,
            Type objectType,
            JsonSerializerOptions options
        )
        {
            return new(reader.GetString());
        }


    }
}
