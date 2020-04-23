using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwimmingPoolChemical
    {
        [JsonProperty("default_brand")]
        public string DefaultBrand { get; set; }
    }
}