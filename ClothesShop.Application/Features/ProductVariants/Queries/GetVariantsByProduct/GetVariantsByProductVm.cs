namespace ClothesShop.Application.Features.ProductVariants.Queries.GetVariantsByProduct;

public class GetVariantsByProductVm
{
    public string Id { get; set; } = null!;
    public string Color { get; set; } = null!;
    public string Size { get; set; } = null!;
    public int Stock { get; set; }
    public List<string> ImageIds { get; set; } = new();
}
