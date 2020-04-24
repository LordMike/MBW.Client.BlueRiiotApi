using System;
using System.Net.Http;

namespace MBW.Client.BlueRiiotApi.Builder
{
    internal class HttpClientFactoryProducer : IHttpClientProducer
    {
        private readonly IHttpClientFactory _factory;
        private readonly string _clientName;

        public HttpClientFactoryProducer(IHttpClientFactory factory, string clientName)
        {
            _factory = factory;
            _clientName = clientName;
        }

        public HttpClient CreateClient()
        {
            HttpClient httpClient = _factory.CreateClient(_clientName);

            httpClient.DefaultRequestHeaders.Add("User-Agent", "BlueConnect/3.2.1");
            httpClient.DefaultRequestHeaders.Add("Accept-Language", "en-DK;q=1.0, da-DK;q=0.9");
            httpClient.DefaultRequestHeaders.Add("Accept", "*/*");
            httpClient.BaseAddress = new Uri("https://api.riiotlabs.com/prod/");

            return httpClient;
        }
    }
}