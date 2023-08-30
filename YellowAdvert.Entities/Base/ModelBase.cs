namespace YellowAdvert.Entities.Base;

public abstract class ModelBase
{
    public Guid Id { get; set; }
    public bool Deleted { get; set; } = false;
    public int LastUpdateUserId { get; set; }
    public DateTimeOffset CreateDate { get; set; }
    public DateTimeOffset LastUpdateDate { get; set; }
}
