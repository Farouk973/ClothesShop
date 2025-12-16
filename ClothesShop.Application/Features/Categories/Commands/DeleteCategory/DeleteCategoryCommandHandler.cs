using MediatR;
using ClothesShop.Application.Common.Interfaces;

namespace ClothesShop.Application.Features.Categories.Commands.DeleteCategory;

public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand>
{
    private readonly ICategoryRepository _repo;

    public DeleteCategoryCommandHandler(ICategoryRepository repo) => _repo = repo;

    public async Task<Unit> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
    {
        await _repo.DeleteAsync(request.Id);
        return Unit.Value;
    }
}
