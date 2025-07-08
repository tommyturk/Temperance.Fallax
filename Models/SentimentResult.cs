namespace Temperance.Fallax.Models
{
    public class SentimentResult
    {
        public decimal Score { get; set; }

        public string Label { get; set; } = "Neutral";

        public decimal Confidence { get; set; } = 1.0m;
    }
}
