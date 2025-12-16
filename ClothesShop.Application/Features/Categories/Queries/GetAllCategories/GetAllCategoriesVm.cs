namespace ClothesShop.Application.Features.Categories.Queries.GetAllCategories;

public class GetAllCategoriesVm
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public List<string> ImageIds { get; set; } = new();
}