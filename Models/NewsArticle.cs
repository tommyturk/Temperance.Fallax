namespace Temperance.Fallax.Models
{
    public class NewsArticle
    {
        public string? Id { get; set; }
        public string? Source { get; set; } // e.g., "Alpha Vantage", "World Bank"
        public string? TickerSymbol { get; set; }
        public string? Title { get; set; }
        public string? Summary { get; set; }
        public string? Url { get; set; }
        public DateTime PublishedUtc { get; set; }
        public List<string> Topics { get; set; } = new();
        public SentimentResult? Sentiment { get; set; } 
        public Dictionary<string, object> AdditionalData { get; set; } = new();
    }
}
