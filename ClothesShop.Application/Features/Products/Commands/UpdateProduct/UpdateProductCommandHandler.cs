using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;
using MediatR;

namespace ClothesShop.Application.Features.Products.Commands.UpdateProduct;

public class UpdateProductCommandHandler
    : IRequestHandler<UpdateProductCommand, bool>
{
    private readonly IRepository<Product> _repository;

    public UpdateProductCommandHandler(IRepository<Product> repository)
    {
        _repository = repository;
    }

    public async Task<bool> Handle(
        UpdateProductCommand request,
        CancellationToken cancellationToken)
    {
        var product = await _repository.GetByIdAsync(request.Id);
        if (product == null) return false;

        product.Name = request.Name;
        product.Description = request.Description;
        product.SellingPrice = request.SellingPrice;
        product.ComingSoon = request.ComingSoon;
        product.InStock = request.InStock;
        product.ImageIds = request.ImageIds;
        product.Tags = request.Tags;
        product.UpdatedAt = DateTime.UtcNow;

        await _repository.UpdateAsync(product.Id, product);
        return true;
    }
}
