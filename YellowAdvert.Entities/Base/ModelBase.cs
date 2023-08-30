namespace YellowAdvert.Entities.Base;

public abstract class ModelBase
{
    public Guid Id { get; set; }
    public bool Deleted { get; set; } = false;
    public Guid? LastUpdateUserId { get; set; }
    public int CreatedBy { get; set; }
    public DateTimeOffset CreateDate { get; set; } = DateTimeOffset.Now;
    public DateTimeOffset? LastUpdateDate { get; set; }
}
