using ClothesShop.Application.Features.Images.Queries.GetImagesByOwner;
using MediatR;

namespace ClothesShop.Application.Features.Images.Queries.GetImagesByOwnerId;

public class GetImagesByOwnerIdQuery : IRequest<List<GetImagesByOwnerIdVm>>
{
    public string OwnerId { get; set; } = null!;
}
