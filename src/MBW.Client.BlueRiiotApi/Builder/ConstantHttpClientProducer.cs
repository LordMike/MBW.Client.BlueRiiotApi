using System;
using System.Net.Http;

namespace MBW.Client.BlueRiiotApi.Builder
{
    internal class ConstantHttpClientProducer : IHttpClientProducer
    {
        private readonly HttpClient _httpClient;

        public ConstantHttpClientProducer(HttpClient httpClient)
        {
            _httpClient = httpClient;

            _httpClient.DefaultRequestHeaders.Add("User-Agent", "BlueConnect/3.2.1");
            _httpClient.DefaultRequestHeaders.Add("Accept-Language", "en-DK;q=1.0, da-DK;q=0.9");
            _httpClient.DefaultRequestHeaders.Add("Accept", "*/*");
            _httpClient.BaseAddress = new Uri("https://api.riiotlabs.com/prod/");
        }

        public HttpClient CreateClient()
        {
            return _httpClient;
        }
    }
}