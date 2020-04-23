using System;
using System.Collections.Generic;
using MBW.Client.BlueRiiotApi.BlueApi.Objects;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.BlueApi.RequestsResponses
{
    public class SwimmingPoolStatusGetResponse
    {
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("global_status_code")]
        public string GlobalStatusCode { get; set; }

        [JsonProperty("status_id")]
        public string StatusId { get; set; }

        [JsonProperty("swimming_pool_name")]
        public string SwimmingPoolName { get; set; }

        [JsonProperty("since")]
        public DateTime Since { get; set; }

        [JsonProperty("swimming_pool_id")]
        public string SwimmingPoolId { get; set; }

        [JsonProperty("tasks")]
        public List<SwimmingPoolTask> Tasks { get; set; }

        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        [JsonProperty("last_notif_date")]
        public DateTime LastNotifDate { get; set; }
    }
}