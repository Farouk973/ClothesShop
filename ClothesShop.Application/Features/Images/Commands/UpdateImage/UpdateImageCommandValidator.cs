using FluentValidation;

namespace ClothesShop.Application.Features.Images.Commands.UpdateImage;

public class UpdateImageCommandValidator
    : AbstractValidator<UpdateImageCommand>
{
    public UpdateImageCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.Url).NotEmpty();
    }
}
