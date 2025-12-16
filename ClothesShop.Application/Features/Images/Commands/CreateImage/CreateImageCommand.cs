using MediatR;

namespace ClothesShop.Application.Features.Images.Commands.CreateImage;

public class CreateImageCommand : IRequest<string>
{
    public string Url { get; set; } = null!;
    public string? AltText { get; set; }

    public string? ProductId { get; set; }
    public string? ProductVariantId { get; set; }
    public string? CategoryId { get; set; }
    public string? PromotionId { get; set; }

    public List<string> Tags { get; set; } = new();
}
