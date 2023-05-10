using kinoUI.Models;
using Microsoft.EntityFrameworkCore;

namespace kinoUI.Data;

public class FilmStoreContext : DbContext
{
    public FilmStoreContext(DbContextOptions<FilmStoreContext> options) : base(options)
    {
        /////TEST
    }

    public DbSet<Film> Film { get; set; }
}