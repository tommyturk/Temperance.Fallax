namespace Temperance.Fallax.Settings
{
    public interface IAlphaVantageSettings
    {
        string BaseUrl { get; set; }

        string ApiKey { get; set; }
    }
}
