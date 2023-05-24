using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using kinoUI.Data;
using kinoUI.Models;

namespace kinoUI.Controllers;

[Route("userData")]
[ApiController]

public class UserController : Controller
{
    private readonly DatabaseContext _db;

    public UserController(DatabaseContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<List<User>> GetUsersAsync()
    {
        return await _db.Users.ToListAsync();
    }

    [HttpPost]
    public async Task AddUserAsync(User user)
    {
        _db.Users.Add(user);
        await _db.SaveChangesAsync();
    }
}