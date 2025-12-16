using MediatR;

namespace ClothesShop.Application.Features.Images.Commands.DeleteImage;

public class DeleteImageCommand : IRequest
{
    public string Id { get; set; } = null!;
}
