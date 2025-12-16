using FluentValidation;

namespace ClothesShop.Application.Features.Promotions.Commands.UpdatePromotion;

public class UpdatePromotionCommandValidator
    : AbstractValidator<UpdatePromotionCommand>
{
    public UpdatePromotionCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.StartDate).LessThan(x => x.EndDate);
    }
}
