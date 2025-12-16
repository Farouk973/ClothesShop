using MediatR;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;

namespace ClothesShop.Application.Features.Videos.Commands.UpdateVideo;

public class UpdateVideoCommandHandler
    : IRequestHandler<UpdateVideoCommand>
{
    private readonly IRepository<Video> _repository;

    public UpdateVideoCommandHandler(IRepository<Video> repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(
        UpdateVideoCommand request,
        CancellationToken cancellationToken)
    {
        var video = await _repository.GetByIdAsync(request.Id);

        if (video == null)
            throw new KeyNotFoundException("Video not found");

        video.Url = request.Url;
        video.Title = request.Title;
        video.Description = request.Description;
        video.Tags = request.Tags;
        video.UpdatedAt = DateTime.UtcNow;

        await _repository.UpdateAsync(request.Id, video);
        return Unit.Value;
    }
}
