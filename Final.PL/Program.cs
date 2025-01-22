using Final.BL.Extentions;
using Final.DL.Contexts;
using Final.DL.Extentions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Final.PL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(opt=>opt.UseSqlServer(builder.Configuration.GetConnectionString("App")));
            builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 4;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(10);
                options.Lockout.MaxFailedAccessAttempts = 10;
            }).AddDefaultTokenProviders()
              .AddEntityFrameworkStores<AppDbContext>();
            builder.Services.AddDlServices();
            builder.Services.AddBlServices();
            var app = builder.Build();

            app.UseStaticFiles();
            app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
            app.MapControllerRoute(
            name: "defrault",
            pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
