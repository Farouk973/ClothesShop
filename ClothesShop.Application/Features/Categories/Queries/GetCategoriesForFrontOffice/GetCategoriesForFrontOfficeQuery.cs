using MediatR;

namespace ClothesShop.Application.Features.Categories.Queries.GetCategoriesForFrontOffice;

public class GetCategoriesForFrontOfficeQuery
    : IRequest<List<GetCategoriesForFrontOfficeVm>>
{
}