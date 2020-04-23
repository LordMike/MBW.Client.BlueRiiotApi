using MBW.Client.BlueRiiotApi.Objects;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.RequestsResponses
{
    public class SwimmingPoolGuidanceGetResponse
    {
        [JsonProperty("guidance")]
        public SwimmingPoolGuidance Guidance { get; set; }

        [JsonProperty("vpc_sharing")]
        public SwimmingPoolVpcSharing VpcSharing { get; set; }
    }
}