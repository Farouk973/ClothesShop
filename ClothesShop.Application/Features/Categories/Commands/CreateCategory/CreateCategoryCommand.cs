using MediatR;

namespace ClothesShop.Application.Features.Categories.Commands.CreateCategory;

public class CreateCategoryCommand : IRequest<string>
{
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
}
