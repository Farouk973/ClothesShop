using MediatR;

namespace ClothesShop.Application.Features.Videos.Commands.CreateVideo;

public class CreateVideoCommand : IRequest<string>
{
    public string Url { get; set; } = null!;
    public string? Title { get; set; }
    public string? Description { get; set; }

    public string? ProductId { get; set; }
    public string? PromotionId { get; set; }

    public List<string> Tags { get; set; } = new();
}
