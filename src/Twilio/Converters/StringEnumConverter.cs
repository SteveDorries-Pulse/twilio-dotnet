using System;
using System.Collections.Generic;
using System.Collections;
using Twilio.Types;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Twilio.Converters
{
    /// <summary>
    /// Converts between enums and strings
    /// </summary>
    public class StringEnumConverter : JsonConverter<object>
    {


        /// <summary>
        /// Writes value to a JsonWriter
        /// </summary>
        /// <param name="writer">JsonWriter to use</param>
        /// <param name="value">value to write</param>
        /// <param name="serializer">unused</param>
        public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
        {
            var t = JsonNode.Parse(value.ToString());
            t.WriteTo(writer);
        }

        /// <summary>
        /// Converts string to an enum
        /// </summary>
        /// <param name="reader">JsonReader to read from</param>
        /// <param name="objectType">unused</param>
        /// <param name="existingValue">unused</param>
        /// <param name="serializer">unused</param>
        /// <returns>Converted object</returns>
        public override object Read(
            ref Utf8JsonReader reader,
            Type objectType,
            JsonSerializerOptions options
        )
        {

            // Value is null for 'Null' tokens and 'StartArray' tokens. If it's the former, stop now!
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                if (objectType.GenericTypeArguments.Length == 0)
                {
                    return null;
                }

                var constructedListType = MakeGenericType(objectType);
                var results = (IList)Activator.CreateInstance(constructedListType);
                reader.Read();

                while (reader.TokenType != JsonTokenType.EndArray)
                {
                    var e = CreateEnum(objectType, reader.GetString());
                    results.Add(e);
                    reader.Read();
                }

                return results;
            }

            var instance = (StringEnum)Activator.CreateInstance(objectType, reader.GetString());

            return instance;
        }

        /// <summary>
        /// Determines if an object can be converted
        /// </summary>
        /// <param name="objectType">Object type to convert</param>
        /// <returns>true if it can be converted; false otherwise</returns>
        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        private Type MakeGenericType(Type objectType)
        {
            var listType = typeof(List<>);

            return listType.MakeGenericType(objectType.GenericTypeArguments[0]);
        }

        private StringEnum CreateEnum(Type objectType, string value)
        {

            return (StringEnum)Activator.CreateInstance(objectType.GenericTypeArguments[0], value);

        }


    }

}

