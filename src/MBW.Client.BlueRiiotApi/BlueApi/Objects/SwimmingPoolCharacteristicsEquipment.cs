using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.Objects
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
    }
}