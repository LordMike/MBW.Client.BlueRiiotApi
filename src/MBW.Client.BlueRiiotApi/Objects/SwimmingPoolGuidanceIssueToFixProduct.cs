using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwimmingPoolGuidanceIssueToFixProduct
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("quantity")]
        public float Quantity { get; set; }

        [JsonProperty("ref_effect")]
        public float RefEffect { get; set; }

        [JsonProperty("ref_product_quantity")]
        public float RefProductQuantity { get; set; }

        [JsonProperty("ref_water_quantity")]
        public float RefWaterQuantity { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}