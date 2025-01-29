using Infrastructure;
using Application;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Config
{
    public static class CMSLotusBootstraper
    {
        public static void InitCMSLotus(this IServiceCollection services, IConfiguration configuration)
        {
            ApplicationBootStraper.RegisterDependency(services);
            InfrastructureBootStraper.RegisterDependency(services, configuration);
        }

        public static void InitCMSLotusLogging(this IHostBuilder hostBuilder, IConfiguration configuration)
        {
            LoggingExtensions.AddSerilogLogging(hostBuilder, configuration);
        }
    }
}
