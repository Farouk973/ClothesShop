using MediatR;

namespace ClothesShop.Application.Features.Promotions.Commands.CreatePromotion;

public class CreatePromotionCommand : IRequest<string>
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public List<string> ImageIds { get; set; } = new();
    public List<string> VideoIds { get; set; } = new();
    public List<string> Tags { get; set; } = new();
}
