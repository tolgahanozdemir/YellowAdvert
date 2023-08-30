using YellowAdvert.DataAccess.Abstract;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.DataAccess.Concrete.EntityFramework;

public class EfCategoryAttributeValuesDal : EfEntityRepositoryBase<CategoryAttributeValues, YellowAdvertEfContext>, ICategoryAttributeValuesDal
{
}
