using MediatR;

namespace ClothesShop.Application.Features.Videos.Commands.DeleteVideo;

public class DeleteVideoCommand : IRequest
{
    public string Id { get; set; } = null!;
}
