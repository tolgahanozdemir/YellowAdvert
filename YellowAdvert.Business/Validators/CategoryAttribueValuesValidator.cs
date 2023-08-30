using FluentValidation;
using YellowAdvert.DataAccess.Abstract;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.Business.Validators;

public class CategoryAttribueValuesValidator : AbstractValidator<CategoryAttributeValues>, IValidator
{
    private readonly IEntityRepository<CategoryAttributes> _categoryAttributeRepository;
    public CategoryAttribueValuesValidator(IEntityRepository<CategoryAttributes> categoryRepository)
    {
        _categoryAttributeRepository = categoryRepository;

        RuleFor(x => x.CategoryAttributeId).Must(y => IsCategoryAttributeValid(y).Result).WithMessage("CategoryAttributeId is not valid");
        RuleFor(x => x.Value).NotEmpty().WithMessage("Value can not be empty");
    }
    private async Task<bool> IsCategoryAttributeValid(Guid id)
    {
        var categoryAttribute = await _categoryAttributeRepository.GetById(id);

        return categoryAttribute == null ? false : true;
    }
}
