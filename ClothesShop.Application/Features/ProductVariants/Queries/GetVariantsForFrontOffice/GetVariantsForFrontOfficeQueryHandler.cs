using AutoMapper;
using MediatR;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;

namespace ClothesShop.Application.Features.ProductVariants.Queries.GetVariantsForFrontOffice;

public class GetVariantsForFrontOfficeQueryHandler
    : IRequestHandler<GetVariantsForFrontOfficeQuery, List<GetVariantsForFrontOfficeVm>>
{
    private readonly IRepository<ProductVariant> _repository;
    private readonly IMapper _mapper;

    public GetVariantsForFrontOfficeQueryHandler(
        IRepository<ProductVariant> repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<GetVariantsForFrontOfficeVm>> Handle(
        GetVariantsForFrontOfficeQuery request,
        CancellationToken cancellationToken)
    {
        var variants = await _repository.FindAsync(
            x => x.ProductId == request.ProductId && x.Stock > 0);

        return _mapper.Map<List<GetVariantsForFrontOfficeVm>>(variants);
    }
}
