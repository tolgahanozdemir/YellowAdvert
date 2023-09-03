using Microsoft.EntityFrameworkCore;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.DataAccess.Concrete.EntityFramework;

public class YellowAdvertEfContext : DbContext
{
    public YellowAdvertEfContext(DbContextOptions<YellowAdvertEfContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .HasOne(x => x.Category)
            .WithMany(x => x.Products)
            .HasForeignKey(x => x.CategoryId);

        modelBuilder.Entity<Product>()
            .HasMany(x => x.ProductAttributes)
            .WithOne(x => x.Product)
            .HasForeignKey(x => x.ProductId);

        modelBuilder.Entity<CategoryAttributes>()
            .HasOne(x=>x.Category)
            .WithMany(x=>x.CategoryAttributes)
            .HasForeignKey(x=>x.CategoryId);

        modelBuilder.Entity<CategoryAttributeValues>()
            .HasOne(x => x.CategoryAttributes)
            .WithMany(x => x.CategoryAttributeValues)
            .HasForeignKey(x => x.CategoryAttributeId);
          
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<CategoryAttributes> CategoryAttributes { get; set; }
    public DbSet<CategoryAttributeValues> CategoryAttributeValues { get; set; }
    public DbSet<Product> Products { get; set; }
}
