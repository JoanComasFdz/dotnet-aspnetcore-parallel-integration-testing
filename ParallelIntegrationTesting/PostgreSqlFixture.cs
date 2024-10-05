using Testcontainers.PostgreSql;

namespace ParallelIntegrationTesting;

public class PostgreSqlFixture : IAsyncLifetime
{
    public PostgreSqlContainer PostgreSqlContainer { get; private set; }

    public PostgreSqlFixture()
    {
        PostgreSqlContainer = new PostgreSqlBuilder()
            .WithDatabase("testdb")
            .WithUsername("postgres")
            .WithPassword("password")
            .WithCleanUp(false)
            .Build();
    }

    public async Task InitializeAsync()
    {
        // Start the PostgreSQL container before any tests run
        await PostgreSqlContainer.StartAsync();
    }

    public async Task DisposeAsync()
    {
        // Stop and clean up the container after all tests have run
        await PostgreSqlContainer.StopAsync();
        await PostgreSqlContainer.DisposeAsync();
    }
}
