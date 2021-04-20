using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebAppRazor
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
            services.AddRazorPages();

            //IoC container will automatically pass an instance of MyLog to
            //the constructor of PageModel Class. We don't need to do anything else.
            //An IoC container will create and dispose an instance of ILog based on registered lifetime.
            services.AddSingleton<ILog, MyLog>();
            //OR
           // services.AddSingleton(typeof(ILog), typeof(MyLog));

           // services.AddTransient<ILog, MyLog>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //The Configure() method is a place where you can configure application request pipeline for your application
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            //UseStaticFiles middleware is used to access static files like css,js,image from wwwroot folder

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseWelcomePage();

            app.UseDeveloperExceptionPage();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
