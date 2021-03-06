﻿namespace Products.Api.CrossCutting.Register
{
    using Microsoft.Extensions.DependencyInjection;
    using Products.Api.Application.ApiCaller;
    using Products.Api.Application.Configuration;
    using Products.Api.Application.Contracts.ApiCaller;
    using Products.Api.Application.Contracts.Services;
    using Products.Api.Application.Repositories;
    using Products.Api.Application.Services;
    using Products.Api.CrossCutting.Interface;
    using Products.Api.CrossCutting.Service;
    using Products.Api.DataAccess.Contracts.Repositories;
    using Products.Api.DataAccess.Repositories;
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
            services.AddTransient<ITransactionService, TransactionService>();
            services.AddTransient<IRateService, RateService>();
            services.AddTransient<IProductService, ProductService>();

            return services;
        }
        /// <summary>
        /// Add Register Repositories
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        private static IServiceCollection AddRegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<ITransactionRepository, TransactionRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IRateRepository, RateRepository>();
            return services;
        }
        /// <summary>
        /// Add Register Others
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        private static IServiceCollection AddRegisterOthers(IServiceCollection services)
        {
            services.AddSingleton<IAppConfig, AppConfig>();
            services.AddTransient<IApiCaller, ApiCaller>();
            services.AddTransient<IInformationService, InformationService>();
            services.AddTransient<ICacheService, CacheService>();
            services.AddSingleton<IServiceLog, ServiceLog>();
            return services;
        }
    }
}
