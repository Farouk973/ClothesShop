using FluentValidation;

namespace ClothesShop.Application.Features.ProductVariants.Commands.DeleteProductVariant;

public class DeleteProductVariantCommandValidator
    : AbstractValidator<DeleteProductVariantCommand>
{
    public DeleteProductVariantCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}
