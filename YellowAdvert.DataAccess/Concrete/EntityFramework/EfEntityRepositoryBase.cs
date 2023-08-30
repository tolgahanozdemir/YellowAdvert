using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using YellowAdvert.DataAccess.Abstract;
using YellowAdvert.Entities.Base;

namespace YellowAdvert.DataAccess.Concrete.EntityFramework;

public class EfEntityRepositoryBase<T, TContext> : IEntityRepository<T>
        where T : ModelBase
        where TContext : DbContext, new()
{
    public async Task Add(T entity)
    {
        using (TContext context = new TContext())
        {
            var addedEntity = await context.AddAsync(entity);
            await context.SaveChangesAsync();
        }
    }

    public async Task PermanentDelete(Guid id)
    {
        using (TContext context = new TContext())
        {
            var entity = await GetById(id);
            if (entity != null)
            {
                var deletedEntity = context.Remove(entity);
                deletedEntity.State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }
        }
    }
    public async Task SoftDelete(Guid id)
    {
        using (TContext context = new TContext())
        {
            var entity = await GetById(id);
            if (entity != null)
            {
                entity.Deleted = true;
                await context.SaveChangesAsync();
            }
        }
    }

    public async Task<List<T>> GetAll()
    {
        using (TContext context = new TContext())
        {
            return await context.Set<T>().ToListAsync();
        }
    }

    public async Task<List<T>> Get(Expression<Func<T, bool>> filter)
    {
        using (TContext context = new TContext())
        {
            return await context.Set<T>().Where(filter).ToListAsync();
        }
    }

    public async Task Update(T entity)
    {
        using (TContext context = new TContext())
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
    public async Task Update(List<T> entities)
    {
        using (TContext context = new TContext())
        {
            foreach (var entity in entities)
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
            }
            await context.SaveChangesAsync();
        }
    }

    public async Task<T> GetById(Guid id)
    {
        using (TContext context = new TContext())
        {
            return await context.Set<T>().FindAsync(id);
        }
    }
}
