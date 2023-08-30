using YellowAdvert.Entities.Base;

namespace YellowAdvert.Entities.Models;

public class ProductAttributes : ModelBase
{
    public int ProductId { get; set; }
    public int CategoryAttributeId { get; set; }
    public int? CategoryAttributeValueId { get; set; }
    public string? CustomCategoryAttributeValue { get; set; }
}