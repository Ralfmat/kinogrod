using kinoUI.Models;
using Microsoft.EntityFrameworkCore;

namespace kinoUI.Data;

public class DatabaseContext : DbContext
{

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
        
    }


    public DbSet<Film> Films { get; set; }
    public DbSet<FilmRating> FilmRatings { get; set; }
}