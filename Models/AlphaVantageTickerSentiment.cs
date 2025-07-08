using System.Text.Json.Serialization;

namespace Temperance.Fallax.Models
{
    public class AlphaVantageTickerSentiment
    {
        [JsonPropertyName("ticker")]
        public string? Ticker { get; set; }

        [JsonPropertyName("relevance_score")]
        public string? RelevanceScore { get; set; } // String representation of a score, e.g., "0.381463", needs parsing to double/decimal

        [JsonPropertyName("ticker_sentiment_score")]
        public double TickerSentimentScore { get; set; } // Direct numeric value

        [JsonPropertyName("ticker_sentiment_label")]
        public string? TickerSentimentLabel { get; set; }
    }
}
