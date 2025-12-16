using MediatR;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;
using ClothesShop.Entities;

namespace ClothesShop.Application.Features.Promotions.Commands.UpdatePromotion;

public class UpdatePromotionCommandHandler
    : IRequestHandler<UpdatePromotionCommand>
{
    private readonly IRepository<Promotion> _repository;

    public UpdatePromotionCommandHandler(IRepository<Promotion> repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(
        UpdatePromotionCommand request,
        CancellationToken cancellationToken)
    {
        var promotion = await _repository.GetByIdAsync(request.Id);
        if (promotion == null)
            throw new KeyNotFoundException("Promotion not found");

        promotion.Title = request.Title;
        promotion.Description = request.Description;
        promotion.StartDate = request.StartDate;
        promotion.EndDate = request.EndDate;
        promotion.ImageIds = request.ImageIds;
        promotion.VideoIds = request.VideoIds;
        promotion.Tags = request.Tags;
        promotion.UpdatedAt = DateTime.UtcNow;

        await _repository.UpdateAsync(request.Id, promotion);
        return Unit.Value;
    }
}
