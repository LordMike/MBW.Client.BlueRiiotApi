using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SigfoxRc
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }
}