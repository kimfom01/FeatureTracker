using FeatureTracker.Context;
using Microsoft.EntityFrameworkCore;

namespace FeatureTracker.Helper;

public static class MigrationHelper
{
    public static async Task ManageDataAsync(IServiceProvider svcProvider)
    {
        //Service: An instance of db context
        var dbContextSvc = svcProvider.GetRequiredService<FeatureDbContext>();

        //Migration: This is the programmatic equivalent to Update-Database
        var pendingMigrations = await dbContextSvc.Database.GetPendingMigrationsAsync();

        if (pendingMigrations.Any())
        {
            await dbContextSvc.Database.MigrateAsync();
        }
    }
}
