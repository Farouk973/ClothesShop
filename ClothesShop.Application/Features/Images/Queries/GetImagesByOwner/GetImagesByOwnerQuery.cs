using MediatR;

namespace ClothesShop.Application.Features.Images.Queries.GetImagesByOwner;

public class GetImagesByOwnerQuery : IRequest<List<GetImagesByOwnerVm>>
{
    public string OwnerId { get; set; } = null!;
}
