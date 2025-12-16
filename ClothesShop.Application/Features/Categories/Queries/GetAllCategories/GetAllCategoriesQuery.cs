using MediatR;

namespace ClothesShop.Application.Features.Categories.Queries.GetAllCategories;

public class GetAllCategoriesQuery : IRequest<List<GetAllCategoriesVm>>
{
}