using System.Linq.Expressions;
using YellowAdvert.Entities.Base;

namespace YellowAdvert.DataAccess.Abstract;

public interface IEntityRepository<T> where T : ModelBase
{
    Task<List<T>> GetAll();
    Task<List<T>> Get(Expression<Func<T, bool>> filter);
    Task<T> GetById(Guid id);
    Task Add(T entity);
    Task Update(T entity);
    Task Update(List<T> entities);
    Task PermanentDelete(Guid id);
    Task SoftDelete(Guid id);
}
