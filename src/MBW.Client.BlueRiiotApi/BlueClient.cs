using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Amazon.Runtime;
using AwsSignatureVersion4.Private;
using Genbox.SimpleS3.Core;
using Genbox.SimpleS3.Core.Abstracts.Enums;
using Genbox.SimpleS3.Core.Authentication;
using MBW.Client.BlueRiiotApi.Objects;
using MBW.Client.BlueRiiotApi.Other;
using MBW.Client.BlueRiiotApi.RequestsResponses;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using HttpMethod = System.Net.Http.HttpMethod;

namespace MBW.Client.BlueRiiotApi
{
    public class BlueClient : BlueClientBase
    {
        private readonly string _token;
        private readonly string _awsKey;
        private readonly string _awsSecret;

        public BlueClient(LoginResponse credentials)
        {
            _awsKey = credentials.Credentials.AccessKey;
            _awsSecret = credentials.Credentials.SecretKey;
            _token = credentials.Credentials.SessionToken;
        }

        private void GenboxSign(HttpRequestMessage request)
        {
            var opts = Options.Create(new S3Config(new StringAccessKey(_awsKey, _awsSecret), AwsRegion.EuWest1));

            var sigBuilder = new SignatureBuilder(new SigningKeyBuilder(opts, NullLogger<SigningKeyBuilder>.Instance),
                new ScopeBuilder(opts), NullLogger<SignatureBuilder>.Instance, opts);

            byte[] sig = sigBuilder.CreateSignature(new DummyRequest(request));
        }

        private async Task Sign(HttpRequestMessage request)
        {
            request.AddHeader("User-Agent", "BlueConnect/3.2.1");
            //.Headers.TryAddWithoutValidation("User-Agent", "Blue Connect/3.2.1 (com.riiotlabs.blue; build:200319.2397; iOS 13.3.1) Alamofire/4.9.1");

            var res = await Signer.SignAsync(GetHttpClient(), request, DateTime.UtcNow, "eu-west-1", "execute-api",
                new ImmutableCredentials(_awsKey, _awsSecret, _token));


        }

        private async Task<TResponse> PerformGet<TResponse>(string path, CancellationToken token) where TResponse : class
        {
            using HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, path);

            await Sign(req);

            using var resp = await GetHttpClient().SendAsync(req, HttpCompletionOption.ResponseContentRead, token);

            if (resp.Content.Headers.ContentType.MediaType != "application/json")
                throw new Exception($"API request did not result in a Json object. Path: '{path}'.");

            JObject obj = Parse<JObject>(await resp.Content.ReadAsStreamAsync());

            if (obj.ContainsKey("errorMessage") && obj.ContainsKey("errorType"))
            {
                // This is an error, regardless of what the status code is
                throw new Exception($"API responded with an error: {obj.Value<string>("errorMessage")}. Path: '{path}'.");
            }

            if (resp.StatusCode == HttpStatusCode.OK)
                return obj.ToObject<TResponse>();

            // Something is wrong, try fetching a message
            if (obj.TryGetValue("errorMessage", out var errorMsg) || obj.TryGetValue("message", out errorMsg))
                throw new Exception($"API resulted in a non-success status code. Message: {errorMsg}. Path: '{path}'.");

            throw new Exception($"API resulted in a non-success status code. No futher details available. Path: '{path}'.");
        }

        public async Task<SwimmingPoolGetResponse> GetSwimmingPools(bool deleted = false, CancellationToken token = default)
        {
            return await PerformGet<SwimmingPoolGetResponse>("swimming_pool?deleted=" + (deleted ? "true" : "false"), token);
        }

        public async Task<SwimmingPool> GetSwimmingPool(string poolId, CancellationToken token = default)
        {
            return await PerformGet<SwimmingPool>($"swimming_pool/{HttpUtility.UrlEncode(poolId)}", token);
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