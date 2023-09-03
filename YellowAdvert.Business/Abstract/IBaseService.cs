using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using YellowAdvert.Business.Args.Generic;
using YellowAdvert.Entities.Base;

namespace YellowAdvert.Business.Abstract
{
    public interface IBaseService<T> where T: ModelBase
    {
        Task<T> Add(CreateArgs<T> args, CancellationToken cancellationToken = default);
        Task<T> Update(T entity, CancellationToken cancellationToken = default);
        Task Delete(Guid id,CancellationToken cancellationToken = default);
        Task<T> GetById(GetByIdArgs args,CancellationToken cancellationToken = default);
        Task<List<T>> GetAll(GetAllArgs args,CancellationToken cancellationToken = default);
        Task<List<T>> GetByCondition(Expression<Func<T,bool>> expression,CancellationToken cancellationToken = default);

    }
}
