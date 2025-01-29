using Application.Behaviors;
using Application.Core.Datas;
using Application.Core.Datas.Commands.CreateData;
using Domain.Core.Datas;
using FluentValidation;
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
                configuration.AddOpenBehavior(typeof(LoggingPipelineBehavior<,>));
                configuration.AddOpenBehavior(typeof(ValidationPipelineBehavior<,>));
            });

            services.AddValidatorsFromAssembly(typeof(CreateDataCommandValidator).Assembly);

            services.AddScoped<IDataDomainService, DataDomainService>();
        }
    }
}
