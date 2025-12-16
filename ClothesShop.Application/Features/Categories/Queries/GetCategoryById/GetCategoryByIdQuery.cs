using MediatR;

namespace ClothesShop.Application.Features.Categories.Queries.GetCategoryById;

public class GetCategoryByIdQuery : IRequest<GetCategoryByIdVm?>
{
    public string Id { get; set; } = null!;
}