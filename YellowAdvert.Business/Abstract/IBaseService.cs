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
        void Add(T entity);
        void Update(T entity);
        void Delete(Guid id);
        T GetById(Guid id);
        List<T> GetAll();
        List<T> GetByCondition(Expression<Func<T,bool>> expression);

    }
}
