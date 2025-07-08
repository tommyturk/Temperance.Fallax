using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Temperance.Fallax.Models;
using Temperance.Fallax.Settings;

namespace Temperance.Fallax.Services
{
    public class AlphaVantageNewsProvider : INewsProvider
    {
        private readonly HttpClient _httpClient;
        private readonly AlphaVantageSettings _settings;
        private readonly ILogger<AlphaVantageNewsProvider> _logger;
        public string ProviderName => "Alpha Vantage";
        public AlphaVantageNewsProvider(HttpClient httpClient, IOptions<AlphaVantageSettings> settings, 
            ILogger<AlphaVantageNewsProvider> logger)
        {
            _settings = settings.Value;
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<AlphaVantageNewsSentimentResponse> GetNewsAsync(string symbol)
        {
            var url = $"{_settings.BaseUrl}?function=NEWS_SENTIMENT&tickers={symbol}" +
                $"&apikey={_settings.ApiKey}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var newsArticles = JsonConvert.DeserializeObject<AlphaVantageNewsSentimentResponse>(content);
            return newsArticles ?? new AlphaVantageNewsSentimentResponse();
        }
    }
}
