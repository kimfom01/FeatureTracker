using Microsoft.EntityFrameworkCore;
using ProjectManager.Models;

namespace ProjectManager.Context;

public class FeatureDbContext : DbContext
{
    public DbSet<Feature> Features { get; set; }
    public DbSet<Project> Project { get; set; }
    public DbSet<Client> Clients { get; set; }

    public FeatureDbContext(DbContextOptions<FeatureDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Feature>()
            .Property(f => f.Created)
            .HasDefaultValueSql("now() at time zone 'utc'");
    }
}
