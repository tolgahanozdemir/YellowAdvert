using YellowAdvert.Entities.Base;

namespace YellowAdvert.Entities.Models;

public class ProductAttributes : ModelBase
{
    public Guid ProductId { get; set; }
    public Guid CategoryAttributeId { get; set; }
    public Guid? CategoryAttributeValueId { get; set; }
    public string? CustomCategoryAttributeValue { get; set; }
}