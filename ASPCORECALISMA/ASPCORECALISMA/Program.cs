using ASPCORECALISMA.Concrete;
using ASPCORECALISMA.Controllers;
using ASPCORECALISMA.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Options;

namespace ASPCORECALISMA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<Context>();
            builder.Services.AddControllersWithViews();

            builder.Services.AddIdentity<Kullanicilar,KullaniciRol>().AddEntityFrameworkStores<Context>().AddDefaultTokenProviders();

         

            builder.Services.AddMvc( config=>

            {
                var kural = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
                config.Filters.Add(new AuthorizeFilter(kural));
            });


            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x=>
            {
               
                x.LoginPath = "/Account/Login";
            }
                
                
                );

            var app = builder.Build();

            app.UseAuthentication();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/ErrorPage/Index");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
           
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseStatusCodePagesWithReExecute("/ErrorPage/Index", "?code={0}");
            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();

           
        }
    }
}