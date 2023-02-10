using FeatureTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace FeatureTracker.Data;

public class FeatureDbContext : DbContext
{
    public DbSet<Feature> Features { get; set; }

    public FeatureDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Feature>()
            .Property(f => f.Created)
            .HasDefaultValueSql("getdate()");
    }
}
