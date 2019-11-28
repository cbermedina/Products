namespace Products.Api.Config
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.IO;
    /// <summary>
    /// Configure Swagge
    /// </summary>
    public static class SwaggerConfig
    {
        /// <summary>
        /// Add configuration to swagger in service
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {

            var basepath = AppDomain.CurrentDomain.BaseDirectory;
            var xmlPath = Path.Combine(basepath, "Products.Api.xml");

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info { Title = "Products API V1", Version = "v1" });
                c.IncludeXmlComments(xmlPath);

                //c.AddSecurityDefinition("Bearer", new OAuth2Scheme
                //{
                //    Type = "Bearer",
                //    Flow = "password",
                //    TokenUrl = Path.Combine("https://myapp.com/token"),
                //    // Optional scopes
                //    Scopes = new Dictionary<string, string>
                //        {
                //            { "api1", "client" },
                //        }
                //});

                //c.OperationFilter<AuthorizationHeaderParameterOperationFilter>();

            }
            );
            return services;
        }
        /// <summary>
        /// Add configuration to swagger in app
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static IApplicationBuilder AddRegistration(this IApplicationBuilder app)
        {

            app.UseSwagger();

            app.UseSwaggerUI(
                c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Products API V1");
                });

            return app;
        }
    }
}
