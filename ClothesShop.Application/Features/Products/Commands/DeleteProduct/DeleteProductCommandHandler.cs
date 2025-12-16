using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;
using MediatR;

namespace ClothesShop.Application.Features.Products.Commands.DeleteProduct;

public class DeleteProductCommandHandler
    : IRequestHandler<DeleteProductCommand, bool>
{
    private readonly IRepository<Product> _repository;

    public DeleteProductCommandHandler(IRepository<Product> repository)
    {
        _repository = repository;
    }

    public async Task<bool> Handle(
        DeleteProductCommand request,
        CancellationToken cancellationToken)
    {
        await _repository.DeleteAsync(request.Id);
        return true;
    }
}
