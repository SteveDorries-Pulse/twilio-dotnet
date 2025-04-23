using System.Text.Json;

namespace Twilio.Types
{
    /// <summary>
    /// Feedback issue POCO
    /// </summary>
    public class FeedbackIssue
    {
        /// <summary>
        /// Number of occurrences
        /// </summary>
        [JsonPropertyName("count")]
        public int Count { get; }

        /// <summary>
        /// Description of issue
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; }

        /// <summary>
        /// Percentage of calls affected
        /// </summary>
        [JsonPropertyName("percentage_of_total_calls")]
        public string PercentageOfTotalCalls { get; }

        /// <summary>
        /// Create new FeedbackIssue
        /// </summary>
        /// <param name="count">Number of occurrences</param>
        /// <param name="description">Description of issue</param>
        /// <param name="percentageOfTotalCalls">Percentage of calls affected</param>
        public FeedbackIssue(int count, string description, string percentageOfTotalCalls)
        {
            Count = count;
            Description = description;
            PercentageOfTotalCalls = percentageOfTotalCalls;
        }
    }
}

