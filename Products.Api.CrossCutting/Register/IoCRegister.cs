using Microsoft.Extensions.DependencyInjection;
using Products.Api.Application.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products.Api.CrossCutting.Register
{
    public static class IoCRegister
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {

            AddRegisterServices(services);
            AddRegisterRepositories(services);
            AddRegisterOthers(services);

            return services;

        }
        /// <summary>
        /// Add Register Services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        private static IServiceCollection AddRegisterServices(IServiceCollection services)
        {
           // services.AddTransient<IServicesService, ServicesService>();
            return services;
        }
        /// <summary>
        /// Add Register Repositories
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        private static IServiceCollection AddRegisterRepositories(IServiceCollection services)
        {
           // services.AddTransient<IServicesRepository, ServicesRepository>();
            return services;
        }
        /// <summary>
        /// Add Register Others
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        private static IServiceCollection AddRegisterOthers(IServiceCollection services)
        {
            services.AddTransient<IAppConfig, AppConfig>();
            return services;
        }
    }
}
