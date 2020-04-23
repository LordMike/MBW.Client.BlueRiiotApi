using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwpMeasureRangesValidation
    {
        [JsonProperty("orp")]
        public SwpMeasureRangeValidation Orp { get; set; }

        [JsonProperty("ph")]
        public SwpMeasureRangeValidation Ph { get; set; }

        [JsonProperty("salinity")]
        public SwpMeasureRangeValidation Salinity { get; set; }

        [JsonProperty("temperature")]
        public SwpMeasureRangeValidation Temperature { get; set; }
    }
}