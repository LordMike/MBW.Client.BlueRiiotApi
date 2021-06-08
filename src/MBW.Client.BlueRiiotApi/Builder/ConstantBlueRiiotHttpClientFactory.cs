using System.Net.Http;

namespace MBW.Client.BlueRiiotApi.Builder
{
    internal class ConstantBlueRiiotHttpClientFactory : IBlueRiiotHttpClientFactory
    {
        private readonly HttpClient _httpClient;

        public ConstantBlueRiiotHttpClientFactory(HttpClient httpClient, BlueRiiotHttpClientSettings settings = null)
        {
            _httpClient = httpClient;
            settings ??= new BlueRiiotHttpClientSettings();

            _httpClient.DefaultRequestHeaders.Add("User-Agent", "BlueConnect/3.2.1");
            _httpClient.DefaultRequestHeaders.Add("Accept-Language", "en-DK;q=1.0, da-DK;q=0.9");
            _httpClient.DefaultRequestHeaders.Add("Accept", "*/*");
            _httpClient.BaseAddress = settings.ServerUri;
        }

        public HttpClient CreateClient()
        {
            return _httpClient;
        }
    }
}