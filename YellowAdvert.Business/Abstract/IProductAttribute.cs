using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YellowAdvert.Business.Abstract.Redis;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.Business.Abstract
{
    public interface IProductAttributeService:IBaseRedisService<ProductAttributes>
    {
    }
}
