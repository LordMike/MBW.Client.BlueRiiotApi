using System;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.Objects
{
    public class SwimmingPoolGuidanceHistoryItem
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }

        [JsonProperty("end_reason")]
        public string EndReason { get; set; }

        [JsonProperty("task_action")]
        public string TaskAction { get; set; }

        [JsonProperty("task_description")]
        public string TaskDescription { get; set; }

        [JsonProperty("task_identifier")]
        public string TaskIdentifier { get; set; }

        [JsonProperty("value_after")]
        public float ValueAfter { get; set; }

        [JsonProperty("value_before")]
        public float ValueBefore { get; set; }
    }
}