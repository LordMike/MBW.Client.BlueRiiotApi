using MBW.Client.BlueRiiotApi.Objects;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.RequestsResponses
{
    public class SwimmingPoolWeatherGetResponse
    {
        [JsonProperty("data")]
        public SwimmingPoolWeather Data { get; set; }

        [JsonProperty("error_family")]
        public string ErrorFamily { get; set; }

        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("swimming_pool_id")]
        public string SwimmingPoolId { get; set; }
    }
}