using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zemzem.BL;
using zemzem.InfraStructure;
using zemzem.IntefaceClasses;

namespace zemzem
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddDbContext<ZemzemContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("zemzem")));

            services.AddScoped<ISliderService, ClsSlider>();
            services.AddScoped<IBannerService, ClsBanner>();
            services.AddScoped<ICategoryService, ClsCategory>();
            services.AddScoped<IProductService, ClsProduct>();
            services.AddScoped<IHaber, ClsHaber>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
            name: "MyArea",
             pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                   "Home",
                   "Home/{categorySlug}",
                   defaults: new { controller = "Home", action = "ProductsByCategory" }
               );

                endpoints.MapControllerRoute(
             name: "default",
              pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
            });
            //for api
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
