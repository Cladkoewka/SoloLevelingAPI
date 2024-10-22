using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructrure.DatabaseContext;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<TargetCategory> TargetCategories { get; set; }
    public DbSet<Target> Targets { get; set; }
    public DbSet<User> Users { get; set; }
}