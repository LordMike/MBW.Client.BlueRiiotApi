using System;
using System.Net;
using System.Net.Http;

namespace MBW.Client.BlueRiiotApi.BlueApi
{
    public abstract class BlueClientBase
    {
        private readonly HttpClient _http;

        public BlueClientBase()
        {
            _http = new HttpClient(new HttpClientHandler()
            {
                Proxy = new WebProxy(new Uri("http://127.0.0.1:8888"))
            });

            // TODO: Support UA with spaces: "Blue Connect/3.2.1 (com.riiotlabs.blue; build:200319.2397; iOS 13.3.1) Alamofire/4.9.1"
            _http.DefaultRequestHeaders.Add("User-Agent", "BlueConnect/3.2.1");
            _http.DefaultRequestHeaders.Add("Accept-Language", "en-DK;q=1.0, da-DK;q=0.9");
            _http.DefaultRequestHeaders.Add("Accept", "*/*");

            _http.BaseAddress = new Uri("https://api.riiotlabs.com/prod/");
        }

        protected HttpClient GetHttpClient()
        {
            // TODO: Support http factory
            return _http;
        }
    }
}