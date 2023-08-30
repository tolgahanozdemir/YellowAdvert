using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YellowAdvert.Entities.Base;

namespace YellowAdvert.Business.Abstract
{
    public abstract class BaseService<T>:IBaseService<T> where T : ModelBase
    {
        public BaseService()
        {

        }
        public virtual void Add(T entity)
        {

        }
        public virtual void Update(T entity)
        {

        }
        public virtual void Delete(int id)
        {

        }
        public virtual T GetById(int id)
        {

        }
        public virtual List<T> GetAll()
        {

        }
        public virtual List<T> GetByCondition(Expression<Func<T,bool>> expression)
        {

        }
    }
}
