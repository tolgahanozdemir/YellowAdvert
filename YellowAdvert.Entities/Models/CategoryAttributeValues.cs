using YellowAdvert.Entities.Base;

namespace YellowAdvert.Entities.Models;

public class CategoryAttributeValues : ModelBase
{
    public int CategoryAttributeId { get; set; }
    public string Value { get; set; }
}
