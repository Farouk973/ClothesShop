using MediatR;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;

namespace ClothesShop.Application.Features.Images.Commands.UpdateImage;

public class UpdateImageCommandHandler
    : IRequestHandler<UpdateImageCommand>
{
    private readonly IRepository<Image> _repository;

    public UpdateImageCommandHandler(IRepository<Image> repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(
        UpdateImageCommand request,
        CancellationToken cancellationToken)
    {
        var image = await _repository.GetByIdAsync(request.Id);

        if (image == null)
            throw new KeyNotFoundException("Image not found");

        image.Url = request.Url;
        image.AltText = request.AltText;
        image.Tags = request.Tags;
        image.UpdatedAt = DateTime.UtcNow;

        await _repository.UpdateAsync(request.Id, image);
        return Unit.Value;
    }
}
