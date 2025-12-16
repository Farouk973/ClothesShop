using MediatR;

namespace ClothesShop.Application.Features.Products.Queries.GetAllProducts;

public class GetAllProductsQuery
    : IRequest<List<GetAllProductsVm>>
{
}
