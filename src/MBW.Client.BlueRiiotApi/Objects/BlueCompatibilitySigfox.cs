using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class BlueCompatibilitySigfox
    {
        [JsonProperty("regions")]
        public SigfoxRc[] Regions { get; set; }

        [JsonProperty("countries")]
        public BlueCompatibilitySigfoxCountry[] Countries { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}