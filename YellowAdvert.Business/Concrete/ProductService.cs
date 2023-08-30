using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YellowAdvert.Business.Abstract;
using YellowAdvert.DataAccess.Abstract;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.Business.Concrete
{
    public class ProductService : BaseService<Product>, IProductService
    {
        private readonly IProductDal _productDal;
        public ProductService(IProductDal productDal) : base(productDal)
        {
            _productDal = productDal;
        }
    }
}
