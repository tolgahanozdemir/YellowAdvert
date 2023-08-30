using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using YellowAdvert.DataAccess.Abstract.Redis;
using YellowAdvert.Entities.Base;

namespace YellowAdvert.DataAccess.Concrete.Redis
{
    public class RedisRepositoryBase<T> : IRedisEntityRepository<T> where T:ModelBase
    {
        private readonly IDistributedCache _redisCache;
        public RedisRepositoryBase(IDistributedCache redisCache)
        {
            _redisCache = redisCache ?? throw new ArgumentNullException(nameof(redisCache));
        }

        public async Task<T> GetByKey(string key)
        {
            var entity = await _redisCache.GetStringAsync(key);
            if (entity == null)
                return null;
            return JsonConvert.DeserializeObject<T>(entity);
        }

        public async Task Delete(string key)
        {
            throw new NotImplementedException();
        }

        public async Task<T> Update(string key,T entity)
        {
            await _redisCache.SetStringAsync(key, JsonConvert.SerializeObject(entity));
            return await GetByKey(key);
        }
    }
}
