using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class TimeRange
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }
}