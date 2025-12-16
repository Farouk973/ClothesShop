using AutoMapper;
using MediatR;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;

namespace ClothesShop.Application.Features.ProductVariants.Queries.GetProductVariantById;

public class GetProductVariantByIdQueryHandler
    : IRequestHandler<GetProductVariantByIdQuery, GetProductVariantByIdVm>
{
    private readonly IRepository<ProductVariant> _repository;
    private readonly IMapper _mapper;

    public GetProductVariantByIdQueryHandler(
        IRepository<ProductVariant> repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<GetProductVariantByIdVm> Handle(
        GetProductVariantByIdQuery request,
        CancellationToken cancellationToken)
    {
        var variant = await _repository.GetByIdAsync(request.Id);
        return _mapper.Map<GetProductVariantByIdVm>(variant);
    }
}
