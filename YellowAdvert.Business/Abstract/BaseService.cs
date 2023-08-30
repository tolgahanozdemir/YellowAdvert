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
            await _entityRepository = entityRepository;
        }
        public virtual async Task Add(T entity)
        {
            await _entityRepository.Add(entity);
        }
        public virtual async Task Update(T entity)
        {
            await _entityRepository.Update(entity);
        }
        public virtual async Task Delete(Guid id)
        {
            await _entityRepository.SoftDelete(id);

        }
        public virtual async Task<T> GetById(Guid id)
        {
            return await _entityRepository.GetById(id);
        }
        public virtual async Task<List<T>> GetAll()
        {
            return await _entityRepository.GetAll();
        }
        public virtual async Task<List<T>> GetByCondition(Expression<Func<T,bool>> expression)
        {
            return await _entityRepository.GetAll(expression);
        }

    }
}
