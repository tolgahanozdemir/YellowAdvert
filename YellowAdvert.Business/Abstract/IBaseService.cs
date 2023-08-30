using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using YellowAdvert.Entities.Base;

namespace YellowAdvert.Business.Abstract
{
    public interface IBaseService<T> where T: ModelBase
    {
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(Guid id);
        Task<T> GetById(Guid id);
        Task<List<T>> GetAll();
        Task<List<T>> GetByCondition(Expression<Func<T,bool>> expression);

    }
}
