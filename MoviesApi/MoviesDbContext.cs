using Microsoft.EntityFrameworkCore;

namespace MoviesApi;

public class MoviesDbContext(DbContextOptions<MoviesDbContext> options) : DbContext(options)
{
    public DbSet<Movie> Movies { get; set; }
}