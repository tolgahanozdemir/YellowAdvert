using Microsoft.EntityFrameworkCore;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.DataAccess.Concrete.EntityFramework;

public class YellowAdvertEfContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //TODO connectionString'i appsettings.json'dan al
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=YellowAdvert;Trusted_Connection=true");
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<CategoryAttributes> CategoryAttributes { get; set; }
    public DbSet<CategoryAttributeValues> CategoryAttributeValues { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductAttributes> ProductAttributes { get; set; }
}
