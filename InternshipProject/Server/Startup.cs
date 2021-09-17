using AutoMapper;
using Blazored.Modal;
using InternshipProject.Server.Data.Context;
using InternshipProject.Server.Services.Extensions;
using InternshipProject.Server.Services.Infrastruce;
using InternshipProject.Server.Services.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;

namespace InternshipProject.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();
            services.AddDbContext<InternshipProjectDbContext>
           (
                options => options.UseSqlServer(Configuration.
            GetConnectionString("MyDatabase"))
                );
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddBlazoredModal();
            services.ConfigureMapping();
            services.AddHttpClient();
            /*
            services.AddScoped<IMapper, Mapper>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IFlatService, FlatService>();
            services.AddScoped<IDebtService, DebtService>();
            services.AddScoped<IAnnouncementService, AnnouncementService>();
            services.AddScoped<IExpenseService, ExpenseService>();
            */
            //services.AddDbContext<InternshipProjectDbContext>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, InternshipProjectDbContext db)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            db.Database.EnsureCreated();
            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
