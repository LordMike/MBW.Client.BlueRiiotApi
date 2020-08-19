using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwimmingPoolChemistry
    {
        [JsonProperty("activeChemicalPackId")]
        public string ActiveChemicalPackId { get; set; }

        [JsonProperty("canSelectChemicalPack")]
        public bool CanSelectChemicalPack { get; set; }

        [JsonProperty("availableChemicalPacks")]
        public List<SwimmingPoolChemistryChemicalPack> AvailableChemicalPacks { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}