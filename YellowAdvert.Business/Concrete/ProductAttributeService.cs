using YellowAdvert.Business.Abstract;
using YellowAdvert.DataAccess.Abstract;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.Business.Concrete;

public class ProductAttributeService : BaseService<ProductAttributes>, IProductAttributeService
{
    private readonly IProductAttributesDal _productAttributesDal;
    public ProductAttributeService(IProductAttributesDal productAttributesDal) : base(productAttributesDal)
    {
        _productAttributesDal = productAttributesDal;
    }
}
