namespace ClothesShop.Application.Features.ProductVariants.Queries.GetVariantsForFrontOffice;

public class GetVariantsForFrontOfficeVm
{
    public string Id { get; set; } = null!;
    public string Color { get; set; } = null!;
    public string Size { get; set; } = null!;
    public bool InStock { get; set; }
}
