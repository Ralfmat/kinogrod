using System.ComponentModel.DataAnnotations;

namespace kinoUI.Models;

public class Film
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string? OriginalTitle { get; set; }
    public int? ReleaseYear { get; set; }
    public string? ImageUrl { get; set; }
    public string? FilmGenre { get; set; }
    [MaxLength(500)]
    public string? Description { get; set; }
    public int? LengthInMinutes { get; set; }
    public List<FilmRating> FilmRatings { get; set; }
}