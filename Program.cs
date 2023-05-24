using kinoUI.Data;
using kinoUI.Controllers;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Register the film service
//builder.Services.AddSingleton<FilmService>();

builder.Services.AddHttpClient();
builder.Services.AddSqlite<DatabaseContext>("Data Source=film.db");
builder.Services.AddScoped<UserController>();
builder.Services.AddScoped<FilmRatingController>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

// Initialize database

var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
using(var scope = scopeFactory.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<DatabaseContext>();
    if(db.Database.EnsureCreated())
    {
        SeedData.Initialize(db);
    }
}

app.Run();
