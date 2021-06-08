using System;
using System.Net.Http;

namespace MBW.Client.BlueRiiotApi.Builder
{
    public static class BlueClientBuilderExtensions
    {
        public static BlueClientBuilder UseHttpClientFactory(this BlueClientBuilder builder, IHttpClientFactory factory, string clientName, BlueRiiotHttpClientSettings settings)
        {
            return builder.UseHttpClientProducer(new BlueRiiotHttpClientFactoryFactory(factory, clientName, settings));
        }

        public static BlueClientBuilder UseHttpClientFactory(this BlueClientBuilder builder, IHttpClientFactory factory, string clientName, Action<BlueRiiotHttpClientSettings> configureSettings)
        {
            BlueRiiotHttpClientSettings settings = new BlueRiiotHttpClientSettings();
            configureSettings?.Invoke(settings);

            return builder.UseHttpClientProducer(new BlueRiiotHttpClientFactoryFactory(factory, clientName, settings));
        }

        public static BlueClientBuilder UseHttpClientFactory(this BlueClientBuilder builder, IHttpClientFactory factory, string clientName)
        {
            return builder.UseHttpClientProducer(new BlueRiiotHttpClientFactoryFactory(factory, clientName));
        }

        public static BlueClientBuilder UseHttpClient(this BlueClientBuilder builder, HttpClient client, BlueRiiotHttpClientSettings settings)
        {
            return builder.UseHttpClientProducer(new ConstantBlueRiiotHttpClientFactory(client, settings));
        }

        public static BlueClientBuilder UseHttpClient(this BlueClientBuilder builder, HttpClient client, Action<BlueRiiotHttpClientSettings> configureSettings)
        {
            BlueRiiotHttpClientSettings settings = new BlueRiiotHttpClientSettings();
            configureSettings?.Invoke(settings);

            return builder.UseHttpClientProducer(new ConstantBlueRiiotHttpClientFactory(client, settings));
        }

        public static BlueClientBuilder UseHttpClient(this BlueClientBuilder builder, HttpClient client)
        {
            return builder.UseHttpClientProducer(new ConstantBlueRiiotHttpClientFactory(client));
        }
    }
}