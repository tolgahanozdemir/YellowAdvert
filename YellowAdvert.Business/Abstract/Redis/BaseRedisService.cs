using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YellowAdvert.DataAccess.Abstract;
using YellowAdvert.DataAccess.Abstract.Redis;
using YellowAdvert.Entities.Base;

namespace YellowAdvert.Business.Abstract.Redis
{
    public abstract class BaseRedisService<T> : IBaseRedisService<T> where T : ModelBase
    {
        private readonly IRedisEntityRepository<T> _entityRepository;
        public BaseRedisService(IRedisEntityRepository<T> entityRepository)
        {
            _entityRepository = entityRepository;
        }

        public async Task Delete(string key)
        {
            await _entityRepository.Delete(key);
        }

        public async Task<T> GetByKey(string key)
        {
            return await _entityRepository.GetByKey(key);
        }

        public async Task<T> Update(string key,T entity)
        {
            return await _entityRepository.Update(key, entity);
        }
    }
}
