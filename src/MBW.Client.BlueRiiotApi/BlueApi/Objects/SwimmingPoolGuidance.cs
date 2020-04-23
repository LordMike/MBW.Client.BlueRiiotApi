using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.Objects
{
    public class SwimmingPoolGuidance
    {
        [JsonProperty("bottom_links")]
        public List<SwimmingPoolGuidanceBottomLink> BottomLinks { get; set; }

        [JsonProperty("buy_process")]
        public string BuyProcess { get; set; }

        [JsonProperty("expiration_time")]
        public DateTime? ExpirationTime { get; set; }

        [JsonProperty("faulty_data")]
        public string FaultyData { get; set; }

        [JsonProperty("issue_to_fix")]
        public SwimmingPoolGuidanceIssueToFix IssueToFix { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("missing_config")]
        public string MissingConfig { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("suggested_cart_item")]
        public CartItem SuggestedCartItem { get; set; }

        [JsonProperty("swimming_pool_id")]
        public string SwimmingPoolId { get; set; }

        [JsonProperty("swp_global_status")]
        public string SwpGlobalStatus { get; set; }

        [JsonProperty("water_temperature_status")]
        public string WaterTemperatureStatus { get; set; }
    }
}