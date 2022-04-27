using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PromotionEngine.Interface;
using PromotionEngine.Service;

namespace PromotionEngine
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
            services.AddControllers();
            ConfigureServiceLifeTime(services);
        }

        private void ConfigureServiceLifeTime(IServiceCollection services)
        {
            services.AddScoped<IPromotionService, PromotionType1>();
            services.AddTransient<Func<PromotionEmun, IPromotionService>>(serviceProvider => protocol =>
            {
                switch (protocol)
                {
                    case PromotionEmun.PROMOTIONTYPE1:
                        var service = serviceProvider.GetService<PromotionType1>();
                        return service;
                    default:
                        return serviceProvider.GetService<PromotionType1>();
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UsePathBase("/api");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                endpoints.MapControllers();
            });
        }
    }
}
