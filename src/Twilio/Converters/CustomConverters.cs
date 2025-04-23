using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Twilio.Converters
{
    
    public class DateTimeConverter : JsonConverter<object>
        {
            public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions serializer)
            {
                // Serializing List<DateTime> objects
                if (value is List<DateTime> dateTimes)
                {
                    writer.WriteStartArray();
                    foreach (var dateTime in dateTimes)
                    {
                        writer.WriteStringValue(Serializers.DateTimeIso8601(dateTime));
                    }

                    writer.WriteEndArray();
                }
                else
                { // Serializing DateTime object
                    writer.WriteStringValue(Serializers.DateTimeIso8601((DateTime)value));
                }
            }

            public override object Read(ref Utf8JsonReader reader, Type objectType, JsonSerializerOptions options)
            {
                if (reader.TokenType == JsonTokenType.StartArray)
                {
                    var dateTimes = new List<DateTime>();

                    while (reader.Read())
                    {
                        if (reader.TokenType == JsonTokenType.String)
                        {
                            if (DateTime.TryParse(reader.GetString(), out DateTime dateTime))
                            {
                                dateTimes.Add(dateTime);
                            }
                        }
                        else if (reader.TokenType == JsonTokenType.EndArray)
                        {
                            return dateTimes;
                        }
                    }
                }
                else if (reader.TokenType == JsonTokenType.String)
                {
                    if (DateTime.TryParse(reader.GetString(), out DateTime dateTime))
                    {
                        return dateTime;
                    }
                }
                throw new JsonException("Failed to deserialize DateTime.");
            }

            public override bool CanConvert(Type objectType)
            {
                return objectType == typeof(DateTime?) || objectType ==typeof(List<DateTime>);
            }
        }

    public class UriConverter : JsonConverter<object>
    {
        public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions serializer)
        {
            // Serializing List<Uri> objects
            if (value is List<Uri> uris)
            {
                writer.WriteStartArray();
                foreach (var uri in uris)
                {
                    writer.WriteStringValue(Serializers.Url(uri));
                }

                writer.WriteEndArray();
            }
            else
            { // Serializing Uri object
                writer.WriteStringValue(Serializers.Url((Uri)value));
            }
        }

        public override object Read(ref Utf8JsonReader reader, Type objectType, JsonSerializerOptions serializer)
        {
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                var uris = new List<Uri>();

                while (reader.Read())
                {
                    if (reader.TokenType == JsonTokenType.String)
                    {
                        if (Uri.TryCreate(reader.GetString(), UriKind.RelativeOrAbsolute, out Uri uri))
                        {
                            uris.Add(uri);
                        }
                    }
                    else if (reader.TokenType == JsonTokenType.EndArray)
                    {
                        return uris;
                    }
                }
            }
            else if (reader.TokenType == JsonTokenType.String)
            {
                if (Uri.TryCreate(reader.GetString(), UriKind.RelativeOrAbsolute, out Uri uri))
                {
                    return uri;
                }
            }
            throw new JsonException("Failed to deserialize URI.");
        }
        
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Uri);
        }
    }

    public class JsonObjectConverter : JsonConverter<object>
    {
        public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions serializer)
        {
            // Serializing List<Uri> objects
            if (value is List<object> objects)
            {
                writer.WriteStartArray();
                foreach (var val in objects)
                {
                    writer.WriteStringValue(Serializers.JsonObject(val));
                }

                writer.WriteEndArray();
            }
            else
            { // Serializing Uri object
                writer.WriteStringValue(Serializers.JsonObject(value));
            }
        }

        public override object Read(ref Utf8JsonReader reader, Type objectType,  JsonSerializerOptions serializer)
        {
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                var objects = new List<object>();

                while (reader.Read())
                {
                    if (reader.TokenType == JsonTokenType.String)
                    {
                        if (Uri.TryCreate(reader.GetString(), UriKind.RelativeOrAbsolute, out Uri uri))
                        {
                            objects.Add(uri);
                        }
                    }
                    else if (reader.TokenType == JsonTokenType.EndArray)
                    {
                        return objects;
                    }
                }
            }
            else if (reader.TokenType == JsonTokenType.String)
            {
                if (Uri.TryCreate(reader.GetString(), UriKind.RelativeOrAbsolute, out Uri uri))
                {
                    return uri;
                }
            }
            throw new JsonException("Failed to deserialize object.");
        }
        
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Uri);
        }
    }
}