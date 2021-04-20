using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebAppRazor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //The Host is a static class which can be used for creating
            //an instance of IHostBuilder with pre-configured defaults.
            //The CreateDefaultBuilder() method creates a new instance
            //of HostBuilder with pre-configured defaults.Internally,
            //it configures Kestrel (Internal Web Server for ASP.NET Core),
            //IISIntegration and other configurations.
                      CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>().UseWebRoot("Content");
                });
    }
}
