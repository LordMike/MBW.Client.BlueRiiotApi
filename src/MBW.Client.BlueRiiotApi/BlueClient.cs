using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using MBW.Client.BlueRiiotApi.Builder;
using MBW.Client.BlueRiiotApi.Helpers;
using MBW.Client.BlueRiiotApi.Objects;
using MBW.Client.BlueRiiotApi.Objects.Enums;
using MBW.Client.BlueRiiotApi.RequestsResponses;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using HttpMethod = System.Net.Http.HttpMethod;

namespace MBW.Client.BlueRiiotApi
{
    public class BlueClient
    {
        private readonly ILogger<BlueClient> _logger;
        private readonly IHttpClientProducer _httpClientProducer;
        private readonly IRequestSigner _requestSigner;
        private readonly JsonSerializer _serializer;
        private readonly Encoding _encoding = new UTF8Encoding(false);

        internal BlueClient(ILogger<BlueClient> logger, IHttpClientProducer httpClientProducer, IRequestSigner requestSigner)
        {
            _logger = logger;
            _httpClientProducer = httpClientProducer;
            _requestSigner = requestSigner;
            _serializer = JsonSerializer.Create(new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
        }

        private T Parse<T>(Stream stream)
        {
            using (StreamReader sr = new StreamReader(stream, _encoding, false, 4096, true))
            using (JsonTextReader jr = new JsonTextReader(sr))
                return _serializer.Deserialize<T>(jr);
        }

        private Task<TResponse> PerformGet<TResponse>(string path, CancellationToken token) where TResponse : class
        {
            return PerformHttp<object, TResponse>(path, HttpMethod.Get, null, token);
        }

        private Task<TResponse> PerformPut<TRequest, TResponse>(string path, TRequest request, CancellationToken token) where TResponse : class
        {
            return PerformHttp<TRequest, TResponse>(path, HttpMethod.Put, request, token);
        }

        private Task<TResponse> PerformPost<TRequest, TResponse>(string path, TRequest request, CancellationToken token) where TResponse : class
        {
            return PerformHttp<TRequest, TResponse>(path, HttpMethod.Post, request, token);
        }

        private async Task<TResponse> PerformHttp<TRequest, TResponse>(string path, HttpMethod method, TRequest requestBody, CancellationToken token) where TResponse : class
        {
            HttpClient httpClient = _httpClientProducer.CreateClient();

            using HttpRequestMessage req = new HttpRequestMessage(method, path);

            if (requestBody != null)
                req.Content = new JsonContent<TRequest>(_serializer, requestBody);

            // Login if needed, then sign the request
            await _requestSigner.LoginIfNeeded(this, token);
            await _requestSigner.Sign(httpClient, req, token);

            // Issue the request
            using HttpResponseMessage resp = await httpClient.SendAsync(req, HttpCompletionOption.ResponseContentRead, token);

            if (resp.Content.Headers.ContentType.MediaType != "application/json")
                throw new Exception($"API request did not result in a Json object. Path: '{path}'.");

            if (_logger.IsEnabled(LogLevel.Trace))
            {
                // Log request / Response
                // Note: It should be fine to read the content twice, as HttpCompletionOption.ResponseContentRead is set
                string responseBody = await resp.Content.ReadAsStringAsync();

                _logger.LogTrace("Received {Code} for {Path}, with body: {Body}", resp.StatusCode, req.RequestUri, responseBody);
            }

            JObject obj = Parse<JObject>(await resp.Content.ReadAsStreamAsync());

            if (obj.ContainsKey("errorMessage")/* && obj.ContainsKey("errorType")*/)
            {
                // This is an error, regardless of what the status code is
                throw new Exception($"API responded with an error: {obj.Value<string>("errorMessage")}. Path: '{path}'.");
            }

            if (resp.StatusCode == HttpStatusCode.OK)
                return obj.ToObject<TResponse>();

            // Something is wrong, try fetching a message
            if (obj.TryGetValue("errorMessage", out JToken errorMsg) || obj.TryGetValue("message", out errorMsg))
                throw new Exception($"API resulted in a non-success status code. Message: {errorMsg}. Path: '{path}'.");

            throw new Exception($"API resulted in a non-success status code. No futher details available. Path: '{path}'.");
        }

        internal async Task<LoginResponse> LoginWithUsernamePassword(string email, string password, CancellationToken token = default)
        {
            HttpClient httpClient = _httpClientProducer.CreateClient();

            using HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Post, "user/login");

            req.Content = new StringContent(JsonConvert.SerializeObject(new
            {
                email,
                password
            }));

            using HttpResponseMessage resp = await httpClient.SendAsync(req, HttpCompletionOption.ResponseContentRead, token);

            resp.EnsureSuccessStatusCode();

            LoginResponse loginResponse = Parse<LoginResponse>(await resp.Content.ReadAsStreamAsync());

            return loginResponse;
        }

        public async Task<UserGetResponse> GetUser(CancellationToken token = default)
        {
            return await PerformGet<UserGetResponse>("user", token);
        }

        public async Task<BluesGetResponse> GetBlues(HwProductType productType, CancellationToken token = default)
        {
            if (productType == HwProductType.unknown)
                return await PerformGet<BluesGetResponse>("blue", token);

            return await PerformGet<BluesGetResponse>($"blue?blueProductType={productType}", token);
        }

        public async Task<BlueGetResponse> GetBlue(string serial, CancellationToken token = default)
        {
            return await PerformGet<BlueGetResponse>($"blue/{serial}", token);
        }

