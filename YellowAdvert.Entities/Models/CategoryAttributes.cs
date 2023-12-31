﻿using YellowAdvert.Entities.Base;

namespace YellowAdvert.Entities.Models;

public class CategoryAttributes : ModelBase
{
    public string Name { get; set; }
    public Guid CategoryId { get; set; }
    public short Type { get; set; }
    public bool IsRequired { get; set; } = false;
    public bool IsCustom { get; set; } = false;
    public Category Category { get; set; }
    public ICollection<CategoryAttributeValues> CategoryAttributeValues { get; set; }
}
