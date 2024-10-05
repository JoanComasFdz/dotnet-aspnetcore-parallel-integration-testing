using Microsoft.EntityFrameworkCore;
using MoviesApi;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MoviesDbContext>((options) =>
{
    var cnstr = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseNpgsql(cnstr);
});

var app = builder.Build();

// Apply migrations on startup
using (var scope = app.Services.CreateScope())
{
    var opt = scope.ServiceProvider.GetRequiredService<DbContextOptions<MoviesDbContext>>();
    var dbContext = scope.ServiceProvider.GetRequiredService<MoviesDbContext>();
    dbContext.Database.Migrate();
}

// Configure Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Define endpoints
app.MapGet("/movies", async (MoviesDbContext db) => await db.Movies.ToListAsync());

app.MapPost("/movies", async (MoviesDbContext db, Movie movie) =>
{
    db.Movies.Add(movie);
    await db.SaveChangesAsync();
    return Results.Created($"/movies/{movie.Id}", movie);
});

app.Run();

// Necessary for integration tests when using Minimal API
public partial class Program { }