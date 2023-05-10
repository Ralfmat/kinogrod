namespace kinoUI.Models;

public class Film
{
    public int Id { get; set; }

    public string Title { get; set; }

    public int ReleaseYear { get; set; }

    public string ImageUrl { get; set; }

    public string FilmGenre { get; set; }

    public int FilmDetailsId { get; set; }

    public FilmDetails FilmDetails { get; set; }
    
    //public int FilmRatingId { get; set;}
    //public listfilmrating filmrating { get; set; }
}