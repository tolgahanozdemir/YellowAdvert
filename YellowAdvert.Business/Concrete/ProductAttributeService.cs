using YellowAdvert.Business.Abstract;
using YellowAdvert.Business.Abstract.Redis;
using YellowAdvert.DataAccess.Abstract;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.Business.Concrete
{
    public class ProductAttributeService : BaseRedisService<ProductAttributes>, IProductAttributeService
    {
        private readonly IProductAttributesDal _productAttributesDal;
        public ProductAttributeService(IProductAttributesDal productAttributesDal) : base(productAttributesDal)
        {
            _productAttributesDal = productAttributesDal;
        }
    }
}
