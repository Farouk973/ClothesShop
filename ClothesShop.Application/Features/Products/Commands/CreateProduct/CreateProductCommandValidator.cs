using FluentValidation;

namespace ClothesShop.Application.Features.Products.Commands.CreateProduct;

public class CreateProductCommandValidator
    : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.Reference).NotEmpty();
        RuleFor(x => x.CostPrice).GreaterThan(0);
        RuleFor(x => x.SellingPrice).GreaterThan(0);
        RuleFor(x => x.CategoryId).NotEmpty();
    }
}
