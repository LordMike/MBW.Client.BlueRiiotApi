using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.Objects
{
    public class SwpAutomationTarget
    {
        [JsonProperty("custom_applied")]
        public bool CustomApplied { get; set; }

        [JsonProperty("repeat_too_high")]
        public bool RepeatTooHigh { get; set; }

        [JsonProperty("repeat_too_low")]
        public bool RepeatTooLow { get; set; }

        [JsonProperty("target")]
        public float Target { get; set; }
    }
}