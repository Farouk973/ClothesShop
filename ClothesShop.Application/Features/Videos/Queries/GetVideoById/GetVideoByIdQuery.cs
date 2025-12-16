using MediatR;

namespace ClothesShop.Application.Features.Videos.Queries.GetVideoById;

public class GetVideoByIdQuery : IRequest<GetVideoByIdVm>
{
    public string Id { get; set; } = null!;
}
