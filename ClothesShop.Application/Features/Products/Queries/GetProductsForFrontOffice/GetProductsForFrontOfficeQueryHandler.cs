using AutoMapper;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;
using MediatR;

namespace ClothesShop.Application.Features.Products.Queries.GetProductsForFrontOffice;

public class GetProductsForFrontOfficeQueryHandler
    : IRequestHandler<GetProductsForFrontOfficeQuery, List<GetProductsForFrontOfficeVm>>
{
    private readonly IRepository<Product> _repository;
    private readonly IMapper _mapper;

    public GetProductsForFrontOfficeQueryHandler(
        IRepository<Product> repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<GetProductsForFrontOfficeVm>> Handle(
        GetProductsForFrontOfficeQuery request,
        CancellationToken cancellationToken)
    {
        var products = await _repository.FindAsync(
            x => x.InStock || x.ComingSoon);

        return _mapper.Map<List<GetProductsForFrontOfficeVm>>(products);
    }
}
