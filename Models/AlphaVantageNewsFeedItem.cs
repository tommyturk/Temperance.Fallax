using System.Text.Json.Serialization;

namespace Temperance.Fallax.Models
{
    public class AlphaVantageNewsFeedItem
    {
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("time_published")]
        public string? TimePublished { get; set; } // Format: "YYYYMMDDTHHMMSS", needs parsing to DateTime

        [JsonPropertyName("authors")]
        public List<string> Authors { get; set; } = new List<string>();

        [JsonPropertyName("summary")]
        public string? Summary { get; set; }

        [JsonPropertyName("banner_image")]
        public string? BannerImage { get; set; }

        [JsonPropertyName("source")]
        public string? Source { get; set; } // e.g., "Benzinga"

        [JsonPropertyName("category_within_source")]
        public string? CategoryWithinSource { get; set; }

        [JsonPropertyName("source_domain")]
        public string? SourceDomain { get; set; } // e.g., "www.benzinga.com"

        [JsonPropertyName("topics")]
        public List<AlphaVantageTopic> Topics { get; set; } = new List<AlphaVantageTopic>();

        [JsonPropertyName("overall_sentiment_score")]
        public double OverallSentimentScore { get; set; } // Direct numeric value

        [JsonPropertyName("overall_sentiment_label")]
        public string? OverallSentimentLabel { get; set; }

        [JsonPropertyName("ticker_sentiment")]
        public List<AlphaVantageTickerSentiment> TickerSentiment { get; set; } = new List<AlphaVantageTickerSentiment>();
    }
}
