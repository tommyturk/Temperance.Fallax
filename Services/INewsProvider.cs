using Temperance.Fallax.Models;

namespace Temperance.Fallax.Services
{
    public interface INewsProvider
    {
        string ProviderName { get; }

        Task<AlphaVantageNewsSentimentResponse> GetNewsAsync(string symbol);
    }
}
