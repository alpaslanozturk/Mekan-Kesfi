using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MekanKesfi.Business.Abstract;
using MekanKesfi.Business.Concrete;
using MekanKesfi.DataAccess.Abstract;
using MekanKesfi.DataAccess.Concrete.Context;
using MekanKesfi.DataAccess.Concrete.EntityFramework;
using MekanKesfi.Entities.Concrete;
using MekanKesfiWebUI.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MekanKesfiWebUI
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<MekanKesfiContext>(x => x.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<Kullanicilar, Roller>()
                .AddEntityFrameworkStores<MekanKesfiContext>()
                .AddDefaultTokenProviders();
            services.AddScoped<IMekanlarService, MekanlarService>();
            services.AddScoped<IMekanlarRepository, EFMekanlarRepository>();
            services.AddScoped<MekanlarViewModel>();
            services.AddScoped<IUrunlerService, UrunlerService>();
            services.AddScoped<IUrunlerRepository, EFUrunlerRepository>();
            services.AddScoped<IReklamlarService, ReklamlarService>();
            services.AddScoped<IReklamlarRepository, EFReklamlarRepository>();
            services.AddScoped<IIllerService, IllerService>();
            services.AddScoped<IIllerRepository, EFIllerRepository>();
            services.AddScoped<IIlcelerService, IlcelerService>();
            services.AddScoped<IIlcelerRepository, EFIlcelerRepository>();
            services.AddScoped<UrunlerViewModel>();
            services.AddAutoMapper();
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
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Mekanlar}/{action=Liste}/{id?}");
            });
            app.UseIdentity();
        }
    }
}
