namespace ClothesShop.Application.Features.Products.Queries.GetAllProducts;

public class GetAllProductsVm
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Reference { get; set; } = null!;
    public decimal SellingPrice { get; set; }
    public bool InStock { get; set; }
}
