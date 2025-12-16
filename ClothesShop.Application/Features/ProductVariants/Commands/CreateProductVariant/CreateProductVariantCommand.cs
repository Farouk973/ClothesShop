using MediatR;

namespace ClothesShop.Application.Features.ProductVariants.Commands.CreateProductVariant;

public class CreateProductVariantCommand : IRequest<string>
{
    public string ProductId { get; set; } = null!;
    public string Color { get; set; } = null!;
    public string Size { get; set; } = null!;
    public int Stock { get; set; }
    public List<string> ImageIds { get; set; } = new();
    public List<string> Tags { get; set; } = new();
}
