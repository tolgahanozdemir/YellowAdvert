namespace YellowAdvert.API.Dtos.Request;

public class CreateCategoryRequest
{
    public string Name { get; set; }
    public Guid? ParentId { get; set; }
    public bool HasSubCategory { get; set; }
    public Guid CreatedBy { get; set; }
}
