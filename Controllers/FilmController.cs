using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using kinoUI.Data;
using kinoUI.Models;

namespace kinoUI.Controllers;

[Route("filmy")]
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
        var filmy = await _db.Films.ToListAsync();

        if (filmy != null) 
        {
            return Ok(filmy);
        }

        return NotFound();
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<Film>> GetFilm(int Id)
    {
        var film = await _db.Films.FindAsync(Id);

        if (film != null)
        {
            return Ok(film);
        }

        return NotFound();
    }
}