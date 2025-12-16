using FluentValidation;

namespace ClothesShop.Application.Features.Images.Commands.CreateImage;

public class CreateImageCommandValidator
    : AbstractValidator<CreateImageCommand>
{
    public CreateImageCommandValidator()
    {
        RuleFor(x => x.Url).NotEmpty();
    }
}
