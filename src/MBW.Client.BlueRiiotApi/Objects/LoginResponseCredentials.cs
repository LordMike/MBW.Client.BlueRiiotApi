using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
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

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}