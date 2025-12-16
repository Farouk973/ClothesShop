using AutoMapper;
using MediatR;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;

namespace ClothesShop.Application.Features.ProductVariants.Queries.GetVariantsByProduct;

public class GetVariantsByProductQueryHandler
    : IRequestHandler<GetVariantsByProductQuery, List<GetVariantsByProductVm>>
{
    private readonly IRepository<ProductVariant> _repository;
    private readonly IMapper _mapper;

    public GetVariantsByProductQueryHandler(
        IRepository<ProductVariant> repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<GetVariantsByProductVm>> Handle(
        GetVariantsByProductQuery request,
        CancellationToken cancellationToken)
    {
        var variants = await _repository.FindAsync(
            x => x.ProductId == request.ProductId);

        return _mapper.Map<List<GetVariantsByProductVm>>(variants);
    }
}
