using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using YellowAdvert.DataAccess.Abstract;
using YellowAdvert.Entities.Base;

namespace YellowAdvert.DataAccess.Concrete.EntityFramework;

public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : ModelBase
        where TContext : DbContext, new()
{
    public void Add(TEntity entity)
    {
        using (TContext context = new TContext())
        {
            var addedEntity = context.Add(entity);
            context.SaveChanges();
        }
    }

    public void Delete(TEntity entity)
    {
        using (TContext context = new TContext())
        {
            //var deletedEntity = context.Remove(entity);
            //deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }
    }

    public TEntity Get(Expression<Func<TEntity, bool>> filter)
    {
        using (TContext context = new TContext())
        {
            return context.Set<TEntity>().SingleOrDefault(filter);
        }
    }

    public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
    {
        using (TContext context = new TContext())
        {
            return filter == null
                ? context.Set<TEntity>().ToList()
                : context.Set<TEntity>().Where(filter).ToList();
        }
    }

    public void Update(TEntity entity)
    {
        using (TContext context = new TContext())
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }

    public TEntity GetById(Guid id)
    {
        using (TContext context = new TContext())
        {
            return context.Set<TEntity>().Find(id);
        }
    }
}
