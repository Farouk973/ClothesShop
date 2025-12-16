namespace ClothesShop.Application.Features.Products.Queries.GetProductsForFrontOffice;

public class GetProductsForFrontOfficeVm
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public decimal SellingPrice { get; set; }
    public List<string> ImageIds { get; set; } = new();
    public bool ComingSoon { get; set; }
}
