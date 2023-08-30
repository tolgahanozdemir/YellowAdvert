using YellowAdvert.DataAccess.Abstract.Redis;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.DataAccess.Abstract;

public interface IProductAttributesDal : IRedisEntityRepository<ProductAttributes>
{
}