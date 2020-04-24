using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MBW.Client.BlueRiiotApi.Builder
{
    internal interface IRequestSigner
    {
        Task LoginIfNeeded(BlueClient client, CancellationToken token = default);

        Task Sign(HttpClient httpClient, HttpRequestMessage request, CancellationToken token = default);
    }
}