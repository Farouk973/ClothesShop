using MediatR;

namespace ClothesShop.Application.Features.Promotions.Queries.GetPromotionById;

public class GetPromotionByIdQuery : IRequest<GetPromotionByIdVm>
{
    public string Id { get; set; } = null!;
}
