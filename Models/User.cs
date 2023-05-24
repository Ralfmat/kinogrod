using System.ComponentModel.DataAnnotations;

namespace kinoUI.Models;

public class User
{
    public int Id { get; set; }
    [EmailAddress(ErrorMessage = "Nieprawidłowy adres email!")]
    public string Email { get; set; }   
    public string UserName { get; set; }
    public string Password { get; set; } 
}