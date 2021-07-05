using FluentValdiationService.Persistance.Services;
using FluentValidationService.Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluentValdiationService.Persistance
{
    public static class  PersistanceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {
            services.AddScoped<ITestService, TestService>();

            return services;
        }
    }
}
