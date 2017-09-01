using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace FullStackTemplate.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var webHost = BuildWebHost(args);
            
            // TODO any pre-run setup steps
            
            webHost.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}