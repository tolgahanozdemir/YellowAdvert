using MediatR;
using YellowAdvert.Business.Abstract;
using YellowAdvert.Cqrs.Query;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.Cqrs.Handler;

public class GetAllCategoriesHandler : IRequestHandler<GetAllCategoriesQuery, List<Category>>
{
    private readonly ICategoryService _categoryService;
    public GetAllCategoriesHandler(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }
    public async Task<List<Category>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
    {
        return await _categoryService.GetAll(request, cancellationToken);
    }
}
