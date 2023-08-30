using FluentValidation;
using YellowAdvert.DataAccess.Abstract;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.Business.Validators;

public class CategoryAttributeValidator : AbstractValidator<CategoryAttributes>, IValidator
{
    private readonly IEntityRepository<Category> _categoryRepository;
    public CategoryAttributeValidator(IEntityRepository<Category> categoryRepository)
    {
        _categoryRepository = categoryRepository;

        RuleFor(x => x.CategoryId).Must(y => IsCategoryValid(y).Result).WithMessage("CategoryId is not valid");
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name can not be empty");
        RuleFor(x => x.Type).NotEmpty().WithMessage("Type can not be empty");
    }

    private async Task<bool> IsCategoryValid(Guid id)
    {
        var category = await _categoryRepository.GetById(id);

        return category == null ? false : true;
    }
}
