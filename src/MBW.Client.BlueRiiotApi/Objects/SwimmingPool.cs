using System;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwimmingPool
    {
        [JsonProperty("characteristics")]
        public SwimmingPoolCharacteristics Characteristics { get; set; }

        [JsonProperty("chemical")]
        public SwimmingPoolChemical Chemical { get; set; }

        [JsonProperty("chemistry")]
        public SwimmingPoolChemistry Chemistry { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("custom_settings")]
        public SwimmingPoolCustomSettings CustomSettings { get; set; }

        [JsonProperty("data_default")]
        public SwimmingPoolDataDefault DataDefault { get; set; }

        [JsonProperty("data_validation")]
        public SwimmingPoolDataValidation DataValidation { get; set; }

        [JsonProperty("favourite_vendor_id")]
        public string FavouriteVendorId { get; set; }

        [JsonProperty("media_uri")]
        public string MediaUri { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("strip_brand_id")]
        public string StripBrandId { get; set; }

        [JsonProperty("swimming_pool_id")]
        public string SwimmingPoolId { get; set; }

        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        [JsonProperty("user_access")]
        public SwimmingPoolUserAccess UserAccess { get; set; }

        [JsonProperty("sigfox_global_coverage")]
        public SigfoxCoverage SigfoxGlobalCoverage { get; set; }
    }
}