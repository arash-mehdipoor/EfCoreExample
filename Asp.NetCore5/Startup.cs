using Asp.NetCore5.Middleware;
using Asp.NetCore5.Repasitory;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddTransient<ITransient, Transient>();
            //services.AddScoped<ITransient, Transient>();
            services.AddSingleton<ITransient, Transient>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
          

            app.UseMiddleware<TransientMiddleware>();
           // app.Use(async (httpContext, next) =>
           //{
           //    if (httpContext.Request.Query.ContainsKey("key"))
           //    {
           //        await httpContext.Response.WriteAsync("key write");
           //    }
           //    await next();
           //});
            //app.UseMiddleware<RequestCultureMiddleware>();
            
            //app.MapWhen(context => context.Request.Query.ContainsKey("mapwhen"), async c =>
            //{
            //    c.Use(async (context, next) =>
            //    {
            //        await context.Response.WriteAsync("mapwhen");
            //    });
            //});
            //app.Map("/admin", c =>
            //{
            //    app.Use(async (httpContext, next) =>
            //    {
            //        await httpContext.Response.WriteAsync("/admin");
            //    });
            //});

           
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World! \n");
                });
            });
        }
    }
}
