namespace ClothesShop.Application.Features.Products.Queries.GetProductById;

public class GetProductByIdVm
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Reference { get; set; } = null!;
    public decimal CostPrice { get; set; }
    public decimal SellingPrice { get; set; }
    public string CategoryId { get; set; } = null!;
    public bool ComingSoon { get; set; }
    public bool InStock { get; set; }
    public List<string> ImageIds { get; set; } = new();
    public List<string> Tags { get; set; } = new();
    public DateTime CreatedAt { get; set; }
}
