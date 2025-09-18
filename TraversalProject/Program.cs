using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using Serilog;
using Serilog.Events;
using Traversal.Business.Container;
using Traversal.Core.Concrete.Entities;
using Traversal.DataAccess.Concrete;
using TraversalProject.CQRS.Handlers.DestinationHandlers;
using TraversalProject.Mapping.AutoMapperProfile;
using TraversalProject.Models;

namespace TraversalProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //CQRS Handler için
            builder.Services.AddScoped<GetAllDestinationQueryHandler>();
            builder.Services.AddScoped<GetDestinationByIdQueryHandler>();
            builder.Services.AddScoped<CreateDestinationCommandHandler>();
            builder.Services.AddScoped<RemoveDestinationCommandHandler>();
            builder.Services.AddScoped<UpdateDestinationCommandHandler>();

            //MediatR için
            builder.Services.AddMediatR(typeof(Program));
            
            //Api kullanýmý için
            builder.Services.AddHttpClient(); 


            //Automapper
            builder.Services.AddAutoMapper(typeof(MapProfile));

            //FluentValidation
            builder.Services.CustomValidator();

            //Excel rapor için license
            ExcelPackage.License.SetNonCommercialPersonal("abc");


            //SeriLog
            var path = Directory.GetCurrentDirectory();
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning) // Microsoft.* loglarý sustur
                .MinimumLevel.Override("System", LogEventLevel.Warning)    // System.* loglarý sustur
                .MinimumLevel.Debug()
                .WriteTo.File($"{path}\\Logs\\Log1.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            builder.Host.UseSerilog();

            //Logging
            //builder.Services.AddLogging(x =>
            //{
            //    x.ClearProviders();
            //    x.SetMinimumLevel(LogLevel.Debug);
            //    x.AddDebug();
            //});

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddFluentValidation();

            //DbContext
            builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            //Identity
            builder.Services.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddErrorDescriber<CustomIdentityValidator>()
                .AddDefaultTokenProviders();

            //Proje seviyesi Authentication
            builder.Services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });


            //Dependency Injections
            builder.Services.ContainerDependencies();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={0}");
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();




            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                  name: "member",
                  areaName: "Member",
                  pattern: "Member/{controller=Profile}/{action=Index}/{id?}"
                );
                endpoints.MapAreaControllerRoute(
                  name: "admin",
                  areaName: "Admin",
                  pattern: "Admin/{controller=Profile}/{action=Index}/{id?}"
                );

                app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Default}/{action=Index}/{id?}");
            });


            app.Run();
        }
    }
}