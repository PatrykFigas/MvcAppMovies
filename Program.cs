using Microsoft.EntityFrameworkCore;
using MvcAppMovies.Data;

namespace MvcAppMovies
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Tworzenie buildera aplikacji ASP.NET Core
            var builder = WebApplication.CreateBuilder(args);

            // Rejestracja MVC (kontrolery + widoki)
            builder.Services.AddControllersWithViews();
            
            // Konfiguracja Entity Framework Core z baz¹ SQLite
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));


            var app = builder.Build();

            // Konfiguracja protoko³u HTTP
            if (!app.Environment.IsDevelopment())
            {
                // Obs³uga b³êdów
                app.UseExceptionHandler("/Home/Error");
                
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            // Domyœlna trasa: Movies/Index
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Movies}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
