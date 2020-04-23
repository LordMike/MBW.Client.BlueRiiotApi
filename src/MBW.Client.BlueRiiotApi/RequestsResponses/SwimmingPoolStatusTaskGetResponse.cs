using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.RequestsResponses
{
    public class SwimmingPoolStatusTaskGetResponse
    {
        [JsonProperty("html_data")]
        public string HtmlData { get; set; }
    }
}