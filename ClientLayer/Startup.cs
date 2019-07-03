using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DataLayer.DAL;
using System.IO;

namespace ClientLayer
{
    public class Startup
    {

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var builder = new ConfigurationBuilder();

            // setting the path to the current directory
            builder.SetBasePath(Directory.GetCurrentDirectory());

            // get configuration from file appsettings.json
            builder.AddJsonFile("appsettings.json");

            // create the configuration
            var config = builder.Build();

            // get the connection string
            string connection = config.GetConnectionString("DefaultConnection");

            services.AddDbContext<RegistrationContext>(options => options.UseSqlServer(connection, b => b.MigrationsAssembly("DataLayer")));

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Genres}/{action=Index}/{filter?}/{id?}");
            });
        }
    }
}
