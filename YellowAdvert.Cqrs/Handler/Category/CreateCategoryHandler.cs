using MediatR;
using YellowAdvert.Business.Abstract;
using YellowAdvert.Cqrs.Command;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.Cqrs.Handler;

public class CreateCategoryHandler : IRequestHandler<CreateCategoryCommand, Category>
{
    private readonly ICategoryService _categoryService;

    public CreateCategoryHandler(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    public async Task<Category> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        return await _categoryService.Add(request, cancellationToken);
    }
}
