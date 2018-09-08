using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyHomeWebsite.Data;
using MyHomeWebsite.Models;
using MyHomeWebsite.Services;

namespace MyHomeWebsite
{
    public class Startup
    {
        public IConfiguration _Configuration;

        public Startup(IConfiguration configuration)
        {
            _Configuration = configuration;
        }

        
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IWorkExperienceData, WorkExperienceData>();
           // services.AddScoped<TimePeriod>();
            services.AddDbContext<MyWebsiteDbContext>(
                options => options.UseSqlServer(_Configuration.GetConnectionString("MyWebsite")));
            services.AddSingleton<IGreeter,Greetings>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IGreeter greeter)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();           
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "Default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });


            //app.Run(async (Context) => {
            //    //var Greetings = Configuration["Greetings"];
            //    await Context.Response.WriteAsync(greeter.Greet);
            //
            //});

        }
    }
}
