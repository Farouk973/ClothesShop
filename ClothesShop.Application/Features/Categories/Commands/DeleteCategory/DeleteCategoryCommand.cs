using MediatR;

namespace ClothesShop.Application.Features.Categories.Commands.DeleteCategory;

public class DeleteCategoryCommand : IRequest
{
    public string Id { get; set; } = null!;
}
