using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.Objects
{
    public class SwimmingPoolCharacteristicsConfiguration
    {
        [JsonProperty("construction_year")]
        public int ConstructionYear { get; set; }

        [JsonProperty("kind")]
        public ModelKind Kind { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("protection")]
        public string Protection { get; set; }

        [JsonProperty("surface")]
        public string Surface { get; set; }

        [JsonProperty("_type")]
        public ModelType Type { get; set; }

        [JsonProperty("waterproofing")]
        public Waterproofing Waterproofing { get; set; }
    }
}