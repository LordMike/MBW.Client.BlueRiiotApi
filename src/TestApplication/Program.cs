using System;
using System.Linq;
using System.Threading.Tasks;
using MBW.Client.BlueRiiotApi.BlueApi;

namespace TestApplication
{
    class Program
    {
        static async Task Main(string[] args)
        {
            BlueLoginClient lc = new BlueLoginClient();

            var crds = await lc.Login("TODO", "TODO");

            BlueClient cl = new BlueClient(crds);

            var pools = await cl.GetSwimmingPools();
            var pool = pools.Data.First();

            var pool2 = await cl.GetSwimmingPool(pool.SwimmingPoolId);
            var feed = await cl.GetSwimmingPoolFeed(pool.SwimmingPoolId);
            var lastMeasurements = await cl.GetSwimmingPoolLastMeasurements(pool.SwimmingPoolId);

            var chemistry = await cl.GetSwimmingPoolChemistry(pool.SwimmingPoolId);

            var status = await cl.GetSwimmingPoolStatus(pool.SwimmingPoolId);
            foreach (var swimmingPoolTask in status.Tasks)
            {
                var task = await cl.GetSwimmingPoolStatusTask(pool.SwimmingPoolId, swimmingPoolTask.TaskIdentifier);
            }

            var blues = await cl.GetSwimmingPoolBlueDevices(pool.SwimmingPoolId);

            var guidance = await cl.GetSwimmingPoolGuidance(pool.SwimmingPoolId);
            var guidanceHistory = await cl.GetSwimmingPoolGuidanceHistory(pool.SwimmingPoolId);

            var weather = await cl.GetSwimmingPoolWeather(pool.SwimmingPoolId);
            var weather2 = await cl.GetSwimmingPoolWeatherForecast(pool.SwimmingPoolId, DateTime.UtcNow);
        }
    }
}
