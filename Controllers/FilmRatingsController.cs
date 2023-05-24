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
    public async Task<ActionResult<List<FilmRating>>> GetFilm()
    {
        return (await _db.FilmRatings.ToListAsync());
    }

}