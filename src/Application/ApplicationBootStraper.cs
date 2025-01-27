using Application.Datas;
using Application.Datas.Commands.CreateData;
using Application.Datas.Services;
using Domain.Datas.Services;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class ApplicationBootStraper
    {
        public static void RegisterDependency(IServiceCollection services)
        {
            services.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssembly(typeof(CreateDataCommand).Assembly);
            });

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<IDataDomainService, DataDomainService>();
        }
    }
}
