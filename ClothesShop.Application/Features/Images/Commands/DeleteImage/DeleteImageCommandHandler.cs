
using MediatR;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;

namespace ClothesShop.Application.Features.Images.Commands.DeleteImage;

public class DeleteImageCommandHandler : IRequestHandler<DeleteImageCommand, Unit>
{
    private readonly IRepository<Image> _repository;

    public DeleteImageCommandHandler(IRepository<Image> repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(DeleteImageCommand request, CancellationToken cancellationToken)
    {
        await _repository.DeleteAsync(request.Id);
        return Unit.Value; // <-- Must return Unit
    }
}
