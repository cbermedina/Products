namespace Products.Api
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Products.Api.Config;
    using Products.Api.CrossCutting.Register;
    using Products.Api.DataAccess;
    using Products.Api.DataAccess.Contracts;
    /// <summary>
    /// Startup
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Constructor Startup
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        /// <summary>
        /// Configuration propertie
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IProductsDBContext, ProductsDBContext>();
            IoCRegister.AddRegistration(services);
            services.AddDbContext<ProductsDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DataBaseConnection")));
            SwaggerConfig.AddRegistration(services);
            services.AddMvc();
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            SwaggerConfig.AddRegistration(app);
            app.UseMvc();
        }
    }
}
