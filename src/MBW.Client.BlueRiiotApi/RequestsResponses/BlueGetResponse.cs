using System;
using MBW.Client.BlueRiiotApi.Objects;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.RequestsResponses
{
    /// <summary>
    /// Note: This object is near identical to <see cref="BlueDeviceFromDevicesList"/>
    /// </summary>
    public class BlueGetResponse
    {
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
        
        [JsonProperty("contract_isMarketPlaceEligible")]
        public bool ContractIsMarketPlaceEligible { get; set; }
        
        [JsonProperty("fw_version_psoc")]
        public string FwVersionPsoc { get; set; }
        
        [JsonProperty("hw_generation")]
        public int HwGeneration { get; set; }
        
        [JsonProperty("hw_has_screw")]
        public bool HwHasScrew { get; set; }
        
        [JsonProperty("hw_product_name")]
        public string HwProductName { get; set; }
        
        [JsonProperty("hw_product_pack")]
        public string HwProductPack { get; set; }
        
        [JsonProperty("hw_product_type")]
        public string HwProductType { get; set; }

        [JsonProperty("hw_sf_country")]
        public string HwSfCountry { get; set; }

        [JsonProperty("hw_sf_zone")]
        public string HwSfZone { get; set; }
        
        [JsonProperty("reseller_channel")]
        public string ResellerChannel { get; set; }

        [JsonProperty("serial")]
        public string Serial { get; set; }
        
        [JsonProperty("SN")]
        public string Sn { get; set; }
        
        [JsonProperty("state")]
        public SleepStateObject SleepState { get; set; }
        
        [JsonProperty("last_measure_ble")]
        public DateTime? LastMeasureBle { get; set; }
        
        [JsonProperty("last_measure_sigfox")]
        public DateTime? LastMeasureSigfox { get; set; }
    }
}