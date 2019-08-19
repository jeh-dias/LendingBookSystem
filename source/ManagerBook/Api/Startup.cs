using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ManagerBooks.Applications.Extensions;
using ManagerBooks.Repository;
using ManagerBooks.Repository.Interfaces;
using ManagerBooks.Services;
using ManagerBooks.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.PlatformAbstractions;
using Repository;
using Repository.Interfaces;
using Services;
using Services.Interfaces;
using Swashbuckle.AspNetCore.Swagger;

namespace Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            DependencyInjections(services);
            services.SwaggerServices();
        }

        private void DependencyInjections(IServiceCollection services)
        {
            services.AddSingleton<IPersonRepository, PersonRepository>();
            services.AddSingleton<IBookRepository, BookRepository>();
            services.AddSingleton<ILendingRepository, LendingRepository>();
            services.AddSingleton<IDeliverRepository, DeliverRepository>();
            services.AddTransient<IPersonServices, PersonServices>();
            services.AddTransient<IBookServices, BookServices>();
            services.AddTransient<ILendingServices, LendingServices>();
            services.AddTransient<IDeliverServices, DeliverServices>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.SwaggerApplication();
        }
    }
}
