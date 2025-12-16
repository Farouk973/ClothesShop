using AutoMapper;
using MediatR;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;

namespace ClothesShop.Application.Features.Categories.Commands.UpdateCategory;

public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand>
{
    private readonly ICategoryRepository _repo;
    private readonly IMapper _mapper;

    public UpdateCategoryCommandHandler(ICategoryRepository repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        var existing = await _repo.GetByIdAsync(request.Id);
        if (existing is null) throw new KeyNotFoundException("Category not found");

        // map fields
        existing.Name = request.Name;
        existing.Description = request.Description;
        existing.UpdatedAt = DateTime.UtcNow;

        await _repo.UpdateAsync(existing.Id, existing);
        return Unit.Value;
    }
}
