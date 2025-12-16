using MediatR;

namespace ClothesShop.Application.Features.Images.Queries.GetImageById;

public class GetImageByIdQuery : IRequest<GetImageByIdVm>
{
    public string Id { get; set; } = null!;
}
