using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Lojinha
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
            services.AddMvc();

            services.AddDistributedMemoryCache();
            services.AddSession( options =>
            {
                options.IdleTimeout = TimeSpan.FromMilliseconds(30);
                options.Cookie.HttpOnly = true;
            }
            
            );
            

            string connectionString =
                Configuration.GetSection("ConnectionString").GetValue<string>("Default");
            services.AddDbContext<BancoContext>(options =>
            options.UseSqlServer(connectionString));
            services.AddScoped<IDataService, DataService>();
            services.AddScoped<IServicosUsuario, ServicosUsuario>();
            services.AddScoped<IServicosEndereco, ServicosEndereco>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
