using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using MBW.Client.BlueRiiotApi.Builder;
using MBW.Client.BlueRiiotApi.Objects;

namespace TestApplication
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var bc = new BlueClientBuilder()
                .UseHttpClient(new HttpClient(new SocketsHttpHandler
                {
                    // Set a proxy if available. Suggestion: Fiddler.
                    Proxy = new WebProxy(new Uri("http://127.0.0.1:8888"))
                }))
                .UseUsernamePassword("TODO", "TODO")
                .Build();

            var blueDevices = await bc.GetBlues(HwProductType.unknown);

            var pools = await bc.GetSwimmingPools();
            var pool = pools.Data.First();

            var blueDevicesPool = await bc.GetSwimmingPoolBlueDevices(pool.SwimmingPoolId);
            var blueDevice = blueDevicesPool.Data.First();
            
            var blueDevice2 = await bc.GetBlue(blueDevice.BlueDeviceSerial);
            var blueCompatibility = await bc.GetBlueCompatibility(blueDevice.BlueDeviceSerial);

            var pool2 = await bc.GetSwimmingPool(pool.SwimmingPoolId);
            var feed = await bc.GetSwimmingPoolFeed(pool.SwimmingPoolId);
            var lastMeasurements = await bc.GetSwimmingPoolLastMeasurements(pool.SwimmingPoolId);

            var chemistry = await bc.GetSwimmingPoolChemistry(pool.SwimmingPoolId);

            var status = await bc.GetSwimmingPoolStatus(pool.SwimmingPoolId);
            foreach (var swimmingPoolTask in status.Tasks)
            {
                var task = await bc.GetSwimmingPoolStatusTask(pool.SwimmingPoolId, swimmingPoolTask.TaskIdentifier);
            }

            var blues = await bc.GetSwimmingPoolBlueDevices(pool.SwimmingPoolId);

            var guidance = await bc.GetSwimmingPoolGuidance(pool.SwimmingPoolId);
            var guidanceHistory = await bc.GetSwimmingPoolGuidanceHistory(pool.SwimmingPoolId);

            var weather = await bc.GetSwimmingPoolWeather(pool.SwimmingPoolId);
            var weather2 = await bc.GetSwimmingPoolWeatherForecast(pool.SwimmingPoolId, DateTime.UtcNow);
        }
    }
}
