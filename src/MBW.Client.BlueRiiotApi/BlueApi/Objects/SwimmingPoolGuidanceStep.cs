using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.Objects
{
    public class SwimmingPoolGuidanceStep
    {
        [JsonProperty("action_button_label")]
        public string ActionButtonLabel { get; set; }

        [JsonProperty("action_title")]
        public string ActionTitle { get; set; }

        [JsonProperty("action_url")]
        public string ActionUrl { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}