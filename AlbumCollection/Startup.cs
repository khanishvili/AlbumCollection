using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using AlbumCollection.Repositories;
using AlbumCollection.Models;
namespace AlbumCollection
{
    public class Startup
    {
       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<AlbumContext>();
            services.AddScoped<IAlbumRepository, AlbumRepository>();
            services.AddScoped<ISongRepository, SongRepository>();
        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Album}/{action=Index}/{id?}");
            });
        }
    }
}
