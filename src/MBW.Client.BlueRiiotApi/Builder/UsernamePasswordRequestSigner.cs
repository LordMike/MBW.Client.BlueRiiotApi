using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using AwsSignatureVersion4.Private;
using MBW.Client.BlueRiiotApi.Objects;
using MBW.Client.BlueRiiotApi.RequestsResponses;

namespace MBW.Client.BlueRiiotApi.Builder
{
    internal class UsernamePasswordRequestSigner : IRequestSigner
    {
        private readonly string _username;
        private readonly string _password;
        private LoginResponseCredentials _creds;
        private ImmutableCredentials _immutableCredentials;

        public UsernamePasswordRequestSigner(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public async Task LoginIfNeeded(BlueClient client, CancellationToken token = default)
        {
            if (_creds != null && DateTime.UtcNow < _creds.Expiration.AddMinutes(-5))
                return;

            // Re-login
            LoginResponse credentials = await client.LoginWithUsernamePassword(_username, _password, token);

            _creds = credentials.Credentials;
            _immutableCredentials = new ImmutableCredentials(_creds.AccessKey, _creds.SecretKey, _creds.SessionToken);
        }

        public async Task Sign(HttpClient httpClient, HttpRequestMessage request, CancellationToken token = default)
        {
            await Signer.SignAsync(httpClient, request, DateTime.UtcNow, "eu-west-1", "execute-api", _immutableCredentials);
        }
    }
}