using MediatR;

namespace ClothesShop.Application.Features.ProductVariants.Queries.GetVariantsByProduct;

public class GetVariantsByProductQuery
    : IRequest<List<GetVariantsByProductVm>>
{
    public string ProductId { get; set; } = null!;
}
