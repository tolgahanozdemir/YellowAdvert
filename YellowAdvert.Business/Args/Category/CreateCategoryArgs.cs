using YellowAdvert.Business.Args.Generic;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.Business.Args;

public class CreateCategoryArgs:CreateArgs<Category>
{
    public string Name { get; set; }
    public Guid? ParentId { get; set; }
    public bool HasSubCategory { get; set; }
    public Guid CreatedBy { get; set; }

    public override Category New()
    {
        var category = new Category();
        category.Id = Guid.NewGuid();
        category.Name = Name;
        category.ParentId = ParentId;
        category.CreatedBy = CreatedBy;
        category.HasSubCategory = HasSubCategory;
        return category;
    }
}
