using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using System;


namespace ConsoleToWebAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //run method
            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello from Run()");
            //});


            //The call is ambiguous between the following methods or properties:
            //'UseExtensions.Use(IApplicationBuilder, Func<HttpContext, Func, Task>)' and
            //'UseExtensions.Use(IApplicationBuilder, Func<HttpContext, RequestDelegate, Task>)'
            //To resolve the error, use app.Run instead of app.Use.

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from Use()1- 1 \n");
                await next();
                await context.Response.WriteAsync("Hello from Use()1- 2 \n");
            });
            app.Use(async (context, next) =>
            {

                await context.Response.WriteAsync("Hello from Use()2- 1 \n");
                await next();
                await context.Response.WriteAsync("Hello from Use()2- 2 \n");
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Request Completed \n");
            });

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello from Run2() \n");
            //});

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();  //Inject WebAPI
            });
        }
    }
}
