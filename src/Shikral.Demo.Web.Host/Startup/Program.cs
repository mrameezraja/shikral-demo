using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Shikral.Demo.Web.Host.Startup
{
    public class Program
    {
        public static void Main(string[] args)
        {
            __BuildWebHost(args).Run();
        }

        public static IWebHost __BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
        }
    }
}
