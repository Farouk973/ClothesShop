using FluentValidation;

namespace ClothesShop.Application.Features.Videos.Commands.UpdateVideo;

public class UpdateVideoCommandValidator
    : AbstractValidator<UpdateVideoCommand>
{
    public UpdateVideoCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.Url).NotEmpty();
    }
}
