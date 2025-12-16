using FluentValidation;

namespace ClothesShop.Application.Features.ProductVariants.Commands.UpdateProductVariant;

public class UpdateProductVariantCommandValidator
    : AbstractValidator<UpdateProductVariantCommand>
{
    public UpdateProductVariantCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.Color).NotEmpty();
        RuleFor(x => x.Size).NotEmpty();
        RuleFor(x => x.Stock).GreaterThanOrEqualTo(0);
    }
}
