using YellowAdvert.Business.Abstract;
using YellowAdvert.DataAccess.Abstract;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.Business.Concrete;

public class CategoryService : BaseService<Category>, ICategoryService
{
    private readonly ICategoryDal _categoryDal;
    public CategoryService(ICategoryDal categoryDal) : base(categoryDal)
    {
        _categoryDal = categoryDal;
    }
}
