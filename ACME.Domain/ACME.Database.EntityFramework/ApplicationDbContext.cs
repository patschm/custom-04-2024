using ACME.Database.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;

namespace ACME.Database.EntityFramework;

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
	{
	}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("Core");
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
    public DbSet<ProductGroup> ProductGroups => Set<ProductGroup>();
    public DbSet<Brand> Brands => Set<Brand>();
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Review> Reviews => Set<Review>();
    public DbSet<Reviewer> Reviewers => Set<Reviewer>();
}
