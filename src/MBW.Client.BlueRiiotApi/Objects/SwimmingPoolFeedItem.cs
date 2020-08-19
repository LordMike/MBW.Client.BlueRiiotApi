using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwimmingPoolFeedItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}