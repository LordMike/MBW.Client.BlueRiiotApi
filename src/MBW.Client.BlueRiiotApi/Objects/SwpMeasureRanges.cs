using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwpMeasureRanges
    {
        [JsonProperty("ph")]
        public SwpMeasureRange Ph { get; set; }

        [JsonProperty("temperature")]
        public SwpMeasureRange Temperature { get; set; }

        [JsonProperty("orp")]
        public SwpMeasureRange Orp { get; set; }

        [JsonProperty("salinity")]
        public SwpMeasureRange Salinity { get; set; }

        [JsonProperty("conductivity")]
        public SwpMeasureRange Conductivity { get; set; }
    }
}