using Microsoft.EntityFrameworkCore;
using YellowAdvert.DataAccess.Abstract;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.DataAccess.Concrete.EntityFramework;

public class EfProductDal : EfEntityRepositoryBase<Product, YellowAdvertEfContext>, IProductDal
{
    public EfProductDal(DbContext context) : base(context)
    {
    }
}
