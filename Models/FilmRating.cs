using System.ComponentModel.DataAnnotations;

namespace kinoUI.Models;

public class FilmRating
{
    public int Id { get; set; }

    [Range(1, 5, ErrorMessage = "Ocena filmu musi być w przedziale od 0 do 5!")]
    public int Rate { get; set; }
    public string? Comment { get; set; }
    public int FilmId { get; set; }
    public Film Film { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}