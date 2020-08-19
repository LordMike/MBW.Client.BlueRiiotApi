using System.Collections.Generic;
using MBW.Client.BlueRiiotApi.Objects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.RequestsResponses
{
    public class SwimmingPoolGetResponse
    {
        [JsonProperty("data")]
        public List<UserSwimmingPool> Data { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}