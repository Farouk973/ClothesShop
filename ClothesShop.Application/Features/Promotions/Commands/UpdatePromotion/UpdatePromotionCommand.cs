using MediatR;

namespace ClothesShop.Application.Features.Promotions.Commands.UpdatePromotion;

public class UpdatePromotionCommand : IRequest
{
    public string Id { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public List<string> ImageIds { get; set; } = new();
    public List<string> VideoIds { get; set; } = new();
    public List<string> Tags { get; set; } = new();
}
