using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwimmingPoolTask
    {
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("done")]
        public bool Done { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("swimming_pool_id")]
        public string SwimmingPoolId { get; set; }

        [JsonProperty("status_id")]
        public string StatusId { get; set; }

        [JsonProperty("task_identifier")]
        public string TaskIdentifier { get; set; }

        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}