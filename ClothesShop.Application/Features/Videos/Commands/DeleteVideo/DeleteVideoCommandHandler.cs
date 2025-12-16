using MediatR;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;

namespace ClothesShop.Application.Features.Videos.Commands.DeleteVideo;

public class DeleteVideoCommandHandler
    : IRequestHandler<DeleteVideoCommand>
{
    private readonly IRepository<Video> _repository;

    public DeleteVideoCommandHandler(IRepository<Video> repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(
        DeleteVideoCommand request,
        CancellationToken cancellationToken)
    {
        await _repository.DeleteAsync(request.Id);
        return Unit.Value;
    }
}
