using MediatR;

namespace ClothesShop.Application.Features.ProductVariants.Commands.UpdateProductVariant;

public class UpdateProductVariantCommand : IRequest
{
    public string Id { get; set; } = null!;
    public string Color { get; set; } = null!;
    public string Size { get; set; } = null!;
    public int Stock { get; set; }
    public List<string> ImageIds { get; set; } = new();
    public List<string> Tags { get; set; } = new();
}
