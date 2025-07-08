using System.Text.Json.Serialization;

namespace Temperance.Fallax.Models
{
    public class AlphaVantageTopic
    {
        [JsonPropertyName("topic")]
        public string? TopicName { get; set; } // Renamed from "topic" to avoid potential class name conflicts

        [JsonPropertyName("relevance_score")]
        public string? RelevanceScore { get; set; } // String representation of a score, e.g., "0.714479", needs parsing to double/decimal
    }
}
