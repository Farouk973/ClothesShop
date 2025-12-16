using MediatR;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;

namespace ClothesShop.Application.Features.ProductVariants.Commands.UpdateProductVariant;

public class UpdateProductVariantCommandHandler
    : IRequestHandler<UpdateProductVariantCommand>
{
    private readonly IRepository<ProductVariant> _repository;

    public UpdateProductVariantCommandHandler(IRepository<ProductVariant> repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(
        UpdateProductVariantCommand request,
        CancellationToken cancellationToken)
    {
        var variant = await _repository.GetByIdAsync(request.Id);

        if (variant == null)
            throw new KeyNotFoundException("ProductVariant not found");

        variant.Color = request.Color;
        variant.Size = request.Size;
        variant.Stock = request.Stock;
        variant.ImageIds = request.ImageIds;
        variant.Tags = request.Tags;
        variant.UpdatedAt = DateTime.UtcNow;

        await _repository.UpdateAsync(request.Id, variant);
        return Unit.Value;
    }
}
