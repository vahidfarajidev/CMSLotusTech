using Application.Base.Behaviors;
using Application.Datas;
using Application.Datas.Commands.CreateData;
using Application.Datas.Services;
using Domain.Datas.Services;
using FluentValidation;
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
                configuration.AddOpenBehavior(typeof(LoggingPipelineBehavior<,>));
                configuration.AddOpenBehavior(typeof(ValidationPipelineBehavior<,>));
            });

            services.AddValidatorsFromAssembly(typeof(CreateDataCommandValidator).Assembly);

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<IDataDomainService, DataDomainService>();
        }
    }
}
