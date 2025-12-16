using FluentValidation;

namespace ClothesShop.Application.Features.ProductVariants.Commands.CreateProductVariant;

public class CreateProductVariantCommandValidator
    : AbstractValidator<CreateProductVariantCommand>
{
    public CreateProductVariantCommandValidator()
    {
        RuleFor(x => x.ProductId).NotEmpty();
        RuleFor(x => x.Color).NotEmpty();
        RuleFor(x => x.Size).NotEmpty();
        RuleFor(x => x.Stock).GreaterThanOrEqualTo(0);
    }
}
