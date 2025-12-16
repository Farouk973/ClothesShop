using MediatR;

namespace ClothesShop.Application.Features.Images.Commands.UpdateImage;

public class UpdateImageCommand : IRequest
{
    public string Id { get; set; } = null!;
    public string Url { get; set; } = null!;
    public string? AltText { get; set; }
    public List<string> Tags { get; set; } = new();
}
