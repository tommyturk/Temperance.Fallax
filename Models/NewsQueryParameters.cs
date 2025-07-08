namespace Temperance.Fallax.Models
{
    public class NewsQueryParameters
    {
        public List<string>? Symbols { get; set; }

        public List<string>? Topics { get; set; }

        public DateTime? FromDate { get; set; }
        
        public DateTime? ToDate { get; set; }

        public int Limit { get; set; }

        public string? SourcePreference { get; set; }
    }
}
