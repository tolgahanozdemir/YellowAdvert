using FluentValidation;
using YellowAdvert.DataAccess.Abstract;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.Business.Validators;

public class ProductAttributeValidator : AbstractValidator<ProductAttributes>, IValidator
{
    private readonly IEntityRepository<Product> _productRepository;
    private readonly IEntityRepository<CategoryAttributes> _categoryAttributeRepository;
    private readonly IEntityRepository<CategoryAttributeValues> _categoryAttributeValueRepository;
    public ProductAttributeValidator(IEntityRepository<CategoryAttributes> categoryAttributeRepository, IEntityRepository<CategoryAttributeValues> categoryAttributeValueRepository, IEntityRepository<Product> productRepository)
    {
        _categoryAttributeRepository = categoryAttributeRepository;
        _categoryAttributeValueRepository = categoryAttributeValueRepository;
        _productRepository = productRepository;

        RuleFor(x => x.ProductId).Must(y => IsProductValid(y).Result).WithMessage("ProductId is not valid");
        RuleFor(x => x.CategoryAttributeId).Must(y => IsCategoryAttributeValid(y).Result).WithMessage("CategoryAttributeId is not valid");
        RuleFor(x => x.CategoryAttributeValueId).Must(y => IsCategoryAttributeValueValid(y).Result).WithMessage("CategoryAttributeValueId is not valid");

    }
    private async Task<bool> IsProductValid(Guid id)
    {
        var categoryAttribute = await _productRepository.GetById(id);

        return categoryAttribute == null ? false : true;
    }
    private async Task<bool> IsCategoryAttributeValid(Guid id)
    {
        var categoryAttribute = await _categoryAttributeRepository.GetById(id);

        return categoryAttribute == null ? false : true;
    }
    private async Task<bool> IsCategoryAttributeValueValid(Guid? id)
    {
        if (id == null) return false;

        var categoryAttributeValue = await _categoryAttributeValueRepository.GetById((Guid)id);

        return categoryAttributeValue == null ? false : true;
    }
}