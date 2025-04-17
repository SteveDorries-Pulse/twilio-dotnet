using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Twilio.Rest;
using static System.String;

namespace Twilio.Base
{
    /// <summary>
    /// Page of resources
    /// </summary>
    /// <typeparam name="T">Resource type</typeparam>
    public class Page<T> where T : Resource
    {
        /// <summary>
        /// Records for this page
        /// </summary>
        public List<T> Records { get; }

        /// <summary>
        /// Page size
        /// </summary>
        public int PageSize { get; }

        private readonly string _uri;
        private readonly string _url;
        private readonly string _firstPageUri;
        private readonly string _firstPageUrl;
        private readonly string _nextPageUri;
        private readonly string _nextPageUrl;
        private readonly string _previousPageUri;
        private readonly string _previousPageUrl;

        private Page(
            List<T> records,
            int pageSize,
            string uri = null,
            string url = null,
            string firstPageUri = null,
            string firstPageUrl = null,
            string previousPageUri = null,
            string previousPageUrl = null,
            string nextPageUri = null,
            string nextPageUrl = null
        )
        {
            Records = records;
            PageSize = pageSize;
            _uri = uri;
            _url = url;
            _firstPageUri = firstPageUri;
            _firstPageUrl = firstPageUrl;
            _nextPageUri = nextPageUri;
            _nextPageUrl = nextPageUrl;
            _previousPageUri = previousPageUri;
            _previousPageUrl = previousPageUrl;
        }

        private static string UrlFromUri(Domain domain, string uri)
        {
            return "https://" + domain + ".twilio.com" + uri;
        }

        /// <summary>
        /// Generate the first page URL
        /// </summary>
        /// <param name="domain">Twilio subdomain</param>
        /// <returns>URL for the first page of results</returns>
        public string GetFirstPageUrl(Domain domain)
        {
            return _firstPageUrl ?? UrlFromUri(domain, _firstPageUri);
        }

        /// <summary>
        /// Get the next page URL
        /// </summary>
        /// <param name="domain">Twilio subdomain</param>
        /// <returns>URL for the next page of results</returns>
        public string GetNextPageUrl(Domain domain)
        {
            return _nextPageUrl ?? UrlFromUri(domain, _nextPageUri);
        }

        /// <summary>
        /// Get the previous page URL
        /// </summary>
        /// <param name="domain">Twilio subdomain</param>
        /// <returns>URL for the previous page of results</returns>
        public string GetPreviousPageUrl(Domain domain)
        {
            return _previousPageUrl ?? UrlFromUri(domain, _previousPageUri);
        }

        /// <summary>
        /// Get the URL for the current page
        /// </summary>
        /// <param name="domain">Twilio subdomain</param>
        /// <returns>URL for the current page of results</returns>
        public string GetUrl(Domain domain)
        {
            return _url ?? UrlFromUri(domain, _uri);
        }

        /// <summary>
        /// Determines if there is another page of results
        /// </summary>
        /// <returns>true if there is a next page; false otherwise</returns>
        public bool HasNextPage()
        {
            return !IsNullOrEmpty(_nextPageUrl) || !IsNullOrEmpty(_nextPageUri);
        }

        /// <summary>
        /// Converts a JSON payload to a Page of results
        /// </summary>
        /// <param name="recordKey">JSON key where the records are</param>
        /// <param name="json">JSON payload</param>
        /// <returns>Page of results</returns>
        public static Page<T> FromJson(string recordKey, string json)
        {
            using (var doc = JsonDocument.Parse(json))
            {
                var root = doc.RootElement;
                var recordsElement = root.GetProperty(recordKey);
                var parsedRecords = recordsElement
                    .EnumerateArray()
                    .Select(record => record.Deserialize<T>())
                    .ToList();
                JsonElement uriNode;
                if (root.TryGetProperty("uri", out uriNode))
                {
                    JsonElement pageSize;
                    JsonElement firstPageUri;
                    JsonElement nextPageUri;
                    JsonElement previousPageUri;

                    // v2010 API
                    return new Page<T>(
                        parsedRecords,
                        root.TryGetProperty("page_size", out pageSize) ? pageSize.GetInt32() : parsedRecords.Count,
                        uri: uriNode.GetString(),
                        firstPageUri: root.TryGetProperty("first_page_uri", out firstPageUri) ? firstPageUri.GetString() : null,
                        nextPageUri: root.TryGetProperty("next_page_uri", out nextPageUri) ? nextPageUri.GetString() : null,
                        previousPageUri: root.TryGetProperty("previous_page_uri", out previousPageUri) ? previousPageUri.GetString() : null
                    );

                }
                JsonElement meta = root.GetProperty("meta");
                return new Page<T>(
                    parsedRecords,
                    meta.GetProperty("page_size").GetInt32(),
                    url: meta.GetProperty("url").GetString(),
                    firstPageUrl: meta.GetProperty("first_page_uri").GetString(),
                    nextPageUrl: meta.GetProperty("next_page_uri").GetString(),
                    previousPageUrl: meta.GetProperty("previous_page_uri").GetString()
                );
            }

        }
    }
}
