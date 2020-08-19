using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwimmingPoolGuidanceBottomLink
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}