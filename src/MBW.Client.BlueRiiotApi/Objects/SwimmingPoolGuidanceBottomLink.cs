using Newtonsoft.Json;

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
    }
}