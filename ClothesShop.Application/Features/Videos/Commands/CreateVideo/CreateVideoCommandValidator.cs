using FluentValidation;

namespace ClothesShop.Application.Features.Videos.Commands.CreateVideo;

public class CreateVideoCommandValidator
    : AbstractValidator<CreateVideoCommand>
{
    public CreateVideoCommandValidator()
    {
        RuleFor(x => x.Url).NotEmpty();
    }
}
