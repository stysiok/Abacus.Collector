using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Abacus.Collector.Worker;

namespace Abacus.Collector
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<DataCollector>();
                });
    }
}
