using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using Migrator;

var serviceProvider = CreateServices();

using var scope = serviceProvider.CreateScope();
UpdateDatabase(scope.ServiceProvider);

static IServiceProvider CreateServices()
{
    return new ServiceCollection()
        .AddFluentMigratorCore()
        .ConfigureRunner(rb => rb
            .AddMySql5()
            .WithGlobalConnectionString("Server=127.0.0.1;Database=log;Uid=app;Password=12345;SSL Mode=None;Allow User Variables=True;Port=3307;")
            .ScanIn(typeof(AddTable).Assembly).For.Migrations())
        .AddLogging(lb => lb.AddFluentMigratorConsole())
        .BuildServiceProvider(false);
}

static void UpdateDatabase(IServiceProvider serviceProvider)
{
    var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
    runner.MigrateUp();
}