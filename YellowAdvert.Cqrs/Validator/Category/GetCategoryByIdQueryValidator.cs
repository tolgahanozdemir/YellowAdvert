using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YellowAdvert.Business.Args;

namespace YellowAdvert.Cqrs.Validator.Category
{
    public class GetCategoryByIdQueryValidator:AbstractValidator<GetCategoryByIdArgs>
    {
        public GetCategoryByIdQueryValidator()
        {
            RuleFor(x => x.Id).NotNull().WithMessage("Category Id cannot be null");
        }
    }
}