        public async Task<SwimmingPoolLastMeasurementsGetResponse> GetBlueLastMeasurements(string poolId, string serial, string mode = "blue_and_strip", CancellationToken token = default)
        {
            return await PerformGet<SwimmingPoolLastMeasurementsGetResponse>($"swimming_pool/{HttpUtility.UrlEncode(poolId)}/blue/{HttpUtility.UrlEncode(serial)}/lastMeasurements?mode={HttpUtility.UrlEncode(mode)}", token);
        }

        public async Task<BlueReleaseLastUnprocessedEventResponse> BlueReleaseLastUnprocessedEvent(string serial, CancellationToken token = default)
        {
            return await PerformPost<object, BlueReleaseLastUnprocessedEventResponse>($"blue/{serial}/releaseLastUnprocessedEvent", null, token);
        }

        public async Task<BlueCompatibilityGetResponse> GetBlueCompatibility(string serial, CancellationToken token = default)
        {
            return await PerformGet<BlueCompatibilityGetResponse>($"blue/{serial}/compatibility", token);
        }

        public async Task<SwimmingPoolGetResponse> GetSwimmingPools(bool deleted = false, CancellationToken token = default)
        {
            return await PerformGet<SwimmingPoolGetResponse>("swimming_pool?deleted=" + (deleted ? "true" : "false"), token);
        }

        public async Task<SwimmingPool> GetSwimmingPool(string poolId, CancellationToken token = default)
        {
            return await PerformGet<SwimmingPool>($"swimming_pool/{HttpUtility.UrlEncode(poolId)}", token);
        }

        public async Task<SwimmingPool> PutSwimmingPool(string poolId, SwimmingPool swimmingPool, CancellationToken token = default)
        {
            return await PerformPut<SwimmingPool, SwimmingPool>($"swimming_pool/{HttpUtility.UrlEncode(poolId)}", swimmingPool, token);
        }

        public async Task<SwimmingPoolFeedGetResponse> GetSwimmingPoolFeed(string poolId, string lang = null, CancellationToken token = default)
        {
            return await PerformGet<SwimmingPoolFeedGetResponse>($"swimming_pool/{HttpUtility.UrlEncode(poolId)}/feed?lang={HttpUtility.UrlEncode(lang)}", token);
        }

        public async Task<SwimmingPoolLastMeasurementsGetResponse> GetSwimmingPoolLastMeasurements(string poolId, CancellationToken token = default)
        {
            return await PerformGet<SwimmingPoolLastMeasurementsGetResponse>($"swimming_pool/{HttpUtility.UrlEncode(poolId)}/lastMeasurements", token);
        }

        public async Task<SwimmingPoolStatusGetResponse> GetSwimmingPoolStatus(string poolId, CancellationToken token = default)
        {
            return await PerformGet<SwimmingPoolStatusGetResponse>($"swimming_pool/{HttpUtility.UrlEncode(poolId)}/status", token);
        }

        public async Task<SwimmingPoolStatusTaskGetResponse> GetSwimmingPoolStatusTask(string poolId, string taskId, CancellationToken token = default)
        {
            return await PerformGet<SwimmingPoolStatusTaskGetResponse>($"swimming_pool/{HttpUtility.UrlEncode(poolId)}/status/{HttpUtility.UrlEncode(taskId)}", token);
        }

        public async Task<SwimmingPoolBlueDevicesGetResponse> GetSwimmingPoolBlueDevices(string poolId, CancellationToken token = default)
        {
            return await PerformGet<SwimmingPoolBlueDevicesGetResponse>($"swimming_pool/{HttpUtility.UrlEncode(poolId)}/blue", token);
        }

        public async Task<SwimmingPoolChemistryGetResponse> GetSwimmingPoolChemistry(string poolId, CancellationToken token = default)
        {
            return await PerformGet<SwimmingPoolChemistryGetResponse>($"swimming_pool/{HttpUtility.UrlEncode(poolId)}/chemistry", token);
        }

        public async Task<SwimmingPoolGuidanceGetResponse> GetSwimmingPoolGuidance(string poolId, string lang = null, string mode = "interactive_v03", CancellationToken token = default)
        {
            return await PerformGet<SwimmingPoolGuidanceGetResponse>($"swimming_pool/{HttpUtility.UrlEncode(poolId)}/guidance?lang={HttpUtility.UrlEncode(lang)}&mode={HttpUtility.UrlEncode(mode)}", token);
        }

        public async Task<SwimmingPoolGuidanceHistoryGetResponse> GetSwimmingPoolGuidanceHistory(string poolId, string lang = null, CancellationToken token = default)
        {
            return await PerformGet<SwimmingPoolGuidanceHistoryGetResponse>($"swimming_pool/{HttpUtility.UrlEncode(poolId)}/guidance/history?lang={HttpUtility.UrlEncode(lang)}", token);
        }

        public async Task<SwimmingPoolWeatherGetResponse> GetSwimmingPoolWeather(string poolId, string lang = null, CancellationToken token = default)
        {
            return await PerformGet<SwimmingPoolWeatherGetResponse>($"swimming_pool/{HttpUtility.UrlEncode(poolId)}/weather?lang={HttpUtility.UrlEncode(lang)}", token);
        }

        public async Task<SwimmingPoolWeatherForecastGetResponse> GetSwimmingPoolWeatherForecast(string poolId, DateTime startDate, string lang = null, CancellationToken token = default)
        {
            return await PerformGet<SwimmingPoolWeatherForecastGetResponse>($"swimming_pool/{HttpUtility.UrlEncode(poolId)}/weather/forecast?startDate={startDate.ToUniversalTime():yyyy-MM-dd'T'HH:mm:ss'Z'}&lang={HttpUtility.UrlEncode(lang)}", token);
        }
    }
}