using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YellowAdvert.DataAccess.Abstract;
using YellowAdvert.Entities.Base;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.Business.Abstract
{
    public abstract class BaseService<T>:IBaseService<T> where T : ModelBase
    {
        private readonly IEntityRepository<T> _entityRepository;
        public BaseService(IEntityRepository<T> entityRepository)
        {
            _entityRepository = entityRepository;
        }
        public virtual void Add(T entity)
        {
            _entityRepository.Add(entity);
        }
        public virtual void Update(T entity)
        {
            _entityRepository.Update(entity);
        }
        public virtual void Delete(Guid id)
        {
            //_entityRepository.SoftDelete(id);
            
        }
        public virtual T GetById(Guid id)
        {
            return _entityRepository.GetById(id);
        }
        public virtual List<T> GetAll()
        {
            return _entityRepository.GetAll();
        }
        public virtual List<T> GetByCondition(Expression<Func<T,bool>> expression)
        {
            return _entityRepository.GetAll(expression);
        }

    }
}
