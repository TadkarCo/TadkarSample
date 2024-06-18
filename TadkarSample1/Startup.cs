using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using TadkarSample1.DataAccessLayer.Context;
using Microsoft.AspNetCore.SpaServices.Extensions;
using AutoMapper;
using TadkarSample1.Core.Classes;

namespace TadkarSample1
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
         services.AddControllers();

         services.AddDbContext<DatabaseContext>(options =>
         {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
         });

         // Auto Mapper Configurations
         var mapperConfig = new MapperConfiguration(mc =>
         {
            mc.AddProfile(new PersonnelProfile());
         });

         IMapper mapper = mapperConfig.CreateMapper();
         services.AddSingleton(mapper);

         services.AddAutoMapper(typeof(Startup));
         services.AddControllersWithViews();

         services.AddCors(options =>
         {
            options.AddPolicy("CorsPolicy", builder =>
            {
               builder.AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod()
               .Build();
            });
         });
      }

      // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
      public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
      {
         if (env.IsDevelopment())
         {
            app.UseDeveloperExceptionPage();
         }
         app.UseHttpsRedirection();
         app.UseStaticFiles();
         if (!env.IsDevelopment())
         {
            app.UseSpaStaticFiles();
         }
         app.UseRouting();

         app.UseAuthorization();

         app.UseCors("CorsPolicy");

         app.UseAuthentication();

         app.UseEndpoints(endpoints =>
         {
            endpoints.MapControllers();
         });

         app.UseSpa(spa =>
         {
            // To learn more about options for serving an Angular SPA from ASP.NET Core,
            // see https://go.microsoft.com/fwlink/?linkid=864501

            spa.UseProxyToSpaDevelopmentServer("http://localhost:1963");

         });
      }
   }
}
