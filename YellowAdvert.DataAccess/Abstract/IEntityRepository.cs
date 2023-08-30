using System.Linq.Expressions;
using YellowAdvert.Entities.Base;

namespace YellowAdvert.DataAccess.Abstract;

public interface IEntityRepository<TEntity> where TEntity : ModelBase
{
    List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);

    TEntity Get(Expression<Func<TEntity, bool>> filter);

    TEntity GetById(Guid id);

    void Add(TEntity entity);

    void Update(TEntity entity);

    void Delete(TEntity entity);
}
