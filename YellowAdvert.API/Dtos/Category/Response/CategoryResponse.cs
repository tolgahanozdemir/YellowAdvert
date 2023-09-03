namespace YellowAdvert.API.Dtos.Category.Response;

public class CategoryResponse
{
    public string Name { get; set; }
    public Guid? ParentId { get; set; }
    public bool HasSubCategory { get; set; }
}
