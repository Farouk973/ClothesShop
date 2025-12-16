using MediatR;

namespace ClothesShop.Application.Features.Products.Queries.GetProductById;

public class GetProductByIdQuery : IRequest<GetProductByIdVm>
{
    public string Id { get; set; } = null!;
}
