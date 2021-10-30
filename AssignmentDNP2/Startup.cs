using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssignmentDNP2.Data;
using AssignmentDNP2.Data.Impl;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Mvc;
using FileData;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using AssignmentDNP2.Authentication;

namespace AssignmentDNP2
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
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<FileContext>();
            
            services.AddScoped<IUserService, InMemoryUserService>();
            
            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            
            services.AddAuthorization(options => {
                options.AddPolicy("SecurityLevel4",  a => 
                    a.RequireAuthenticatedUser().RequireClaim("Level", "4","5"));
            
                options.AddPolicy("MustBeAdmin",  a => 
                    a.RequireAuthenticatedUser().RequireClaim("Role", "Admin"));
            
                options.AddPolicy("SecurityLevel2", policy =>
                    policy.RequireAuthenticatedUser().RequireAssertion(context => {
                        Claim levelClaim = context.User.FindFirst(claim => claim.Type.Equals("Level"));
                        if (levelClaim == null) return false;
                        return int.Parse(levelClaim.Value) >= 2;
                    }));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
                endpoints.MapControllers();
            });
        }
    }
}