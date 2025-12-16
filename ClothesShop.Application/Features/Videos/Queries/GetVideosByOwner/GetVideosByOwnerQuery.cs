using MediatR;

namespace ClothesShop.Application.Features.Videos.Queries.GetVideosByOwner;

public class GetVideosByOwnerQuery : IRequest<List<GetVideosByOwnerVm>>
{
    public string OwnerId { get; set; } = null!;
}
