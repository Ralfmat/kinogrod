using kinoUI.Models;

namespace kinoUI.Data;

public static class SeedData
{
    public static void Initialize(DatabaseContext db)
    {
        var filmy = new Film[]
        {
            new Film()
            {
                Title="Buntownik z wyboru",
                ReleaseYear=1997, ImageUrl="img/filmy/buntownik_z_wyboru.jpg",
                FilmGenre="Dramat obyczajowy"
            },
            new Film()
            {
                Title="Forest Gump",
                ReleaseYear=1997, ImageUrl="img/filmy/forest_gump.jpg",
                FilmGenre=""
            },
            new Film()
            {
                Title="Lista Schindlera",
                ReleaseYear=1997, ImageUrl="img/filmy/lista_schindlera.jpg",
                FilmGenre=""
            },
            new Film()
            {
                Title="Zielona Mila",
                ReleaseYear=1997, ImageUrl="img/filmy/zielona_mila.jpg",
                FilmGenre=""
            },
            new Film()
            {
                Title="Pianista",
                ReleaseYear=1997, ImageUrl="img/filmy/pianista.jpg",
                FilmGenre=""
            },
            new Film()
            {
                Title="Leon zawodowiec",
                ReleaseYear=1997, ImageUrl="img/filmy/leon_zawodowiec.jpg",
                FilmGenre=""
            },
            new Film()
            {
                Title="Skazani na Shawshank",
                ReleaseYear=1997, ImageUrl="img/filmy/skazani_na_shawshank.jpg",
                FilmGenre=""
            }

        };
        var users = new User[]
        {
            new User()
            {
                Id = 1,
                Email = "test",
                UserName = "test",
                Password = "test"
            }
        };
        var filmRatings = new FilmRating[]
        {
            new FilmRating()
            {
                Id = 1,
                Rate = 5,
                FilmId = 1,
                UserId = 1
            },
            new FilmRating()
            {
                Id = 2,
                Rate = 4,
                FilmId = 1,
                UserId = 1
            },
            new FilmRating()
            {
                Id = 3,
                Rate = 2,
                FilmId = 1,
                UserId = 1
            },
            new FilmRating()
            {
                Id = 4,
                Rate = 3,
                FilmId = 1,
                UserId = 1
            }
        };

        db.Films.AddRange(filmy);
        db.FilmRatings.AddRange(filmRatings);
        db.Users.AddRange(users);
        db.SaveChanges();
    }
}