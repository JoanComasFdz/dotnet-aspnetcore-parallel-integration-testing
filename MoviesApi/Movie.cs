namespace MoviesApi;

public record Movie()
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Director { get; set; }
}