using MediatR;

namespace ClothesShop.Application.Features.ProductVariants.Queries.GetProductVariantById;

public class GetProductVariantByIdQuery : IRequest<GetProductVariantByIdVm>
{
    public string Id { get; set; } = null!;
}
