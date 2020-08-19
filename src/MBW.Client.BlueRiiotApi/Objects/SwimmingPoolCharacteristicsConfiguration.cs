using System.Collections.Generic;
using MBW.Client.BlueRiiotApi.Objects.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
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

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}