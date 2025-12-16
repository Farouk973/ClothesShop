namespace ClothesShop.Application.Features.Products.Queries.GetProductsByCategory;

public class GetProductsByCategoryVm
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public decimal SellingPrice { get; set; }
    public bool InStock { get; set; }
    public List<string> ImageIds { get; set; } = new();
}
