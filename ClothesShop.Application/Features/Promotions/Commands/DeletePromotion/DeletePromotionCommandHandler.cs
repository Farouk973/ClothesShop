using MediatR;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;
using ClothesShop.Entities;

namespace ClothesShop.Application.Features.Promotions.Commands.DeletePromotion;

public class DeletePromotionCommandHandler
    : IRequestHandler<DeletePromotionCommand>
{
    private readonly IRepository<Promotion> _repository;

    public DeletePromotionCommandHandler(IRepository<Promotion> repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(
        DeletePromotionCommand request,
        CancellationToken cancellationToken)
    {
        await _repository.DeleteAsync(request.Id);
        return Unit.Value;
    }
}
