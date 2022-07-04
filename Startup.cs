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
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();  //Inject WebAPI
            });
        }
    }
}
