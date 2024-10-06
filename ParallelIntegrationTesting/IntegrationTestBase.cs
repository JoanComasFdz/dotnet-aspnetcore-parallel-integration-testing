using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Npgsql;
using ParallelIntegrationTesting;
using Xunit.Abstractions;

namespace MoviesApi.IntegrationTests.Infrastructure;

public class IntegrationTestBase<TProgram, TDbContext>(PostgreSqlFixture fixture, ITestOutputHelper testOutputHelper)
    : WebApplicationFactory<TProgram>, IClassFixture<PostgreSqlFixture>
    where TProgram : class
    where TDbContext : DbContext
{
    private readonly string _connectionString = fixture.ConnectionString;

    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        // Generate a unique database name for each test
        var uniqueDbName = $"moviesdb_{testOutputHelper.GetTestName()}";
        var uniqueConnectionString = new NpgsqlConnectionStringBuilder(this._connectionString)
        {
            Database = uniqueDbName
        }.ToString();

        builder.ConfigureServices(services =>
        {
            // Remove the previous database context configuration
            var options = services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<TDbContext>));
            if (options is not null)
            {
                services.Remove(options);
            }

            // Add the unique database context configuration for the test
            services.AddDbContext<TDbContext>(options => options.UseNpgsql(uniqueConnectionString));

            // Redirect logging to the test output
            services.AddLogging(logBuilder => logBuilder.AddXUnit(testOutputHelper));
        });
    }
}