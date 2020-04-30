using MBW.Client.BlueRiiotApi.Objects;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.RequestsResponses
{
    public class BlueCompatibilityGetResponse
    {
        [JsonProperty("serial")]
        public string Serial { get; set; }
        
        [JsonProperty("sigfox")]
        public BlueCompatibilitySigfox Sigfox { get; set; }
    }
}