using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwimmingPoolDataDefault
    {
        [JsonProperty("automation_targets")]
        public SwpAutomationTargets AutomationTargets { get; set; }

        [JsonProperty("measure_ranges")]
        public SwpMeasureRanges MeasureRanges { get; set; }
    }
}