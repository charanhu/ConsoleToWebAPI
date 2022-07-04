using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System;


namespace ConsoleToWebAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello from new WEB API APP");
                });

                //Append the URL
                endpoints.MapGet("/test", async context =>
                {
                    await context.Response.WriteAsync("Hello from new WEB API APP TEST");
                });
            });
        }
    }
}
