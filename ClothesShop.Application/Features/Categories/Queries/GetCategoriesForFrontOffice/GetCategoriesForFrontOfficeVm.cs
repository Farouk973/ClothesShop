namespace ClothesShop.Application.Features.Categories.Queries.GetCategoriesForFrontOffice;

public class GetCategoriesForFrontOfficeVm
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public List<string> ImageIds { get; set; } = new();
}
