using System;
using System.Text.Json;

namespace Twilio.Types
{
    /// <summary>
    /// Ice Server POCO
    /// </summary>
    public class IceServer
    {
        /// <summary>
        /// Ice Server credential
        /// </summary>
        [JsonPropertyName("credential")]
        public string Credential { get; }

        /// <summary>
        /// Username for server
        /// </summary>
        [JsonPropertyName("username")]
        public string Username { get; }

        /// <summary>
        /// Server URL
        /// </summary>
        [JsonPropertyName("url")]
        public Uri Url { get; }

         /// <summary>
         /// Server URL
         /// </summary>
         [JsonPropertyName("urls")]
         public Uri Urls { get; }

        /// <summary>
        /// Create a new IceServer
        /// </summary>
        /// <param name="credential">Ice Server credential</param>
        /// <param name="username">Server username</param>
        /// <param name="url">Server URL</param>
        /// <param name="urls">Server URL</param>
        public IceServer(string credential, string username, Uri url, Uri urls) {
            Credential = credential;
            Username = username;
            Url = url;
            Urls = urls;
        }
    }
}

