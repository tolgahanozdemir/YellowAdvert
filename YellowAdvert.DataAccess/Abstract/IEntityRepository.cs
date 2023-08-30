using System.Linq.Expressions;
using YellowAdvert.Entities.Base;

namespace YellowAdvert.DataAccess.Abstract;

public interface IEntityRepository<T> where T : ModelBase
{
    List<T> GetAll(Expression<Func<T, bool>> filter = null);
    T Get(Expression<Func<T, bool>> filter);
    T GetById(Guid id);
    void Add(T entity);
    void Update(T entity);
    void Update(List<T> entities);
    void PermanentDelete(T entity);
    void SoftDelete(T entity);
}
