using MBW.Client.BlueRiiotApi.BlueApi.Objects;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.RequestsResponses
{
    public class SwimmingPoolChemistryGetResponse
    {
        [JsonProperty("chemistry")]
        public SwimmingPoolChemistry Chemistry { get; set; }
    }
}