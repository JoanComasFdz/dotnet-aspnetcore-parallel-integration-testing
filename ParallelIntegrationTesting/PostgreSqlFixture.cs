using Testcontainers.PostgreSql;

namespace ParallelIntegrationTesting;

public class PostgreSqlFixture : IAsyncLifetime
{
    private readonly PostgreSqlContainer _postgreSqlContainer;
    public string ConnectionString => _postgreSqlContainer is not null
        ? _postgreSqlContainer.GetConnectionString()
        : throw new InvalidOperationException("The PosgreSQLContainer has not been yet initialized.");

    public PostgreSqlFixture()
    {
        _postgreSqlContainer = new PostgreSqlBuilder()
            .WithDatabase("testdb")
            .WithUsername("postgres")
            .WithPassword("password")
            .WithCleanUp(false)
            .Build();
    }

    public async Task InitializeAsync()
    {
        // Start the PostgreSQL container before any tests run
        await _postgreSqlContainer.StartAsync();
    }

    public async Task DisposeAsync()
    {
        // Stop and clean up the container after all tests have run
        await _postgreSqlContainer.StopAsync();
        await _postgreSqlContainer.DisposeAsync();
    }
}
