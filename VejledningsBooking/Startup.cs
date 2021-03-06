using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using DataAcces;
using DataAcces.Command;
using DataAcces.Query;
using Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace VejledningsBooking
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
            services.AddControllersWithViews();
            services.AddDbContext<VejledningsContext>(o =>
            {
                o.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            }, ServiceLifetime.Transient);
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            ConfigureModels(services);
            ConfigureRepositories(services);
            ConfigureApplicationLogic(services);
        }
        private void ConfigureRepositories(IServiceCollection services)
        {
            var collection = Assembly.Load(nameof(DataAcces)).GetTypes().Where(x => !x.FullName.Contains("Migrations") && !x.Name.Contains("Anonymous") && x.Name != nameof(VejledningsContext) &&  !x.Name.StartsWith("I") && !x.IsNested).ToList();

            foreach (var c in collection)
            {
                if (c.Name.Contains("QueryRepository"))
                {
                    services.AddTransient(typeof(IQueryRepository<>), typeof(QueryRepository<>));
                    continue;
                }
                else if (c.Name.Contains("CommandRepository"))
                {
                    services.AddTransient(typeof(ICommandRepository<>), typeof(CommandRepository<>));
                    continue;
                }
                else
                {
                    var iFace = c.GetInterfaces().Where(x => x.Name == "I"+c.Name).FirstOrDefault();
                    services.AddTransient(iFace, c);
                }
            }
        }
        private void ConfigureApplicationLogic(IServiceCollection services)
        {
            var collection = Assembly.Load(nameof(Infrastructure)).GetTypes().Where(x => x.FullName.Contains("ApplicationLogic") && !x.Name.StartsWith("I") && !x.IsNested).ToList();
            foreach (var c in collection)
            {
                if(c.Name == "PersonState")
                {
                    services.AddScoped(c.GetInterfaces().First(), c);
                    continue;
                }
                else if (c.Name == "CalenderDateManager")
                {
                    services.AddSingleton(c.GetInterfaces().First(), c);
                        continue;
                }
                services.AddTransient(c.GetInterfaces().First(), c);
            }
        }
        private void ConfigureModels(IServiceCollection services)
        {
            var collection = Assembly.Load(nameof(Model)).GetTypes().Where(x => !x.IsNested && !x.IsInterface && !x.IsAbstract && !x.IsEnum).ToList();
            foreach (var c in collection)
            {
                services.AddTransient(c);
            }
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
