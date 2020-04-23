using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using MBW.Client.BlueRiiotApi.RequestsResponses;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi
{
    public class BlueLoginClient : BlueClientBase
    {
        public async Task<LoginResponse> Login(string email, string password, CancellationToken token = default)
        {
            using HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Post, "user/login");

            req.Content = new StringContent(JsonConvert.SerializeObject(new
            {
                email,
                password
            }));

            using var resp = await GetHttpClient().SendAsync(req, HttpCompletionOption.ResponseContentRead, token);

            resp.EnsureSuccessStatusCode();

            return Parse<LoginResponse>(await resp.Content.ReadAsStreamAsync());
        }
    }
}