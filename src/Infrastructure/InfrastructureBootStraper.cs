using Application.Datas.Services;
using Domain.Base;
using Domain.DataCategories.Repositories;
using Domain.Datas.Repositories;
using Domain.Tags.Repositories;
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
            services.AddScoped<ITagRepository, TagRepository>();

            services.AddScoped<IDataQueryService, DataQueryService>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddDbContext<Persistence.SQLServer.EF.AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        }
    }    
}
