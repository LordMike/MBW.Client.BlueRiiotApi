using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}