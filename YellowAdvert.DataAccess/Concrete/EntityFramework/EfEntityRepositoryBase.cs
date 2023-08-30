using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using YellowAdvert.DataAccess.Abstract;
using YellowAdvert.Entities.Base;

namespace YellowAdvert.DataAccess.Concrete.EntityFramework;

public class EfEntityRepositoryBase<T, TContext> : IEntityRepository<T>
        where T : ModelBase
        where TContext : DbContext
{
    private readonly DbContext _context;
    public EfEntityRepositoryBase(DbContext context)
    {
        _context = context;
    }
    public async Task Add(T entity)
    {

        var addedEntity = await _context.AddAsync(entity);
        await _context.SaveChangesAsync();

    }

    public async Task PermanentDelete(Guid id)
    {

        var entity = await GetById(id);
        if (entity != null)
        {
            var deletedEntity = _context.Remove(entity);
            deletedEntity.State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

    }
    public async Task SoftDelete(Guid id)
    {

        var entity = await GetById(id);
        if (entity != null)
        {
            entity.Deleted = true;
            await _context.SaveChangesAsync();
        }

    }

    public async Task<List<T>> GetAll()
    {

        return await _context.Set<T>().ToListAsync();
    }

    public async Task<List<T>> Get(Expression<Func<T, bool>> filter)
    {
        return await _context.Set<T>().Where(filter).ToListAsync();

    }

    public async Task Update(T entity)
    {

        var updatedEntity = _context.Entry(entity);
        updatedEntity.State = EntityState.Modified;
        await _context.SaveChangesAsync();

    }
    public async Task Update(List<T> entities)
    {

        foreach (var entity in entities)
        {
            var updatedEntity = _context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
        }
        await _context.SaveChangesAsync();

    }

    public async Task<T> GetById(Guid id)
    {

        return await _context.Set<T>().FindAsync(id);

    }
}
