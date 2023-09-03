using FluentValidation;
using YellowAdvert.Business.Args;

namespace YellowAdvert.Cqrs.Validator.Category;

public class GetCategoryByIdQueryValidator:AbstractValidator<GetCategoryByIdArgs>
{
    public GetCategoryByIdQueryValidator()
    {
        RuleFor(x => x.Id).NotNull().WithMessage("Category Id cannot be null");
    }
}
