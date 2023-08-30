using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using YellowAdvert.DataAccess.Abstract;
using YellowAdvert.Entities.Base;

namespace YellowAdvert.DataAccess.Concrete.EntityFramework;

public class EfEntityRepositoryBase<T, TContext> : IEntityRepository<T>
        where T : ModelBase
        where TContext : DbContext, new()
{
    public void Add(T entity)
    {
        using (TContext context = new TContext())
        {
            var addedEntity = context.Add(entity);
            context.SaveChanges();
        }
    }

    public void PermanentDelete(T entity)
    {
        using (TContext context = new TContext())
        {
            var deletedEntity = context.Remove(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }
    }
    public void SoftDelete(T entity)
    {
        using (TContext context = new TContext())
        {
            entity.Deleted = true;
            context.SaveChanges();
        }
    }

    public T Get(Expression<Func<T, bool>> filter)
    {
        using (TContext context = new TContext())
        {
            return context.Set<T>().SingleOrDefault(filter);
        }
    }

    public List<T> GetAll(Expression<Func<T, bool>> filter = null)
    {
        using (TContext context = new TContext())
        {
            return filter == null
                ? context.Set<T>().ToList()
                : context.Set<T>().Where(filter).ToList();
        }
    }

    public void Update(T entity)
    {
        using (TContext context = new TContext())
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
    public void Update(List<T> entities)
    {
        using (TContext context = new TContext())
        {
            foreach (var entity in entities)
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
            }
            context.SaveChanges();
        }
    }

    public T GetById(Guid id)
    {
        using (TContext context = new TContext())
        {
            return context.Set<T>().Find(id);
        }
    }
}
