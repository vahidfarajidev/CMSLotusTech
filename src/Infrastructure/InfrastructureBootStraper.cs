using Domain.Base;
using Infrastructure.Services;
using Infrastructure.Persistence.SQLServer.EF;
using Infrastructure.Persistence.SQLServer.EF.Repositories;
using Infrastructure.QueryServices;
using Application.Services;
using Application.Core.Datas.Queries;
using Domain.Core.Datas;
using Domain.Core.DataCategories;
using Domain.Core.Tags;
using Domain.Core.Authors;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver.Core.Configuration;

namespace Infrastructure
{
    public class InfrastructureBootStraper
    {
        public static void RegisterDependency(IServiceCollection services, IConfiguration configuration)
        {
            string? connectionString = configuration.GetConnectionString("DefaultConnection");

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Connection string 'DefaultConnection' is not configured.");
            }

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IDataRepository, DataRepository>();
            services.AddScoped<IDataCategoryRepository, DataCategoryRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<ITagRepository, TagRepository>();

            services.AddScoped<IDataQueryService, DataQueryService>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<IAppLogger, SerilogAppLogger>();

            services.AddDbContext<EFDbContext>(options =>
                options.UseSqlServer(connectionString));


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
