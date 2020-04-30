using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class BlueCompatibilitySigfoxCountry
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("available")]
        public bool Available { get; set; }

        [JsonProperty("region")]
        public SigfoxRc Region { get; set; }
    }
}