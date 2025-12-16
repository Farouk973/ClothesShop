using MediatR;

namespace ClothesShop.Application.Features.ProductVariants.Commands.DeleteProductVariant;

public class DeleteProductVariantCommand : IRequest
{
    public string Id { get; set; } = null!;
}
