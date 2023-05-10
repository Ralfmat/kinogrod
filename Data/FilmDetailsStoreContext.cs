using kinoUI.Models;
using Microsoft.EntityFrameworkCore;

namespace kinoUI.Data;

public class FilmDetailsStoreContext : DbContext
{
    public FilmDetailsStoreContext(DbContextOptions<FilmDetailsStoreContext> options) : base(options)
    {

    }

    public DbSet<FilmDetails> FilmDetails { get; set; }
}