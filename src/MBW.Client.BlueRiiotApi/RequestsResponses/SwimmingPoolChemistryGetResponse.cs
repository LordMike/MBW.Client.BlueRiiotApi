using MBW.Client.BlueRiiotApi.Objects;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.RequestsResponses
{
    public class SwimmingPoolChemistryGetResponse
    {
        [JsonProperty("chemistry")]
        public SwimmingPoolChemistry Chemistry { get; set; }
    }
}