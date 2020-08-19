using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwimmingPoolCharacteristicsEquipment
    {
        [JsonProperty("heatings")]
        public string[] Heatings { get; set; }

        [JsonProperty("protections")]
        public string[] Protections { get; set; }

        [JsonProperty("cleanings")]
        public string[] Cleanings { get; set; }

        [JsonProperty("filtrations")]
        public string[] Filtrations { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}