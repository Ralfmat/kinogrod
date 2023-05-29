using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using kinoUI.Data;
using kinoUI.Models;

namespace kinoUI.Controllers;

[Route("filmyRating")]
[ApiController]
public class FilmRatingController : Controller
{
    private readonly DatabaseContext _db;
    
    public FilmRatingController(DatabaseContext db)
    {
        _db = db;
    } 

    [HttpGet]
    public async Task<ActionResult<List<FilmRating>>> GetFilmRating()
    {
        return (await _db.FilmRatings.ToListAsync());
    }

    [HttpGet("{FilmId}")]
    public async Task<ActionResult<List<FilmRating>>> GetFilmRating(int FilmId)
    {
        var filmRating = await _db.FilmRatings.Where(fr => fr.FilmId == FilmId).ToListAsync();

        if (filmRating != null)
        {
            return Ok(filmRating);
        }

        return NotFound();
    }
}