using MediatR;
using ClothesShop.Application.Common.Interfaces;

namespace ClothesShop.Application.Features.ProductVariants.Commands.DeleteProductVariant;

public class DeleteProductVariantCommandHandler
    : IRequestHandler<DeleteProductVariantCommand>
{
    private readonly IRepository<Domain.Entities.ProductVariant> _repository;

    public DeleteProductVariantCommandHandler(
        IRepository<Domain.Entities.ProductVariant> repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(
        DeleteProductVariantCommand request,
        CancellationToken cancellationToken)
    {
        await _repository.DeleteAsync(request.Id);
        return Unit.Value;
    }
}
