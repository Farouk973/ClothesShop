using MediatR;

namespace ClothesShop.Application.Features.Categories.Commands.UpdateCategory;

public class UpdateCategoryCommand : IRequest
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
}
