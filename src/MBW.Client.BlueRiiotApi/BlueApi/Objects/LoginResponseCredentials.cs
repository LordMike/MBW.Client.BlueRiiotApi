using System;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.Objects
{
    public class LoginResponseCredentials
    {
        [JsonProperty("access_key")]
        public string AccessKey { get; set; }

        [JsonProperty("secret_key")]
        public string SecretKey { get; set; }

        [JsonProperty("session_token")]
        public string SessionToken { get; set; }

        [JsonProperty("expiration")]
        public DateTime Expiration { get; set; }
    }
}