using FluentValidation;

namespace ClothesShop.Application.Features.Promotions.Commands.CreatePromotion;

public class CreatePromotionCommandValidator
    : AbstractValidator<CreatePromotionCommand>
{
    public CreatePromotionCommandValidator()
    {
        RuleFor(x => x.Title).NotEmpty();
        RuleFor(x => x.StartDate).LessThan(x => x.EndDate);
    }
}
