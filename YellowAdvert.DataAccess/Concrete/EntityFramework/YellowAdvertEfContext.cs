using Microsoft.EntityFrameworkCore;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.DataAccess.Concrete.EntityFramework;

public class YellowAdvertEfContext : DbContext
{
    public YellowAdvertEfContext(DbContextOptions<YellowAdvertEfContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<CategoryAttributes> CategoryAttributes { get; set; }
    public DbSet<CategoryAttributeValues> CategoryAttributeValues { get; set; }
    public DbSet<Product> Products { get; set; }
}
