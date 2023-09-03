using Microsoft.EntityFrameworkCore;
using YellowAdvert.DataAccess.Abstract;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.DataAccess.Concrete.EntityFramework;

public class EfProductAttributesDal : EfEntityRepositoryBase<ProductAttributes, YellowAdvertEfContext>, IProductAttributesDal
{
    public EfProductAttributesDal(DbContext context) : base(context)
    {
    }
}