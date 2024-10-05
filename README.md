# dotnet-aspnetcore-parallel-integration-testing
This repository contains an example of how to run ASP .NET Core integration tests in parallel by default, each with its own database, in a single postgresql test container.

![A screenshot of visual studio showing the tests, the total time and the logs in the test output. on the right, Docker Desktop showing 1 PostgreSQL container running, and a console connected to that container listing the databases. There is one database for each test.](paralla-integration-tests-dotnet.png "Parallel integrations tests with 1 container and 1 DB per test.")

## Motivation
Running tests in parallel speeds up the time it takes to run tests covering the whole application or service and don;t require  micromanaging which data to clean after each test, or how to partition it.

The usual issue when running integration test against a real database, is that tests may interfere with each other, since they may be accessing the same tables.

A solution can be to partition data, usually with user and or tenant info, but not all systems have multiple users and or tenants. 

Anoother solution would be to use a different database container for each test, which can be done with test containers. But this would add an overhead that would not offset the benefit of running tests in parallel.

The proposed solution is to keep one single database container using test containers, but use an individual database for each test.

The example infrastructure give you:
- Tests are run in parallel by default. This elimitates the need to data cleanup and partitioning.
- Only one database docker container for the full test run.
- Each test method uses its own database.
- The database name contains the name of the test.
- The service logging is redirected to the test output.


# How to run the example
Have docker desktop running.

```bash
dotnet test
```

Or run all tests in Visual Studio.

The first time it may take longer since images may have to be dowloaded.

> Important: The test container is **not** removed after the test execution. This is so that you can start it, remotely connect to it, and explore its databases.

# How to use
In your testing project:
- Add a reference to ParallelIntegrationTesting
- `dotnet add package Meziantou.Xunit.ParallelTestFramework`

In your testing classes:
 - Pass the `PostgreSqlFixture fixture` and `ITestOutputHelper testOutputHelper` in the primary constructor.
 - Make the class inherit from `IntegrationTestBase<TProgram, TDbContext>`.

 It should look like:
 ```csharp
 public class MoviesApiIntegrationTest(PostgreSqlFixture fixture, ITestOutputHelper testOutputHelper)
    : IntegrationTestBase<Program, MoviesDbContext>(fixture, testOutputHelper)
{
}
 ```
---
 > To know more about how to parallelize or serialize test runs, check out https://github.com/meziantou/Meziantou.Xunit.ParallelTestFramework
.
