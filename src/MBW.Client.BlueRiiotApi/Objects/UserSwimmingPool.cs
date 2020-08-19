using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class UserSwimmingPool
    {
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("swimming_pool_id")]
        public string SwimmingPoolId { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("swimming_pool")]
        public SwimmingPool SwimmingPool { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}