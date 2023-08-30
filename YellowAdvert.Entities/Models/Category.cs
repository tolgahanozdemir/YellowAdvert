using YellowAdvert.Entities.Base;

namespace YellowAdvert.Entities.Models;

public class Category : ModelBase
{
    public string Name { get; set; }
    public int? ParentId { get; set; }
    public bool HasSubCategory { get; set; } = false;
}
