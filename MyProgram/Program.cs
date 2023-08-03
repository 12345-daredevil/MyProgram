using Microsoft.EntityFrameworkCore;
using PlayGames.Data;

using HashiCorpConfiguration.Extensions;
using HashiCorpConfiguration.Models;

namespace MyProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Configuration.AddVaultConfiguration(new VaultConfigSettings
            {
                //Set up your vault settings here
                Token = "hvs.CIn79oTIlZmrOeqNzzrulGDE",
                ServerUriWithPort = "http://127.0.0.1:8200",
                MountPoint = "secret",
                Path = "demo"
            });

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}