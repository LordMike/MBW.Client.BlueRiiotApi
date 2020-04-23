using System.Collections.Generic;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.Objects
{
    public class SwimmingPoolChemistry
    {
        [JsonProperty("activeChemicalPackId")]
        public string ActiveChemicalPackId { get; set; }

        [JsonProperty("canSelectChemicalPack")]
        public bool CanSelectChemicalPack { get; set; }

        [JsonProperty("availableChemicalPacks")]
        public List<SwimmingPoolChemistryChemicalPack> AvailableChemicalPacks { get; set; }
    }
}