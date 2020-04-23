using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwpMeasureRange
    {
        [JsonProperty("custom_applied")]
        public bool CustomApplied { get; set; }

        [JsonProperty("ideal")]
        public float Ideal { get; set; }

        [JsonProperty("max")]
        public float Max { get; set; }

        [JsonProperty("min")]
        public float Min { get; set; }
    }
}