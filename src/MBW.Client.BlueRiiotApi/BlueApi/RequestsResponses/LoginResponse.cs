using MBW.Client.BlueRiiotApi.BlueApi.Objects;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.RequestsResponses
{
    public class LoginResponse
    {
        [JsonProperty("identity_id")]
        public string IdentityId { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("credentials")]
        public LoginResponseCredentials Credentials { get; set; }
    }
}