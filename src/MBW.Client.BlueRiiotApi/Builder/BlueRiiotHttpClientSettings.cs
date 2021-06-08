using System;

namespace MBW.Client.BlueRiiotApi.Builder
{
    public class BlueRiiotHttpClientSettings
    {
        public Uri ServerUri { get; set; } = new Uri("https://api.riiotlabs.com/prod/");
    }
}