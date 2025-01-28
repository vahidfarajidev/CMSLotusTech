using Application.Base.Logs;
using Application.Datas.Services;
using Domain.Authors.Repositories;
using Domain.Base;
using Domain.DataCategories.Repositories;
using Domain.Datas.Repositories;
using Domain.Tags.Repositories;
using Infrastructure.Base.Logs;
using Infrastructure.Persistence.SQLServer.EF;
using Infrastructure.Persistence.SQLServer.EF.Repositories;
using Infrastructure.Persistence.SQLServer.EF.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Formatting.Json;
using Serilog.Sinks.Elasticsearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class InfrastructureBootStraper
    {
        public static void RegisterDependency(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IDataRepository, DataRepository>();
            services.AddScoped<IDataCategoryRepository, DataCategoryRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<ITagRepository, TagRepository>();

            services.AddScoped<IDataQueryService, DataQueryService>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<IAppLogger, SerilogAppLogger>();

            services.AddDbContext<Persistence.SQLServer.EF.AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        }
    }

    public static class LoggingExtensions
    {
        public static void AddSerilogLogging(this IHostBuilder hostBuilder, IConfiguration configuration)
        {
            //Log.Logger = new LoggerConfiguration()
            //    .Enrich.FromLogContext()
            //    //.WriteTo.Console(new JsonFormatter())
            //    .WriteTo.Elasticsearch(new ElasticsearchSinkOptions(new Uri("http://localhost:9200"))
            //    {
            //        AutoRegisterTemplate = true,
            //        IndexFormat = "logs-{0:yyyy.MM.dd}"
            //    })
            //    .CreateLogger();

            Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(configuration)
            .CreateLogger();

            hostBuilder.UseSerilog();
        }

        //public static void AddSerilogLogging(this IHostBuilder hostBuilder, IConfiguration configuration)
        //{
        //    try
        //    {
        //        var elasticsearchUri = configuration["Serilog:WriteTo:0:Args:NodeUris"];
        //        if (string.IsNullOrEmpty(elasticsearchUri))
        //            throw new InvalidOperationException("Elasticsearch NodeUris is not configured.");

        //        Log.Logger = new LoggerConfiguration()
        //            .ReadFrom.Configuration(configuration)
        //            .CreateLogger();

        //        Log.Information("Serilog has been successfully configured.");

        //        hostBuilder.UseSerilog();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Failed to configure Serilog.");
        //        Console.WriteLine($"Error: {ex.Message}");
        //        throw;
        //    }
        //}
    }
}
