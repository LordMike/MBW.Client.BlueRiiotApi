using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SleepStateObject
    {
        [JsonProperty("sleep_state")]
        public string SleepState { get; set; }
    }
}