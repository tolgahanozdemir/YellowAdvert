using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YellowAdvert.Entities.Base;

namespace YellowAdvert.DataAccess.Abstract.Redis
{
    public interface IRedisEntityRepository<T> where T:ModelBase
    {
        Task<T> GetByKey(string key);
        Task Delete(string key);
        Task<T> Update(string key,T entity);
    }
}
