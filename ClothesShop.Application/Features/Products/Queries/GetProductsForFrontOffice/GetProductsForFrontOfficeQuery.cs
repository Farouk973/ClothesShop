using MediatR;
using ClothesShop.Application.Common.Models;
namespace ClothesShop.Application.Features.Products.Queries.GetProductsForFrontOffice;

public record GetProductsForFrontOfficeQuery(
    PaginationParams Pagination
) : IRequest<PaginatedResult<GetProductsForFrontOfficeVm>>;
