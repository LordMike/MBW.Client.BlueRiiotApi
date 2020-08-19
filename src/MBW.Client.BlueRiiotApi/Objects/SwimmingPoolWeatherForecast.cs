using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwimmingPoolWeatherForecast
    {
        [JsonProperty("temperature_max")]
        public float TemperatureMax { get; set; }

        [JsonProperty("temperature_min")]
        public float TemperatureMin { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("uv")]
        public float? Uv { get; set; }

        [JsonProperty("weather_code")]
        public float WeatherCode { get; set; }

        [JsonProperty("weather_description")]
        public string WeatherDescription { get; set; }

        [JsonProperty("weather_icon_code")]
        public string WeatherIconCode { get; set; }

        [JsonProperty("wind_direction")]
        public float WindDirection { get; set; }

        [JsonProperty("wind_speed")]
        public float WindSpeed { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtraProperties { get; set; }
    }
}