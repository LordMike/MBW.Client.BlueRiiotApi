using System;
using System.Collections.Generic;
using MBW.Client.BlueRiiotApi.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class TimeRange
    {
        [JsonProperty("start")]
        [JsonConverter(typeof(TimeSpanDatedConverter))]
        public TimeSpan Start { get; set; }

        [JsonProperty("end")]
        [JsonConverter(typeof(TimeSpanDatedConverter))]
        public TimeSpan End { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}