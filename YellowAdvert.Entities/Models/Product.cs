using YellowAdvert.Entities.Base;

namespace YellowAdvert.Entities.Models;

public class Product : ModelBase
{
    public string Name { get; set; }
    public Guid CategoryId { get; set; }
    public decimal Price { get; set; }
    public bool IsActive { get; set; } = true;
}