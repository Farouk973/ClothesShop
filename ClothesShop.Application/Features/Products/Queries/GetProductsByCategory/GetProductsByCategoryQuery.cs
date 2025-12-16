using MediatR;

namespace ClothesShop.Application.Features.Products.Queries.GetProductsByCategory;

public class GetProductsByCategoryQuery
    : IRequest<List<GetProductsByCategoryVm>>
{
    public string CategoryId { get; set; } = null!;
}

