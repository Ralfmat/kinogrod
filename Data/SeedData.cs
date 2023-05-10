using kinoUI.Models;

namespace kinoUI.Data;

public static class SeedData
{
    public static void Initialize(FilmStoreContext db)
    {
        var filmy = new Film[]
        {
            new Film()
            {
                Title="Buntownik z wyboru",
                ReleaseYear=1997, ImageUrl="img/filmy/buntownik_z_wyboru.jpg",
                FilmGenre="Dramat obyczajowy",
                FilmDetails = new FilmDetails()
                {
                    Description="opis1",
                    LengthInMinutes=124
                }
            },
            new Film()
            {
                Title="Forest Gump",
                ReleaseYear=1997, ImageUrl="img/filmy/forest_gump.jpg",
                FilmGenre="",
                FilmDetails = new FilmDetails()
                {
                    Description="opis1",
                    LengthInMinutes=124
                }
            },
            new Film()
            {
                Title="Lista Schindlera",
                ReleaseYear=1997, ImageUrl="img/filmy/lista_schindlera.jpg",
                FilmGenre="",
                FilmDetails = new FilmDetails()
                {
                    Description="opis1",
                    LengthInMinutes=124
                }
            },
            new Film()
            {
                Title="Zielona Mila",
                ReleaseYear=1997, ImageUrl="img/filmy/zielona_mila.jpg",
                FilmGenre="",
                FilmDetails = new FilmDetails()
                {
                    Description="opis1",
                    LengthInMinutes=124
                }
            },
            new Film()
            {
                Title="Pianista",
                ReleaseYear=1997, ImageUrl="img/filmy/pianista.jpg",
                FilmGenre="",
                FilmDetails = new FilmDetails()
                {
                    Description="opis1",
                    LengthInMinutes=124
                }
            },
            new Film()
            {
                Title="Leon zawodowiec",
                ReleaseYear=1997, ImageUrl="img/filmy/leon_zawodowiec.jpg",
                FilmGenre="",
                FilmDetails = new FilmDetails()
                {
                    Description="opis1",
                    LengthInMinutes=124
                }
            },
            new Film()
            {
                Title="Skazani na Shawshank",
                ReleaseYear=1997, ImageUrl="img/filmy/skazani_na_shawshank.jpg",
                FilmGenre="",
                FilmDetails = new FilmDetails()
                {
                    Description="opis1",
                    LengthInMinutes=124
                }
            }

        };
        
        db.Film.AddRange(filmy);
        db.SaveChanges();
    }
}