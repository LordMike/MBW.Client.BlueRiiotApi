using System.Collections.Generic;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.Objects
{
    public class SwimmingPoolChemistryChemicalPackProduct
    {
        [JsonProperty("additional_info")]
        public string AdditionalInfo { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("img_banner")]
        public string ImgBanner { get; set; }

        [JsonProperty("img_logo")]
        public string ImgLogo { get; set; }

        [JsonProperty("references")]
        public List<SwimmingPoolChemistryChemicalPackProductReferencesItem> References { get; set; }
    }
}