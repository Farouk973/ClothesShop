using MediatR;

namespace ClothesShop.Application.Features.Videos.Commands.UpdateVideo;

public class UpdateVideoCommand : IRequest
{
    public string Id { get; set; } = null!;
    public string Url { get; set; } = null!;
    public string? Title { get; set; }
    public string? Description { get; set; }
    public List<string> Tags { get; set; } = new();
}
