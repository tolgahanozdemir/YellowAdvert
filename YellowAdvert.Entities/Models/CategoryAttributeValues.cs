using YellowAdvert.Entities.Base;

namespace YellowAdvert.Entities.Models;

public class CategoryAttributeValues : ModelBase
{
    public Guid CategoryAttributeId { get; set; }
    public string Value { get; set; }
    public CategoryAttributes CategoryAttributes { get; set; }
}
