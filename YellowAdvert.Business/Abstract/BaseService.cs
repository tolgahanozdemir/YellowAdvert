using System.Linq.Expressions;
using YellowAdvert.Business.Args.Generic;
using YellowAdvert.DataAccess.Abstract;
using YellowAdvert.Entities.Base;

namespace YellowAdvert.Business.Abstract;

public abstract class BaseService<T> : IBaseService<T> where T : ModelBase
{
    private readonly IEntityRepository<T> _entityRepository;
    public BaseService(IEntityRepository<T> entityRepository)
    {
        _entityRepository = entityRepository;
    }
    public virtual async Task<T> Add(CreateArgs<T> args, CancellationToken cancellationToken = default)
    {
        var entity = args.New();
        await _entityRepository.Add(entity);
        return await GetById(new GetByIdArgs { Id = entity.Id }, cancellationToken);
    }
    public virtual async Task<T> Update(T entity, CancellationToken cancellationToken = default)
    {
        await _entityRepository.Update(entity);
        return await GetById(new GetByIdArgs { Id = entity.Id }, cancellationToken);
    }
    public virtual async Task Delete(Guid id, CancellationToken cancellationToken = default)
    {
        await _entityRepository.SoftDelete(id);

    }
    public virtual async Task<T> GetById(GetByIdArgs args, CancellationToken cancellationToken = default)
    {
        return await _entityRepository.GetById(args.Id);
    }
    public virtual async Task<List<T>> GetAll(GetAllArgs args, CancellationToken cancellationToken = default)
    {
        return await _entityRepository.GetAll();
    }
    public virtual async Task<List<T>> GetByCondition(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
    {
        return await _entityRepository.Get(expression);
    }

}
