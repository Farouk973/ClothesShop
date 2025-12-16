using MediatR;

namespace ClothesShop.Application.Features.Promotions.Commands.DeletePromotion;

public class DeletePromotionCommand : IRequest
{
    public string Id { get; set; } = null!;
}
