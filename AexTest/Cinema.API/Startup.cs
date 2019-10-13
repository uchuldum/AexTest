using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Cinema.DAL.EF;
using Cinema.DAL.Interfaces;
using Cinema.DAL.Repositories;
using Cinema.BLL.Interfaces;
using Cinema.BLL.Services;
using Cinema.API.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Cinema.API
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //Add Cors so that client application can connect to API 
            services.AddCors(o => o.AddPolicy("LocalPolicy", builder =>
            {
                builder.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
            }));

            services.AddAutoMapper(typeof(ActorMapping),typeof(MovieMapping), typeof(GenreMapping));

            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<IGenreRepository, GenreRepository>();
            services.AddScoped<IActorRepository, ActorRepository>();
            services.AddScoped<IUnitOfWork, EFUnitOfWork>();

            services.AddTransient<IActorService, ActorService>();
            services.AddTransient<IMovieService, MovieService>();
            services.AddTransient<IGenreService, GenreService>();
            services.AddDbContext<AEXTestDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseCors("LocalPolicy");

            app.UseHttpsRedirection();
            app.UseMvc(routes =>
            {
                routes
                .MapRoute("ControllerAction", "api/{controller}/{action}");
            });
        }
    }
}
