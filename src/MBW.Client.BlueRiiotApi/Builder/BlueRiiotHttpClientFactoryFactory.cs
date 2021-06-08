using System.Net.Http;

namespace MBW.Client.BlueRiiotApi.Builder
{
    internal class BlueRiiotHttpClientFactoryFactory : IBlueRiiotHttpClientFactory
    {
        private readonly IHttpClientFactory _factory;
        private readonly string _clientName;
        private readonly BlueRiiotHttpClientSettings _settings;

        public BlueRiiotHttpClientFactoryFactory(IHttpClientFactory factory, string clientName, BlueRiiotHttpClientSettings settings = null)
        {
            _factory = factory;
            _clientName = clientName;
            _settings = settings ?? new BlueRiiotHttpClientSettings();
        }

        public HttpClient CreateClient()
        {
            HttpClient httpClient = _factory.CreateClient(_clientName);

            httpClient.DefaultRequestHeaders.Add("User-Agent", "BlueConnect/3.2.1");
            httpClient.DefaultRequestHeaders.Add("Accept-Language", "en-DK;q=1.0, da-DK;q=0.9");
            httpClient.DefaultRequestHeaders.Add("Accept", "*/*");
            httpClient.BaseAddress = _settings.ServerUri;

            return httpClient;
        }
    }
}