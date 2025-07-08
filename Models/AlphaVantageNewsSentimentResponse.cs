using System.Text.Json.Serialization;

namespace Temperance.Fallax.Models
{
    public class AlphaVantageNewsSentimentResponse
    {
        [JsonPropertyName("items")]
        public string? Items { get; set; } // e.g., "50"

        [JsonPropertyName("sentiment_score_definition")]
        public string? SentimentScoreDefinition { get; set; }

        [JsonPropertyName("relevance_score_definition")]
        public string? RelevanceScoreDefinition { get; set; }

        [JsonPropertyName("feed")]
        public List<AlphaVantageNewsFeedItem> Feed { get; set; } = new List<AlphaVantageNewsFeedItem>();
    }
}
