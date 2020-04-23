using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi
{
    public abstract class BlueClientBase
    {
        private readonly HttpClient _http;
        private readonly JsonSerializer _serializer;
        private readonly Encoding _encoding = new UTF8Encoding(false);

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

            _serializer = new JsonSerializer();
        }

        protected T Parse<T>(Stream stream)
        {
            using (var sr = new StreamReader(stream, _encoding, false, 4096, true))
            using (var jr = new JsonTextReader(sr))
                return _serializer.Deserialize<T>(jr);
        }

        protected HttpClient GetHttpClient()
        {
            // TODO: Support http factory
            return _http;
        }
    }
}