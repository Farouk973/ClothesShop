using MediatR;

namespace ClothesShop.Application.Features.Products.Commands.UpdateProduct;

public class UpdateProductCommand : IRequest<bool>
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal SellingPrice { get; set; }
    public bool ComingSoon { get; set; }
    public bool InStock { get; set; }
    public List<string> ImageIds { get; set; } = new();
    public List<string> Tags { get; set; } = new();
}
