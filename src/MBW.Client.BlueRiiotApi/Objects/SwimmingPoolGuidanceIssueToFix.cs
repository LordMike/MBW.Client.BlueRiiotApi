using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwimmingPoolGuidanceIssueToFix
    {
        [JsonProperty("action_title")]
        public string ActionTitle { get; set; }

        [JsonProperty("current_value")]
        public float CurrentValue { get; set; }

        [JsonProperty("ideal_value")]
        public float IdealValue { get; set; }

        [JsonProperty("info")]
        public List<SwimmingPoolGuidanceStep> Info { get; set; }

        [JsonProperty("issue_title")]
        public string IssueTitle { get; set; }

        [JsonProperty("pool_volume")]
        public float PoolVolume { get; set; }

        [JsonProperty("poststeps")]
        public List<SwimmingPoolGuidanceStep> Poststeps { get; set; }

        [JsonProperty("products")]
        public List<SwimmingPoolGuidanceIssueToFixProduct> Products { get; set; }

        [JsonProperty("steps")]
        public List<SwimmingPoolGuidanceStep> Steps { get; set; }

        [JsonProperty("task_identifier")]
        public string TaskIdentifier { get; set; }

        [JsonProperty("user_action")]
        public string UserAction { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}