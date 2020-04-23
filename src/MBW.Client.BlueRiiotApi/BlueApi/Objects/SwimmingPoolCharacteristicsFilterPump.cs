using System.Collections.Generic;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.Objects
{
    public class SwimmingPoolCharacteristicsFilterPump
    {
        [JsonProperty("is_present")]
        public bool IsPresent { get; set; }

        [JsonProperty("operating_hours")]
        public List<TimeRange> OperatingHours { get; set; }

        [JsonProperty("operating_type")]
        public string OperatingType { get; set; }
    }
}