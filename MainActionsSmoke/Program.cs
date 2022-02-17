using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MainActionsSmoke
{
    public class Program
    { //https://github.com/AnastasiiaPosulikhina/ProjectModelSmoke/blob/42be363fe9e4b59155014c9e28a939687a1ce794/MainActionsSmoke/Program.cs
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run(); 
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}