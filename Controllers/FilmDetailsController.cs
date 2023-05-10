using kinoUI.Data;
using kinoUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace kinoUI.Controllers;

[Route("filmyDetailsData")]
[ApiController]
public class FilmDetailsController : Controller
{
    private readonly FilmDetailsStoreContext _db;

    public FilmDetailsController(FilmDetailsStoreContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<FilmDetails>>> GetFilmDetails()
    {
        return (await _db.FilmDetails.ToListAsync());
    }
}