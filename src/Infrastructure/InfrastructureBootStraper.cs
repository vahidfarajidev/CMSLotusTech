using Domain.Base;
using Infrastructure.Services;
using Application.Services;
using Domain.Core.Datas;
using Domain.Core.DataCategories;
using Domain.Core.Tags;
using Domain.Core.Authors;
using Application.Core.Datas.Queries.GetDataViewById;
using Application.Core.Datas.Queries.GetDataById;

using Infrastructure.Persistence.SQLServer.EF.Base;
using Infrastructure.Persistence.SQLServer.Dapper.Base;

using Infrastructure.Persistence.SQLServer.EF.Core.Authors;
using Infrastructure.Persistence.SQLServer.EF.Core.DataCategories;
using Infrastructure.Persistence.SQLServer.EF.Core.Datas;
using Infrastructure.Persistence.SQLServer.EF.Core.Tags;

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
using Infrastructure.Persistence.SQLServer.Dapper;

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

            services.AddScoped<IGetDataByIdService,
                Persistence.SQLServer.EF.Core.Datas.QueryServices.GetDataByIdService>();
            services.AddScoped<IGetDataViewByIdService, 
                Persistence.SQLServer.Dapper.Core.Datas.QueryServices.GetDataViewByIdService>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<IAppLogger, SerilogAppLogger>();

            services.AddDbContext<EFDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped(_ => new DapperContext(connectionString));
        }
    }

    public static class LoggingExtensions
    {

        public static void AddSerilogLogging(this IHostBuilder hostBuilder, IConfiguration configuration)
        {
            try
            {
                var elasticsearchUri = configuration["Serilog:WriteTo:0:Args:NodeUris"];
                if (string.IsNullOrEmpty(elasticsearchUri))
                    throw new InvalidOperationException("Elasticsearch NodeUris is not configured.");

                Log.Logger = new LoggerConfiguration()
                    .ReadFrom.Configuration(configuration)
                    .CreateLogger();

                Log.Information("Serilog has been successfully configured.");

                hostBuilder.UseSerilog();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to configure Serilog.");
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
    }
}
