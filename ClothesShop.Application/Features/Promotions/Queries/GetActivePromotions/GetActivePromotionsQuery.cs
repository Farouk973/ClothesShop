using MediatR;

namespace ClothesShop.Application.Features.Promotions.Queries.GetActivePromotions;

public class GetActivePromotionsQuery
    : IRequest<List<GetActivePromotionsVm>>
{
}
