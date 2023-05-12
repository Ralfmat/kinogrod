using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using kinoUI.Data;
using kinoUI.Models;

namespace kinoUI.Controllers;

[Route("filmyData")]
[ApiController]
public class FilmController : Controller
{
    private readonly DatabaseContext _db;
    
    public FilmController(DatabaseContext db)
    {
        _db = db;
    } 

    [HttpGet]
    public async Task<ActionResult<List<Film>>> GetFilm()
    {
        return (await _db.Films.ToListAsync());
    }

}