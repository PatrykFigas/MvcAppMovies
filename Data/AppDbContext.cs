using Microsoft.EntityFrameworkCore;
using MvcAppMovies.Models;
using System.Collections.Generic;

namespace MvcAppMovies.Data
{
    // Klasa kontekstu bazy danych (Entity Framework Core)
    public class AppDbContext : DbContext
    {
        // Konstruktor przyjmujący opcję kontekstu
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options) 
        {
        }

        // Reprezentacja tabeli Movies w bazie danych
        public DbSet<Movie> Movies => Set<Movie>();
    }
}
