using System;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

using Twilio.Http;


namespace Twilio.Converters
{
    /// <summary>
    /// Convert between strings and HttpMethod
    /// </summary>
    public class HttpMethodConverter : JsonConverter<Twilio.Http.HttpMethod>
    {
        /// <summary>
        /// Write the HTTP method out to json
        /// </summary>
        ///
        /// <param name="writer">json writer</param>
        /// <param name="value">value to write serialize</param>
        /// <param name="options">json serialize</param>
        public override void Write(Utf8JsonWriter writer, HttpMethod value, JsonSerializerOptions options)
        {
            var t = JsonNode.Parse(value.ToString());
            t.WriteTo(writer);
        }

        /// <summary>
        /// Deserialize a string into a HttpMethod
        /// </summary>
        ///
        /// <param name="reader">json reader</param>
        /// <param name="objectType">type of object</param>
        /// <param name="existingValue"></param>
        /// <param name="options"></param>
        ///
        /// <returns>Deserialized HttpMethod</returns>
        public override HttpMethod Read(ref Utf8JsonReader reader, Type objectType, JsonSerializerOptions options)
        {
            var token = reader.GetString();
            if (token == null)
            {
                return null;
            }

            switch (token.ToLower())
            {
                case "get":
                    return Http.HttpMethod.Get;

                case "post":
                    return Http.HttpMethod.Post;

                case "put":
                    return Http.HttpMethod.Put;

                case "delete":
                    return Http.HttpMethod.Delete;

                default:
                    return null;
            }
        }

        /// <summary>
        /// Determine if an object can be converted to HttpMethod
        /// </summary>
        ///
        /// <param name="objectType">object type</param>
        /// <returns>true if the type is an HttpMethod; false otherwise</returns>
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Http.HttpMethod);
        }

       

    }
}

