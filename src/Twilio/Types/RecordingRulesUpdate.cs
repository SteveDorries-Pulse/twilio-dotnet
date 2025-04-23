using System.Collections.Generic;
using System.Text.Json;
using Twilio.Converters;

/// <summary>
/// Recording Rule Update - Used to update the list of Recording Rules
/// </summary>
namespace Twilio.Types
{
    public class RecordingRulesUpdate
    {
        [JsonPropertyName("rules")]
        public List<RecordingRule> Rules { get; private set; }

        public RecordingRulesUpdate(
            List<RecordingRule> rules
        )
        {
            Rules = rules;
        }
    }
}
