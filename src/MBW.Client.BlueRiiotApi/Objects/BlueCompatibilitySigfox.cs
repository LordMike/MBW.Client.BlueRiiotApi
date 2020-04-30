using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class BlueCompatibilitySigfox
    {
        [JsonProperty("regions")]
        public SigfoxRc[] Regions { get; set; }

        [JsonProperty("countries")]
        public BlueCompatibilitySigfoxCountry[] Countries { get; set; }
    }
}