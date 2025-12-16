namespace ClothesShop.Application.Features.Categories.Queries.GetCategoryById;

public class GetCategoryByIdVm
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public List<string> ImageIds { get; set; } = new();
    public List<string> Tags { get; set; } = new();
}
