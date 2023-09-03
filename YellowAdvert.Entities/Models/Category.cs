using YellowAdvert.Entities.Base;

namespace YellowAdvert.Entities.Models;

public class Category : ModelBase
{
    public string Name { get; set; }
    public Guid? ParentId { get; set; }
    public bool HasSubCategory { get; set; } = false;
    public ICollection<Product> Products { get; set; }
    public ICollection<CategoryAttributes> CategoryAttributes { get; set; }
}
