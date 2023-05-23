namespace kinoUI.Models;

public class Film
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string? OriginalTitle { get; set; }
    public int? ReleaseYear { get; set; }
    public string? ImageUrl { get; set; }
    public string? FilmGenre { get; set; }
    public string? Description { get; set; }
    public int? LengthInMinutes { get; set; }
    public ICollection<FilmRating> FilmRatings { get; set; }
}