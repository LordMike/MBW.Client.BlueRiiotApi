using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwpMeasureRangeValidation
    {
        [JsonProperty("delta")]
        public float Delta { get; set; }

        [JsonProperty("max")]
        public float Max { get; set; }

        [JsonProperty("min")]
        public float Min { get; set; }
    }
}