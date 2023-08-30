using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YellowAdvert.Entities.Base;

namespace YellowAdvert.Business.Abstract.Redis
{
    public interface IBaseRedisService<T> where T:ModelBase
    {
        Task<T> Update(string key,T entity);
        Task Delete(string key);
        Task<T> GetByKey(string key);
    }
}
