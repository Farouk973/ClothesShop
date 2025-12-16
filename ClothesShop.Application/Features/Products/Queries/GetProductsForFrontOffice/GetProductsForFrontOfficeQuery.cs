using MediatR;

namespace ClothesShop.Application.Features.Products.Queries.GetProductsForFrontOffice;

public class GetProductsForFrontOfficeQuery
    : IRequest<List<GetProductsForFrontOfficeVm>>
{
}
