using System;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class FirmwareVersionHistory
    {
        [JsonProperty("fw_version_psoc")]
        public string FwVersionPsoc { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }
    }
}