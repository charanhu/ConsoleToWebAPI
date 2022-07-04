using Microsoft.AspNetCore.Builder;
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
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello from Run()");
            });

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello from Run2()");
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
