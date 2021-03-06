﻿using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwimmingPoolCharacteristicsSanitizer
    {
        [JsonProperty("advised_max_salt_ppm")]
        public float AdvisedMaxSaltPpm { get; set; }

        [JsonProperty("advised_min_salt_ppm")]
        public float AdvisedMinSaltPpm { get; set; }

        [JsonProperty("advised_salt_ppm")]
        public float AdvisedSaltPpm { get; set; }

        [JsonProperty("chemical_other")]
        public string ChemicalOther { get; set; }

        [JsonProperty("chemical")]
        public string Chemical { get; set; }

        [JsonProperty("process")]
        public string Process { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}