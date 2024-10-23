using Domain.Models;
using Infrastructrure.DatabaseContext.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructrure.DatabaseContext;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<TargetCategory> TargetCategories { get; set; } = null!;
    public DbSet<Target> Targets { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ApplyConfigurations(modelBuilder);
        AddTestData(modelBuilder);
    }

    private void ApplyConfigurations(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new TargetConfiguration());
        modelBuilder.ApplyConfiguration(new TargetCategoryConfiguration());
    }

    // For development tests
    private void AddTestData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User {Id = 1, Name = "Name1", Email = "name1@gmail.com", PasswordHash = "hash1", Level = 1},
            new User {Id = 2, Name = "Name2", Email = "name2@gmail.com", PasswordHash = "hash2", Level = 2},
            new User {Id = 3, Name = "Name3", Email = "name3@gmail.com", PasswordHash = "hash3", Level = 3}
            );
        modelBuilder.Entity<TargetCategory>().HasData(
            new TargetCategory {Id = 1, Name = "Category1", Description = "Category1 Description"},
            new TargetCategory {Id = 2, Name = "Category2", Description = "Category2 Description"}
            );
        modelBuilder.Entity<Target>().HasData(
            new Target {Id = 1, Name = "target1", CategoryId = 1, Description = "target1 Description", Score = 50},
            new Target {Id = 2, Name = "target2", CategoryId = 1, Description = "target2 Description", Score = 30},
            new Target {Id = 3, Name = "target3", CategoryId = 2, Description = "target3 Description", Score = 150}
            );
    }
}