using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CardinalWebApi.SeedData;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace CardinalWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
#if DEBUG
            BuildWebHost(args).Seed().Run();
#else
            BuildWebHost(args).Run();
#endif
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                //.UseUrls("http://*:5000;http://localhost:5001;https://hostname:5002")
                .Build();
    }
}
