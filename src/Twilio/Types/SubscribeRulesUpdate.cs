using System.Collections.Generic;
using System.Text.Json;
using Twilio.Converters;

/// <summary>
/// Subscribe Rule Update - Used to update the list of Subscribe Rules
///
///   For more information see:
///   <a href="https://www.twilio.com/docs/video/api/track-subscriptions#specifying-sr">Specifying Subscribe Rules</a>
/// </summary>
namespace Twilio.Types
{
    public class SubscribeRulesUpdate
    {
        [JsonPropertyName("rules")]
        public List<SubscribeRule> Rules { get; private set; }

        public SubscribeRulesUpdate (
            List<SubscribeRule> rules
        )
        {
            Rules = rules;
        }
    }
}
