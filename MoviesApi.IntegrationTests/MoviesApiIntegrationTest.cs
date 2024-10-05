
using System.Net;
using System.Net.Http.Json;
using MoviesApi.IntegrationTests.Infrastructure;
using Xunit.Abstractions;
using ParallelIntegrationTesting;

namespace MoviesApi.IntegrationTests;

// This class contains 50 tests to showcase parallel execution.
// The tests themselves are kinda meaningless and were generated with OpenAI's ChatGPT.
public class MoviesApiIntegrationTest(PostgreSqlFixture fixture, ITestOutputHelper testOutputHelper)
    : IntegrationTestBase<Program, MoviesDbContext>(fixture, testOutputHelper)
{

    [Fact]
    public async Task Get_ReturnsNoMovies_1()
    {
        // Arrange
        var client = CreateClient();


        // Act
        var response = await client.GetAsync("/movies");

        // Assert

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var movies = await response.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Empty(movies);

    }

    [Fact]
    public async Task Post_And_Get_ReturnsMovie_1()
    {
        // Arrange
        var client = CreateClient();

        var newMovie = new Movie()
        {
            Title = "The Godfather 1",
            Director = "Francis Ford Coppola"
        };


        // Act

        var postResponse = await client.PostAsJsonAsync("/movies", newMovie);
        postResponse.EnsureSuccessStatusCode();
        var getResponse = await client.GetAsync("/movies");


        // Assert

        getResponse.EnsureSuccessStatusCode();
        var movies = await getResponse.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Single(movies);
        Assert.Equal(newMovie.Title, movies[0].Title);
        Assert.Equal(newMovie.Director, movies[0].Director);

    }

    [Fact]
    public async Task Get_ReturnsNoMovies_2()
    {
        // Arrange
        var client = CreateClient();


        // Act
        var response = await client.GetAsync("/movies");

        // Assert

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var movies = await response.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Empty(movies);

    }

    [Fact]
    public async Task Post_And_Get_ReturnsMovie_2()
    {
        // Arrange
        var client = CreateClient();

        var newMovie = new Movie()
        {
            Title = "The Godfather 2",
            Director = "Francis Ford Coppola"
        };


        // Act

        var postResponse = await client.PostAsJsonAsync("/movies", newMovie);
        postResponse.EnsureSuccessStatusCode();
        var getResponse = await client.GetAsync("/movies");


        // Assert

        getResponse.EnsureSuccessStatusCode();
        var movies = await getResponse.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Single(movies);
        Assert.Equal(newMovie.Title, movies[0].Title);
        Assert.Equal(newMovie.Director, movies[0].Director);

    }

    [Fact]
    public async Task Get_ReturnsNoMovies_3()
    {
        // Arrange
        var client = CreateClient();


        // Act
        var response = await client.GetAsync("/movies");

        // Assert

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var movies = await response.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Empty(movies);

    }

    [Fact]
    public async Task Post_And_Get_ReturnsMovie_3()
    {
        // Arrange
        var client = CreateClient();

        var newMovie = new Movie()
        {
            Title = "The Godfather 3",
            Director = "Francis Ford Coppola"
        };


        // Act

        var postResponse = await client.PostAsJsonAsync("/movies", newMovie);
        postResponse.EnsureSuccessStatusCode();
        var getResponse = await client.GetAsync("/movies");


        // Assert

        getResponse.EnsureSuccessStatusCode();
        var movies = await getResponse.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Single(movies);
        Assert.Equal(newMovie.Title, movies[0].Title);
        Assert.Equal(newMovie.Director, movies[0].Director);

    }

    [Fact]
    public async Task Get_ReturnsNoMovies_4()
    {
        // Arrange
        var client = CreateClient();


        // Act
        var response = await client.GetAsync("/movies");

        // Assert

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var movies = await response.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Empty(movies);

    }

    [Fact]
    public async Task Post_And_Get_ReturnsMovie_4()
    {
        // Arrange
        var client = CreateClient();

        var newMovie = new Movie()
        {
            Title = "The Godfather 4",
            Director = "Francis Ford Coppola"
        };


        // Act

        var postResponse = await client.PostAsJsonAsync("/movies", newMovie);
        postResponse.EnsureSuccessStatusCode();
        var getResponse = await client.GetAsync("/movies");


        // Assert

        getResponse.EnsureSuccessStatusCode();
        var movies = await getResponse.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Single(movies);
        Assert.Equal(newMovie.Title, movies[0].Title);
        Assert.Equal(newMovie.Director, movies[0].Director);

    }

    [Fact]
    public async Task Get_ReturnsNoMovies_5()
    {
        // Arrange
        var client = CreateClient();


        // Act
        var response = await client.GetAsync("/movies");

        // Assert

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var movies = await response.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Empty(movies);

    }

    [Fact]
    public async Task Post_And_Get_ReturnsMovie_5()
    {
        // Arrange
        var client = CreateClient();

        var newMovie = new Movie()
        {
            Title = "The Godfather 5",
            Director = "Francis Ford Coppola"
        };


        // Act

        var postResponse = await client.PostAsJsonAsync("/movies", newMovie);
        postResponse.EnsureSuccessStatusCode();
        var getResponse = await client.GetAsync("/movies");


        // Assert

        getResponse.EnsureSuccessStatusCode();
        var movies = await getResponse.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Single(movies);
        Assert.Equal(newMovie.Title, movies[0].Title);
        Assert.Equal(newMovie.Director, movies[0].Director);

    }

    [Fact]
    public async Task Get_ReturnsNoMovies_6()
    {
        // Arrange
        var client = CreateClient();


        // Act
        var response = await client.GetAsync("/movies");

        // Assert

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var movies = await response.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Empty(movies);

    }

    [Fact]
    public async Task Post_And_Get_ReturnsMovie_6()
    {
        // Arrange
        var client = CreateClient();

        var newMovie = new Movie()
        {
            Title = "The Godfather 6",
            Director = "Francis Ford Coppola"
        };


        // Act

        var postResponse = await client.PostAsJsonAsync("/movies", newMovie);
        postResponse.EnsureSuccessStatusCode();
        var getResponse = await client.GetAsync("/movies");


        // Assert

        getResponse.EnsureSuccessStatusCode();
        var movies = await getResponse.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Single(movies);
        Assert.Equal(newMovie.Title, movies[0].Title);
        Assert.Equal(newMovie.Director, movies[0].Director);

    }

    [Fact]
    public async Task Get_ReturnsNoMovies_7()
    {
        // Arrange
        var client = CreateClient();


        // Act
        var response = await client.GetAsync("/movies");

        // Assert

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var movies = await response.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Empty(movies);

    }

    [Fact]
    public async Task Post_And_Get_ReturnsMovie_7()
    {
        // Arrange
        var client = CreateClient();

        var newMovie = new Movie()
        {
            Title = "The Godfather 7",
            Director = "Francis Ford Coppola"
        };


        // Act

        var postResponse = await client.PostAsJsonAsync("/movies", newMovie);
        postResponse.EnsureSuccessStatusCode();
        var getResponse = await client.GetAsync("/movies");


        // Assert

        getResponse.EnsureSuccessStatusCode();
        var movies = await getResponse.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Single(movies);
        Assert.Equal(newMovie.Title, movies[0].Title);
        Assert.Equal(newMovie.Director, movies[0].Director);

    }

    [Fact]
    public async Task Get_ReturnsNoMovies_8()
    {
        // Arrange
        var client = CreateClient();


        // Act
        var response = await client.GetAsync("/movies");

        // Assert

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var movies = await response.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Empty(movies);

    }

    [Fact]
    public async Task Post_And_Get_ReturnsMovie_8()
    {
        // Arrange
        var client = CreateClient();

        var newMovie = new Movie()
        {
            Title = "The Godfather 8",
            Director = "Francis Ford Coppola"
        };


        // Act

        var postResponse = await client.PostAsJsonAsync("/movies", newMovie);
        postResponse.EnsureSuccessStatusCode();
        var getResponse = await client.GetAsync("/movies");


        // Assert

        getResponse.EnsureSuccessStatusCode();
        var movies = await getResponse.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Single(movies);
        Assert.Equal(newMovie.Title, movies[0].Title);
        Assert.Equal(newMovie.Director, movies[0].Director);

    }

    [Fact]
    public async Task Get_ReturnsNoMovies_9()
    {
        // Arrange
        var client = CreateClient();


        // Act
        var response = await client.GetAsync("/movies");

        // Assert

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var movies = await response.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Empty(movies);

    }

    [Fact]
    public async Task Post_And_Get_ReturnsMovie_9()
    {
        // Arrange
        var client = CreateClient();

        var newMovie = new Movie()
        {
            Title = "The Godfather 9",
            Director = "Francis Ford Coppola"
        };


        // Act

        var postResponse = await client.PostAsJsonAsync("/movies", newMovie);
        postResponse.EnsureSuccessStatusCode();
        var getResponse = await client.GetAsync("/movies");


        // Assert

        getResponse.EnsureSuccessStatusCode();
        var movies = await getResponse.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Single(movies);
        Assert.Equal(newMovie.Title, movies[0].Title);
        Assert.Equal(newMovie.Director, movies[0].Director);

    }

    [Fact]
    public async Task Get_ReturnsNoMovies_10()
    {
        // Arrange
        var client = CreateClient();


        // Act
        var response = await client.GetAsync("/movies");

        // Assert

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var movies = await response.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Empty(movies);

    }

    [Fact]
    public async Task Post_And_Get_ReturnsMovie_10()
    {
        // Arrange
        var client = CreateClient();

        var newMovie = new Movie()
        {
            Title = "The Godfather 10",
            Director = "Francis Ford Coppola"
        };


        // Act

        var postResponse = await client.PostAsJsonAsync("/movies", newMovie);
        postResponse.EnsureSuccessStatusCode();
        var getResponse = await client.GetAsync("/movies");


        // Assert

        getResponse.EnsureSuccessStatusCode();
        var movies = await getResponse.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Single(movies);
        Assert.Equal(newMovie.Title, movies[0].Title);
        Assert.Equal(newMovie.Director, movies[0].Director);

    }

    [Fact]
    public async Task Get_ReturnsNoMovies_11()
    {
        // Arrange
        var client = CreateClient();


        // Act
        var response = await client.GetAsync("/movies");

        // Assert

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var movies = await response.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Empty(movies);

    }

    [Fact]
    public async Task Post_And_Get_ReturnsMovie_11()
    {
        // Arrange
        var client = CreateClient();

        var newMovie = new Movie()
        {
            Title = "The Godfather 11",
            Director = "Francis Ford Coppola"
        };


        // Act

        var postResponse = await client.PostAsJsonAsync("/movies", newMovie);
        postResponse.EnsureSuccessStatusCode();
        var getResponse = await client.GetAsync("/movies");


        // Assert

        getResponse.EnsureSuccessStatusCode();
        var movies = await getResponse.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Single(movies);
        Assert.Equal(newMovie.Title, movies[0].Title);
        Assert.Equal(newMovie.Director, movies[0].Director);

    }

    [Fact]
    public async Task Get_ReturnsNoMovies_12()
    {
        // Arrange
        var client = CreateClient();


        // Act
        var response = await client.GetAsync("/movies");

        // Assert

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var movies = await response.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Empty(movies);

    }

    [Fact]
    public async Task Post_And_Get_ReturnsMovie_12()
    {
        // Arrange
        var client = CreateClient();

        var newMovie = new Movie()
        {
            Title = "The Godfather 12",
            Director = "Francis Ford Coppola"
        };


        // Act

        var postResponse = await client.PostAsJsonAsync("/movies", newMovie);
        postResponse.EnsureSuccessStatusCode();
        var getResponse = await client.GetAsync("/movies");


        // Assert

        getResponse.EnsureSuccessStatusCode();
        var movies = await getResponse.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Single(movies);
        Assert.Equal(newMovie.Title, movies[0].Title);
        Assert.Equal(newMovie.Director, movies[0].Director);

    }

    [Fact]
    public async Task Get_ReturnsNoMovies_13()
    {
        // Arrange
        var client = CreateClient();


        // Act
        var response = await client.GetAsync("/movies");

        // Assert

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var movies = await response.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Empty(movies);

    }

    [Fact]
    public async Task Post_And_Get_ReturnsMovie_13()
    {
        // Arrange
        var client = CreateClient();

        var newMovie = new Movie()
        {
            Title = "The Godfather 13",
            Director = "Francis Ford Coppola"
        };


        // Act

        var postResponse = await client.PostAsJsonAsync("/movies", newMovie);
        postResponse.EnsureSuccessStatusCode();
        var getResponse = await client.GetAsync("/movies");


        // Assert

        getResponse.EnsureSuccessStatusCode();
        var movies = await getResponse.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Single(movies);
        Assert.Equal(newMovie.Title, movies[0].Title);
        Assert.Equal(newMovie.Director, movies[0].Director);

    }

    [Fact]
    public async Task Get_ReturnsNoMovies_14()
    {
        // Arrange
        var client = CreateClient();


        // Act
        var response = await client.GetAsync("/movies");

        // Assert

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var movies = await response.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Empty(movies);

    }

    [Fact]
    public async Task Post_And_Get_ReturnsMovie_14()
    {
        // Arrange
        var client = CreateClient();

        var newMovie = new Movie()
        {
            Title = "The Godfather 14",
            Director = "Francis Ford Coppola"
        };


        // Act

        var postResponse = await client.PostAsJsonAsync("/movies", newMovie);
        postResponse.EnsureSuccessStatusCode();
        var getResponse = await client.GetAsync("/movies");


        // Assert

        getResponse.EnsureSuccessStatusCode();
        var movies = await getResponse.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Single(movies);
        Assert.Equal(newMovie.Title, movies[0].Title);
        Assert.Equal(newMovie.Director, movies[0].Director);

    }

    [Fact]
    public async Task Get_ReturnsNoMovies_15()
    {
        // Arrange
        var client = CreateClient();


        // Act
        var response = await client.GetAsync("/movies");

        // Assert

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var movies = await response.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Empty(movies);

    }

    [Fact]
    public async Task Post_And_Get_ReturnsMovie_15()
    {
        // Arrange
        var client = CreateClient();

        var newMovie = new Movie()
        {
            Title = "The Godfather 15",
            Director = "Francis Ford Coppola"
        };


        // Act

        var postResponse = await client.PostAsJsonAsync("/movies", newMovie);
        postResponse.EnsureSuccessStatusCode();
        var getResponse = await client.GetAsync("/movies");


        // Assert

        getResponse.EnsureSuccessStatusCode();
        var movies = await getResponse.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Single(movies);
        Assert.Equal(newMovie.Title, movies[0].Title);
        Assert.Equal(newMovie.Director, movies[0].Director);

    }

    [Fact]
    public async Task Get_ReturnsNoMovies_16()
    {
        // Arrange
        var client = CreateClient();


        // Act
        var response = await client.GetAsync("/movies");

        // Assert

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var movies = await response.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Empty(movies);

    }

    [Fact]
    public async Task Post_And_Get_ReturnsMovie_16()
    {
        // Arrange
        var client = CreateClient();

        var newMovie = new Movie()
        {
            Title = "The Godfather 16",
            Director = "Francis Ford Coppola"
        };


        // Act

        var postResponse = await client.PostAsJsonAsync("/movies", newMovie);
        postResponse.EnsureSuccessStatusCode();
        var getResponse = await client.GetAsync("/movies");


        // Assert

        getResponse.EnsureSuccessStatusCode();
        var movies = await getResponse.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Single(movies);
        Assert.Equal(newMovie.Title, movies[0].Title);
        Assert.Equal(newMovie.Director, movies[0].Director);

    }

    [Fact]
    public async Task Get_ReturnsNoMovies_17()
    {
        // Arrange
        var client = CreateClient();


        // Act
        var response = await client.GetAsync("/movies");

        // Assert

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var movies = await response.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Empty(movies);

    }

    [Fact]
    public async Task Post_And_Get_ReturnsMovie_17()
    {
        // Arrange
        var client = CreateClient();

        var newMovie = new Movie()
        {
            Title = "The Godfather 17",
            Director = "Francis Ford Coppola"
        };


        // Act

        var postResponse = await client.PostAsJsonAsync("/movies", newMovie);
        postResponse.EnsureSuccessStatusCode();
        var getResponse = await client.GetAsync("/movies");


        // Assert

        getResponse.EnsureSuccessStatusCode();
        var movies = await getResponse.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Single(movies);
        Assert.Equal(newMovie.Title, movies[0].Title);
        Assert.Equal(newMovie.Director, movies[0].Director);

    }

    [Fact]
    public async Task Get_ReturnsNoMovies_18()
    {
        // Arrange
        var client = CreateClient();


        // Act
        var response = await client.GetAsync("/movies");

        // Assert

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var movies = await response.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Empty(movies);

    }

    [Fact]
    public async Task Post_And_Get_ReturnsMovie_18()
    {
        // Arrange
        var client = CreateClient();

        var newMovie = new Movie()
        {
            Title = "The Godfather 18",
            Director = "Francis Ford Coppola"
        };


        // Act

        var postResponse = await client.PostAsJsonAsync("/movies", newMovie);
        postResponse.EnsureSuccessStatusCode();
        var getResponse = await client.GetAsync("/movies");


        // Assert

        getResponse.EnsureSuccessStatusCode();
        var movies = await getResponse.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Single(movies);
        Assert.Equal(newMovie.Title, movies[0].Title);
        Assert.Equal(newMovie.Director, movies[0].Director);

    }

    [Fact]
    public async Task Get_ReturnsNoMovies_19()
    {
        // Arrange
        var client = CreateClient();


        // Act
        var response = await client.GetAsync("/movies");

        // Assert

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var movies = await response.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Empty(movies);

    }

    [Fact]
    public async Task Post_And_Get_ReturnsMovie_19()
    {
        // Arrange
        var client = CreateClient();

        var newMovie = new Movie()
        {
            Title = "The Godfather 19",
            Director = "Francis Ford Coppola"
        };


        // Act

        var postResponse = await client.PostAsJsonAsync("/movies", newMovie);
        postResponse.EnsureSuccessStatusCode();
        var getResponse = await client.GetAsync("/movies");


        // Assert

        getResponse.EnsureSuccessStatusCode();
        var movies = await getResponse.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Single(movies);
        Assert.Equal(newMovie.Title, movies[0].Title);
        Assert.Equal(newMovie.Director, movies[0].Director);

    }

    [Fact]
    public async Task Get_ReturnsNoMovies_20()
    {
        // Arrange
        var client = CreateClient();


        // Act
        var response = await client.GetAsync("/movies");

        // Assert

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var movies = await response.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Empty(movies);

    }

    [Fact]
    public async Task Post_And_Get_ReturnsMovie_20()
    {
        // Arrange
        var client = CreateClient();

        var newMovie = new Movie()
        {
            Title = "The Godfather 20",
            Director = "Francis Ford Coppola"
        };


        // Act

        var postResponse = await client.PostAsJsonAsync("/movies", newMovie);
        postResponse.EnsureSuccessStatusCode();
        var getResponse = await client.GetAsync("/movies");


        // Assert

        getResponse.EnsureSuccessStatusCode();
        var movies = await getResponse.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Single(movies);
        Assert.Equal(newMovie.Title, movies[0].Title);
        Assert.Equal(newMovie.Director, movies[0].Director);

    }

    [Fact]
    public async Task Get_ReturnsNoMovies_21()
    {
        // Arrange
        var client = CreateClient();


        // Act
        var response = await client.GetAsync("/movies");

        // Assert

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var movies = await response.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Empty(movies);

    }

    [Fact]
    public async Task Post_And_Get_ReturnsMovie_21()
    {
        // Arrange
        var client = CreateClient();

        var newMovie = new Movie()
        {
            Title = "The Godfather 21",
            Director = "Francis Ford Coppola"
        };


        // Act

        var postResponse = await client.PostAsJsonAsync("/movies", newMovie);
        postResponse.EnsureSuccessStatusCode();
        var getResponse = await client.GetAsync("/movies");


        // Assert

        getResponse.EnsureSuccessStatusCode();
        var movies = await getResponse.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Single(movies);
        Assert.Equal(newMovie.Title, movies[0].Title);
        Assert.Equal(newMovie.Director, movies[0].Director);

    }

    [Fact]
    public async Task Get_ReturnsNoMovies_22()
    {
        // Arrange
        var client = CreateClient();


        // Act
        var response = await client.GetAsync("/movies");

        // Assert

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var movies = await response.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Empty(movies);

    }

    [Fact]
    public async Task Post_And_Get_ReturnsMovie_22()
    {
        // Arrange
        var client = CreateClient();

        var newMovie = new Movie()
        {
            Title = "The Godfather 22",
            Director = "Francis Ford Coppola"
        };


        // Act

        var postResponse = await client.PostAsJsonAsync("/movies", newMovie);
        postResponse.EnsureSuccessStatusCode();
        var getResponse = await client.GetAsync("/movies");


        // Assert

        getResponse.EnsureSuccessStatusCode();
        var movies = await getResponse.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Single(movies);
        Assert.Equal(newMovie.Title, movies[0].Title);
        Assert.Equal(newMovie.Director, movies[0].Director);

    }

    [Fact]
    public async Task Get_ReturnsNoMovies_23()
    {
        // Arrange
        var client = CreateClient();


        // Act
        var response = await client.GetAsync("/movies");

        // Assert

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var movies = await response.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Empty(movies);

    }

    [Fact]
    public async Task Post_And_Get_ReturnsMovie_23()
    {
        // Arrange
        var client = CreateClient();

        var newMovie = new Movie()
        {
            Title = "The Godfather 23",
            Director = "Francis Ford Coppola"
        };


        // Act

        var postResponse = await client.PostAsJsonAsync("/movies", newMovie);
        postResponse.EnsureSuccessStatusCode();
        var getResponse = await client.GetAsync("/movies");


        // Assert

        getResponse.EnsureSuccessStatusCode();
        var movies = await getResponse.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Single(movies);
        Assert.Equal(newMovie.Title, movies[0].Title);
        Assert.Equal(newMovie.Director, movies[0].Director);

    }

    [Fact]
    public async Task Get_ReturnsNoMovies_24()
    {
        // Arrange
        var client = CreateClient();


        // Act
        var response = await client.GetAsync("/movies");

        // Assert

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var movies = await response.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Empty(movies);

    }

    [Fact]
    public async Task Post_And_Get_ReturnsMovie_24()
    {
        // Arrange
        var client = CreateClient();

        var newMovie = new Movie()
        {
            Title = "The Godfather 24",
            Director = "Francis Ford Coppola"
        };


        // Act

        var postResponse = await client.PostAsJsonAsync("/movies", newMovie);
        postResponse.EnsureSuccessStatusCode();
        var getResponse = await client.GetAsync("/movies");


        // Assert

        getResponse.EnsureSuccessStatusCode();
        var movies = await getResponse.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Single(movies);
        Assert.Equal(newMovie.Title, movies[0].Title);
        Assert.Equal(newMovie.Director, movies[0].Director);

    }

    [Fact]
    public async Task Get_ReturnsNoMovies_25()
    {
        // Arrange
        var client = CreateClient();


        // Act
        var response = await client.GetAsync("/movies");

        // Assert

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var movies = await response.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Empty(movies);

    }

    [Fact]
    public async Task Post_And_Get_ReturnsMovie_25()
    {
        // Arrange
        var client = CreateClient();

        var newMovie = new Movie()
        {
            Title = "The Godfather 25",
            Director = "Francis Ford Coppola"
        };


        // Act

        var postResponse = await client.PostAsJsonAsync("/movies", newMovie);
        postResponse.EnsureSuccessStatusCode();
        var getResponse = await client.GetAsync("/movies");


        // Assert

        getResponse.EnsureSuccessStatusCode();
        var movies = await getResponse.Content.ReadFromJsonAsync<Movie[]>();
        Assert.NotNull(movies);
        Assert.Single(movies);
        Assert.Equal(newMovie.Title, movies[0].Title);
        Assert.Equal(newMovie.Director, movies[0].Director);

    }

}
