using System;
using System.Net.Http;
using MBW.Client.BlueRiiotApi;
using MBW.Client.BlueRiiotApi.Builder;
using Microsoft.Extensions.Logging;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    public static class BlueClientExtensions
    {
        public static void AddBlueRiiotClient(this IServiceCollection services, Action<BlueClientBuilder> configure)
        {
            services
                .AddHttpClient()
                .AddSingleton(x =>
                {
                    BlueClientBuilder builder = new BlueClientBuilder()
                        .UseLogger(x.GetRequiredService<ILogger<BlueClient>>())
                        .UseHttpClientFactory(x.GetRequiredService<IHttpClientFactory>(), string.Empty);

                    configure(builder);

                    return builder.Build();
                });
        }
    }
}