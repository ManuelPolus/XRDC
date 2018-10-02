using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace XRDC
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseMvc
            (
                routes =>
                {
                    routes.MapRoute
                    (
                        "resources",
                        "/api/resources",
                        new { controller = "Resources", action = "Get" }
                    );
                    routes.MapRoute
                    (
                        "request",
                        "/api/request/{request}",
                        new { controller = "Resources", action = "Post", request = "{request}" }
                    );
                    routes.MapRoute
                    (
                        name: "default",
                        template: "{controller=Resources}/{action=Get}"
                    );
                }
            );


        }
    }
}
