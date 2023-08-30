using FluentValidation;
using YellowAdvert.DataAccess.Abstract;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.Business.Validators;

public class CategoryValidator : AbstractValidator<Category>,IValidator
{
    private readonly IEntityRepository<Category> _categoryRepository;
    public CategoryValidator(IEntityRepository<Category> categoryRepository)
    {
        _categoryRepository = categoryRepository;

        RuleFor(x=>x.Name).NotEmpty().WithMessage("Name can not be empty");
        RuleFor(x => x.ParentId).Must(y => IsParentCategoryValid(y).Result).WithMessage("ParentId is not valid");
    }
    private async Task<bool> IsParentCategoryValid(Guid? id)
    {
        if(id == null) return false;

        var category = await _categoryRepository.GetById((Guid)id);
        
        return category == null ? false : category.HasSubCategory == true ? true : false;
    }
}
