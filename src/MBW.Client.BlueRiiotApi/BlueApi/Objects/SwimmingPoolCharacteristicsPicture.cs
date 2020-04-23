using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.Objects
{
    public class SwimmingPoolCharacteristicsPicture
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
}