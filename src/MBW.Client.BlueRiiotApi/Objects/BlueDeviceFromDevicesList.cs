using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    /// <summary>
    /// Note: This object is slightly different, depending on where you get the BlueDevice from
    /// </summary>
    public class BlueDeviceFromDevicesList
    {
        [JsonProperty("battery_low")]
        public bool BatteryLow { get; set; }

        [JsonProperty("contract_servicePlan")]
        public string ContractServicePlan { get; set; }
        
        [JsonProperty("contract_isSwaUs")]
        public bool ContractIsSwaUs { get; set; }
        
        [JsonProperty("contract_isGo")]
        public bool ContractIsGo { get; set; }
        
        [JsonProperty("contract_isBasic")]
        public bool ContractIsBasic { get; set; }
        
        [JsonProperty("contract_isVpcEligible")]
        public bool ContractIsVpcEligible { get; set; }
        
        [JsonProperty("fs_sigfox_enabled")]
        public bool FsSigfoxEnabled { get; set; }

        [JsonProperty("fs_beacon_enabled")]
        public bool FsBeaconEnabled { get; set; }

        [JsonProperty("fw_version_history")]
        public List<FirmwareVersionHistory> FwVersionHistory { get; set; }
        
        [JsonProperty("fw_version_psoc")]
        public string FwVersionPsoc { get; set; }
        
        [JsonProperty("hw_type")]
        public string HwType { get; set; }
        
        [JsonProperty("hw_generation")]
        public int HwGeneration { get; set; }
        
        [JsonProperty("hw_bundle_extender")]
        public bool HwBundleExtender { get; set; }
        
        [JsonProperty("hw_color")]
        public string HwColor { get; set; }
        
        [JsonProperty("hw_region")]
        public string HwRegion { get; set; }

        [JsonProperty("production_datetime")]
        public DateTime ProductionDatetime { get; set; }

        [JsonProperty("serial")]
        public string Serial { get; set; }
        
        [JsonProperty("sf_rc")]
        public string SfRc { get; set; }
        
        [JsonProperty("sf_rc_country")]
        public string SfRcCountry { get; set; }
        
        [JsonProperty("SN")]
        public string Sn { get; set; }
        
        [JsonProperty("sleep_state")]
        public string SleepState { get; set; }
        
        [JsonProperty("wake_period")]
        public int WakePeriod { get; set; }
        
        [JsonProperty("last_hello_message_v")]
        public DateTime? LastHelloMessageV { get; set; }
        
        [JsonProperty("last_measure_message")]
        public DateTime? LastMeasureMessage { get; set; }
        
        [JsonProperty("last_measure_message_ble")]
        public DateTime? LastMeasureMessageBle { get; set; }
        
        [JsonProperty("last_measure_message_sigfox")]
        public DateTime? LastMeasureMessageSigfox { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}