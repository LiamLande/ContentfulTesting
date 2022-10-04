using Microsoft.Extensions.Configuration;
using Contentful.AspNetCore;


namespace Contenful_Test
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/404");
                app.UseHsts();
            }

            app.UseCookiePolicy();
            

            

            app.UseHttpsRedirection();

            
            app.UseStaticFiles();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });


        }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddHttpClient();

            services.AddRazorPages();


            services.AddContentful(Configuration);


        }

    }
}
