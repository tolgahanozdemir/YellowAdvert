using YellowAdvert.Business.Abstract;
using YellowAdvert.DataAccess.Abstract;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.Business.Concrete;

public class ProductService : BaseService<Product>, IProductService
{
    private readonly IProductDal _productDal;
    public ProductService(IProductDal productDal) : base(productDal)
    {
        _productDal = productDal;
    }
}
