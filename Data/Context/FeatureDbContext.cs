using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Context;

public class FeatureDbContext : DbContext
{
    public DbSet<Feature> Features { get; set; }

    public FeatureDbContext(DbContextOptions<FeatureDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Feature>()
            .Property(f => f.Created)
            .HasDefaultValueSql("getdate()");
    }
}
