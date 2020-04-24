using System.Net.Http;

namespace MBW.Client.BlueRiiotApi.Builder
{
    internal interface IHttpClientProducer
    {
        HttpClient CreateClient();
    }
}